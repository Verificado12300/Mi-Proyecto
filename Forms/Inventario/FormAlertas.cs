using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Forms.Shared;
using SistemaPOS.Models;
using SistemaPOS.Reports.DataSources;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Inventario
{
    public partial class FormAlertas : Form
    {
        private List<ProductoAlerta> _productos = new List<ProductoAlerta>();
        private List<Categoria> _categorias = new List<Categoria>();

        public FormAlertas()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarControles();
            CargarCategorias();
            CargarProductos();
        }

        private void ConfigurarEventos()
        {
            btnActualizar.Click += BtnActualizar_Click;
            btnExportar.Click += BtnExportar_Click;
            txtBuscar.TextChanged += Filtros_Changed;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            cmbCategoria.SelectedIndexChanged += Filtros_Changed;
            cmbFiltroStock.SelectedIndexChanged += Filtros_Changed;
            dgvInventario.CellClick += DgvInventario_CellClick;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AplicarFiltros();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ConfigurarControles()
        {
            // Configurar DataGridView
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configurar combo de filtro
            cmbFiltroStock.SelectedIndex = 0; // Todos
        }

        private void CargarCategorias()
        {
            try
            {
                _categorias = CategoriaRepository.ObtenerTodas();

                cmbCategoria.Items.Clear();
                cmbCategoria.Items.Add("Todas las categorías");

                foreach (var categoria in _categorias)
                {
                    cmbCategoria.Items.Add(categoria.Nombre);
                }

                cmbCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                _productos = ObtenerProductosConAlerta();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<ProductoAlerta> ObtenerProductosConAlerta()
        {
            var productos = new List<ProductoAlerta>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT p.ProductoID, p.Codigo, p.Nombre, p.StockTotal, p.StockMinimo,
                           c.Nombre as CategoriaNombre, c.CategoriaID
                    FROM Productos p
                    INNER JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                    WHERE p.Activo = 1
                    ORDER BY p.StockTotal ASC";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal stockTotal = reader.GetDecimal(3);
                            decimal stockMinimo = reader.GetDecimal(4);

                            string estado;
                            if (stockTotal <= 0)
                                estado = "CRÍTICO";
                            else if (stockTotal <= stockMinimo)
                                estado = "ALERTA";
                            else
                                estado = "NORMAL";

                            productos.Add(new ProductoAlerta
                            {
                                ProductoID = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                StockTotal = stockTotal,
                                StockMinimo = stockMinimo,
                                CategoriaNombre = reader.GetString(5),
                                CategoriaID = reader.GetInt32(6),
                                Estado = estado
                            });
                        }
                    }
                }
            }

            return productos;
        }

        private void AplicarFiltros()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            string categoriaSeleccionada = cmbCategoria.SelectedIndex > 0 ? cmbCategoria.SelectedItem.ToString() : null;
            string filtroStock = cmbFiltroStock.SelectedItem?.ToString() ?? "Todos";

            var productosFiltrados = _productos.Where(p =>
            {
                // Filtro de búsqueda
                bool cumpleBusqueda = string.IsNullOrEmpty(busqueda) ||
                    p.Nombre.ToLower().Contains(busqueda) ||
                    p.Codigo.ToLower().Contains(busqueda);

                // Filtro de categoría
                bool cumpleCategoria = string.IsNullOrEmpty(categoriaSeleccionada) ||
                    p.CategoriaNombre == categoriaSeleccionada;

                // Filtro de estado
                bool cumpleEstado = filtroStock == "Todos" ||
                    (filtroStock == "Crítico" && p.Estado == "CRÍTICO") ||
                    (filtroStock == "Alerta" && p.Estado == "ALERTA") ||
                    (filtroStock == "Normal" && p.Estado == "NORMAL");

                return cumpleBusqueda && cumpleCategoria && cumpleEstado;
            }).ToList();

            MostrarProductos(productosFiltrados);
            ActualizarResumen(productosFiltrados);
        }

        private void MostrarProductos(List<ProductoAlerta> productos)
        {
            dgvInventario.Rows.Clear();

            int numero = 1;
            foreach (var producto in productos)
            {
                int rowIndex = dgvInventario.Rows.Add();
                var row = dgvInventario.Rows[rowIndex];

                row.Cells["colNumero"].Value = numero++;
                row.Cells["colProducto"].Value = $"{producto.Codigo}\n{producto.Nombre}";
                row.Cells["colCategoria"].Value = producto.CategoriaNombre;
                row.Cells["colStocktotal"].Value = producto.StockTotal.ToString("N2");
                row.Cells["colStockMinimo"].Value = producto.StockMinimo.ToString("N2");
                row.Cells["colEstado"].Value = producto.Estado;

                // Colorear según estado
                switch (producto.Estado)
                {
                    case "CRÍTICO":
                        row.Cells["colEstado"].Style.ForeColor = Color.White;
                        row.Cells["colEstado"].Style.BackColor = Color.FromArgb(220, 53, 69); // Rojo
                        row.Cells["colStocktotal"].Style.ForeColor = Color.Red;
                        break;
                    case "ALERTA":
                        row.Cells["colEstado"].Style.ForeColor = Color.Black;
                        row.Cells["colEstado"].Style.BackColor = Color.FromArgb(255, 193, 7); // Amarillo
                        row.Cells["colStocktotal"].Style.ForeColor = Color.Orange;
                        break;
                    case "NORMAL":
                        row.Cells["colEstado"].Style.ForeColor = Color.White;
                        row.Cells["colEstado"].Style.BackColor = Color.FromArgb(40, 167, 69); // Verde
                        row.Cells["colStocktotal"].Style.ForeColor = Color.Green;
                        break;
                }

                row.Tag = producto;
            }
        }

        private void ActualizarResumen(List<ProductoAlerta> productos)
        {
            int totalProductos = productos.Count;
            int stockNormal = productos.Count(p => p.Estado == "NORMAL");
            int stockAlerta = productos.Count(p => p.Estado == "ALERTA");
            int stockCritico = productos.Count(p => p.Estado == "CRÍTICO");

            lblMotivosDisponibles.Text = $"Total productos monitoreados: {totalProductos}";
            lblStockNormal.Text = $"Stock Normal:   {stockNormal} productos";
            lblStockAlerta.Text = $"Stock en Alerta:   {stockAlerta} productos";
            lblStockCrítico.Text = $"Stock Crítico:   {stockCritico} productos";

            // Cambiar colores de los labels
            lblStockNormal.ForeColor = Color.Green;
            lblStockAlerta.ForeColor = Color.Orange;
            lblStockCrítico.ForeColor = Color.Red;
        }

        private void Filtros_Changed(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductos();
            MessageBox.Show("Datos actualizados correctamente", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ReportDataSourceHelper.ObtenerDatosAlertasInventario();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var dataSources = new Dictionary<string, DataTable>
                {
                    { "DsAlertasInventario", dt }
                };

                var parameters = ReportHelper.GetCompanyParameters();

                int stockNormal = _productos.Count(p => p.Estado == "NORMAL");
                int stockAlerta = _productos.Count(p => p.Estado == "ALERTA");
                int stockCritico = _productos.Count(p => p.Estado == "CRÍTICO");
                parameters["pResumen"] = $"Normal: {stockNormal} | Alerta: {stockAlerta} | Crítico: {stockCritico}";

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Tabular\RptAlertasInventario.rdlc"),
                    dataSources, parameters, "alertas_inventario");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Click en columna "Ver"
            if (e.ColumnIndex == dgvInventario.Columns["colVer"].Index)
            {
                var row = dgvInventario.Rows[e.RowIndex];
                if (row.Tag is ProductoAlerta producto)
                {
                    // Mostrar detalle del producto
                    MostrarDetalleProducto(producto);
                }
            }
        }

        private void MostrarDetalleProducto(ProductoAlerta producto)
        {
            string mensaje = $"Producto: {producto.Nombre}\n" +
                $"Código: {producto.Codigo}\n" +
                $"Categoría: {producto.CategoriaNombre}\n\n" +
                $"Stock Actual: {producto.StockTotal:N2}\n" +
                $"Stock Mínimo: {producto.StockMinimo:N2}\n" +
                $"Estado: {producto.Estado}\n\n";

            if (producto.Estado == "CRÍTICO")
            {
                mensaje += "ATENCIÓN: Este producto requiere reposición inmediata.";
            }
            else if (producto.Estado == "ALERTA")
            {
                decimal faltante = producto.StockMinimo - producto.StockTotal;
                if (faltante > 0)
                    mensaje += $"Se recomienda reabastecer al menos {faltante:N2} unidades.";
            }

            MessageBox.Show(mensaje, "Detalle del Producto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class ProductoAlerta
    {
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal StockTotal { get; set; }
        public decimal StockMinimo { get; set; }
        public string CategoriaNombre { get; set; }
        public int CategoriaID { get; set; }
        public string Estado { get; set; }
    }
}
