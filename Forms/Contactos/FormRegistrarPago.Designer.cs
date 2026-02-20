namespace SistemaPOS.Forms.Contactos
{
    partial class FormRegistrarPago
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCardDatos = new System.Windows.Forms.Panel();
            this.lblCardDatosTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.pnlCardMetodo = new System.Windows.Forms.Panel();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbYape = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbMixto = new System.Windows.Forms.RadioButton();
            this.pnlCardMixto = new System.Windows.Forms.Panel();
            this.lblCardMixtoTitulo = new System.Windows.Forms.Label();
            this.lblEfLabel = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblYpLabel = new System.Windows.Forms.Label();
            this.txtYape = new System.Windows.Forms.TextBox();
            this.lblTrLabel = new System.Windows.Forms.Label();
            this.txtTransferencia = new System.Windows.Forms.TextBox();
            this.pnlCardObs = new System.Windows.Forms.Panel();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCardDatos.SuspendLayout();
            this.pnlCardMetodo.SuspendLayout();
            this.pnlCardMixto.SuspendLayout();
            this.pnlCardObs.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.pnlHeader.Controls.Add(this.lblSaldoActual);
            this.pnlHeader.Controls.Add(this.txtSaldoActual);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 68;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Pago";
            //
            // lblSaldoActual
            //
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldoActual.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblSaldoActual.Location = new System.Drawing.Point(16, 44);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(110, 15);
            this.lblSaldoActual.TabIndex = 1;
            this.lblSaldoActual.Text = "Saldo pendiente:";
            //
            // txtSaldoActual
            //
            this.txtSaldoActual.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldoActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSaldoActual.ForeColor = System.Drawing.Color.White;
            this.txtSaldoActual.Location = new System.Drawing.Point(132, 41);
            this.txtSaldoActual.Multiline = false;
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(180, 22);
            this.txtSaldoActual.TabIndex = 2;
            this.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnRegistrarPago);
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 56;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.TabIndex = 2;
            //
            // btnRegistrarPago
            //
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(0, 184, 148);
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.Location = new System.Drawing.Point(16, 13);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(190, 30);
            this.btnRegistrarPago.TabIndex = 0;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(222, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // pnlBody
            //
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlBody.Controls.Add(this.pnlCardObs);
            this.pnlBody.Controls.Add(this.pnlCardMixto);
            this.pnlBody.Controls.Add(this.pnlCardMetodo);
            this.pnlBody.Controls.Add(this.pnlCardDatos);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.TabIndex = 1;
            //
            // pnlCardDatos
            //
            this.pnlCardDatos.BackColor = System.Drawing.Color.White;
            this.pnlCardDatos.Controls.Add(this.lblCardDatosTitulo);
            this.pnlCardDatos.Controls.Add(this.lblFecha);
            this.pnlCardDatos.Controls.Add(this.dtpFecha);
            this.pnlCardDatos.Controls.Add(this.lblMontoPagar);
            this.pnlCardDatos.Controls.Add(this.txtMontoPagar);
            this.pnlCardDatos.Location = new System.Drawing.Point(10, 10);
            this.pnlCardDatos.Name = "pnlCardDatos";
            this.pnlCardDatos.Size = new System.Drawing.Size(418, 110);
            this.pnlCardDatos.TabIndex = 0;
            //
            // lblCardDatosTitulo
            //
            this.lblCardDatosTitulo.AutoSize = true;
            this.lblCardDatosTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCardDatosTitulo.Location = new System.Drawing.Point(14, 10);
            this.lblCardDatosTitulo.Name = "lblCardDatosTitulo";
            this.lblCardDatosTitulo.Size = new System.Drawing.Size(100, 13);
            this.lblCardDatosTitulo.TabIndex = 0;
            this.lblCardDatosTitulo.Text = "DATOS DEL PAGO";
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.Location = new System.Drawing.Point(14, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de pago:";
            //
            // dtpFecha
            //
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(14, 56);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(160, 24);
            this.dtpFecha.TabIndex = 2;
            //
            // lblMontoPagar
            //
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMontoPagar.Location = new System.Drawing.Point(200, 38);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new System.Drawing.Size(80, 15);
            this.lblMontoPagar.TabIndex = 3;
            this.lblMontoPagar.Text = "Monto (S/):";
            //
            // txtMontoPagar
            //
            this.txtMontoPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtMontoPagar.Location = new System.Drawing.Point(200, 54);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(204, 30);
            this.txtMontoPagar.TabIndex = 4;
            this.txtMontoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlCardMetodo
            //
            this.pnlCardMetodo.BackColor = System.Drawing.Color.White;
            this.pnlCardMetodo.Controls.Add(this.lblMetodoPago);
            this.pnlCardMetodo.Controls.Add(this.rbEfectivo);
            this.pnlCardMetodo.Controls.Add(this.rbYape);
            this.pnlCardMetodo.Controls.Add(this.rbTransferencia);
            this.pnlCardMetodo.Controls.Add(this.rbMixto);
            this.pnlCardMetodo.Location = new System.Drawing.Point(10, 128);
            this.pnlCardMetodo.Name = "pnlCardMetodo";
            this.pnlCardMetodo.Size = new System.Drawing.Size(418, 115);
            this.pnlCardMetodo.TabIndex = 1;
            //
            // lblMetodoPago
            //
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMetodoPago.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblMetodoPago.Location = new System.Drawing.Point(14, 10);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(110, 13);
            this.lblMetodoPago.TabIndex = 0;
            this.lblMetodoPago.Text = "MÉTODO DE PAGO";
            //
            // rbEfectivo
            //
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbEfectivo.Location = new System.Drawing.Point(14, 38);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(75, 21);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            //
            // rbYape
            //
            this.rbYape.AutoSize = true;
            this.rbYape.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbYape.Location = new System.Drawing.Point(14, 64);
            this.rbYape.Name = "rbYape";
            this.rbYape.Size = new System.Drawing.Size(60, 21);
            this.rbYape.TabIndex = 2;
            this.rbYape.TabStop = true;
            this.rbYape.Text = "Yape";
            this.rbYape.UseVisualStyleBackColor = true;
            //
            // rbTransferencia
            //
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbTransferencia.Location = new System.Drawing.Point(14, 90);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(105, 21);
            this.rbTransferencia.TabIndex = 3;
            this.rbTransferencia.TabStop = true;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            //
            // rbMixto
            //
            this.rbMixto.AutoSize = true;
            this.rbMixto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbMixto.Location = new System.Drawing.Point(220, 38);
            this.rbMixto.Name = "rbMixto";
            this.rbMixto.Size = new System.Drawing.Size(60, 21);
            this.rbMixto.TabIndex = 4;
            this.rbMixto.TabStop = true;
            this.rbMixto.Text = "Mixto";
            this.rbMixto.UseVisualStyleBackColor = true;
            //
            // pnlCardMixto
            //
            this.pnlCardMixto.BackColor = System.Drawing.Color.White;
            this.pnlCardMixto.Controls.Add(this.lblCardMixtoTitulo);
            this.pnlCardMixto.Controls.Add(this.lblEfLabel);
            this.pnlCardMixto.Controls.Add(this.txtEfectivo);
            this.pnlCardMixto.Controls.Add(this.lblYpLabel);
            this.pnlCardMixto.Controls.Add(this.txtYape);
            this.pnlCardMixto.Controls.Add(this.lblTrLabel);
            this.pnlCardMixto.Controls.Add(this.txtTransferencia);
            this.pnlCardMixto.Location = new System.Drawing.Point(10, 251);
            this.pnlCardMixto.Name = "pnlCardMixto";
            this.pnlCardMixto.Size = new System.Drawing.Size(418, 82);
            this.pnlCardMixto.TabIndex = 2;
            //
            // lblCardMixtoTitulo
            //
            this.lblCardMixtoTitulo.AutoSize = true;
            this.lblCardMixtoTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardMixtoTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCardMixtoTitulo.Location = new System.Drawing.Point(14, 10);
            this.lblCardMixtoTitulo.Name = "lblCardMixtoTitulo";
            this.lblCardMixtoTitulo.Size = new System.Drawing.Size(130, 13);
            this.lblCardMixtoTitulo.TabIndex = 0;
            this.lblCardMixtoTitulo.Text = "DESGLOSE PAGO MIXTO";
            //
            // lblEfLabel
            //
            this.lblEfLabel.AutoSize = true;
            this.lblEfLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfLabel.Location = new System.Drawing.Point(14, 44);
            this.lblEfLabel.Name = "lblEfLabel";
            this.lblEfLabel.Size = new System.Drawing.Size(55, 15);
            this.lblEfLabel.TabIndex = 1;
            this.lblEfLabel.Text = "Efectivo:";
            //
            // txtEfectivo
            //
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfectivo.Location = new System.Drawing.Point(72, 40);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(76, 23);
            this.txtEfectivo.TabIndex = 2;
            //
            // lblYpLabel
            //
            this.lblYpLabel.AutoSize = true;
            this.lblYpLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYpLabel.Location = new System.Drawing.Point(158, 44);
            this.lblYpLabel.Name = "lblYpLabel";
            this.lblYpLabel.Size = new System.Drawing.Size(38, 15);
            this.lblYpLabel.TabIndex = 3;
            this.lblYpLabel.Text = "Yape:";
            //
            // txtYape
            //
            this.txtYape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYape.Location = new System.Drawing.Point(200, 40);
            this.txtYape.Name = "txtYape";
            this.txtYape.Size = new System.Drawing.Size(76, 23);
            this.txtYape.TabIndex = 4;
            //
            // lblTrLabel
            //
            this.lblTrLabel.AutoSize = true;
            this.lblTrLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrLabel.Location = new System.Drawing.Point(286, 44);
            this.lblTrLabel.Name = "lblTrLabel";
            this.lblTrLabel.Size = new System.Drawing.Size(45, 15);
            this.lblTrLabel.TabIndex = 5;
            this.lblTrLabel.Text = "Transf.:";
            //
            // txtTransferencia
            //
            this.txtTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferencia.Location = new System.Drawing.Point(334, 40);
            this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(76, 23);
            this.txtTransferencia.TabIndex = 6;
            //
            // pnlCardObs
            //
            this.pnlCardObs.BackColor = System.Drawing.Color.White;
            this.pnlCardObs.Controls.Add(this.lblObservaciones);
            this.pnlCardObs.Controls.Add(this.txtObservaciones);
            this.pnlCardObs.Location = new System.Drawing.Point(10, 341);
            this.pnlCardObs.Name = "pnlCardObs";
            this.pnlCardObs.Size = new System.Drawing.Size(418, 90);
            this.pnlCardObs.TabIndex = 3;
            //
            // lblObservaciones
            //
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblObservaciones.Location = new System.Drawing.Point(14, 10);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(110, 13);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "OBSERVACIONES";
            //
            // txtObservaciones
            //
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(14, 30);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(390, 48);
            this.txtObservaciones.TabIndex = 1;
            //
            // FormRegistrarPago
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Pago";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlCardDatos.ResumeLayout(false);
            this.pnlCardDatos.PerformLayout();
            this.pnlCardMetodo.ResumeLayout(false);
            this.pnlCardMetodo.PerformLayout();
            this.pnlCardMixto.ResumeLayout(false);
            this.pnlCardMixto.PerformLayout();
            this.pnlCardObs.ResumeLayout(false);
            this.pnlCardObs.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlCardDatos;
        private System.Windows.Forms.Label lblCardDatosTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMontoPagar;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.Panel pnlCardMetodo;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbYape;
        private System.Windows.Forms.RadioButton rbTransferencia;
        private System.Windows.Forms.RadioButton rbMixto;
        private System.Windows.Forms.Panel pnlCardMixto;
        private System.Windows.Forms.Label lblCardMixtoTitulo;
        private System.Windows.Forms.Label lblEfLabel;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblYpLabel;
        private System.Windows.Forms.TextBox txtYape;
        private System.Windows.Forms.Label lblTrLabel;
        private System.Windows.Forms.TextBox txtTransferencia;
        private System.Windows.Forms.Panel pnlCardObs;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}
