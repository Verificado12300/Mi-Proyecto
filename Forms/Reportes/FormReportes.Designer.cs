namespace SistemaPOS.Forms.Reportes
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNotificaciones = new System.Windows.Forms.Panel();
            this.chkAmbosFormatos = new System.Windows.Forms.CheckBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtDestinatarios = new System.Windows.Forms.TextBox();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.chkEnviarporCorreo = new System.Windows.Forms.CheckBox();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.lblDestinatarios = new System.Windows.Forms.Label();
            this.lblSubTitulo4 = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cmbDiaEnvio = new System.Windows.Forms.ComboBox();
            this.lblDiaEnvio = new System.Windows.Forms.Label();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.lblReportesGenerar = new System.Windows.Forms.Label();
            this.chkMostrarEmail = new System.Windows.Forms.CheckBox();
            this.chkMostrarTelefono = new System.Windows.Forms.CheckBox();
            this.chkMostrarDireccion = new System.Windows.Forms.CheckBox();
            this.chkMostrarRUC = new System.Windows.Forms.CheckBox();
            this.chkMostrarNombre = new System.Windows.Forms.CheckBox();
            this.chkMostrarLogo = new System.Windows.Forms.CheckBox();
            this.rbSemanal = new System.Windows.Forms.RadioButton();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.chkGenerarReportes = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAlertas = new System.Windows.Forms.Panel();
            this.numMontoVentas = new System.Windows.Forms.NumericUpDown();
            this.chkNotificarCompras = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.chkAlertarProductosVencer = new System.Windows.Forms.CheckBox();
            this.chkAlertaStockBajo = new System.Windows.Forms.CheckBox();
            this.chkNotificarVentasMayores = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlNotificaciones.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNotificaciones
            // 
            this.pnlNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotificaciones.BackColor = System.Drawing.Color.White;
            this.pnlNotificaciones.Controls.Add(this.chkAmbosFormatos);
            this.pnlNotificaciones.Controls.Add(this.txtAsunto);
            this.pnlNotificaciones.Controls.Add(this.lblAsunto);
            this.pnlNotificaciones.Controls.Add(this.lblFormato);
            this.pnlNotificaciones.Controls.Add(this.txtDestinatarios);
            this.pnlNotificaciones.Controls.Add(this.rbExcel);
            this.pnlNotificaciones.Controls.Add(this.chkEnviarporCorreo);
            this.pnlNotificaciones.Controls.Add(this.rbPDF);
            this.pnlNotificaciones.Controls.Add(this.lblDestinatarios);
            this.pnlNotificaciones.Controls.Add(this.lblSubTitulo4);
            this.pnlNotificaciones.Location = new System.Drawing.Point(477, 42);
            this.pnlNotificaciones.Name = "pnlNotificaciones";
            this.pnlNotificaciones.Size = new System.Drawing.Size(695, 220);
            this.pnlNotificaciones.TabIndex = 68;
            // 
            // chkAmbosFormatos
            // 
            this.chkAmbosFormatos.AutoSize = true;
            this.chkAmbosFormatos.Location = new System.Drawing.Point(339, 139);
            this.chkAmbosFormatos.Name = "chkAmbosFormatos";
            this.chkAmbosFormatos.Size = new System.Drawing.Size(58, 17);
            this.chkAmbosFormatos.TabIndex = 96;
            this.chkAmbosFormatos.Text = "Ambos";
            this.chkAmbosFormatos.UseVisualStyleBackColor = true;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Location = new System.Drawing.Point(82, 179);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(315, 21);
            this.txtAsunto.TabIndex = 101;
            this.txtAsunto.Text = "Reporte Automático - SistemaPOS";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAsunto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(17, 182);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(48, 15);
            this.lblAsunto.TabIndex = 100;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(17, 139);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(55, 15);
            this.lblFormato.TabIndex = 97;
            this.lblFormato.Text = "Formato:";
            // 
            // txtDestinatarios
            // 
            this.txtDestinatarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinatarios.Location = new System.Drawing.Point(283, 94);
            this.txtDestinatarios.Name = "txtDestinatarios";
            this.txtDestinatarios.Size = new System.Drawing.Size(315, 20);
            this.txtDestinatarios.TabIndex = 97;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(230, 138);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(51, 17);
            this.rbExcel.TabIndex = 98;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // chkEnviarporCorreo
            // 
            this.chkEnviarporCorreo.AutoSize = true;
            this.chkEnviarporCorreo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviarporCorreo.Location = new System.Drawing.Point(17, 57);
            this.chkEnviarporCorreo.Name = "chkEnviarporCorreo";
            this.chkEnviarporCorreo.Size = new System.Drawing.Size(241, 20);
            this.chkEnviarporCorreo.TabIndex = 96;
            this.chkEnviarporCorreo.Text = "Enviar reportes por correo electrónico";
            this.chkEnviarporCorreo.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(129, 138);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(46, 17);
            this.rbPDF.TabIndex = 96;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.AutoSize = true;
            this.lblDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDestinatarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatarios.Location = new System.Drawing.Point(14, 97);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(196, 15);
            this.lblDestinatarios.TabIndex = 62;
            this.lblDestinatarios.Text = "Destinatarios (separados por coma):";
            // 
            // lblSubTitulo4
            // 
            this.lblSubTitulo4.AutoSize = true;
            this.lblSubTitulo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo4.Location = new System.Drawing.Point(13, 12);
            this.lblSubTitulo4.Name = "lblSubTitulo4";
            this.lblSubTitulo4.Size = new System.Drawing.Size(220, 20);
            this.lblSubTitulo4.TabIndex = 67;
            this.lblSubTitulo4.Text = "NOTIFICACIONES POR CORREO";
            // 
            // pnlReportes
            // 
            this.pnlReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlReportes.BackColor = System.Drawing.Color.White;
            this.pnlReportes.Controls.Add(this.lblHora);
            this.pnlReportes.Controls.Add(this.dtpHora);
            this.pnlReportes.Controls.Add(this.cmbDiaEnvio);
            this.pnlReportes.Controls.Add(this.lblDiaEnvio);
            this.pnlReportes.Controls.Add(this.rbMensual);
            this.pnlReportes.Controls.Add(this.lblFrecuencia);
            this.pnlReportes.Controls.Add(this.lblReportesGenerar);
            this.pnlReportes.Controls.Add(this.chkMostrarEmail);
            this.pnlReportes.Controls.Add(this.chkMostrarTelefono);
            this.pnlReportes.Controls.Add(this.chkMostrarDireccion);
            this.pnlReportes.Controls.Add(this.chkMostrarRUC);
            this.pnlReportes.Controls.Add(this.chkMostrarNombre);
            this.pnlReportes.Controls.Add(this.chkMostrarLogo);
            this.pnlReportes.Controls.Add(this.rbSemanal);
            this.pnlReportes.Controls.Add(this.rbDiario);
            this.pnlReportes.Controls.Add(this.chkGenerarReportes);
            this.pnlReportes.Controls.Add(this.lblSubTitulo);
            this.pnlReportes.Location = new System.Drawing.Point(16, 42);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(455, 557);
            this.pnlReportes.TabIndex = 65;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(283, 137);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 15);
            this.lblHora.TabIndex = 95;
            this.lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(353, 134);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(67, 20);
            this.dtpHora.TabIndex = 94;
            // 
            // cmbDiaEnvio
            // 
            this.cmbDiaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaEnvio.FormattingEnabled = true;
            this.cmbDiaEnvio.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cmbDiaEnvio.Location = new System.Drawing.Point(115, 134);
            this.cmbDiaEnvio.Name = "cmbDiaEnvio";
            this.cmbDiaEnvio.Size = new System.Drawing.Size(128, 21);
            this.cmbDiaEnvio.TabIndex = 93;
            // 
            // lblDiaEnvio
            // 
            this.lblDiaEnvio.AutoSize = true;
            this.lblDiaEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiaEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaEnvio.Location = new System.Drawing.Point(14, 137);
            this.lblDiaEnvio.Name = "lblDiaEnvio";
            this.lblDiaEnvio.Size = new System.Drawing.Size(75, 15);
            this.lblDiaEnvio.TabIndex = 92;
            this.lblDiaEnvio.Text = "Día de Envio:";
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(335, 94);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 91;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFrecuencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecuencia.Location = new System.Drawing.Point(14, 95);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(67, 15);
            this.lblFrecuencia.TabIndex = 83;
            this.lblFrecuencia.Text = "Frecuencia:";
            // 
            // lblReportesGenerar
            // 
            this.lblReportesGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblReportesGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReportesGenerar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesGenerar.Location = new System.Drawing.Point(14, 185);
            this.lblReportesGenerar.Name = "lblReportesGenerar";
            this.lblReportesGenerar.Size = new System.Drawing.Size(158, 1);
            this.lblReportesGenerar.TabIndex = 90;
            // 
            // chkMostrarEmail
            // 
            this.chkMostrarEmail.AutoSize = true;
            this.chkMostrarEmail.Location = new System.Drawing.Point(29, 328);
            this.chkMostrarEmail.Name = "chkMostrarEmail";
            this.chkMostrarEmail.Size = new System.Drawing.Size(117, 17);
            this.chkMostrarEmail.TabIndex = 89;
            this.chkMostrarEmail.Text = "Cuentas por Cobrar";
            this.chkMostrarEmail.UseVisualStyleBackColor = true;
            // 
            // chkMostrarTelefono
            // 
            this.chkMostrarTelefono.AutoSize = true;
            this.chkMostrarTelefono.Location = new System.Drawing.Point(29, 305);
            this.chkMostrarTelefono.Name = "chkMostrarTelefono";
            this.chkMostrarTelefono.Size = new System.Drawing.Size(123, 17);
            this.chkMostrarTelefono.TabIndex = 88;
            this.chkMostrarTelefono.Text = "Reporte de Compras";
            this.chkMostrarTelefono.UseVisualStyleBackColor = true;
            // 
            // chkMostrarDireccion
            // 
            this.chkMostrarDireccion.AutoSize = true;
            this.chkMostrarDireccion.Location = new System.Drawing.Point(29, 282);
            this.chkMostrarDireccion.Name = "chkMostrarDireccion";
            this.chkMostrarDireccion.Size = new System.Drawing.Size(110, 17);
            this.chkMostrarDireccion.TabIndex = 87;
            this.chkMostrarDireccion.Text = "Resumen de Caja";
            this.chkMostrarDireccion.UseVisualStyleBackColor = true;
            // 
            // chkMostrarRUC
            // 
            this.chkMostrarRUC.AutoSize = true;
            this.chkMostrarRUC.Location = new System.Drawing.Point(29, 259);
            this.chkMostrarRUC.Name = "chkMostrarRUC";
            this.chkMostrarRUC.Size = new System.Drawing.Size(150, 17);
            this.chkMostrarRUC.TabIndex = 86;
            this.chkMostrarRUC.Text = "Productos con Stock Bajo";
            this.chkMostrarRUC.UseVisualStyleBackColor = true;
            // 
            // chkMostrarNombre
            // 
            this.chkMostrarNombre.AutoSize = true;
            this.chkMostrarNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMostrarNombre.Location = new System.Drawing.Point(29, 236);
            this.chkMostrarNombre.Name = "chkMostrarNombre";
            this.chkMostrarNombre.Size = new System.Drawing.Size(129, 17);
            this.chkMostrarNombre.TabIndex = 85;
            this.chkMostrarNombre.Text = "Reporte de Inventario";
            this.chkMostrarNombre.UseVisualStyleBackColor = true;
            // 
            // chkMostrarLogo
            // 
            this.chkMostrarLogo.AutoSize = true;
            this.chkMostrarLogo.Location = new System.Drawing.Point(29, 213);
            this.chkMostrarLogo.Name = "chkMostrarLogo";
            this.chkMostrarLogo.Size = new System.Drawing.Size(115, 17);
            this.chkMostrarLogo.TabIndex = 84;
            this.chkMostrarLogo.Text = "Reporte de Ventas";
            this.chkMostrarLogo.UseVisualStyleBackColor = true;
            // 
            // rbSemanal
            // 
            this.rbSemanal.AutoSize = true;
            this.rbSemanal.Location = new System.Drawing.Point(227, 94);
            this.rbSemanal.Name = "rbSemanal";
            this.rbSemanal.Size = new System.Drawing.Size(66, 17);
            this.rbSemanal.TabIndex = 83;
            this.rbSemanal.TabStop = true;
            this.rbSemanal.Text = "Semanal";
            this.rbSemanal.UseVisualStyleBackColor = true;
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Location = new System.Drawing.Point(126, 94);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 82;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            // 
            // chkGenerarReportes
            // 
            this.chkGenerarReportes.AutoSize = true;
            this.chkGenerarReportes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerarReportes.Location = new System.Drawing.Point(17, 57);
            this.chkGenerarReportes.Name = "chkGenerarReportes";
            this.chkGenerarReportes.Size = new System.Drawing.Size(227, 20);
            this.chkGenerarReportes.TabIndex = 81;
            this.chkGenerarReportes.Text = "Generar reportes automáticamente";
            this.chkGenerarReportes.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(185, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "REPORTES AUTOMÁTICOS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 21);
            this.lblTitulo.TabIndex = 76;
            this.lblTitulo.Text = "Configuración de Reportes";
            // 
            // pnlAlertas
            // 
            this.pnlAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlertas.BackColor = System.Drawing.Color.White;
            this.pnlAlertas.Controls.Add(this.btnGuardar);
            this.pnlAlertas.Controls.Add(this.numMontoVentas);
            this.pnlAlertas.Controls.Add(this.chkNotificarCompras);
            this.pnlAlertas.Controls.Add(this.lblSubTitulo3);
            this.pnlAlertas.Controls.Add(this.chkAlertarProductosVencer);
            this.pnlAlertas.Controls.Add(this.chkAlertaStockBajo);
            this.pnlAlertas.Controls.Add(this.chkNotificarVentasMayores);
            this.pnlAlertas.Location = new System.Drawing.Point(477, 270);
            this.pnlAlertas.Name = "pnlAlertas";
            this.pnlAlertas.Size = new System.Drawing.Size(695, 329);
            this.pnlAlertas.TabIndex = 69;
            // 
            // numMontoVentas
            // 
            this.numMontoVentas.DecimalPlaces = 2;
            this.numMontoVentas.Location = new System.Drawing.Point(177, 83);
            this.numMontoVentas.Name = "numMontoVentas";
            this.numMontoVentas.Size = new System.Drawing.Size(77, 20);
            this.numMontoVentas.TabIndex = 100;
            // 
            // chkNotificarCompras
            // 
            this.chkNotificarCompras.AutoSize = true;
            this.chkNotificarCompras.Location = new System.Drawing.Point(17, 132);
            this.chkNotificarCompras.Name = "chkNotificarCompras";
            this.chkNotificarCompras.Size = new System.Drawing.Size(158, 17);
            this.chkNotificarCompras.TabIndex = 99;
            this.chkNotificarCompras.Text = "Notificar compras realizadas";
            this.chkNotificarCompras.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(13, 12);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(202, 20);
            this.lblSubTitulo3.TabIndex = 67;
            this.lblSubTitulo3.Text = "ALERTAS Y NOTIFICACIONES";
            // 
            // chkAlertarProductosVencer
            // 
            this.chkAlertarProductosVencer.AutoSize = true;
            this.chkAlertarProductosVencer.Location = new System.Drawing.Point(17, 109);
            this.chkAlertarProductosVencer.Name = "chkAlertarProductosVencer";
            this.chkAlertarProductosVencer.Size = new System.Drawing.Size(195, 17);
            this.chkAlertarProductosVencer.TabIndex = 98;
            this.chkAlertarProductosVencer.Text = "Alertar productos próximos a vencer";
            this.chkAlertarProductosVencer.UseVisualStyleBackColor = true;
            // 
            // chkAlertaStockBajo
            // 
            this.chkAlertaStockBajo.AutoSize = true;
            this.chkAlertaStockBajo.Location = new System.Drawing.Point(17, 63);
            this.chkAlertaStockBajo.Name = "chkAlertaStockBajo";
            this.chkAlertaStockBajo.Size = new System.Drawing.Size(170, 17);
            this.chkAlertaStockBajo.TabIndex = 96;
            this.chkAlertaStockBajo.Text = "Alertar cuando stock esté bajo";
            this.chkAlertaStockBajo.UseVisualStyleBackColor = true;
            // 
            // chkNotificarVentasMayores
            // 
            this.chkNotificarVentasMayores.AutoSize = true;
            this.chkNotificarVentasMayores.Location = new System.Drawing.Point(17, 86);
            this.chkNotificarVentasMayores.Name = "chkNotificarVentasMayores";
            this.chkNotificarVentasMayores.Size = new System.Drawing.Size(154, 17);
            this.chkNotificarVentasMayores.TabIndex = 97;
            this.chkNotificarVentasMayores.Text = "Notificar ventas mayores a:";
            this.chkNotificarVentasMayores.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnGuardar.Location = new System.Drawing.Point(552, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 38);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnlAlertas);
            this.Controls.Add(this.pnlNotificaciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlReportes);
            this.Name = "FormReportes";
            this.Text = " ";
            this.pnlNotificaciones.ResumeLayout(false);
            this.pnlNotificaciones.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.pnlAlertas.ResumeLayout(false);
            this.pnlAlertas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlNotificaciones;
        private System.Windows.Forms.Label lblDestinatarios;
        private System.Windows.Forms.Label lblSubTitulo4;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chkGenerarReportes;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.RadioButton rbSemanal;
        private System.Windows.Forms.CheckBox chkMostrarEmail;
        private System.Windows.Forms.CheckBox chkMostrarTelefono;
        private System.Windows.Forms.CheckBox chkMostrarDireccion;
        private System.Windows.Forms.CheckBox chkMostrarRUC;
        private System.Windows.Forms.CheckBox chkMostrarNombre;
        private System.Windows.Forms.CheckBox chkMostrarLogo;
        private System.Windows.Forms.Label lblReportesGenerar;
        private System.Windows.Forms.Label lblDiaEnvio;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ComboBox cmbDiaEnvio;
        private System.Windows.Forms.Panel pnlAlertas;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.CheckBox chkEnviarporCorreo;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtDestinatarios;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.CheckBox chkNotificarCompras;
        private System.Windows.Forms.CheckBox chkAlertarProductosVencer;
        private System.Windows.Forms.CheckBox chkAlertaStockBajo;
        private System.Windows.Forms.CheckBox chkNotificarVentasMayores;
        private System.Windows.Forms.CheckBox chkAmbosFormatos;
        private System.Windows.Forms.NumericUpDown numMontoVentas;
        private System.Windows.Forms.Button btnGuardar;
    }
}