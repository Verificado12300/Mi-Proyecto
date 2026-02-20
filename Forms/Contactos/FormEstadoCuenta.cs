using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Reports.DataSources;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Contactos
{
    public partial class FormEstadoCuenta : Form
    {
        private int _clienteID;

        public FormEstadoCuenta(int clienteID)
        {
            InitializeComponent();
            _clienteID = clienteID;

            ConfigurarEventos();
            CargarDatos();
        }

        private void ConfigurarEventos()
        {
            dtpDesde.Value = DateTime.Now.AddMonths(-3);
            dtpHasta.Value = DateTime.Now;

            dgvHistorialMovimientos.AutoGenerateColumns = false;
            dgvHistorialMovimientos.AllowUserToAddRows = false;
            dgvHistorialMovimientos.ReadOnly = true;

            btnRegistrarPago.Click += BtnRegistrarPago_Click;
            btnImprimirEstado.Click += BtnImprimirEstado_Click;
            btnCerrar.Click += BtnCerrar_Click;
            dtpDesde.ValueChanged += Filtros_Changed;
            dtpHasta.ValueChanged += Filtros_Changed;
        }

        private void CargarDatos()
        {
            try
            {
                var estadoCuenta = ClienteRepository.ObtenerEstadoCuenta(_clienteID);
                var cliente = estadoCuenta.Cliente;

                string nombreCliente = cliente.TipoDocumento == "RUC"
                    ? cliente.RazonSocial
                    : $"{cliente.Nombres} {cliente.Apellidos}".Trim();

                lblTitulo.Text = $"Estado de Cuenta  —  {nombreCliente}";

                txtCliente.Text = nombreCliente;
                txtDocumento.Text = $"{cliente.TipoDocumento} - {cliente.NumeroDocumento}";
                txtTelefono.Text = string.IsNullOrWhiteSpace(cliente.Telefono) ? "-" : cliente.Telefono;
                txtEmail.Text = string.IsNullOrWhiteSpace(cliente.Email) ? "-" : cliente.Email;
                txtEstado.Text = cliente.Activo ? "ACTIVO" : "INACTIVO";
                txtEstado.ForeColor = cliente.Activo ? Color.FromArgb(39, 174, 96) : Color.FromArgb(214, 48, 49);
                txtEstado.Font = new Font(txtEstado.Font, FontStyle.Bold);

                lblBadgeEstado.Text = cliente.Activo ? "ACTIVO" : "INACTIVO";
                lblBadgeEstado.BackColor = cliente.Activo ? Color.FromArgb(39, 174, 96) : Color.FromArgb(214, 48, 49);

                txtTotalVentas.Text = $"S/ {estadoCuenta.TotalVentas:N2}";
                txtTotalPagos.Text = $"S/ {estadoCuenta.TotalPagos:N2}";

                decimal saldo = estadoCuenta.SaldoPendiente;
                txtSaldoPendiente.Text = $"S/ {saldo:N2}";
                txtSaldoPendiente.ForeColor = saldo > 0 ? Color.FromArgb(214, 48, 49)
                                            : saldo < 0 ? Color.FromArgb(39, 174, 96)
                                            : Color.FromArgb(99, 110, 114);
                pnlSaldoDestacado.BackColor = saldo > 0 ? Color.FromArgb(255, 235, 235)
                                            : saldo < 0 ? Color.FromArgb(235, 255, 245)
                                            : Color.FromArgb(244, 244, 250);

                txtLimiteCredito.Text = $"S/ {estadoCuenta.LimiteCredito:N2}";
                txtCreditoUtilizado.Text = $"S/ {estadoCuenta.CreditoUtilizado:N2}";

                decimal disponible = estadoCuenta.CreditoDisponible;
                txtCreditoDisponible.Text = $"S/ {disponible:N2}";
                txtCreditoDisponible.ForeColor = disponible > 0 ? Color.FromArgb(39, 174, 96) : Color.FromArgb(214, 48, 49);
                txtCreditoDisponible.Font = new Font(txtCreditoDisponible.Font, FontStyle.Bold);

                CargarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMovimientos()
        {
            try
            {
                var movimientos = ClienteRepository.ObtenerMovimientos(_clienteID,
                    dtpDesde.Value.Date, dtpHasta.Value.Date);

                dgvHistorialMovimientos.Rows.Clear();

                int numero = 1;
                foreach (var mov in movimientos)
                {
                    int index = dgvHistorialMovimientos.Rows.Add();
                    var row = dgvHistorialMovimientos.Rows[index];

                    row.Cells["colNumero"].Value = numero++;
                    row.Cells["colFechaHora"].Value = $"{mov.Fecha:dd/MM/yyyy}  {mov.Hora:hh\\:mm}";
                    row.Cells["colTipo"].Value = mov.Tipo;
                    row.Cells["colDetalle"].Value = mov.Detalle;

                    if (mov.Cargo > 0)
                    {
                        row.Cells["colCargo"].Value = $"S/ {mov.Cargo:N2}";
                        row.Cells["colCargo"].Style.ForeColor = Color.FromArgb(214, 48, 49);
                        row.Cells["colAbono"].Value = "";
                    }
                    else if (mov.Abono > 0)
                    {
                        row.Cells["colAbono"].Value = $"S/ {mov.Abono:N2}";
                        row.Cells["colAbono"].Style.ForeColor = Color.FromArgb(39, 174, 96);
                        row.Cells["colCargo"].Value = "";
                    }

                    decimal saldo = mov.Saldo;
                    row.Cells["colSaldo"].Value = $"S/ {saldo:N2}";
                    row.Cells["colSaldo"].Style.ForeColor = saldo > 0 ? Color.FromArgb(214, 48, 49)
                                                          : saldo < 0 ? Color.FromArgb(39, 174, 96)
                                                          : Color.FromArgb(45, 52, 54);
                    row.Cells["colSaldo"].Style.Font = new Font(dgvHistorialMovimientos.Font, FontStyle.Bold);

                    // Tipo con color
                    if (mov.Tipo == "VENTA")
                        row.Cells["colTipo"].Style.ForeColor = Color.FromArgb(214, 48, 49);
                    else if (mov.Tipo == "PAGO")
                        row.Cells["colTipo"].Style.ForeColor = Color.FromArgb(39, 174, 96);

                    row.Cells["colTipo"].Style.Font = new Font(dgvHistorialMovimientos.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                var estadoCuenta = ClienteRepository.ObtenerEstadoCuenta(_clienteID);

                if (estadoCuenta.SaldoPendiente <= 0)
                {
                    MessageBox.Show("Este cliente no tiene saldo pendiente.", "Sin deuda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var formPago = new FormRegistrarPago(_clienteID, estadoCuenta.SaldoPendiente);
                if (formPago.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimirEstado_Click(object sender, EventArgs e)
        {
            try
            {
                var parametros = ReportHelper.GetCompanyParameters();
                var dt = ReportDataSourceHelper.ObtenerDatosEstadoCuenta(
                    _clienteID, dtpDesde.Value.Date, dtpHasta.Value.Date, parametros);

                var dataSources = new Dictionary<string, DataTable> { { "DsMovimientos", dt } };

                ReportHelper.MostrarDialogoExportacion(
                    ReportHelper.GetRdlcPath(@"Documents\RptEstadoCuenta.rdlc"),
                    dataSources, parametros, "estado_cuenta");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filtros_Changed(object sender, EventArgs e)
        {
            CargarMovimientos();
        }
    }
}
