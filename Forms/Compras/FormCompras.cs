using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Compras
{
    public partial class FormCompras : Form
    {
        private int _proveedorID;
        private List<Proveedor> _proveedores;
        private List<Producto> _productosEncontrados;
        private Producto _productoSeleccionado;
        private bool _actualizandoBusqueda;
        private Timer _timerBusqueda;

        public FormCompras()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarControles();
            InicializarFormulario();
        }

        private void ConfigurarEventos()
        {
            cmbBuscarProveedor.SelectionChangeCommitted += CmbBuscarProveedor_SelectionChangeCommitted;
            btnBuscarCliente.Click += BtnBuscarProveedor_Click;

            // TextUpdate solo se dispara cuando el usuario escribe, no al cambiar Items programaticamente
            cmbBuscarProducto.TextUpdate += CmbBuscarProducto_TextUpdate;
            // SelectionChangeCommitted solo se dispara cuando el usuario selecciona, no programaticamente
            cmbBuscarProducto.SelectionChangeCommitted += CmbBuscarProducto_SelectionChangeCommitted;
            cmbBuscarProducto.KeyDown += CmbBuscarProducto_KeyDown;

            cmbPresentacion.SelectedIndexChanged += CmbPresentacion_SelectedIndexChanged;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            dgvProductos.CellClick += DgvProductos_CellClick;
            chkIncluirIGV.CheckedChanged += ChkIncluirIGV_CheckedChanged;
            rbCredito.CheckedChanged += RbCredito_CheckedChanged;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            txtCostoUnitario.KeyPress += TxtSoloNumeros_KeyPress;
            btnHistorial.Click += BtnHistorial_Click;

            // Timer para debounce de busqueda
            _timerBusqueda = new Timer();
            _timerBusqueda.Interval = 400;
            _timerBusqueda.Tick += (s, e) =>
            {
                _timerBusqueda.Stop();
                EjecutarBusquedaProducto();
            };
        }

        private void ConfigurarControles()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtSubtotal.ReadOnly = true;
            txtIGV.ReadOnly = true;
            txtTotal.ReadOnly = true;

            numCantidad.Minimum = 1;
            numCantidad.Maximum = 99999;
            numCantidad.Value = 1;

            cmbTipoComprobante.Items.Clear();
            cmbTipoComprobante.Items.Add("FACTURA");
            cmbTipoComprobante.Items.Add("BOLETA");
            cmbTipoComprobante.Items.Add("GUIA");
            cmbTipoComprobante.SelectedIndex = 0;

            cmbBuscarProducto.AutoCompleteMode = AutoCompleteMode.None;
            cmbBuscarProducto.DropDownStyle = ComboBoxStyle.DropDown;

            dtpVencimiento.Visible = false;
            lblVencimiento.Visible = false;
        }

        private void InicializarFormulario()
        {
            _proveedorID = 0;
            _proveedores = ProveedorRepository.ObtenerTodos();
            _productoSeleccionado = null;
            lblNombreRazonSocial.Text = "";

            CargarProveedoresEnCombo();

            dtpFecha.Value = DateTime.Now;
            rbContado.Checked = true;

            txtSubtotal.Text = "0.00";
            txtIGV.Text = "0.00";
            txtTotal.Text = "0.00";
        }

        // ===== PROVEEDOR =====

        private void CargarProveedoresEnCombo()
        {
            cmbBuscarProveedor.Items.Clear();
            cmbBuscarProveedor.Items.Add("-- Seleccionar Proveedor --");
            foreach (var p in _proveedores)
                cmbBuscarProveedor.Items.Add(p.RazonSocial);
            cmbBuscarProveedor.SelectedIndex = 0;
        }

        private void CmbBuscarProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBuscarProveedor.SelectedIndex <= 0)
            {
                _proveedorID = 0;
                lblNombreRazonSocial.Text = "";
                return;
            }

            var proveedor = _proveedores[cmbBuscarProveedor.SelectedIndex - 1];
            _proveedorID = proveedor.ProveedorID;
            lblNombreRazonSocial.Text = proveedor.RazonSocial;
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (cmbBuscarProveedor.SelectedIndex > 0)
            {
                var proveedor = _proveedores[cmbBuscarProveedor.SelectedIndex - 1];
                _proveedorID = proveedor.ProveedorID;
                lblNombreRazonSocial.Text = proveedor.RazonSocial;
            }
        }

        // ===== PRODUCTO =====

        private void CmbBuscarProducto_TextUpdate(object sender, EventArgs e)
        {
            // Reiniciar timer en cada tecleo (debounce)
            _timerBusqueda.Stop();
            _timerBusqueda.Start();
        }

        private void EjecutarBusquedaProducto()
        {
            if (_actualizandoBusqueda) return;

            string busqueda = cmbBuscarProducto.Text.Trim();
            if (busqueda.Length < 2)
            {
                _productosEncontrados = null;
                _productoSeleccionado = null;
                return;
            }

            _productosEncontrados = ProductoRepository.BuscarProductos(busqueda);

            if (_productosEncontrados.Count > 0)
            {
                _actualizandoBusqueda = true;
                try
                {
                    string textoActual = cmbBuscarProducto.Text;
                    int cursorPos = cmbBuscarProducto.SelectionStart;

                    cmbBuscarProducto.BeginUpdate();
                    cmbBuscarProducto.Items.Clear();
                    foreach (var p in _productosEncontrados)
                        cmbBuscarProducto.Items.Add($"{p.Codigo} - {p.Nombre}");
                    cmbBuscarProducto.EndUpdate();

                    cmbBuscarProducto.Text = textoActual;
                    cmbBuscarProducto.SelectionStart = textoActual.Length;
                    cmbBuscarProducto.SelectionLength = 0;
                    cmbBuscarProducto.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
                finally
                {
                    _actualizandoBusqueda = false;
                }

                if (_productosEncontrados.Count == 1)
                {
                    _productoSeleccionado = _productosEncontrados[0];
                    CargarPresentaciones(_productoSeleccionado.ProductoID);
                }
            }
            else
            {
                _productoSeleccionado = null;
                cmbPresentacion.DataSource = null;
                txtCostoUnitario.Clear();
            }
        }

        private void CmbBuscarProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_actualizandoBusqueda) return;
            if (cmbBuscarProducto.SelectedIndex < 0) return;
            if (_productosEncontrados == null || cmbBuscarProducto.SelectedIndex >= _productosEncontrados.Count) return;

            _productoSeleccionado = _productosEncontrados[cmbBuscarProducto.SelectedIndex];
            CargarPresentaciones(_productoSeleccionado.ProductoID);
        }

        private void CmbBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _productosEncontrados != null && _productosEncontrados.Count > 0)
            {
                _timerBusqueda.Stop();

                if (cmbBuscarProducto.SelectedIndex >= 0)
                {
                    _productoSeleccionado = _productosEncontrados[cmbBuscarProducto.SelectedIndex];
                }
                else
                {
                    _productoSeleccionado = _productosEncontrados[0];
                }
                CargarPresentaciones(_productoSeleccionado.ProductoID);

                _actualizandoBusqueda = true;
                cmbBuscarProducto.Text = $"{_productoSeleccionado.Codigo} - {_productoSeleccionado.Nombre}";
                _actualizandoBusqueda = false;

                cmbBuscarProducto.DroppedDown = false;
                cmbPresentacion.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CargarPresentaciones(int productoID)
        {
            var presentaciones = ProductoRepository.ObtenerPresentaciones(productoID);
            string simboloUnidad = ObtenerSimboloUnidadBase(_productoSeleccionado.UnidadBaseID);

            var items = new List<object>();
            foreach (var pres in presentaciones)
            {
                string nombrePres = ObtenerNombrePresentacion(pres.PresentacionID);
                items.Add(new
                {
                    Display = $"{nombrePres} ({pres.CantidadUnidades} {simboloUnidad})",
                    Value = pres.ProductoPresentacionID,
                    Presentacion = pres
                });
            }

            cmbPresentacion.DataSource = items;
            cmbPresentacion.DisplayMember = "Display";
            cmbPresentacion.ValueMember = "Value";

            if (items.Count > 0)
            {
                cmbPresentacion.SelectedIndex = 0;
                var pres = ((dynamic)items[0]).Presentacion;
                txtCostoUnitario.Text = pres.CostoBase.ToString("N2");
            }
        }

        private void CmbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPresentacion.SelectedItem == null) return;

            try
            {
                var item = (dynamic)cmbPresentacion.SelectedItem;
                var pres = item.Presentacion;
                txtCostoUnitario.Text = ((decimal)pres.CostoBase).ToString("N2");
            }
            catch { }
        }

        private string ObtenerSimboloUnidadBase(int unidadBaseID)
        {
            return UnidadRepository.ObtenerSimboloPorID(unidadBaseID);
        }

        private string ObtenerNombrePresentacion(int presentacionID)
        {
            return PresentacionRepository.ObtenerNombrePorID(presentacionID);
        }

        // ===== GRILLA =====

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Busca y selecciona un producto", "Validación");
                cmbBuscarProducto.Focus();
                return;
            }

            if (cmbPresentacion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una presentación", "Validación");
                return;
            }

            if (!decimal.TryParse(txtCostoUnitario.Text, out decimal costo) || costo <= 0)
            {
                MessageBox.Show("Ingresa un costo válido", "Validación");
                txtCostoUnitario.Focus();
                return;
            }

            var itemPres = (dynamic)cmbPresentacion.SelectedItem;
            var presentacion = itemPres.Presentacion;
            int cantidad = (int)numCantidad.Value;
            decimal subtotal = cantidad * costo;

            int index = dgvProductos.Rows.Add();
            DataGridViewRow row = dgvProductos.Rows[index];

            row.Cells["colNumero"].Value = dgvProductos.Rows.Count;
            row.Cells["colProductoDV"].Value = _productoSeleccionado.Nombre;
            row.Cells["colPresentacionDV"].Value = cmbPresentacion.Text;
            row.Cells["colCantidad"].Value = cantidad;
            row.Cells["colCostoUnitario"].Value = "S/ " + costo.ToString("N2");
            row.Cells["colSubTotal"].Value = "S/ " + subtotal.ToString("N2");

            row.Tag = new
            {
                ProductoID = _productoSeleccionado.ProductoID,
                ProductoPresentacionID = (int)presentacion.ProductoPresentacionID,
                CostoUnitario = costo,
                CantidadUnidades = (decimal)presentacion.CantidadUnidades,
                Cantidad = cantidad
            };

            LimpiarCamposProducto();
            CalcularTotales();
            cmbBuscarProducto.Focus();
        }

        private void LimpiarCamposProducto()
        {
            _actualizandoBusqueda = true;
            cmbBuscarProducto.Items.Clear();
            cmbBuscarProducto.Text = "";
            _actualizandoBusqueda = false;

            cmbPresentacion.DataSource = null;
            txtCostoUnitario.Clear();
            numCantidad.Value = 1;
            _productoSeleccionado = null;
            _productosEncontrados = null;
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                dgvProductos.Rows.RemoveAt(e.RowIndex);
                RenumerarFilas();
                CalcularTotales();
            }
        }

        private void RenumerarFilas()
        {
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
                dgvProductos.Rows[i].Cells["colNumero"].Value = i + 1;
        }

        // ===== TOTALES =====

        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                var item = (dynamic)row.Tag;
                subtotal += (decimal)item.CostoUnitario * item.Cantidad;
            }

            decimal igv = chkIncluirIGV.Checked ? subtotal * 0.18m : 0;
            decimal total = subtotal + igv;

            txtSubtotal.Text = subtotal.ToString("N2");
            txtIGV.Text = igv.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }

        private void ChkIncluirIGV_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void RbCredito_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Visible = rbCredito.Checked;
            lblVencimiento.Visible = rbCredito.Checked;
            if (rbCredito.Checked)
                dtpVencimiento.Value = DateTime.Now.AddDays(30);
        }

        // ===== GUARDAR =====

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            var confirmacion = MessageBox.Show(
                $"¿Registrar compra por S/ {txtTotal.Text}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            try
            {
                if (!TryParseDecimal(txtSubtotal.Text, out decimal subTotal)
                    || !TryParseDecimal(txtIGV.Text, out decimal igv)
                    || !TryParseDecimal(txtTotal.Text, out decimal total))
                {
                    MessageBox.Show("No se pudo interpretar los totales de la compra.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var compra = new Compra
                {
                    NumeroCompra = CompraRepository.GenerarNumeroCompra(),
                    Fecha = dtpFecha.Value.Date,
                    Hora = DateTime.Now.TimeOfDay,
                    ProveedorID = _proveedorID,
                    TipoComprobante = cmbTipoComprobante.Text,
                    Serie = cmbTipoComprobante.Text == "FACTURA" ? "F001" : (cmbTipoComprobante.Text == "BOLETA" ? "B001" : "G001"),
                    Numero = txtNumero.Text.Trim(),
                    IncluyeIGV = chkIncluirIGV.Checked,
                    SubTotal = subTotal,
                    IGV = igv,
                    Total = total,
                    MetodoPago = rbContado.Checked ? "EFECTIVO" : "CREDITO",
                    Estado = rbCredito.Checked ? "CREDITO" : "COMPLETADA",
                    UsuarioID = SesionActual.Usuario.UsuarioID,
                    Observaciones = txtObservaciones.Text.Trim()
                };

                var detalles = new List<CompraDetalle>();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    var item = (dynamic)row.Tag;
                    detalles.Add(new CompraDetalle
                    {
                        ProductoID = item.ProductoID,
                        ProductoPresentacionID = item.ProductoPresentacionID,
                        Cantidad = item.Cantidad,
                        CostoUnitario = item.CostoUnitario,
                        Subtotal = (decimal)item.CostoUnitario * item.Cantidad,
                        CantidadUnidadesBase = (decimal)item.CantidadUnidades * item.Cantidad
                    });
                }

                DateTime? fechaVencimiento = rbCredito.Checked ? (DateTime?)dtpVencimiento.Value.Date : null;

                if (CompraRepository.Crear(compra, detalles, fechaVencimiento))
                {
                    MessageBox.Show(
                        $"Compra registrada exitosamente\n\nN°: {compra.NumeroCompra}\nTotal: S/ {compra.Total:N2}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar compra: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            if (_proveedorID == 0)
            {
                MessageBox.Show("Selecciona un proveedor", "Validación");
                cmbBuscarProveedor.Focus();
                return false;
            }

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto", "Validación");
                return false;
            }

            if (!rbContado.Checked && !rbCredito.Checked)
            {
                MessageBox.Show("Selecciona un método de pago", "Validación");
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Cancelar compra actual?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) return;
            }
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            dgvProductos.Rows.Clear();
            cmbBuscarProveedor.SelectedIndex = 0;
            lblNombreRazonSocial.Text = "";
            _proveedorID = 0;

            LimpiarCamposProducto();

            txtNumero.Clear();
            txtNumero.Clear();
            txtObservaciones.Clear();
            txtSubtotal.Text = "0.00";
            txtIGV.Text = "0.00";
            txtTotal.Text = "0.00";
            chkIncluirIGV.Checked = false;
            rbContado.Checked = true;
            dtpFecha.Value = DateTime.Now;
            cmbTipoComprobante.SelectedIndex = 0;
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            var formHistorial = new FormHistorialCompras();
            formHistorial.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _timerBusqueda?.Dispose();
            base.OnFormClosed(e);
        }

        private static bool TryParseDecimal(string texto, out decimal valor)
        {
            if (decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out valor))
                return true;

            return decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
        }
    }
}
