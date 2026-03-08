namespace SistemaPOS.Forms.Ventas
{
    partial class FormPago
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.lblProcesoTitle    = new System.Windows.Forms.Label();
            this.lblTotalAmount     = new System.Windows.Forms.Label();
            this.pnlMetodos         = new System.Windows.Forms.Panel();
            this.btnEfectivo        = new System.Windows.Forms.Button();
            this.btnYape            = new System.Windows.Forms.Button();
            this.btnTransferencia   = new System.Windows.Forms.Button();
            this.btnTarjeta         = new System.Windows.Forms.Button();
            this.btnMixto           = new System.Windows.Forms.Button();
            this.btnCredito         = new System.Windows.Forms.Button();
            this.pnlContenido       = new System.Windows.Forms.Panel();
            // --- pnlEfectivo ---
            this.pnlEfectivo        = new System.Windows.Forms.Panel();
            this.lblEfectivoTitulo  = new System.Windows.Forms.Label();
            this.lblCantRecibida    = new System.Windows.Forms.Label();
            this.txtMontoEfectivo   = new System.Windows.Forms.TextBox();
            this.lblCambio          = new System.Windows.Forms.Label();
            this.txtVueltoEfectivo  = new System.Windows.Forms.TextBox();
            // --- pnlYape ---
            this.pnlYape            = new System.Windows.Forms.Panel();
            this.lblYapeTitulo      = new System.Windows.Forms.Label();
            this.lblYapeAmnt        = new System.Windows.Forms.Label();
            this.txtMontoYape       = new System.Windows.Forms.TextBox();
            // --- pnlTransferencia ---
            this.pnlTransferencia   = new System.Windows.Forms.Panel();
            this.lblTransTitulo     = new System.Windows.Forms.Label();
            this.lblTransAmnt       = new System.Windows.Forms.Label();
            this.txtMontoTransferencia = new System.Windows.Forms.TextBox();
            // --- pnlTarjeta ---
            this.pnlTarjeta         = new System.Windows.Forms.Panel();
            this.lblTarjetaTitulo   = new System.Windows.Forms.Label();
            this.lblTarjetaAmnt     = new System.Windows.Forms.Label();
            this.txtMontoTarjeta    = new System.Windows.Forms.TextBox();
            // --- pnlMixto ---
            this.pnlMixto           = new System.Windows.Forms.Panel();
            this.lblMixtoTitulo     = new System.Windows.Forms.Label();
            this.lblMixEfectivo     = new System.Windows.Forms.Label();
            this.txtMixtoEfectivo   = new System.Windows.Forms.TextBox();
            this.lblMixYape         = new System.Windows.Forms.Label();
            this.txtMixtoYape       = new System.Windows.Forms.TextBox();
            this.lblMixTransferencia = new System.Windows.Forms.Label();
            this.txtMixtoTransferencia = new System.Windows.Forms.TextBox();
            this.lblMixTarjeta      = new System.Windows.Forms.Label();
            this.txtMixtoTarjeta    = new System.Windows.Forms.TextBox();
            this.lblMixtoTotal      = new System.Windows.Forms.Label();
            // --- pnlCredito ---
            this.pnlCredito         = new System.Windows.Forms.Panel();
            this.lblCreditoInfo     = new System.Windows.Forms.Label();
            // --- Botones ---
            this.pnlBotones         = new System.Windows.Forms.Panel();
            this.btnCancelarPago    = new System.Windows.Forms.Button();
            this.btnConfirmar       = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlMetodos.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlEfectivo.SuspendLayout();
            this.pnlYape.SuspendLayout();
            this.pnlTransferencia.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.pnlMixto.SuspendLayout();
            this.pnlCredito.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 82, 118);
            this.pnlHeader.Controls.Add(this.lblProcesoTitle);
            this.pnlHeader.Controls.Add(this.lblTotalAmount);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 72;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Padding  = new System.Windows.Forms.Padding(20, 10, 20, 8);

            this.lblProcesoTitle.AutoSize  = true;
            this.lblProcesoTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblProcesoTitle.ForeColor = System.Drawing.Color.White;
            this.lblProcesoTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblProcesoTitle.Name      = "lblProcesoTitle";
            this.lblProcesoTitle.Text      = "Procesar Pago";

            this.lblTotalAmount.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.lblTotalAmount.AutoSize  = false;
            this.lblTotalAmount.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location  = new System.Drawing.Point(320, 14);
            this.lblTotalAmount.Name      = "lblTotalAmount";
            this.lblTotalAmount.Size      = new System.Drawing.Size(200, 40);
            this.lblTotalAmount.Text      = "S/ 0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── pnlMetodos ────────────────────────────────────────────
            this.pnlMetodos.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlMetodos.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnEfectivo, this.btnYape, this.btnTransferencia,
                this.btnTarjeta, this.btnMixto, this.btnCredito });
            this.pnlMetodos.Dock    = System.Windows.Forms.DockStyle.Top;
            this.pnlMetodos.Height  = 86;
            this.pnlMetodos.Name    = "pnlMetodos";
            this.pnlMetodos.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            // Method buttons: 6 × 78px + gaps
            int bx = 10, bw = 78, bh = 62, by = 12, gap = 8;
            ConfigMetodoBtn(this.btnEfectivo,      "EFECTIVO",      "Efectivo",      bx,          by, bw, bh);
            ConfigMetodoBtn(this.btnYape,           "YAPE",          "Yape",          bx+bw+gap,   by, bw, bh);
            ConfigMetodoBtn(this.btnTransferencia,  "TRANSFERENCIA", "Transferencia", bx+2*(bw+gap),by, bw, bh);
            ConfigMetodoBtn(this.btnTarjeta,        "TARJETA",       "Tarjeta",       bx+3*(bw+gap),by, bw, bh);
            ConfigMetodoBtn(this.btnMixto,          "MIXTO",         "Mixto",         bx+4*(bw+gap),by, bw, bh);
            ConfigMetodoBtn(this.btnCredito,        "CREDITO",       "Crédito",       bx+5*(bw+gap),by, bw, bh);

            // ── pnlContenido ──────────────────────────────────────────
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlEfectivo, this.pnlYape, this.pnlTransferencia,
                this.pnlTarjeta, this.pnlMixto, this.pnlCredito });
            this.pnlContenido.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Name    = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);

            // ── pnlEfectivo ───────────────────────────────────────────
            this.pnlEfectivo.BackColor = System.Drawing.Color.White;
            this.pnlEfectivo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblEfectivoTitulo, this.lblCantRecibida, this.txtMontoEfectivo,
                this.lblCambio, this.txtVueltoEfectivo });
            this.pnlEfectivo.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlEfectivo.Name    = "pnlEfectivo";
            this.pnlEfectivo.Visible = true;

            this.lblEfectivoTitulo.AutoSize  = true;
            this.lblEfectivoTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEfectivoTitulo.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblEfectivoTitulo.Location  = new System.Drawing.Point(0, 8);
            this.lblEfectivoTitulo.Name      = "lblEfectivoTitulo";
            this.lblEfectivoTitulo.Text      = "Pago en Efectivo";

            this.lblCantRecibida.AutoSize  = true;
            this.lblCantRecibida.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCantRecibida.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCantRecibida.Location  = new System.Drawing.Point(0, 42);
            this.lblCantRecibida.Name      = "lblCantRecibida";
            this.lblCantRecibida.Text      = "Cantidad Recibida:";

            this.txtMontoEfectivo.Font      = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMontoEfectivo.Location  = new System.Drawing.Point(0, 62);
            this.txtMontoEfectivo.Name      = "txtMontoEfectivo";
            this.txtMontoEfectivo.Size      = new System.Drawing.Size(200, 30);
            this.txtMontoEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblCambio.AutoSize  = true;
            this.lblCambio.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCambio.Location  = new System.Drawing.Point(240, 42);
            this.lblCambio.Name      = "lblCambio";
            this.lblCambio.Text      = "Cambio a Entregar:";

            this.txtVueltoEfectivo.Font        = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtVueltoEfectivo.Location    = new System.Drawing.Point(240, 62);
            this.txtVueltoEfectivo.Name        = "txtVueltoEfectivo";
            this.txtVueltoEfectivo.Size        = new System.Drawing.Size(200, 30);
            this.txtVueltoEfectivo.ReadOnly    = true;
            this.txtVueltoEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVueltoEfectivo.BackColor   = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtVueltoEfectivo.ForeColor   = System.Drawing.Color.White;
            this.txtVueltoEfectivo.Text        = "S/ 0.00";
            this.txtVueltoEfectivo.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;

            // ── pnlYape ───────────────────────────────────────────────
            this.pnlYape.BackColor = System.Drawing.Color.White;
            this.pnlYape.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblYapeTitulo, this.lblYapeAmnt, this.txtMontoYape });
            this.pnlYape.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlYape.Name    = "pnlYape";
            this.pnlYape.Visible = false;

            this.lblYapeTitulo.AutoSize  = true;
            this.lblYapeTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYapeTitulo.ForeColor = System.Drawing.Color.FromArgb(105, 46, 128);
            this.lblYapeTitulo.Location  = new System.Drawing.Point(0, 8);
            this.lblYapeTitulo.Name      = "lblYapeTitulo";
            this.lblYapeTitulo.Text      = "Pago con Yape";

            this.lblYapeAmnt.AutoSize  = true;
            this.lblYapeAmnt.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblYapeAmnt.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblYapeAmnt.Location  = new System.Drawing.Point(0, 42);
            this.lblYapeAmnt.Name      = "lblYapeAmnt";
            this.lblYapeAmnt.Text      = "Monto Yape:";

            this.txtMontoYape.Font        = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMontoYape.Location    = new System.Drawing.Point(0, 62);
            this.txtMontoYape.Name        = "txtMontoYape";
            this.txtMontoYape.Size        = new System.Drawing.Size(200, 30);
            this.txtMontoYape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoYape.TextAlign   = System.Windows.Forms.HorizontalAlignment.Right;

            // ── pnlTransferencia ─────────────────────────────────────
            this.pnlTransferencia.BackColor = System.Drawing.Color.White;
            this.pnlTransferencia.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTransTitulo, this.lblTransAmnt, this.txtMontoTransferencia });
            this.pnlTransferencia.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransferencia.Name    = "pnlTransferencia";
            this.pnlTransferencia.Visible = false;

            this.lblTransTitulo.AutoSize  = true;
            this.lblTransTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransTitulo.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTransTitulo.Location  = new System.Drawing.Point(0, 8);
            this.lblTransTitulo.Name      = "lblTransTitulo";
            this.lblTransTitulo.Text      = "Pago por Transferencia";

            this.lblTransAmnt.AutoSize  = true;
            this.lblTransAmnt.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTransAmnt.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTransAmnt.Location  = new System.Drawing.Point(0, 42);
            this.lblTransAmnt.Name      = "lblTransAmnt";
            this.lblTransAmnt.Text      = "Monto Transferencia:";

            this.txtMontoTransferencia.Font        = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMontoTransferencia.Location    = new System.Drawing.Point(0, 62);
            this.txtMontoTransferencia.Name        = "txtMontoTransferencia";
            this.txtMontoTransferencia.Size        = new System.Drawing.Size(200, 30);
            this.txtMontoTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoTransferencia.TextAlign   = System.Windows.Forms.HorizontalAlignment.Right;

            // ── pnlTarjeta ────────────────────────────────────────────
            this.pnlTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlTarjeta.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTarjetaTitulo, this.lblTarjetaAmnt, this.txtMontoTarjeta });
            this.pnlTarjeta.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlTarjeta.Name    = "pnlTarjeta";
            this.pnlTarjeta.Visible = false;

            this.lblTarjetaTitulo.AutoSize  = true;
            this.lblTarjetaTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarjetaTitulo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTarjetaTitulo.Location  = new System.Drawing.Point(0, 8);
            this.lblTarjetaTitulo.Name      = "lblTarjetaTitulo";
            this.lblTarjetaTitulo.Text      = "Pago con Tarjeta";

            this.lblTarjetaAmnt.AutoSize  = true;
            this.lblTarjetaAmnt.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTarjetaAmnt.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTarjetaAmnt.Location  = new System.Drawing.Point(0, 42);
            this.lblTarjetaAmnt.Name      = "lblTarjetaAmnt";
            this.lblTarjetaAmnt.Text      = "Monto Tarjeta:";

            this.txtMontoTarjeta.Font        = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMontoTarjeta.Location    = new System.Drawing.Point(0, 62);
            this.txtMontoTarjeta.Name        = "txtMontoTarjeta";
            this.txtMontoTarjeta.Size        = new System.Drawing.Size(200, 30);
            this.txtMontoTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoTarjeta.TextAlign   = System.Windows.Forms.HorizontalAlignment.Right;

            // ── pnlMixto ─────────────────────────────────────────────
            this.pnlMixto.BackColor = System.Drawing.Color.White;
            this.pnlMixto.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMixtoTitulo,
                this.lblMixEfectivo, this.txtMixtoEfectivo,
                this.lblMixYape, this.txtMixtoYape,
                this.lblMixTransferencia, this.txtMixtoTransferencia,
                this.lblMixTarjeta, this.txtMixtoTarjeta,
                this.lblMixtoTotal });
            this.pnlMixto.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlMixto.Name    = "pnlMixto";
            this.pnlMixto.Visible = false;

            this.lblMixtoTitulo.AutoSize  = true;
            this.lblMixtoTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMixtoTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblMixtoTitulo.Location  = new System.Drawing.Point(0, 5);
            this.lblMixtoTitulo.Name      = "lblMixtoTitulo";
            this.lblMixtoTitulo.Text      = "Pago Mixto — distribuya el total entre los métodos";

            int mx = 0, my = 28, mw = 140, mwt = 100, mh = 22, mvy = 26;
            // Columna 1
            SetLblTxt(this.lblMixEfectivo,      "Efectivo (S/):", mx, my, "lblMixEfectivo");
            SetTxt(this.txtMixtoEfectivo,        mx, my + mvy, mwt, mh, "txtMixtoEfectivo");
            SetLblTxt(this.lblMixYape,           "Yape (S/):", mx, my + 55, "lblMixYape");
            SetTxt(this.txtMixtoYape,            mx, my + 55 + mvy, mwt, mh, "txtMixtoYape");
            // Columna 2
            SetLblTxt(this.lblMixTransferencia,  "Transferencia (S/):", mx + 160, my, "lblMixTransferencia");
            SetTxt(this.txtMixtoTransferencia,   mx + 160, my + mvy, mwt, mh, "txtMixtoTransferencia");
            SetLblTxt(this.lblMixTarjeta,        "Tarjeta (S/):", mx + 160, my + 55, "lblMixTarjeta");
            SetTxt(this.txtMixtoTarjeta,         mx + 160, my + 55 + mvy, mwt, mh, "txtMixtoTarjeta");

            this.lblMixtoTotal.AutoSize  = false;
            this.lblMixtoTotal.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMixtoTotal.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblMixtoTotal.Location  = new System.Drawing.Point(0, my + 130);
            this.lblMixtoTotal.Name      = "lblMixtoTotal";
            this.lblMixtoTotal.Size      = new System.Drawing.Size(460, 20);
            this.lblMixtoTotal.Text      = "";

            // ── pnlCredito ────────────────────────────────────────────
            this.pnlCredito.BackColor = System.Drawing.Color.White;
            this.pnlCredito.Controls.Add(this.lblCreditoInfo);
            this.pnlCredito.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.pnlCredito.Name    = "pnlCredito";
            this.pnlCredito.Visible = false;

            this.lblCreditoInfo.AutoSize  = false;
            this.lblCreditoInfo.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreditoInfo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblCreditoInfo.Location  = new System.Drawing.Point(0, 20);
            this.lblCreditoInfo.Name      = "lblCreditoInfo";
            this.lblCreditoInfo.Size      = new System.Drawing.Size(460, 80);
            this.lblCreditoInfo.Text      = "La venta se registrará como CRÉDITO.\n\nEl cliente pagará el monto pendiente posteriormente.\nAsegúrese de tener un cliente registrado seleccionado.";

            // ── pnlBotones ────────────────────────────────────────────
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlBotones.Controls.Add(this.btnCancelarPago);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Dock    = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Height  = 60;
            this.pnlBotones.Name    = "pnlBotones";

            this.btnCancelarPago.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelarPago.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPago.FlatAppearance.BorderSize = 0;
            this.btnCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPago.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPago.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPago.Location  = new System.Drawing.Point(20, 13);
            this.btnCancelarPago.Name      = "btnCancelarPago";
            this.btnCancelarPago.Size      = new System.Drawing.Size(130, 34);
            this.btnCancelarPago.Text      = "✕  Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = false;

            this.btnConfirmar.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnConfirmar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location  = new System.Drawing.Point(390, 13);
            this.btnConfirmar.Name      = "btnConfirmar";
            this.btnConfirmar.Size      = new System.Drawing.Size(130, 34);
            this.btnConfirmar.Text      = "✔  Confirmar Pago";
            this.btnConfirmar.UseVisualStyleBackColor = false;

            // ── FormPago ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode  = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor      = System.Drawing.Color.White;
            this.ClientSize     = new System.Drawing.Size(540, 430);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMetodos);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox    = false;
            this.MinimizeBox    = false;
            this.Name           = "FormPago";
            this.StartPosition  = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text           = "Procesar Pago";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMetodos.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlEfectivo.ResumeLayout(false);
            this.pnlEfectivo.PerformLayout();
            this.pnlYape.ResumeLayout(false);
            this.pnlYape.PerformLayout();
            this.pnlTransferencia.ResumeLayout(false);
            this.pnlTransferencia.PerformLayout();
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.pnlMixto.ResumeLayout(false);
            this.pnlMixto.PerformLayout();
            this.pnlCredito.ResumeLayout(false);
            this.pnlCredito.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Helpers para configurar controles ────────────────────────
        private void ConfigMetodoBtn(System.Windows.Forms.Button btn, string name,
            string text, int x, int y, int w, int h)
        {
            btn.BackColor = System.Drawing.Color.White;
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            btn.FlatAppearance.BorderSize  = 1;
            btn.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            btn.Font       = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btn.ForeColor  = System.Drawing.Color.FromArgb(45, 52, 54);
            btn.Location   = new System.Drawing.Point(x, y);
            btn.Name       = "btn" + name;
            btn.Size       = new System.Drawing.Size(w, h);
            btn.Text       = text;
            btn.UseVisualStyleBackColor = false;
        }

        private void SetLblTxt(System.Windows.Forms.Label lbl, string text, int x, int y, string name)
        {
            lbl.AutoSize  = true;
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            lbl.Location  = new System.Drawing.Point(x, y);
            lbl.Name      = name;
            lbl.Text      = text;
        }

        private void SetTxt(System.Windows.Forms.TextBox txt, int x, int y, int w, int h, string name)
        {
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font        = new System.Drawing.Font("Segoe UI", 10F);
            txt.Location    = new System.Drawing.Point(x, y);
            txt.Name        = name;
            txt.Size        = new System.Drawing.Size(w, h);
            txt.TextAlign   = System.Windows.Forms.HorizontalAlignment.Right;
        }

        #endregion

        // ── Control declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel     pnlHeader;
        private System.Windows.Forms.Label     lblProcesoTitle;
        private System.Windows.Forms.Label     lblTotalAmount;
        private System.Windows.Forms.Panel     pnlMetodos;
        private System.Windows.Forms.Button    btnEfectivo;
        private System.Windows.Forms.Button    btnYape;
        private System.Windows.Forms.Button    btnTransferencia;
        private System.Windows.Forms.Button    btnTarjeta;
        private System.Windows.Forms.Button    btnMixto;
        private System.Windows.Forms.Button    btnCredito;
        private System.Windows.Forms.Panel     pnlContenido;
        private System.Windows.Forms.Panel     pnlEfectivo;
        private System.Windows.Forms.Label     lblEfectivoTitulo;
        private System.Windows.Forms.Label     lblCantRecibida;
        private System.Windows.Forms.TextBox   txtMontoEfectivo;
        private System.Windows.Forms.Label     lblCambio;
        private System.Windows.Forms.TextBox   txtVueltoEfectivo;
        private System.Windows.Forms.Panel     pnlYape;
        private System.Windows.Forms.Label     lblYapeTitulo;
        private System.Windows.Forms.Label     lblYapeAmnt;
        private System.Windows.Forms.TextBox   txtMontoYape;
        private System.Windows.Forms.Panel     pnlTransferencia;
        private System.Windows.Forms.Label     lblTransTitulo;
        private System.Windows.Forms.Label     lblTransAmnt;
        private System.Windows.Forms.TextBox   txtMontoTransferencia;
        private System.Windows.Forms.Panel     pnlTarjeta;
        private System.Windows.Forms.Label     lblTarjetaTitulo;
        private System.Windows.Forms.Label     lblTarjetaAmnt;
        private System.Windows.Forms.TextBox   txtMontoTarjeta;
        private System.Windows.Forms.Panel     pnlMixto;
        private System.Windows.Forms.Label     lblMixtoTitulo;
        private System.Windows.Forms.Label     lblMixEfectivo;
        private System.Windows.Forms.TextBox   txtMixtoEfectivo;
        private System.Windows.Forms.Label     lblMixYape;
        private System.Windows.Forms.TextBox   txtMixtoYape;
        private System.Windows.Forms.Label     lblMixTransferencia;
        private System.Windows.Forms.TextBox   txtMixtoTransferencia;
        private System.Windows.Forms.Label     lblMixTarjeta;
        private System.Windows.Forms.TextBox   txtMixtoTarjeta;
        private System.Windows.Forms.Label     lblMixtoTotal;
        private System.Windows.Forms.Panel     pnlCredito;
        private System.Windows.Forms.Label     lblCreditoInfo;
        private System.Windows.Forms.Panel     pnlBotones;
        private System.Windows.Forms.Button    btnCancelarPago;
        private System.Windows.Forms.Button    btnConfirmar;
    }
}
