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
    public partial class FormBalanceGeneral : Form
    {
        public FormBalanceGeneral()
        {
            InitializeComponent();
        }

        private void FormBalanceGeneral_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            dgvBalance.AutoGenerateColumns = false;
            dgvBalance.AllowUserToAddRows = false;
            dgvBalance.ReadOnly = true;
            btnExportar.Click += BtnExportar_Click;

            // Cargar automaticamente al abrir y al cambiar fecha
            dtpFecha.ValueChanged += (s, ev) => CargarDatos();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvBalance.Rows.Clear();
                var balance = BalanceRepository.Calcular(dtpFecha.Value);

                // ACTIVOS
                int idx = dgvBalance.Rows.Add("ACTIVOS", "");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold);

                dgvBalance.Rows.Add("  Efectivo en Caja", $"S/ {balance.Efectivo:N2}");
                dgvBalance.Rows.Add("  Inventario", $"S/ {balance.Inventario:N2}");
                dgvBalance.Rows.Add("  Cuentas por Cobrar", $"S/ {balance.CuentasPorCobrar:N2}");

                idx = dgvBalance.Rows.Add("TOTAL ACTIVOS", $"S/ {balance.TotalActivos:N2}");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold);
                dgvBalance.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(39, 174, 96);

                dgvBalance.Rows.Add("", "");

                // PASIVOS
                idx = dgvBalance.Rows.Add("PASIVOS", "");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold);

                dgvBalance.Rows.Add("  Cuentas por Pagar", $"S/ {balance.CuentasPorPagar:N2}");

                idx = dgvBalance.Rows.Add("TOTAL PASIVOS", $"S/ {balance.TotalPasivos:N2}");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold);
                dgvBalance.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(192, 57, 43);

                dgvBalance.Rows.Add("", "");

                // PATRIMONIO
                idx = dgvBalance.Rows.Add("PATRIMONIO", "");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold);

                dgvBalance.Rows.Add("  Capital", $"S/ {balance.Capital:N2}");
                dgvBalance.Rows.Add("  Utilidad Acumulada", $"S/ {balance.UtilidadAcumulada:N2}");

                idx = dgvBalance.Rows.Add("PATRIMONIO NETO", $"S/ {balance.TotalPatrimonio:N2}");
                dgvBalance.Rows[idx].DefaultCellStyle.Font = new Font(dgvBalance.Font, FontStyle.Bold | FontStyle.Italic);
                dgvBalance.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(52, 152, 219);
                dgvBalance.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
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
            if (dgvBalance.Rows.Count == 0)
            {
                MessageBox.Show("Primero genere el balance general", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var dt = ReportDataSourceHelper.ObtenerDatosBalanceGeneral(dtpFecha.Value);
                var dataSources = new Dictionary<string, DataTable> { { "DsBalanceGeneral", dt } };
                var parameters = ReportHelper.GetCompanyParameters();
                parameters["pPeriodo"] = $"Al: {dtpFecha.Value:dd/MM/yyyy}";

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Tabular\RptBalanceGeneral.rdlc"),
                    dataSources, parameters, "balance_general");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
