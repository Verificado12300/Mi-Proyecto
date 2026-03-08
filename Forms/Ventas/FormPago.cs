using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPOS.Forms.Ventas
{
    public partial class FormPago : Form
    {
        private readonly decimal _totalPagar;
        private bool _configurandoUI;

        // ── Resultado del pago ─────────────────────────────────────
        public string MetodoPago { get; private set; } = "EFECTIVO";
        public decimal MontoEfectivo { get; private set; }
        public decimal MontoYape { get; private set; }
        public decimal MontoTransferencia { get; private set; }
        public decimal MontoTarjeta { get; private set; }
        public decimal MontoRecibido { get; private set; }
        public decimal Vuelto { get; private set; }

        public FormPago(decimal totalPagar)
        {
            InitializeComponent();
            _totalPagar = totalPagar;
            lblTotalAmount.Text = $"S/ {totalPagar:N2}";

            txtMontoEfectivo.TextChanged += TxtMonto_TextChanged;
            txtMontoEfectivo.KeyPress   += TxtSoloNumeros_KeyPress;
            txtMontoYape.KeyPress        += TxtSoloNumeros_KeyPress;
            txtMontoTransferencia.KeyPress += TxtSoloNumeros_KeyPress;
            txtMontoTarjeta.KeyPress    += TxtSoloNumeros_KeyPress;
            txtMixtoEfectivo.KeyPress   += TxtSoloNumeros_KeyPress;
            txtMixtoYape.KeyPress       += TxtSoloNumeros_KeyPress;
            txtMixtoTransferencia.KeyPress += TxtSoloNumeros_KeyPress;
            txtMixtoTarjeta.KeyPress    += TxtSoloNumeros_KeyPress;

            txtMixtoEfectivo.TextChanged    += TxtMixto_TextChanged;
            txtMixtoYape.TextChanged        += TxtMixto_TextChanged;
            txtMixtoTransferencia.TextChanged += TxtMixto_TextChanged;
            txtMixtoTarjeta.TextChanged     += TxtMixto_TextChanged;

            btnEfectivo.Click      += (s, e) => SeleccionarMetodo("EFECTIVO");
            btnYape.Click          += (s, e) => SeleccionarMetodo("YAPE");
            btnTransferencia.Click += (s, e) => SeleccionarMetodo("TRANSFERENCIA");
            btnTarjeta.Click       += (s, e) => SeleccionarMetodo("TARJETA");
            btnMixto.Click         += (s, e) => SeleccionarMetodo("MIXTO");
            btnCredito.Click       += (s, e) => SeleccionarMetodo("CREDITO");

            btnConfirmar.Click    += BtnConfirmar_Click;
            btnCancelarPago.Click += BtnCancelarPago_Click;

            SeleccionarMetodo("EFECTIVO");
        }

        // ── Selección de método ────────────────────────────────────
        private void SeleccionarMetodo(string metodo)
        {
            _configurandoUI = true;
            MetodoPago = metodo;

            Color inactiveBack = Color.White;
            Color inactiveFore = Color.FromArgb(45, 52, 54);
            Color activeBack   = Color.FromArgb(37, 99, 235);
            Color activeFore   = Color.White;

            foreach (Button b in new[] { btnEfectivo, btnYape, btnTransferencia, btnTarjeta, btnMixto, btnCredito })
            {
                b.BackColor = inactiveBack;
                b.ForeColor = inactiveFore;
                b.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            }

            Button activo = null;
            switch (metodo)
            {
                case "EFECTIVO":      activo = btnEfectivo;      break;
                case "YAPE":         activo = btnYape;          break;
                case "TRANSFERENCIA":activo = btnTransferencia; break;
                case "TARJETA":      activo = btnTarjeta;       break;
                case "MIXTO":        activo = btnMixto;         break;
                case "CREDITO":      activo = btnCredito;       break;
            }
            if (activo != null)
            {
                activo.BackColor = activeBack;
                activo.ForeColor = activeFore;
                activo.FlatAppearance.BorderColor = activeBack;
            }

            pnlEfectivo.Visible      = metodo == "EFECTIVO";
            pnlYape.Visible          = metodo == "YAPE";
            pnlTransferencia.Visible = metodo == "TRANSFERENCIA";
            pnlTarjeta.Visible       = metodo == "TARJETA";
            pnlMixto.Visible         = metodo == "MIXTO";
            pnlCredito.Visible       = metodo == "CREDITO";

            // Pre-rellenar con el total
            switch (metodo)
            {
                case "EFECTIVO":
                    txtMontoEfectivo.Text = _totalPagar.ToString("N2");
                    ActualizarVuelto();
                    txtMontoEfectivo.SelectAll();
                    txtMontoEfectivo.Focus();
                    break;
                case "YAPE":
                    txtMontoYape.Text = _totalPagar.ToString("N2");
                    txtMontoYape.SelectAll(); txtMontoYape.Focus();
                    break;
                case "TRANSFERENCIA":
                    txtMontoTransferencia.Text = _totalPagar.ToString("N2");
                    txtMontoTransferencia.SelectAll(); txtMontoTransferencia.Focus();
                    break;
                case "TARJETA":
                    txtMontoTarjeta.Text = _totalPagar.ToString("N2");
                    txtMontoTarjeta.SelectAll(); txtMontoTarjeta.Focus();
                    break;
                case "MIXTO":
                    txtMixtoEfectivo.Clear(); txtMixtoYape.Clear();
                    txtMixtoTransferencia.Clear(); txtMixtoTarjeta.Clear();
                    ActualizarTotalMixto();
                    txtMixtoEfectivo.Focus();
                    break;
                case "CREDITO":
                    break;
            }
            _configurandoUI = false;
        }

        // ── Eventos de texto ──────────────────────────────────────
        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            if (_configurandoUI) return;
            ActualizarVuelto();
        }

        private void ActualizarVuelto()
        {
            if (decimal.TryParse(txtMontoEfectivo.Text, out decimal recibido))
            {
                decimal vuelto = recibido - _totalPagar;
                txtVueltoEfectivo.Text = vuelto >= 0 ? $"S/ {vuelto:N2}" : "S/ 0.00";
                txtVueltoEfectivo.BackColor = vuelto >= 0
                    ? Color.FromArgb(39, 174, 96)
                    : Color.FromArgb(231, 76, 60);
                txtVueltoEfectivo.ForeColor = Color.White;
            }
            else
            {
                txtVueltoEfectivo.Text = "S/ 0.00";
            }
        }

        private void TxtMixto_TextChanged(object sender, EventArgs e)
        {
            if (_configurandoUI) return;
            ActualizarTotalMixto();
        }

        private void ActualizarTotalMixto()
        {
            decimal ef = ParseMonto(txtMixtoEfectivo.Text);
            decimal yp = ParseMonto(txtMixtoYape.Text);
            decimal tr = ParseMonto(txtMixtoTransferencia.Text);
            decimal tj = ParseMonto(txtMixtoTarjeta.Text);
            decimal suma = ef + yp + tr + tj;
            decimal diferencia = suma - _totalPagar;

            lblMixtoTotal.Text = $"Total ingresado: S/ {suma:N2}  |  Total a pagar: S/ {_totalPagar:N2}";
            if (Math.Abs(diferencia) < 0.01m)
            {
                lblMixtoTotal.ForeColor = Color.FromArgb(39, 174, 96);
            }
            else if (diferencia > 0)
            {
                lblMixtoTotal.ForeColor = Color.FromArgb(231, 76, 60);
                lblMixtoTotal.Text += $"  (exceso: S/ {diferencia:N2})";
            }
            else
            {
                lblMixtoTotal.ForeColor = Color.FromArgb(231, 76, 60);
                lblMixtoTotal.Text += $"  (faltan: S/ {Math.Abs(diferencia):N2})";
            }
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // ── Validación ────────────────────────────────────────────
        private bool ValidarPago()
        {
            if (MetodoPago == "CREDITO") return true;
            if (MetodoPago == "TARJETA") return true;

            if (MetodoPago == "MIXTO")
            {
                decimal suma = ParseMonto(txtMixtoEfectivo.Text)
                             + ParseMonto(txtMixtoYape.Text)
                             + ParseMonto(txtMixtoTransferencia.Text)
                             + ParseMonto(txtMixtoTarjeta.Text);

                if (Math.Abs(suma - _totalPagar) > 0.01m)
                {
                    MessageBox.Show(
                        $"La suma de los montos ingresados (S/ {suma:N2}) no coincide con el total (S/ {_totalPagar:N2}).",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }

            decimal recibido = 0;
            switch (MetodoPago)
            {
                case "EFECTIVO":      decimal.TryParse(txtMontoEfectivo.Text,      out recibido); break;
                case "YAPE":         decimal.TryParse(txtMontoYape.Text,           out recibido); break;
                case "TRANSFERENCIA":decimal.TryParse(txtMontoTransferencia.Text,  out recibido); break;
            }

            if (recibido < _totalPagar)
            {
                MessageBox.Show(
                    $"El monto recibido (S/ {recibido:N2}) es menor al total a pagar (S/ {_totalPagar:N2}).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ── Confirmar pago ────────────────────────────────────────
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidarPago()) return;

            switch (MetodoPago)
            {
                case "EFECTIVO":
                    MontoEfectivo = ParseMonto(txtMontoEfectivo.Text);
                    if (MontoEfectivo == 0) MontoEfectivo = _totalPagar;
                    MontoRecibido = MontoEfectivo;
                    Vuelto = Math.Max(0, MontoEfectivo - _totalPagar);
                    break;
                case "YAPE":
                    MontoYape = ParseMonto(txtMontoYape.Text);
                    if (MontoYape == 0) MontoYape = _totalPagar;
                    MontoRecibido = MontoYape;
                    break;
                case "TRANSFERENCIA":
                    MontoTransferencia = ParseMonto(txtMontoTransferencia.Text);
                    if (MontoTransferencia == 0) MontoTransferencia = _totalPagar;
                    MontoRecibido = MontoTransferencia;
                    break;
                case "TARJETA":
                    MontoTarjeta = ParseMonto(txtMontoTarjeta.Text);
                    if (MontoTarjeta == 0) MontoTarjeta = _totalPagar;
                    MontoRecibido = MontoTarjeta;
                    break;
                case "MIXTO":
                    MontoEfectivo      = ParseMonto(txtMixtoEfectivo.Text);
                    MontoYape          = ParseMonto(txtMixtoYape.Text);
                    MontoTransferencia = ParseMonto(txtMixtoTransferencia.Text);
                    MontoTarjeta       = ParseMonto(txtMixtoTarjeta.Text);
                    MontoRecibido = MontoEfectivo + MontoYape + MontoTransferencia + MontoTarjeta;
                    break;
                case "CREDITO":
                    MontoRecibido = 0;
                    break;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelarPago_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private decimal ParseMonto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return 0;
            texto = texto.Replace("S/", "").Trim();
            return decimal.TryParse(texto, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture, out decimal v) ? v
                : decimal.TryParse(texto, System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal v2) ? v2 : 0;
        }
    }
}
