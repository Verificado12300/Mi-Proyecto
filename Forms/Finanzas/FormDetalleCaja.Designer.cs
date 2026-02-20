namespace SistemaPOS.Forms.Finanzas
{
    partial class FormDetalleCaja
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
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlInfoTurno = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFondoinicial = new System.Windows.Forms.Label();
            this.txtFondoInicial1 = new System.Windows.Forms.TextBox();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivoCantidad = new System.Windows.Forms.TextBox();
            this.lbllblYape = new System.Windows.Forms.Label();
            this.txtYapeCantidad = new System.Windows.Forms.TextBox();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.txtTransferenciaCantidad = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCreditoCantidad = new System.Windows.Forms.TextBox();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalCantidad = new System.Windows.Forms.TextBox();
            this.pnlArqueoEfectivo = new System.Windows.Forms.Panel();
            this.lblSubtitulo3 = new System.Windows.Forms.Label();
            this.lblFondoInicial2 = new System.Windows.Forms.Label();
            this.txtFondoInicial = new System.Windows.Forms.TextBox();
            this.lblEfectivoVentas = new System.Windows.Forms.Label();
            this.txtEfectivoVentas = new System.Windows.Forms.TextBox();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblEfectivoEsperado = new System.Windows.Forms.Label();
            this.txtEfectivoEsperado = new System.Windows.Forms.TextBox();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblEfectivoReal = new System.Windows.Forms.Label();
            this.txtEfectivoReal = new System.Windows.Forms.TextBox();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.txtDiferenciaCantidad = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.pnlCardObs = new System.Windows.Forms.Panel();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlInfoTurno.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.pnlArqueoEfectivo.SuspendLayout();
            this.pnlCardObs.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 68;
            this.pnlHeader.Name = "pnlHeader";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Detalle de Cierre de Caja";
            //
            // lblHeaderSub
            //
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblHeaderSub.Location = new System.Drawing.Point(22, 42);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Text = "Resumen e información del turno";
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnImprimir);
            this.pnlFooter.Controls.Add(this.btnCerrar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 60;
            this.pnlFooter.Name = "pnlFooter";
            //
            // btnImprimir
            //
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(9, 132, 227);
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(7, 110, 195);
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(354, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 36);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Exportar";
            this.btnImprimir.UseVisualStyleBackColor = false;
            //
            // btnCerrar
            //
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCerrar.FlatAppearance.BorderSize = 1;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.btnCerrar.Location = new System.Drawing.Point(472, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            //
            // pnlBody
            //
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlBody.Controls.Add(this.pnlCardObs);
            this.pnlBody.Controls.Add(this.pnlArqueoEfectivo);
            this.pnlBody.Controls.Add(this.pnlResumen);
            this.pnlBody.Controls.Add(this.pnlInfoTurno);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
            //
            // pnlInfoTurno
            //
            this.pnlInfoTurno.BackColor = System.Drawing.Color.White;
            this.pnlInfoTurno.Controls.Add(this.lblSubTitulo);
            this.pnlInfoTurno.Controls.Add(this.lblEncargado);
            this.pnlInfoTurno.Controls.Add(this.lblFecha);
            this.pnlInfoTurno.Controls.Add(this.lblHora);
            this.pnlInfoTurno.Controls.Add(this.lblTipoComprobante);
            this.pnlInfoTurno.Controls.Add(this.lblNumeroSerie);
            this.pnlInfoTurno.Controls.Add(this.lblEstado);
            this.pnlInfoTurno.Controls.Add(this.lblFondoinicial);
            this.pnlInfoTurno.Controls.Add(this.txtFondoInicial1);
            this.pnlInfoTurno.Location = new System.Drawing.Point(10, 10);
            this.pnlInfoTurno.Name = "pnlInfoTurno";
            this.pnlInfoTurno.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlInfoTurno.Size = new System.Drawing.Size(560, 140);
            //
            // lblSubTitulo
            //
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblSubTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Text = "INFORMACIÓN DEL TURNO";
            //
            // lblEncargado
            //
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEncargado.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEncargado.Location = new System.Drawing.Point(15, 30);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Text = "Encargado: —";
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblFecha.Location = new System.Drawing.Point(15, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha: —";
            //
            // lblHora
            //
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblHora.Location = new System.Drawing.Point(15, 75);
            this.lblHora.Name = "lblHora";
            this.lblHora.Text = "Hora Apertura: —";
            //
            // lblTipoComprobante
            //
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoComprobante.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblTipoComprobante.Location = new System.Drawing.Point(300, 30);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Text = "Turno: —";
            //
            // lblNumeroSerie
            //
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroSerie.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblNumeroSerie.Location = new System.Drawing.Point(300, 54);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Text = "Duración: —";
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEstado.Location = new System.Drawing.Point(300, 75);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Text = "Hora Cierre: —";
            //
            // lblFondoinicial
            //
            this.lblFondoinicial.AutoSize = true;
            this.lblFondoinicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFondoinicial.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblFondoinicial.Location = new System.Drawing.Point(15, 107);
            this.lblFondoinicial.Name = "lblFondoinicial";
            this.lblFondoinicial.Text = "Fondo Inicial:";
            //
            // txtFondoInicial1
            //
            this.txtFondoInicial1.BackColor = System.Drawing.Color.White;
            this.txtFondoInicial1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFondoInicial1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFondoInicial1.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtFondoInicial1.Location = new System.Drawing.Point(120, 108);
            this.txtFondoInicial1.Multiline = true;
            this.txtFondoInicial1.Name = "txtFondoInicial1";
            this.txtFondoInicial1.ReadOnly = true;
            this.txtFondoInicial1.Size = new System.Drawing.Size(120, 20);
            this.txtFondoInicial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //
            // pnlResumen
            //
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.Controls.Add(this.lblSubTitulo2);
            this.pnlResumen.Controls.Add(this.lblOperaciones);
            this.pnlResumen.Controls.Add(this.lblEfectivo);
            this.pnlResumen.Controls.Add(this.txtEfectivoCantidad);
            this.pnlResumen.Controls.Add(this.lbllblYape);
            this.pnlResumen.Controls.Add(this.txtYapeCantidad);
            this.pnlResumen.Controls.Add(this.lblTransferencia);
            this.pnlResumen.Controls.Add(this.txtTransferenciaCantidad);
            this.pnlResumen.Controls.Add(this.lblCredito);
            this.pnlResumen.Controls.Add(this.txtCreditoCantidad);
            this.pnlResumen.Controls.Add(this.lblSeparador2);
            this.pnlResumen.Controls.Add(this.lblTotal);
            this.pnlResumen.Controls.Add(this.txtTotalCantidad);
            this.pnlResumen.Location = new System.Drawing.Point(10, 160);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlResumen.Size = new System.Drawing.Size(272, 215);
            //
            // lblSubTitulo2
            //
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblSubTitulo2.Location = new System.Drawing.Point(15, 10);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Text = "RESUMEN DE INGRESOS";
            //
            // lblOperaciones
            //
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOperaciones.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblOperaciones.Location = new System.Drawing.Point(15, 30);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Text = "Operaciones: 0";
            //
            // lblEfectivo
            //
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEfectivo.Location = new System.Drawing.Point(15, 55);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Text = "Efectivo:";
            //
            // txtEfectivoCantidad
            //
            this.txtEfectivoCantidad.BackColor = System.Drawing.Color.White;
            this.txtEfectivoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivoCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEfectivoCantidad.Location = new System.Drawing.Point(145, 54);
            this.txtEfectivoCantidad.Multiline = true;
            this.txtEfectivoCantidad.Name = "txtEfectivoCantidad";
            this.txtEfectivoCantidad.ReadOnly = true;
            this.txtEfectivoCantidad.Size = new System.Drawing.Size(100, 18);
            this.txtEfectivoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lbllblYape
            //
            this.lbllblYape.AutoSize = true;
            this.lbllblYape.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbllblYape.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lbllblYape.Location = new System.Drawing.Point(15, 80);
            this.lbllblYape.Name = "lbllblYape";
            this.lbllblYape.Text = "Yape:";
            //
            // txtYapeCantidad
            //
            this.txtYapeCantidad.BackColor = System.Drawing.Color.White;
            this.txtYapeCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYapeCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtYapeCantidad.Location = new System.Drawing.Point(145, 79);
            this.txtYapeCantidad.Multiline = true;
            this.txtYapeCantidad.Name = "txtYapeCantidad";
            this.txtYapeCantidad.ReadOnly = true;
            this.txtYapeCantidad.Size = new System.Drawing.Size(100, 18);
            this.txtYapeCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblTransferencia
            //
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTransferencia.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblTransferencia.Location = new System.Drawing.Point(15, 105);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Text = "Transferencia:";
            //
            // txtTransferenciaCantidad
            //
            this.txtTransferenciaCantidad.BackColor = System.Drawing.Color.White;
            this.txtTransferenciaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransferenciaCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTransferenciaCantidad.Location = new System.Drawing.Point(145, 104);
            this.txtTransferenciaCantidad.Multiline = true;
            this.txtTransferenciaCantidad.Name = "txtTransferenciaCantidad";
            this.txtTransferenciaCantidad.ReadOnly = true;
            this.txtTransferenciaCantidad.Size = new System.Drawing.Size(100, 18);
            this.txtTransferenciaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblCredito
            //
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCredito.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblCredito.Location = new System.Drawing.Point(15, 130);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Text = "A Crédito:";
            //
            // txtCreditoCantidad
            //
            this.txtCreditoCantidad.BackColor = System.Drawing.Color.White;
            this.txtCreditoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditoCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCreditoCantidad.Location = new System.Drawing.Point(145, 129);
            this.txtCreditoCantidad.Multiline = true;
            this.txtCreditoCantidad.Name = "txtCreditoCantidad";
            this.txtCreditoCantidad.ReadOnly = true;
            this.txtCreditoCantidad.Size = new System.Drawing.Size(100, 18);
            this.txtCreditoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSeparador2
            //
            this.lblSeparador2.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSeparador2.Location = new System.Drawing.Point(15, 155);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(235, 1);
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblTotal.Location = new System.Drawing.Point(15, 163);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "TOTAL:";
            //
            // txtTotalCantidad
            //
            this.txtTotalCantidad.BackColor = System.Drawing.Color.White;
            this.txtTotalCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalCantidad.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtTotalCantidad.Location = new System.Drawing.Point(120, 162);
            this.txtTotalCantidad.Multiline = true;
            this.txtTotalCantidad.Name = "txtTotalCantidad";
            this.txtTotalCantidad.ReadOnly = true;
            this.txtTotalCantidad.Size = new System.Drawing.Size(130, 22);
            this.txtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlArqueoEfectivo
            //
            this.pnlArqueoEfectivo.BackColor = System.Drawing.Color.White;
            this.pnlArqueoEfectivo.Controls.Add(this.lblSubtitulo3);
            this.pnlArqueoEfectivo.Controls.Add(this.lblFondoInicial2);
            this.pnlArqueoEfectivo.Controls.Add(this.txtFondoInicial);
            this.pnlArqueoEfectivo.Controls.Add(this.lblEfectivoVentas);
            this.pnlArqueoEfectivo.Controls.Add(this.txtEfectivoVentas);
            this.pnlArqueoEfectivo.Controls.Add(this.lblSeparador);
            this.pnlArqueoEfectivo.Controls.Add(this.lblEfectivoEsperado);
            this.pnlArqueoEfectivo.Controls.Add(this.txtEfectivoEsperado);
            this.pnlArqueoEfectivo.Controls.Add(this.lblSeparador1);
            this.pnlArqueoEfectivo.Controls.Add(this.lblEfectivoReal);
            this.pnlArqueoEfectivo.Controls.Add(this.txtEfectivoReal);
            this.pnlArqueoEfectivo.Controls.Add(this.lblDiferencia);
            this.pnlArqueoEfectivo.Controls.Add(this.txtDiferenciaCantidad);
            this.pnlArqueoEfectivo.Controls.Add(this.lblMotivo);
            this.pnlArqueoEfectivo.Controls.Add(this.txtMotivo);
            this.pnlArqueoEfectivo.Location = new System.Drawing.Point(292, 160);
            this.pnlArqueoEfectivo.Name = "pnlArqueoEfectivo";
            this.pnlArqueoEfectivo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlArqueoEfectivo.Size = new System.Drawing.Size(278, 215);
            //
            // lblSubtitulo3
            //
            this.lblSubtitulo3.AutoSize = true;
            this.lblSubtitulo3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo3.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblSubtitulo3.Location = new System.Drawing.Point(15, 10);
            this.lblSubtitulo3.Name = "lblSubtitulo3";
            this.lblSubtitulo3.Text = "ARQUEO DE EFECTIVO";
            //
            // lblFondoInicial2
            //
            this.lblFondoInicial2.AutoSize = true;
            this.lblFondoInicial2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFondoInicial2.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblFondoInicial2.Location = new System.Drawing.Point(15, 33);
            this.lblFondoInicial2.Name = "lblFondoInicial2";
            this.lblFondoInicial2.Text = "Fondo Inicial:";
            //
            // txtFondoInicial
            //
            this.txtFondoInicial.BackColor = System.Drawing.Color.White;
            this.txtFondoInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFondoInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtFondoInicial.Location = new System.Drawing.Point(150, 32);
            this.txtFondoInicial.Multiline = true;
            this.txtFondoInicial.Name = "txtFondoInicial";
            this.txtFondoInicial.ReadOnly = true;
            this.txtFondoInicial.Size = new System.Drawing.Size(100, 18);
            this.txtFondoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblEfectivoVentas
            //
            this.lblEfectivoVentas.AutoSize = true;
            this.lblEfectivoVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfectivoVentas.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEfectivoVentas.Location = new System.Drawing.Point(15, 57);
            this.lblEfectivoVentas.Name = "lblEfectivoVentas";
            this.lblEfectivoVentas.Text = "(+) Efectivo Ventas:";
            //
            // txtEfectivoVentas
            //
            this.txtEfectivoVentas.BackColor = System.Drawing.Color.White;
            this.txtEfectivoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivoVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEfectivoVentas.Location = new System.Drawing.Point(150, 56);
            this.txtEfectivoVentas.Multiline = true;
            this.txtEfectivoVentas.Name = "txtEfectivoVentas";
            this.txtEfectivoVentas.ReadOnly = true;
            this.txtEfectivoVentas.Size = new System.Drawing.Size(100, 18);
            this.txtEfectivoVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSeparador
            //
            this.lblSeparador.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSeparador.Location = new System.Drawing.Point(15, 80);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(240, 1);
            //
            // lblEfectivoEsperado
            //
            this.lblEfectivoEsperado.AutoSize = true;
            this.lblEfectivoEsperado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfectivoEsperado.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEfectivoEsperado.Location = new System.Drawing.Point(15, 89);
            this.lblEfectivoEsperado.Name = "lblEfectivoEsperado";
            this.lblEfectivoEsperado.Text = "Efectivo Esperado:";
            //
            // txtEfectivoEsperado
            //
            this.txtEfectivoEsperado.BackColor = System.Drawing.Color.White;
            this.txtEfectivoEsperado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivoEsperado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEfectivoEsperado.Location = new System.Drawing.Point(150, 88);
            this.txtEfectivoEsperado.Multiline = true;
            this.txtEfectivoEsperado.Name = "txtEfectivoEsperado";
            this.txtEfectivoEsperado.ReadOnly = true;
            this.txtEfectivoEsperado.Size = new System.Drawing.Size(100, 18);
            this.txtEfectivoEsperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSeparador1
            //
            this.lblSeparador1.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSeparador1.Location = new System.Drawing.Point(15, 112);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(240, 1);
            //
            // lblEfectivoReal
            //
            this.lblEfectivoReal.AutoSize = true;
            this.lblEfectivoReal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfectivoReal.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblEfectivoReal.Location = new System.Drawing.Point(15, 120);
            this.lblEfectivoReal.Name = "lblEfectivoReal";
            this.lblEfectivoReal.Text = "Efectivo Real:";
            //
            // txtEfectivoReal
            //
            this.txtEfectivoReal.BackColor = System.Drawing.Color.White;
            this.txtEfectivoReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivoReal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEfectivoReal.Location = new System.Drawing.Point(150, 119);
            this.txtEfectivoReal.Multiline = true;
            this.txtEfectivoReal.Name = "txtEfectivoReal";
            this.txtEfectivoReal.ReadOnly = true;
            this.txtEfectivoReal.Size = new System.Drawing.Size(100, 18);
            this.txtEfectivoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblDiferencia
            //
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiferencia.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblDiferencia.Location = new System.Drawing.Point(15, 144);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Text = "Diferencia:";
            //
            // txtDiferenciaCantidad
            //
            this.txtDiferenciaCantidad.BackColor = System.Drawing.Color.White;
            this.txtDiferenciaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiferenciaCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDiferenciaCantidad.Location = new System.Drawing.Point(150, 143);
            this.txtDiferenciaCantidad.Multiline = true;
            this.txtDiferenciaCantidad.Name = "txtDiferenciaCantidad";
            this.txtDiferenciaCantidad.ReadOnly = true;
            this.txtDiferenciaCantidad.Size = new System.Drawing.Size(100, 18);
            this.txtDiferenciaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblMotivo
            //
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblMotivo.Location = new System.Drawing.Point(15, 168);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Text = "Motivo:";
            //
            // txtMotivo
            //
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtMotivo.Location = new System.Drawing.Point(60, 165);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(195, 35);
            //
            // pnlCardObs
            //
            this.pnlCardObs.BackColor = System.Drawing.Color.White;
            this.pnlCardObs.Controls.Add(this.lblObservaciones);
            this.pnlCardObs.Controls.Add(this.txtObservaciones);
            this.pnlCardObs.Location = new System.Drawing.Point(10, 385);
            this.pnlCardObs.Name = "pnlCardObs";
            this.pnlCardObs.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlCardObs.Size = new System.Drawing.Size(560, 95);
            //
            // lblObservaciones
            //
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblObservaciones.Location = new System.Drawing.Point(15, 10);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Observaciones del Cierre:";
            //
            // txtObservaciones
            //
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.Location = new System.Drawing.Point(15, 28);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(530, 52);
            //
            // FormDetalleCaja
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(584, 580);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetalleCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Cierre de Caja";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlInfoTurno.ResumeLayout(false);
            this.pnlInfoTurno.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.pnlArqueoEfectivo.ResumeLayout(false);
            this.pnlArqueoEfectivo.PerformLayout();
            this.pnlCardObs.ResumeLayout(false);
            this.pnlCardObs.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlInfoTurno;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFondoinicial;
        private System.Windows.Forms.TextBox txtFondoInicial1;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox txtEfectivoCantidad;
        private System.Windows.Forms.Label lbllblYape;
        private System.Windows.Forms.TextBox txtYapeCantidad;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.TextBox txtTransferenciaCantidad;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtCreditoCantidad;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalCantidad;
        private System.Windows.Forms.Panel pnlArqueoEfectivo;
        private System.Windows.Forms.Label lblSubtitulo3;
        private System.Windows.Forms.Label lblFondoInicial2;
        private System.Windows.Forms.TextBox txtFondoInicial;
        private System.Windows.Forms.Label lblEfectivoVentas;
        private System.Windows.Forms.TextBox txtEfectivoVentas;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblEfectivoEsperado;
        private System.Windows.Forms.TextBox txtEfectivoEsperado;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblEfectivoReal;
        private System.Windows.Forms.TextBox txtEfectivoReal;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.TextBox txtDiferenciaCantidad;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Panel pnlCardObs;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}
