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
    public partial class FormFlujoCaja : Form
    {
        public FormFlujoCaja()
        {
            InitializeComponent();
        }

        private void FormFlujoCaja_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            dgvFlujoCaja.AutoGenerateColumns = false;
            dgvFlujoCaja.AllowUserToAddRows = false;
            dgvFlujoCaja.ReadOnly = true;
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
                dgvFlujoCaja.Rows.Clear();
                var items = FlujoCajaRepository.ObtenerFlujoCaja(dtpDesde.Value, dtpHasta.Value);

                decimal totalIngresos = 0;
                decimal totalEgresos = 0;

                foreach (var item in items)
                {
                    decimal flujoItem = item.Ingreso - item.Egreso;
                    dgvFlujoCaja.Rows.Add(
                        item.Concepto,
                        item.Ingreso > 0 ? $"S/ {item.Ingreso:N2}" : "-",
                        item.Egreso > 0 ? $"S/ {item.Egreso:N2}" : "-",
                        $"S/ {flujoItem:N2}"
                    );
                    totalIngresos += item.Ingreso;
                    totalEgresos += item.Egreso;
                }

                decimal flujoNeto = totalIngresos - totalEgresos;

                lblTotalIngresos.Text = $"S/ {totalIngresos:N2}";
                lblTotalEgresos.Text = $"S/ {totalEgresos:N2}";
                lblFlujoNeto.Text = $"S/ {flujoNeto:N2}";
                lblFlujoNeto.ForeColor = flujoNeto >= 0 ? Color.Green : Color.Red;
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
            if (dgvFlujoCaja.Rows.Count == 0)
            {
                MessageBox.Show("Primero genere el flujo de caja", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var dt = ReportDataSourceHelper.ObtenerDatosFlujoCaja(dtpDesde.Value, dtpHasta.Value);
                var dataSources = new Dictionary<string, DataTable> { { "DsFlujoCaja", dt } };
                var parameters = ReportHelper.GetCompanyParameters();
                parameters["pPeriodo"] = $"Período: {dtpDesde.Value:dd/MM/yyyy} - {dtpHasta.Value:dd/MM/yyyy}";

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Tabular\RptFlujoCaja.rdlc"),
                    dataSources, parameters, "flujo_caja");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
