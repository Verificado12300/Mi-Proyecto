using SistemaPOS.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPOS.Forms.Finanzas
{
    public partial class FormHistorialCobros : Form
    {
        private readonly CuentaPorCobrarDetalle _cuenta;

        public FormHistorialCobros(CuentaPorCobrarDetalle cuenta)
        {
            InitializeComponent();
            _cuenta = cuenta;
            btnCerrar.Click += (_, __) => this.Close();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cabecera
            lblNombreCliente.Text = _cuenta.NombreCliente;
            lblNumeroVenta.Text = $"Venta: {_cuenta.NumeroVenta}";
            lblFechaVenta.Text = $"Fecha: {_cuenta.FechaVenta:dd/MM/yyyy}";
            lblVencimiento.Text = $"Vence: {_cuenta.FechaVencimiento:dd/MM/yyyy}";

            // Tarjetas resumen
            lblCardTotal.Text = $"S/ {_cuenta.TotalCredito:N2}";
            lblCardPagado.Text = $"S/ {_cuenta.MontoPagado:N2}";
            lblCardSaldo.Text = $"S/ {_cuenta.SaldoPendiente:N2}";

            lblCardSaldo.ForeColor = _cuenta.SaldoPendiente > 0 ? Color.FromArgb(214, 48, 49) : Color.FromArgb(39, 174, 96);

            // Estado badge
            lblEstado.Text = _cuenta.Estado;
            switch (_cuenta.Estado)
            {
                case "PAGADO":
                    lblEstado.BackColor = Color.FromArgb(39, 174, 96);
                    break;
                case "VENCIDO":
                    lblEstado.BackColor = Color.FromArgb(214, 48, 49);
                    break;
                case "PARCIAL":
                    lblEstado.BackColor = Color.FromArgb(225, 112, 85);
                    break;
                default:
                    lblEstado.BackColor = Color.FromArgb(243, 156, 18);
                    break;
            }

            // Historial de pagos
            var pagos = CuentaPorCobrarRepository.ObtenerPagosVenta(_cuenta.VentaID);
            dgvPagos.Rows.Clear();

            decimal totalAplicado = 0;
            int num = 1;
            foreach (var p in pagos)
            {
                int i = dgvPagos.Rows.Add();
                var row = dgvPagos.Rows[i];
                row.Cells["colNum"].Value = num++;
                row.Cells["colFecha"].Value = p.Fecha.ToString("dd/MM/yyyy");
                row.Cells["colHora"].Value = p.Hora.ToString(@"hh\:mm");
                row.Cells["colMetodo"].Value = p.MetodoPago;
                row.Cells["colMonto"].Value = $"S/ {p.MontoAplicado:N2}";
                row.Cells["colObs"].Value = string.IsNullOrWhiteSpace(p.Observaciones) ? "-" : p.Observaciones;

                // Color por método
                Color metodoColor;
                switch (p.MetodoPago)
                {
                    case "EFECTIVO": metodoColor = Color.FromArgb(0, 184, 148); break;
                    case "YAPE": metodoColor = Color.FromArgb(108, 92, 231); break;
                    case "TRANSFERENCIA": metodoColor = Color.FromArgb(9, 132, 227); break;
                    case "MIXTO": metodoColor = Color.FromArgb(253, 203, 110); break;
                    default: metodoColor = Color.FromArgb(99, 110, 114); break;
                }
                row.Cells["colMetodo"].Style.ForeColor = metodoColor;
                row.Cells["colMetodo"].Style.Font = new Font(dgvPagos.Font, FontStyle.Bold);

                totalAplicado += p.MontoAplicado;
            }

            if (pagos.Count == 0)
            {
                lblSinPagos.Visible = true;
                dgvPagos.Visible = false;
            }

            lblResumen.Text = $"{pagos.Count} pago(s) registrado(s)  |  Total cobrado: S/ {totalAplicado:N2}";
        }
    }
}
