using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Reports.DataSources;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Reportes
{
    public partial class FormEstadoResultados : Form
    {
        public FormEstadoResultados()
        {
            InitializeComponent();
        }

        private void FormEstadoResultados_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            dgvEstadoResultados.AutoGenerateColumns = false;
            dgvEstadoResultados.AllowUserToAddRows = false;
            dgvEstadoResultados.ReadOnly = true;
            btnExportar.Click += BtnExportar_Click;

            // Cargar automaticamente al abrir y al cambiar fechas
            dtpDesde.ValueChanged += (s, ev) => CargarDatos();
            dtpHasta.ValueChanged += (s, ev) => CargarDatos();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvEstadoResultados.Rows.Clear();
                var estado = EstadoResultadosRepository.Calcular(dtpDesde.Value, dtpHasta.Value);

                // Ingresos
                int idx = dgvEstadoResultados.Rows.Add("INGRESOS", "");
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.Font = new Font(dgvEstadoResultados.Font, FontStyle.Bold);

                dgvEstadoResultados.Rows.Add("  Ventas", $"S/ {estado.VentasBrutas:N2}");

                // Costos
                idx = dgvEstadoResultados.Rows.Add("COSTOS", "");
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.Font = new Font(dgvEstadoResultados.Font, FontStyle.Bold);

                dgvEstadoResultados.Rows.Add("  Costo de Mercadería", $"S/ {estado.CostoMercaderia:N2}");

                // Utilidad Bruta
                idx = dgvEstadoResultados.Rows.Add("UTILIDAD BRUTA", $"S/ {estado.UtilidadBruta:N2}");
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.Font = new Font(dgvEstadoResultados.Font, FontStyle.Bold);
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.ForeColor = estado.UtilidadBruta >= 0 ? Color.Green : Color.Red;

                // Gastos Operativos
                idx = dgvEstadoResultados.Rows.Add("GASTOS OPERATIVOS", "");
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.Font = new Font(dgvEstadoResultados.Font, FontStyle.Bold);

                foreach (var gasto in estado.GastosPorCategoria)
                {
                    dgvEstadoResultados.Rows.Add($"  {gasto.Key}", $"S/ {gasto.Value:N2}");
                }

                dgvEstadoResultados.Rows.Add("  Total Gastos", $"S/ {estado.TotalGastos:N2}");

                // Utilidad Neta
                idx = dgvEstadoResultados.Rows.Add("UTILIDAD NETA", $"S/ {estado.UtilidadNeta:N2}");
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.Font = new Font(dgvEstadoResultados.Font, FontStyle.Bold | FontStyle.Italic);
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.ForeColor = estado.UtilidadNeta >= 0 ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);
                dgvEstadoResultados.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            ExportarReporte();
        }

        private void ExportarReporte()
        {
            if (dgvEstadoResultados.Rows.Count == 0)
            {
                MessageBox.Show("Primero genere el estado de resultados", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var dt = ReportDataSourceHelper.ObtenerDatosEstadoResultados(dtpDesde.Value, dtpHasta.Value);
                var dataSources = new Dictionary<string, DataTable> { { "DsEstadoResultados", dt } };
                var parameters = ReportHelper.GetCompanyParameters();
                parameters["pPeriodo"] = $"Período: {dtpDesde.Value:dd/MM/yyyy} - {dtpHasta.Value:dd/MM/yyyy}";

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Tabular\RptEstadoResultados.rdlc"),
                    dataSources, parameters, "estado_resultados");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
