using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Reports.DataSources;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Finanzas
{
    public partial class FormDetalleCaja : Form
    {
        private int _cajaID;
        private Caja _caja;

        public FormDetalleCaja(int cajaID)
        {
            InitializeComponent();
            _cajaID = cajaID;
            ConfigurarEventos();
            CargarDatos();
        }

        public FormDetalleCaja()
        {
            InitializeComponent();
        }

        private void ConfigurarEventos()
        {
            btnCerrar.Click += (s, e) => this.Close();
            btnImprimir.Click += BtnImprimir_Click;
        }

        private void CargarDatos()
        {
            _caja = CajaRepository.ObtenerPorID(_cajaID);

            if (_caja == null)
            {
                MessageBox.Show("No se encontró la información de la caja", "Error");
                this.Close();
                return;
            }

            // Información del turno
            string nombreUsuario = ObtenerNombreUsuario(_caja.UsuarioID);
            lblEncargado.Text = $"Encargado: {nombreUsuario}";
            lblFecha.Text = $"Fecha: {_caja.FechaApertura:dd/MM/yyyy}";
            lblHora.Text = $"Hora Apertura: {_caja.HoraApertura:hh\\:mm\\:ss}";
            lblTipoComprobante.Text = $"Turno: {_caja.Turno}";

            if (_caja.HoraCierre.HasValue)
            {
                var duracion = _caja.HoraCierre.Value - _caja.HoraApertura;
                lblNumeroSerie.Text = $"Duración: {(int)duracion.TotalHours}h {duracion.Minutes}m";
                lblEstado.Text = $"Hora Cierre: {_caja.HoraCierre.Value:hh\\:mm}";
            }
            else
            {
                lblNumeroSerie.Text = "Duración: En curso";
                lblEstado.Text = "Hora Cierre: -";
            }

            // Fondo inicial en panel info turno
            txtFondoInicial1.Text = $"S/ {_caja.MontoInicial:N2}";

            // Resumen de ingresos
            lblOperaciones.Text = $"Operaciones: {ObtenerCantidadOperaciones()}";
            txtEfectivoCantidad.Text = $"S/ {_caja.TotalEfectivo:N2}";
            txtYapeCantidad.Text = $"S/ {_caja.TotalYape:N2}";
            txtTransferenciaCantidad.Text = $"S/ {_caja.TotalTransferencia:N2}";
            txtCreditoCantidad.Text = $"S/ {_caja.TotalCredito:N2}";

            txtTotalCantidad.Text = $"S/ {_caja.TotalVentas:N2}";

            // Arqueo de efectivo
            txtFondoInicial.Text = $"S/ {_caja.MontoInicial:N2}";
            txtEfectivoVentas.Text = $"S/ {_caja.TotalEfectivo:N2}";
            txtEfectivoEsperado.Text = $"S/ {_caja.EfectivoEsperado:N2}";
            txtEfectivoReal.Text = $"S/ {_caja.EfectivoReal:N2}";

            // Diferencia - solo color rojo si no cuadra
            txtDiferenciaCantidad.Text = $"S/ {_caja.Diferencia:N2}";
            txtDiferenciaCantidad.ForeColor = _caja.Diferencia != 0 ? Color.Red : Color.Green;

            // Motivo
            txtMotivo.Text = _caja.MotivoDiferencia ?? "";
            txtMotivo.ReadOnly = true;

            // Gastos en efectivo del turno
            if (_caja.TotalGastos > 0)
            {
                txtObservaciones.Text = $"Gastos en efectivo del turno: S/ {_caja.TotalGastos:N2}";
            }
            else
            {
                txtObservaciones.Text = "Sin gastos registrados en este turno";
            }
            txtObservaciones.ReadOnly = true;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (_caja == null) return;

            try
            {
                var parametros = ReportHelper.GetCompanyParameters();
                ReportDataSourceHelper.ObtenerParametrosDetalleCaja(_cajaID, parametros);

                var dataSources = new Dictionary<string, DataTable>();

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Documents\RptDetalleCaja.rdlc"),
                    dataSources, parametros, "detalle_caja");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerCantidadOperaciones()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    var cmd = new System.Data.SQLite.SQLiteCommand(
                        "SELECT COUNT(*) FROM Ventas WHERE CajaID = @cajaID AND Estado != 'ANULADA'", conn);
                    cmd.Parameters.AddWithValue("@cajaID", _cajaID);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private string ObtenerNombreUsuario(int usuarioID)
        {
            return UsuarioRepository.ObtenerNombreCompletoPorID(usuarioID);
        }
    }
}
