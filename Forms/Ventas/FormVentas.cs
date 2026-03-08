using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Reports.DataSources;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Ventas
{
    public partial class FormVentas : Form
    {
        private int _clienteID;
        private int _cajaID;
        private List<dynamic> _todosLosClientes; // Cache de clientes
        private bool _actualizandoDesdeEdicion; // Flag para evitar ciclo al editar cantidad/total
        private bool _aplicandoPago; // Flag para evitar que RadioPago_CheckedChanged interfiera al aplicar resultado
        private decimal _tasaIGV = 0.18m;
        private decimal _rawCartTotal = 0m; // suma bruta de líneas del carrito sin ajuste por IGV adicional
        private bool _vistaCards = false; // false=lista, true=tarjetas
        private int _categoriaFiltro = 0;  // 0=TODOS, >0=CategoriaID

        public FormVentas()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarDataGridViews();
            ConfigurarComboClientes();
            InicializarVenta();
            CargarCategorias();
            CargarProductos();
            CargarClientes();

            // Restringir descuentos según permiso
            var usuarioActual = SesionActual.Usuario;
            bool puedeDescontar = usuarioActual != null && (usuarioActual.PermisoDescuentos || usuarioActual.RolID == 1);
            txtDescuento.ReadOnly = !puedeDescontar;
            txtDescuento.BackColor = puedeDescontar ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.Control;

            // Leer tasa IGV de configuración
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                using (var cmd = new System.Data.SQLite.SQLiteCommand(
                    "SELECT Valor FROM ConfigGeneral WHERE Clave = 'IGV' LIMIT 1", conn))
                {
                    var v = cmd.ExecuteScalar()?.ToString();
                    if (decimal.TryParse(v, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal tasa))
                        _tasaIGV = tasa / 100m;
                }
            }
            catch { }
        }

        private void ConfigurarEventos()
        {
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            dgvProductos.CellDoubleClick += DgvProductos_CellDoubleClick;
            dgvCarritoVenta.CellClick += DgvCarritoVenta_CellClick;
            dgvCarritoVenta.CellEndEdit += DgvCarritoVenta_CellEndEdit;
            dgvCarritoVenta.CellFormatting += DgvCarritoVenta_CellFormatting;

            txtRecibido.TextChanged += TxtRecibido_TextChanged;
            txtRecibido.KeyPress += TxtRecibido_KeyPress;
            txtEfectivo.KeyPress += TxtSoloNumeros_KeyPress;
            txtYape.KeyPress += TxtSoloNumeros_KeyPress;
            txtTransferencia.KeyPress += TxtSoloNumeros_KeyPress;
            txtEfectivo.TextChanged += TxtMetodoPago_TextChanged;
            txtYape.TextChanged += TxtMetodoPago_TextChanged;
            txtTransferencia.TextChanged += TxtMetodoPago_TextChanged;

            // Hacer txtVuelto de solo lectura (es un campo calculado)
            txtVuelto.ReadOnly = true;
            txtVuelto.BackColor = System.Drawing.SystemColors.Control;

            cboIGV.SelectedIndexChanged += (s, e) => CalcularTotales();

            rbEfectivo.CheckedChanged += RadioPago_CheckedChanged;
            rbYape.CheckedChanged += RadioPago_CheckedChanged;
            rbTransferencia.CheckedChanged += RadioPago_CheckedChanged;
            rbMixto.CheckedChanged += RadioPago_CheckedChanged;
            rbCredito.CheckedChanged += RadioPago_CheckedChanged;
            rbTarjeta.CheckedChanged += RadioPago_CheckedChanged;
            txtTarjeta.KeyPress += TxtSoloNumeros_KeyPress;
            txtTarjeta.TextChanged += TxtMetodoPago_TextChanged;

            btnBuscarCliente.Click += BtnBuscarCliente_Click;
            cmbClientes.SelectedIndexChanged += CmbClientes_SelectedIndexChanged;
            cmbClientes.TextChanged += CmbClientes_TextChanged;

            btnCobrar.Click   += BtnCobrar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnHistorial.Click += BtnHistorial_Click;
            btnPrevia.Click   += BtnPrevia_Click;
            btnVistaLista.Click += BtnVistaLista_Click;
            btnVistaCards.Click += BtnVistaCards_Click;

            dgvProductos.EditingControlShowing += DgvProductos_EditingControlShowing;
            dgvProductos.CellValueChanged += DgvProductos_CellValueChanged;
            dgvProductos.CurrentCellDirtyStateChanged += DgvProductos_CurrentCellDirtyStateChanged;
            txtDescuento.KeyPress += TxtDescuento_KeyPress;
            txtDescuento.Leave += TxtDescuento_Leave;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            cmbClientes.Focus();
            cmbClientes.DroppedDown = true;
        }

        private void ConfigurarComboClientes()
        {
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDown;
            cmbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarClientes()
        {
            try
            {
                _todosLosClientes = ClienteRepository.Listar()
                    .Cast<dynamic>()
                    .ToList();

                cmbClientes.Items.Clear();
                cmbClientes.Items.Add("CLIENTE GENERAL");

                foreach (var cliente in _todosLosClientes)
                {
                    string display = $"{cliente.NombreCompleto} - {cliente.NumeroDocumento}";
                    cmbClientes.Items.Add(display);
                }

                cmbClientes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error");
            }
        }

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == 0) // Cliente General
            {
                _clienteID = 1;
                lblNombreCliente.Text = "CLIENTE GENERAL";
                lblDNICliente.Text = "00000000";
            }
            else if (cmbClientes.SelectedIndex > 0)
            {
                try
                {
                    var cliente = _todosLosClientes[cmbClientes.SelectedIndex - 1];
                    _clienteID = cliente.ClienteID;
                    lblNombreCliente.Text = cliente.NombreCompleto;
                    lblDNICliente.Text = cliente.NumeroDocumento;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al seleccionar cliente: {ex.Message}");
                }
            }
        }

        private void CmbClientes_TextChanged(object sender, EventArgs e)
        {
            // Búsqueda en tiempo real mientras escribe
            string busqueda = cmbClientes.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(busqueda))
                return;

            // Buscar en la lista de clientes
            var clienteEncontrado = _todosLosClientes.FirstOrDefault(c =>
                c.NombreCompleto.ToString().ToLower().Contains(busqueda) ||
                c.NumeroDocumento.ToString().Contains(busqueda)
            );

            if (clienteEncontrado != null)
            {
                _clienteID = clienteEncontrado.ClienteID;
                lblNombreCliente.Text = clienteEncontrado.NombreCompleto;
                lblDNICliente.Text = clienteEncontrado.NumeroDocumento;
            }
        }

        // ==================== FIN NUEVO ====================

        private void ConfigurarDataGridViews()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCarritoVenta.AutoGenerateColumns = false;
            dgvCarritoVenta.AllowUserToAddRows = false;
            dgvCarritoVenta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProductos.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void InicializarVenta()
        {
            var clienteGeneral = ClienteRepository.ObtenerClienteGeneral();
            _clienteID = clienteGeneral != null ? clienteGeneral.ClienteID : 1;
            lblNombreCliente.Text = "CLIENTE GENERAL";
            lblDNICliente.Text = "00000000";

            var caja = CajaRepository.ObtenerCajaAbierta();
            if (caja != null)
            {
                _cajaID = caja.CajaID;
            }
            else
            {
                MessageBox.Show("No hay caja abierta", "Error");
                this.Close();
            }

            txtSubtotal.Text = "0.00";
            txtIGV.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtVuelto.Text = "0.00";

            rbEfectivo.Checked = true;
            txtEfectivo.Enabled = true;
            txtYape.Enabled = false;
            txtTransferencia.Enabled = false;
            txtTarjeta.Enabled = false;

            cmbTipoComprobante.Text = "NOTA_VENTA";
        }

        private void CargarProductos(string busqueda = "")
        {
            try
            {
                dgvProductos.Rows.Clear();

                var productos = ProductoRepository.BuscarProductos(busqueda);

                // Filtro por categoría seleccionada
                if (_categoriaFiltro > 0)
                    productos = productos.FindAll(p => p.CategoriaID == _categoriaFiltro);

                int numero = 1;
                foreach (var producto in productos)
                {
                    var presentaciones = ProductoRepository.ObtenerPresentaciones(producto.ProductoID);

                    if (presentaciones.Count == 0) continue;

                    int index = dgvProductos.Rows.Add();
                    DataGridViewRow row = dgvProductos.Rows[index];

                    row.Cells["colNumero"].Value = numero++;
                    row.Cells["colProducto"].Value = producto.Nombre;

                    // Cargar imagen del producto
                    if (producto.Imagen != null && producto.Imagen.Length > 0)
                    {
                        try
                        {
                            using (var ms = new System.IO.MemoryStream(producto.Imagen))
                            using (var img = System.Drawing.Image.FromStream(ms))
                            {
                                row.Cells["colImagen"].Value = new System.Drawing.Bitmap(img);
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error al cargar imagen del producto: {ex.Message}");
                        }
                    }

                    var comboPres = row.Cells["colPresentacion"] as DataGridViewComboBoxCell;
                    if (comboPres != null)
                    {
                        var itemsPresentacion = new List<object>();

                        foreach (var pres in presentaciones)
                        {
                            string nombrePres = ObtenerNombrePresentacion(pres.PresentacionID);
                            itemsPresentacion.Add(new
                            {
                                Display = $"{nombrePres} - S/ {pres.PrecioVenta:N2}",
                                Value = pres.ProductoPresentacionID,
                                Presentacion = pres
                            });
                        }

                        comboPres.DataSource = itemsPresentacion;
                        comboPres.DisplayMember = "Display";
                        comboPres.ValueMember = "Value";

                        if (itemsPresentacion.Count > 0)
                        {
                            comboPres.Value = ((dynamic)itemsPresentacion[0]).Value;
                            row.Cells["colPrecioUnit"].Value = "S/ " + presentaciones[0].PrecioVenta.ToString("N2");
                        }
                    }

                    row.Tag = new
                    {
                        ProductoID = producto.ProductoID,
                        UnidadBaseID = producto.UnidadBaseID,
                        Presentaciones = presentaciones
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error");
            }
        }

        private string ObtenerNombrePresentacion(int presentacionID)
        {
            return PresentacionRepository.ObtenerNombrePorID(presentacionID);
        }

        private string ObtenerSimboloUnidad(int unidadBaseID)
        {
            return UnidadRepository.ObtenerSimboloPorID(unidadBaseID);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (_vistaCards)
                CargarProductosTarjetas(txtBuscar.Text.Trim(), _categoriaFiltro);
            else
                CargarProductos(txtBuscar.Text.Trim());
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var item = (dynamic)dgvProductos.Rows[e.RowIndex].Tag;
                string nombreProducto = dgvProductos.Rows[e.RowIndex].Cells["colProducto"].Value.ToString();

                var comboCell = dgvProductos.Rows[e.RowIndex].Cells["colPresentacion"] as DataGridViewComboBoxCell;
                if (comboCell != null && comboCell.Value != null)
                {
                    int presentacionID = Convert.ToInt32(comboCell.Value);

                    List<ProductoPresentacion> presentaciones = item.Presentaciones;
                    var presentacion = presentaciones.Find(p => p.ProductoPresentacionID == presentacionID);

                    if (presentacion != null)
                    {
                        string unidadSimbolo = ObtenerSimboloUnidad(item.UnidadBaseID);
                        AgregarAlCarrito(item.ProductoID, nombreProducto, presentacion, unidadSimbolo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void AgregarAlCarrito(int productoID, string nombreProducto, ProductoPresentacion presentacion, string unidadSimbolo)
        {
            // Calcular cuántas unidades base ya están en el carrito para este producto
            decimal cantidadYaEnCarrito = 0;
            foreach (DataGridViewRow row in dgvCarritoVenta.Rows)
            {
                if (row.Tag != null)
                {
                    var item = (dynamic)row.Tag;
                    if (item.ProductoID == productoID)
                    {
                        var _cv = row.Cells["colCantidad"].Value;
                        cantidadYaEnCarrito += (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;
                    }
                }
            }

            // Verificar stock disponible
            var producto = ProductoRepository.ObtenerPorID(productoID);
            decimal stockDisponible = producto?.StockTotal ?? 0;
            decimal unidadesAAgregar = presentacion.CantidadUnidades;

            if (cantidadYaEnCarrito + unidadesAAgregar > stockDisponible)
            {
                MessageBox.Show(
                    $"Stock insuficiente para '{nombreProducto}'.\n" +
                    $"Stock disponible: {stockDisponible:N2} | En carrito: {cantidadYaEnCarrito:N2}",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si ya existe en el carrito
            foreach (DataGridViewRow row in dgvCarritoVenta.Rows)
            {
                if (row.Tag != null)
                {
                    var item = (dynamic)row.Tag;
                    if (item.ProductoID == productoID && item.PresentacionID == presentacion.ProductoPresentacionID)
                    {
                        var _cv = row.Cells["colCantidad"].Value;
                        decimal cantidad = (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;
                        row.Cells["colCantidad"].Value = cantidad + presentacion.CantidadUnidades;
                        ActualizarTotalFila(row.Index);
                        return;
                    }
                }
            }

            // Agregar nuevo producto
            int index = dgvCarritoVenta.Rows.Add();
            DataGridViewRow newRow = dgvCarritoVenta.Rows[index];

            // Obtener nombre de presentación
            string nombrePresentacion = ObtenerNombrePresentacion(presentacion.PresentacionID);

            newRow.Cells["colProductoDV"].Value = nombreProducto;
            newRow.Cells["colPresentacionDV"].Value = nombrePresentacion;
            newRow.Cells["colCantidad"].Value = presentacion.CantidadUnidades;
            newRow.Cells["colTotalDV"].Value = "S/ " + presentacion.PrecioVenta.ToString("N2");

            newRow.Tag = new
            {
                ProductoID = productoID,
                PresentacionID = presentacion.ProductoPresentacionID,
                PrecioUnitario = presentacion.PrecioVenta,
                CantidadUnidades = presentacion.CantidadUnidades,
                UnidadSimbolo = unidadSimbolo,
                PrecioIncluyeIGV = presentacion.PrecioIncluyeIGV
            };

            CalcularTotales();
        }

        private void DgvCarritoVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCarritoVenta.Rows[e.RowIndex];

            if (dgvCarritoVenta.Columns[e.ColumnIndex].Name == "colAumentar")
            {
                var _cv = row.Cells["colCantidad"].Value;
                decimal cantidad = (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;
                var itemAum = (dynamic)row.Tag;
                decimal step = (decimal)itemAum.CantidadUnidades;
                row.Cells["colCantidad"].Value = cantidad + step;
                ActualizarTotalFila(e.RowIndex);
            }
            else if (dgvCarritoVenta.Columns[e.ColumnIndex].Name == "colDisminuir")
            {
                var _cv2 = row.Cells["colCantidad"].Value;
                decimal cantidad = (_cv2 != null && decimal.TryParse(_cv2.ToString(), out decimal _cvp2)) ? _cvp2 : 0m;
                var itemDis = (dynamic)row.Tag;
                decimal step = (decimal)itemDis.CantidadUnidades;
                if (cantidad > step)
                {
                    row.Cells["colCantidad"].Value = cantidad - step;
                    ActualizarTotalFila(e.RowIndex);
                }
                else if (cantidad > 0.01m)
                {
                    row.Cells["colCantidad"].Value = Math.Max(0.01m, cantidad - 0.1m);
                    ActualizarTotalFila(e.RowIndex);
                }
            }
            else if (dgvCarritoVenta.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                dgvCarritoVenta.Rows.RemoveAt(e.RowIndex);
                CalcularTotales();
            }
        }

        private void DgvCarritoVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCarritoVenta.Columns[e.ColumnIndex].Name != "colCantidad") return;

            var row = dgvCarritoVenta.Rows[e.RowIndex];
            if (row.Tag == null || e.Value == null) return;

            if (decimal.TryParse(e.Value.ToString(), out decimal cantidad))
            {
                var item = (dynamic)row.Tag;
                string unidad = item.UnidadSimbolo ?? "";
                e.Value = cantidad.ToString("0.00#") + (string.IsNullOrEmpty(unidad) ? "" : " " + unidad);
                e.FormattingApplied = true;
            }
        }

        private void DgvCarritoVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _actualizandoDesdeEdicion) return;

            DataGridViewRow row = dgvCarritoVenta.Rows[e.RowIndex];
            if (row.Tag == null) return;

            var item = (dynamic)row.Tag;
            decimal precioUnitario = item.PrecioUnitario;
            string colName = dgvCarritoVenta.Columns[e.ColumnIndex].Name;

            _actualizandoDesdeEdicion = true;
            try
            {
                if (colName == "colCantidad")
                {
                    // Limpiar texto: quitar letras/simbolos de unidad, dejar solo números y punto
                    string cantidadStr = row.Cells["colCantidad"].Value?.ToString() ?? "";
                    cantidadStr = new string(cantidadStr.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

                    decimal cantidadUnidades = (decimal)item.CantidadUnidades;
                    if (decimal.TryParse(cantidadStr, out decimal cantidadBase) && cantidadBase > 0)
                    {
                        cantidadBase = Math.Round(cantidadBase, 3);
                        row.Cells["colCantidad"].Value = cantidadBase;
                        decimal cantPres = cantidadBase / cantidadUnidades;
                        row.Cells["colTotalDV"].Value = "S/ " + (cantPres * precioUnitario).ToString("N2");
                    }
                    else
                    {
                        row.Cells["colCantidad"].Value = cantidadUnidades;
                        row.Cells["colTotalDV"].Value = "S/ " + precioUnitario.ToString("N2");
                    }
                    CalcularTotales();
                }
                else if (colName == "colTotalDV")
                {
                    // Usuario editó total → recalcular cantidad en unidades base
                    string totalStr = row.Cells["colTotalDV"].Value?.ToString().Replace("S/", "").Replace("s/", "").Trim() ?? "0";
                    decimal cantidadUnidades = (decimal)item.CantidadUnidades;
                    if (decimal.TryParse(totalStr, out decimal totalDeseado) && totalDeseado > 0 && precioUnitario > 0)
                    {
                        decimal cantPres = Math.Round(totalDeseado / precioUnitario, 3);
                        decimal nuevaCantidadBase = cantPres * cantidadUnidades;
                        row.Cells["colCantidad"].Value = nuevaCantidadBase;
                        row.Cells["colTotalDV"].Value = "S/ " + totalDeseado.ToString("N2");
                    }
                    else
                    {
                        row.Cells["colCantidad"].Value = cantidadUnidades;
                        row.Cells["colTotalDV"].Value = "S/ " + precioUnitario.ToString("N2");
                    }
                    CalcularTotales();
                }
            }
            finally
            {
                _actualizandoDesdeEdicion = false;
            }
        }

        private void ActualizarTotalFila(int rowIndex)
        {
            DataGridViewRow row = dgvCarritoVenta.Rows[rowIndex];
            var _cv = row.Cells["colCantidad"].Value;
            decimal cantidadBase = (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;

            var item = (dynamic)row.Tag;
            decimal _cantUnidades = (decimal)item.CantidadUnidades;
            if (_cantUnidades <= 0) return;
            decimal cantidadPresentaciones = cantidadBase / _cantUnidades;
            decimal total = cantidadPresentaciones * (decimal)item.PrecioUnitario;

            row.Cells["colTotalDV"].Value = "S/ " + total.ToString("N2");

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            // Separar ítems: los que tienen PrecioIncluyeIGV=true siempre se desglosan;
            // los que tienen false siguen el modo de venta (cboIGV).
            decimal subtotalConIGV = 0m;
            decimal subtotalSinIGV = 0m;

            foreach (DataGridViewRow row in dgvCarritoVenta.Rows)
            {
                if (row.Tag == null) continue;
                string totalStr = row.Cells["colTotalDV"].Value?.ToString() ?? "0";
                if (!TryParseMonto(totalStr, out decimal totalFila)) continue;
                var item = (dynamic)row.Tag;
                if ((bool)item.PrecioIncluyeIGV)
                    subtotalConIGV += totalFila;
                else
                    subtotalSinIGV += totalFila;
            }

            _rawCartTotal = subtotalConIGV + subtotalSinIGV;

            // Ítems con IGV incluido → desglosar siempre
            decimal baseConIGV = subtotalConIGV > 0m
                ? Math.Round(subtotalConIGV / (1m + _tasaIGV), 2) : 0m;
            decimal igvConIGV = subtotalConIGV - baseConIGV;

            // Ítems sin flag → aplicar modo de venta (cboIGV)
            int tipoIGV = cboIGV.SelectedIndex; // 0=SIN_IGV  1=IGV_INCLUIDO  2=IGV_ADICIONAL
            decimal baseSinIGV, igvSinIGV, totalSinIGV;

            if (tipoIGV == 1)           // IGV INCLUIDO
            {
                totalSinIGV = subtotalSinIGV;
                baseSinIGV  = Math.Round(subtotalSinIGV / (1m + _tasaIGV), 2);
                igvSinIGV   = subtotalSinIGV - baseSinIGV;
            }
            else if (tipoIGV == 2)      // IGV ADICIONAL
            {
                baseSinIGV  = subtotalSinIGV;
                igvSinIGV   = Math.Round(subtotalSinIGV * _tasaIGV, 2);
                totalSinIGV = subtotalSinIGV + igvSinIGV;
            }
            else                        // SIN IGV
            {
                baseSinIGV  = subtotalSinIGV;
                igvSinIGV   = 0m;
                totalSinIGV = subtotalSinIGV;
            }

            decimal totalBase = baseConIGV + baseSinIGV;
            decimal totalIGV  = igvConIGV  + igvSinIGV;
            decimal total     = subtotalConIGV + totalSinIGV;

            decimal descuento = decimal.TryParse(txtDescuento.Text, out decimal desc) ? desc : 0m;
            if (descuento < 0) descuento = 0m;
            if (descuento > total) descuento = total;
            total -= descuento;

            txtSubtotal.Text   = totalBase.ToString("N2"); // base imponible
            txtIGV.Text        = totalIGV.ToString("N2");
            txtTotalPagar.Text = total.ToString("N2");
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void RadioPago_CheckedChanged(object sender, EventArgs e)
        {
            if (_aplicandoPago) return; // evitar interferencia al aplicar resultado del modal

            txtEfectivo.Enabled = false;
            txtYape.Enabled = false;
            txtTransferencia.Enabled = false;
            txtTarjeta.Enabled = false;

            txtEfectivo.Clear();
            txtYape.Clear();
            txtTransferencia.Clear();
            txtTarjeta.Clear();

            if (rbEfectivo.Checked)
            {
                txtEfectivo.Enabled = true;
                txtEfectivo.Focus();
            }
            else if (rbYape.Checked)
            {
                txtYape.Enabled = true;
                txtYape.Focus();
            }
            else if (rbTransferencia.Checked)
            {
                txtTransferencia.Enabled = true;
                txtTransferencia.Focus();
            }
            else if (rbTarjeta.Checked)
            {
                txtTarjeta.Enabled = true;
                txtTarjeta.Focus();
            }
            else if (rbMixto.Checked)
            {
                txtEfectivo.Enabled = true;
                txtYape.Enabled = true;
                txtTransferencia.Enabled = true;
                txtTarjeta.Enabled = true;
                txtEfectivo.Focus();
            }
        }

        private void TxtRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }

        private void TxtRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir numeros, punto decimal y backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            // Forzar actualizacion con Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CalcularVuelto();
                btnCobrar.Focus(); // Mover foco al boton cobrar
            }
        }

        private void TxtMetodoPago_TextChanged(object sender, EventArgs e)
        {
            if (rbMixto.Checked)
            {
                decimal efectivo = decimal.TryParse(txtEfectivo.Text, out decimal ef) ? ef : 0;
                decimal yape = decimal.TryParse(txtYape.Text, out decimal yp) ? yp : 0;
                decimal transferencia = decimal.TryParse(txtTransferencia.Text, out decimal tr) ? tr : 0;
                decimal tarjeta = decimal.TryParse(txtTarjeta.Text, out decimal tj) ? tj : 0;

                decimal totalRecibido = efectivo + yape + transferencia + tarjeta;
                txtRecibido.Text = totalRecibido.ToString("N2");
            }
            else
            {
                TextBox txt = sender as TextBox;
                if (txt != null && !string.IsNullOrEmpty(txt.Text))
                {
                    txtRecibido.Text = txt.Text;
                }
            }
        }

        private void CalcularVuelto()
        {
            if (decimal.TryParse(txtRecibido.Text, out decimal recibido))
            {
                if (decimal.TryParse(txtTotalPagar.Text, out decimal total))
                {
                    decimal vuelto = recibido - total;
                    txtVuelto.Text = vuelto >= 0 ? vuelto.ToString("N2") : "0.00";
                }
            }
            else
            {
                txtVuelto.Text = "0.00";
            }
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            // Validación básica del carrito
            if (dgvCarritoVenta.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al carrito antes de cobrar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TryParseMonto(txtTotalPagar.Text, out decimal totalModal) || totalModal <= 0)
            {
                MessageBox.Show("El total de la venta es inválido.", "Validación");
                return;
            }

            // Abrir modal de pago
            using (var formPago = new FormPago(totalModal))
            {
                if (formPago.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                    return;

                AplicarResultadoPago(formPago);
            }

            // Verificar cliente para crédito
            if (rbCredito.Checked)
            {
                if (_clienteID == 1 || _clienteID == 0)
                {
                    MessageBox.Show("No se puede vender a crédito sin un cliente registrado.\nPor favor, seleccione un cliente.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbClientes.Focus();
                    return;
                }
            }

            ProcesarVenta();
        }

        private void AplicarResultadoPago(FormPago formPago)
        {
            _aplicandoPago = true;
            try
            {
                string metodo = formPago.MetodoPago;
                rbEfectivo.Checked      = metodo == "EFECTIVO";
                rbYape.Checked          = metodo == "YAPE";
                rbTransferencia.Checked = metodo == "TRANSFERENCIA";
                rbTarjeta.Checked       = metodo == "TARJETA";
                rbMixto.Checked         = metodo == "MIXTO";
                rbCredito.Checked       = metodo == "CREDITO";

                txtEfectivo.Text      = formPago.MontoEfectivo      > 0 ? formPago.MontoEfectivo.ToString("N2")      : "";
                txtYape.Text          = formPago.MontoYape           > 0 ? formPago.MontoYape.ToString("N2")          : "";
                txtTransferencia.Text = formPago.MontoTransferencia  > 0 ? formPago.MontoTransferencia.ToString("N2") : "";
                txtTarjeta.Text       = formPago.MontoTarjeta        > 0 ? formPago.MontoTarjeta.ToString("N2")       : "";
                txtRecibido.Text      = formPago.MontoRecibido.ToString("N2");
                txtVuelto.Text        = formPago.Vuelto.ToString("N2");
            }
            finally
            {
                _aplicandoPago = false;
            }
        }

        private void ProcesarVenta()
        {
            try
            {
                decimal efectivo = decimal.TryParse(txtEfectivo.Text, out decimal ef) ? ef : 0;
                decimal yape = decimal.TryParse(txtYape.Text, out decimal yp) ? yp : 0;
                decimal transferencia = decimal.TryParse(txtTransferencia.Text, out decimal tr) ? tr : 0;
                decimal tarjeta = decimal.TryParse(txtTarjeta.Text, out decimal tj) ? tj : 0;
                if (!TryParseMonto(txtTotalPagar.Text, out decimal total))
                    throw new Exception("Total de venta inválido.");
                if (!TryParseMonto(txtSubtotal.Text, out decimal baseImp))
                    throw new Exception("Base imponible inválida.");
                if (!TryParseMonto(txtIGV.Text, out decimal igv))
                    throw new Exception("IGV inválido.");
                // SubTotal = suma bruta de líneas del carrito (sin agregar IGV adicional).
                // Usamos _rawCartTotal que es la suma directa de colTotalDV antes de cualquier ajuste.
                decimal subTotal = _rawCartTotal;

                // Obtener serie y correlativo según tipo de comprobante
                var configFact = EmpresaRepository.ObtenerConfiguracionFacturacion();
                string tipoComp = cmbTipoComprobante.Text;
                string serieComp;
                int correlativo;
                switch (tipoComp)
                {
                    case "BOLETA":
                        serieComp = configFact.SerieBoleta;
                        correlativo = configFact.CorrelativoBoleta + 1;
                        configFact.CorrelativoBoleta = correlativo;
                        break;
                    case "FACTURA":
                        serieComp = configFact.SerieFactura;
                        correlativo = configFact.CorrelativoFactura + 1;
                        configFact.CorrelativoFactura = correlativo;
                        break;
                    default: // NOTA_VENTA y cualquier otro
                        serieComp = configFact.SerieNotaVenta;
                        correlativo = configFact.CorrelativoNotaVenta + 1;
                        configFact.CorrelativoNotaVenta = correlativo;
                        break;
                }

                var venta = new Venta
                {
                    NumeroVenta = VentaRepository.GenerarNumeroVenta(),
                    Fecha = DateTime.Now.Date,
                    Hora = DateTime.Now.TimeOfDay,
                    ClienteID = _clienteID,
                    TipoComprobante = tipoComp,
                    Serie = serieComp,
                    Numero = correlativo.ToString("D8"),
                    SubTotal      = subTotal,
                    IGV           = igv,
                    TipoIGV       = cboIGV.SelectedIndex,
                    BaseImponible = baseImp,
                    Total         = total,
                    MetodoPago = ObtenerMetodoPago(),
                    MontoEfectivo = rbEfectivo.Checked ? total : (rbMixto.Checked ? efectivo : 0),
                    MontoYape = rbYape.Checked ? total : (rbMixto.Checked ? yape : 0),
                    MontoTarjeta = rbTarjeta.Checked ? total : (rbMixto.Checked ? tarjeta : 0),
                    MontoTransferencia = rbTransferencia.Checked ? total : (rbMixto.Checked ? transferencia : 0),
                    Estado = rbCredito.Checked ? "CREDITO" : "COMPLETADA",
                    CajaID = _cajaID,
                    UsuarioID = SesionActual.Usuario.UsuarioID
                };

                var detalles = new List<VentaDetalle>();

                foreach (DataGridViewRow row in dgvCarritoVenta.Rows)
                {
                    if (row.IsNewRow) continue;

                    var item = (dynamic)row.Tag;
                    var _cv = row.Cells["colCantidad"].Value;
                    decimal cantidadBase = (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;
                    decimal cantidadUnidades = (decimal)item.CantidadUnidades;
                    if (cantidadUnidades <= 0) continue;
                    decimal cantidadPresentaciones = cantidadBase / cantidadUnidades;

                    detalles.Add(new VentaDetalle
                    {
                        ProductoID = item.ProductoID,
                        ProductoPresentacionID = item.PresentacionID,
                        Cantidad = cantidadPresentaciones,
                        PrecioUnitario = item.PrecioUnitario,
                        Subtotal = cantidadPresentaciones * (decimal)item.PrecioUnitario,
                        CantidadUnidadesBase = cantidadBase
                    });
                }

                if (VentaRepository.Crear(venta, detalles))
                {
                    // Guardar correlativo actualizado
                    EmpresaRepository.GuardarConfiguracionFacturacion(configFact);

                    MessageBox.Show(
                        $"Venta registrada exitosamente\n\nComprobante: {venta.NumeroVenta}\nTotal: S/ {venta.Total:N2}",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    var imprimirResult = MessageBox.Show("¿Desea imprimir el comprobante?",
                        "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (imprimirResult == DialogResult.Yes)
                    {
                        ImprimirTicketVenta(venta, detalles);
                    }

                    LimpiarVenta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar venta: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string ObtenerMetodoPago()
        {
            if (rbMixto.Checked) return "MIXTO";
            if (rbEfectivo.Checked) return "EFECTIVO";
            if (rbYape.Checked) return "YAPE";
            if (rbTransferencia.Checked) return "TRANSFERENCIA";
            if (rbTarjeta.Checked) return "TARJETA";
            if (rbCredito.Checked) return "CREDITO";

            return "EFECTIVO";
        }

        private bool ValidarVenta()
        {
            if (dgvCarritoVenta.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al carrito", "Validación");
                return false;
            }

            if (!TryParseMonto(txtTotalPagar.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("El total de la venta es inválido", "Validación");
                return false;
            }

            decimal recibido = decimal.TryParse(txtRecibido.Text, out decimal rec) ? rec : 0;

            if (rbCredito.Checked)
            {
                return true;
            }

            if (rbMixto.Checked)
            {
                decimal efectivo = decimal.TryParse(txtEfectivo.Text, out decimal ef) ? ef : 0;
                decimal yape = decimal.TryParse(txtYape.Text, out decimal yp) ? yp : 0;
                decimal transferencia = decimal.TryParse(txtTransferencia.Text, out decimal tr) ? tr : 0;
                decimal tarjeta = decimal.TryParse(txtTarjeta.Text, out decimal tj) ? tj : 0;
                decimal suma = efectivo + yape + transferencia + tarjeta;

                if (Math.Abs(suma - total) > 0.01m)
                {
                    MessageBox.Show("La suma de pagos mixtos no coincide con el total", "Validación");
                    return false;
                }
            }

            if (rbTarjeta.Checked)
                return true; // Tarjeta no requiere validar vuelto

            if (recibido < total)
            {
                MessageBox.Show("El monto recibido es menor al total", "Validación");
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCarritoVenta.Rows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Cancelar venta actual?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LimpiarVenta();
                }
            }
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            var formHistorial = new FormHistorialVentas();
            formHistorial.ShowDialog();
        }

        private void ImprimirTicketVenta(Venta venta, List<VentaDetalle> detallesVenta)
        {
            try
            {
                int ventaID = VentaRepository.ObtenerVentaIDPorNumero(venta.NumeroVenta);
                if (ventaID == 0)
                {
                    MessageBox.Show("No se pudo encontrar la venta para imprimir", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var parametros = ReportHelper.GetCompanyParameters();
                var dt = ReportDataSourceHelper.ObtenerDatosTicketVenta(ventaID, parametros);

                var dataSources = new Dictionary<string, DataTable> { { "DsDetalleVenta", dt } };

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Documents\RptTicketVenta.rdlc"),
                    dataSources, parametros, "ticket_venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarVenta()
        {
            dgvCarritoVenta.Rows.Clear();
            txtSubtotal.Text = "0.00";
            txtIGV.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtRecibido.Text = "0.00";
            txtEfectivo.Clear();
            txtYape.Clear();
            txtTransferencia.Clear();
            txtTarjeta.Clear();
            txtVuelto.Text = "0.00";

            cmbClientes.SelectedIndex = 0; // ← CAMBIADO: Volver a cliente general

            var clienteGeneral = ClienteRepository.ObtenerClienteGeneral();
            _clienteID = clienteGeneral != null ? clienteGeneral.ClienteID : 1;
            lblNombreCliente.Text = "CLIENTE GENERAL";
            lblDNICliente.Text = "00000000";

            rbEfectivo.Checked = true;
        }

        private void DgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox combo = e.Control as ComboBox;

                combo.DropDown -= ComboBox_DropDown;
                combo.DrawItem -= ComboBox_DrawItem;

                combo.BackColor = Color.White;
                combo.ForeColor = Color.Black;
                combo.FlatStyle = FlatStyle.Popup;
                combo.DrawMode = DrawMode.OwnerDrawFixed;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;

                combo.DropDown += ComboBox_DropDown;
                combo.DrawItem += ComboBox_DrawItem;
            }
        }

        private void ComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo != null)
            {
                combo.BackColor = Color.White;
                combo.ForeColor = Color.Black;
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox combo = sender as ComboBox;

            e.DrawBackground();

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color backColor = isSelected ? Color.LightSkyBlue : Color.White;
            Color foreColor = isSelected ? Color.White : Color.Black;

            using (SolidBrush backBrush = new SolidBrush(backColor))
            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);

                if (combo.Items[e.Index] != null)
                {
                    string text = combo.GetItemText(combo.Items[e.Index]);
                    e.Graphics.DrawString(text, e.Font, foreBrush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }

        private void DgvProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProductos.IsCurrentCellDirty)
            {
                dgvProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "colPresentacion")
            {
                try
                {
                    var item = (dynamic)dgvProductos.Rows[e.RowIndex].Tag;
                    var comboCell = dgvProductos.Rows[e.RowIndex].Cells["colPresentacion"] as DataGridViewComboBoxCell;

                    if (comboCell != null && comboCell.Value != null)
                    {
                        int presentacionID = Convert.ToInt32(comboCell.Value);

                        List<ProductoPresentacion> presentaciones = item.Presentaciones;
                        var presentacion = presentaciones.Find(p => p.ProductoPresentacionID == presentacionID);

                        if (presentacion != null)
                        {
                            dgvProductos.Rows[e.RowIndex].Cells["colPrecioUnit"].Value = "S/ " + presentacion.PrecioVenta.ToString("N2");
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al cambiar presentación: {ex.Message}");
                }
            }
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CalcularTotales();
            }
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDescuento.Text, out decimal desc))
            {
                if (desc < 0)
                {
                    txtDescuento.Text = "0.00";
                }
                else
                {
                    decimal subtotal = decimal.TryParse(txtSubtotal.Text, out decimal st) ? st : 0;
                    decimal igv = decimal.TryParse(txtIGV.Text, out decimal iv) ? iv : 0;
                    decimal maxDescuento = subtotal + igv;
                    if (desc > maxDescuento)
                    {
                        txtDescuento.Text = maxDescuento.ToString("N2");
                    }
                }
            }
            else
            {
                txtDescuento.Text = "0.00";
            }

            CalcularTotales();
        }

        private bool TryParseMonto(string valor, out decimal monto)
        {
            valor = (valor ?? string.Empty).Trim().Replace("S/ ", "");
            return decimal.TryParse(valor, NumberStyles.Number, CultureInfo.CurrentCulture, out monto)
                || decimal.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out monto);
        }

        // ══════════════════════════════════════════════════════════════
        // CATEGORÍAS — chips horizontales
        // ══════════════════════════════════════════════════════════════

        private void CargarCategorias()
        {
            flpCategorias.Controls.Clear();

            var btnTodos = CrearChipCategoria("TODOS", 0, activo: true);
            flpCategorias.Controls.Add(btnTodos);

            try
            {
                var categorias = CategoriaRepository.ObtenerTodas();
                foreach (var cat in categorias)
                {
                    var btn = CrearChipCategoria(cat.Nombre, cat.CategoriaID, activo: false);
                    flpCategorias.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando categorías: {ex.Message}");
            }
        }

        private System.Windows.Forms.Button CrearChipCategoria(string texto, int categoriaID, bool activo)
        {
            var btn = new System.Windows.Forms.Button
            {
                Text      = texto,
                Tag       = categoriaID,
                AutoSize  = false,
                Height    = 28,
                MinimumSize = new System.Drawing.Size(70, 28),
                Padding   = new System.Windows.Forms.Padding(10, 0, 10, 0),
                Cursor    = System.Windows.Forms.Cursors.Hand,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                Margin    = new System.Windows.Forms.Padding(0, 0, 6, 0),
            };
            btn.FlatAppearance.BorderSize = 1;

            // Medir el texto y ajustar ancho
            using (var g = btn.CreateGraphics())
            {
                var sz = g.MeasureString(texto, btn.Font);
                btn.Width = (int)sz.Width + 24;
            }

            AplicarEstiloChip(btn, activo);
            btn.Click += (s, e) =>
            {
                _categoriaFiltro = (int)btn.Tag;
                foreach (System.Windows.Forms.Button b in flpCategorias.Controls)
                    AplicarEstiloChip(b, (int)b.Tag == _categoriaFiltro);
                if (_vistaCards)
                    CargarProductosTarjetas(txtBuscar.Text.Trim(), _categoriaFiltro);
                else
                    CargarProductos(txtBuscar.Text.Trim());
            };
            return btn;
        }

        private void AplicarEstiloChip(System.Windows.Forms.Button btn, bool activo)
        {
            if (activo)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
                btn.ForeColor = System.Drawing.Color.White;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            }
            else
            {
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            }
        }

        // ══════════════════════════════════════════════════════════════
        // VISTA LISTA / TARJETAS
        // ══════════════════════════════════════════════════════════════

        private void BtnVistaLista_Click(object sender, EventArgs e)
        {
            if (!_vistaCards) return;
            _vistaCards = false;
            btnVistaLista.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnVistaLista.ForeColor = System.Drawing.Color.White;
            btnVistaCards.BackColor = System.Drawing.Color.White;
            btnVistaCards.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);

            flpProductCards.Visible = false;
            dgvProductos.Visible    = true;
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void BtnVistaCards_Click(object sender, EventArgs e)
        {
            if (_vistaCards) return;
            _vistaCards = true;
            btnVistaCards.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnVistaCards.ForeColor = System.Drawing.Color.White;
            btnVistaLista.BackColor = System.Drawing.Color.White;
            btnVistaLista.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);

            dgvProductos.Visible    = false;
            flpProductCards.Visible = true;
            CargarProductosTarjetas(txtBuscar.Text.Trim(), _categoriaFiltro);
        }

        private void CargarProductosTarjetas(string busqueda = "", int categoriaID = 0)
        {
            flpProductCards.Controls.Clear();

            try
            {
                var productos = ProductoRepository.BuscarProductos(busqueda);

                // Filtro de categoría cliente-side
                if (categoriaID > 0)
                    productos = productos.FindAll(p => p.CategoriaID == categoriaID);

                foreach (var producto in productos)
                {
                    var presentaciones = ProductoRepository.ObtenerPresentaciones(producto.ProductoID);
                    if (presentaciones.Count == 0) continue;

                    var card = CrearTarjetaProducto(producto, presentaciones);
                    flpProductCards.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando tarjetas: {ex.Message}");
            }
        }

        private System.Windows.Forms.Panel CrearTarjetaProducto(
            SistemaPOS.Models.Producto producto,
            System.Collections.Generic.List<SistemaPOS.Models.ProductoPresentacion> presentaciones)
        {
            const int CARD_W = 168, CARD_H = 210;

            var card = new System.Windows.Forms.Panel
            {
                Size      = new System.Drawing.Size(CARD_W, CARD_H),
                BackColor = System.Drawing.Color.White,
                Cursor    = System.Windows.Forms.Cursors.Hand,
                Margin    = new System.Windows.Forms.Padding(6),
                Tag       = new { ProductoID = producto.ProductoID, Presentaciones = presentaciones,
                                  UnidadBaseID = producto.UnidadBaseID },
            };

            // Imagen o placeholder
            var pic = new System.Windows.Forms.PictureBox
            {
                Location  = new System.Drawing.Point(0, 0),
                Size      = new System.Drawing.Size(CARD_W, 110),
                SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                BackColor = System.Drawing.Color.FromArgb(240, 242, 246),
            };
            if (producto.Imagen != null && producto.Imagen.Length > 0)
            {
                try
                {
                    using (var ms = new System.IO.MemoryStream(producto.Imagen))
                    using (var img = System.Drawing.Image.FromStream(ms))
                        pic.Image = new System.Drawing.Bitmap(img);
                }
                catch { /* sin imagen */ }
            }
            card.Controls.Add(pic);

            // Nombre
            var lblNom = new System.Windows.Forms.Label
            {
                Text      = producto.Nombre,
                Location  = new System.Drawing.Point(6, 114),
                Size      = new System.Drawing.Size(CARD_W - 12, 34),
                Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(45, 52, 54),
            };
            card.Controls.Add(lblNom);

            // Precio (primera presentación)
            string precio = presentaciones.Count > 0 ? $"S/ {presentaciones[0].PrecioVenta:N2}" : "";
            var lblPrecio = new System.Windows.Forms.Label
            {
                Text      = precio,
                Location  = new System.Drawing.Point(6, 150),
                Size      = new System.Drawing.Size(CARD_W - 12, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(39, 174, 96),
            };
            card.Controls.Add(lblPrecio);

            // Botón Agregar
            var btnAdd = new System.Windows.Forms.Button
            {
                Text      = "+ Agregar",
                Location  = new System.Drawing.Point(6, 178),
                Size      = new System.Drawing.Size(CARD_W - 12, 26),
                BackColor = System.Drawing.Color.FromArgb(37, 99, 235),
                ForeColor = System.Drawing.Color.White,
                Cursor    = System.Windows.Forms.Cursors.Hand,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
            };
            btnAdd.FlatAppearance.BorderSize = 0;

            // Capturar variables para el closure
            var prod     = producto;
            var pres      = presentaciones;
            btnAdd.Click += (s, e) =>
            {
                var item2 = card.Tag as dynamic;
                string unidad = ObtenerSimboloUnidad((int)item2.UnidadBaseID);
                AgregarAlCarrito(prod.ProductoID, prod.Nombre, pres[0], unidad);
            };

            // Double-click en la tarjeta también agrega
            card.DoubleClick += (s, e) =>
            {
                string unidad = ObtenerSimboloUnidad(producto.UnidadBaseID);
                AgregarAlCarrito(producto.ProductoID, producto.Nombre, presentaciones[0], unidad);
            };

            card.Controls.Add(btnAdd);

            // Borde sutil
            card.Paint += (s, e) =>
            {
                using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(223, 228, 234), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            };

            return card;
        }

        // ══════════════════════════════════════════════════════════════
        // VISTA PREVIA
        // ══════════════════════════════════════════════════════════════

        private void BtnPrevia_Click(object sender, EventArgs e)
        {
            if (dgvCarritoVenta.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al carrito para ver la vista previa.", "Vista Previa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var parametros  = ReportHelper.GetCompanyParameters();
                var dt          = ObtenerDatosTicketPrevia(parametros);
                var dataSources = new Dictionary<string, DataTable> { { "DsDetalleVenta", dt } };

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Documents\RptTicketVenta.rdlc"),
                    dataSources, parametros, "previa_ticket");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en vista previa: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosTicketPrevia(Dictionary<string, string> parametros)
        {
            var dt = new DataTable("DetalleVenta");
            dt.Columns.Add("Numero",        typeof(int));
            dt.Columns.Add("Producto",      typeof(string));
            dt.Columns.Add("Presentacion",  typeof(string));
            dt.Columns.Add("Cantidad",      typeof(string));
            dt.Columns.Add("PrecioUnitario",typeof(decimal));
            dt.Columns.Add("SubTotal",      typeof(decimal));

            parametros["pTipoComprobante"] = cmbTipoComprobante.Text;
            parametros["pNumeroVenta"]     = "(PREVIA)";
            parametros["pFecha"]           = DateTime.Now.ToString("dd/MM/yyyy");
            parametros["pHora"]            = DateTime.Now.ToString(@"hh\:mm\:ss");
            parametros["pEstado"]          = "PREVIA";
            parametros["pMetodoPago"]      = "-";
            parametros["pSubTotal"]        = $"S/ {txtSubtotal.Text}";

            decimal descuento = decimal.TryParse(txtDescuento.Text, out decimal ds) ? ds : 0;
            parametros["pDescuento"] = $"S/ {descuento:N2}";
            parametros["pIGV"]       = $"S/ {txtIGV.Text}";
            parametros["pTotal"]     = $"S/ {txtTotalPagar.Text}";
            parametros["pCliente"]   = lblNombreCliente.Text;
            parametros["pDocCliente"]= lblDNICliente.Text;

            var usuario = SesionActual.Usuario;
            parametros["pEncargado"] = usuario?.NombreCompleto ?? "Usuario";

            int numero = 1;
            foreach (DataGridViewRow row in dgvCarritoVenta.Rows)
            {
                if (row.IsNewRow || row.Tag == null) continue;
                var item = (dynamic)row.Tag;

                var _cv = row.Cells["colCantidad"].Value;
                decimal cantBase = (_cv != null && decimal.TryParse(_cv.ToString(), out decimal _cvp)) ? _cvp : 0m;
                decimal cantUnidades = (decimal)item.CantidadUnidades;

                string totalStr = row.Cells["colTotalDV"].Value?.ToString() ?? "0";
                TryParseMonto(totalStr, out decimal totalFila);

                string simbolo  = item.UnidadSimbolo ?? "";
                string cantTxt  = cantBase.ToString("N2") + (string.IsNullOrEmpty(simbolo) ? "" : " " + simbolo);
                string nombrePres = row.Cells["colPresentacionDV"].Value?.ToString() ?? "";

                dt.Rows.Add(numero++,
                    row.Cells["colProductoDV"].Value?.ToString() ?? "",
                    nombrePres,
                    cantTxt,
                    (decimal)item.PrecioUnitario,
                    totalFila);
            }
            return dt;
        }
    }
}
