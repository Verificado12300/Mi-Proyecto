namespace SistemaPOS.Forms.Configuracion
{
    partial class FormGeneral
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
            this.pnlSeguridad = new System.Windows.Forms.Panel();
            this.numInactividad = new System.Windows.Forms.NumericUpDown();
            this.chkRegistrarAcciones = new System.Windows.Forms.CheckBox();
            this.chkCerrarSesionMinimizar = new System.Windows.Forms.CheckBox();
            this.lblTiempoInactividad = new System.Windows.Forms.Label();
            this.chkSolicitarContraseña = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo4 = new System.Windows.Forms.Label();
            this.pnlFormato = new System.Windows.Forms.Panel();
            this.cmbZonaHoraria = new System.Windows.Forms.ComboBox();
            this.lblSeparadorDecimal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFormatoHora = new System.Windows.Forms.Label();
            this.lblZonaHoraria = new System.Windows.Forms.Label();
            this.cmbDiaEnvio = new System.Windows.Forms.ComboBox();
            this.lblFormatoFecha = new System.Windows.Forms.Label();
            this.rbComa = new System.Windows.Forms.RadioButton();
            this.rbPunto = new System.Windows.Forms.RadioButton();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblUbicacionBaseDatos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlOpcionesInterfaz = new System.Windows.Forms.Panel();
            this.chkIniciarWindows = new System.Windows.Forms.CheckBox();
            this.chkSonidosSistema = new System.Windows.Forms.CheckBox();
            this.chkMostrarNotificacionPantalla = new System.Windows.Forms.CheckBox();
            this.cmbTamañoFuente = new System.Windows.Forms.ComboBox();
            this.lblTamañoFuente = new System.Windows.Forms.Label();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlInfoSistema = new System.Windows.Forms.Panel();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.pnlOtrasOpciones = new System.Windows.Forms.Panel();
            this.btnExaminarTemp = new System.Windows.Forms.Button();
            this.lblDirectorioTem = new System.Windows.Forms.Label();
            this.txtDirectorioTemp = new System.Windows.Forms.TextBox();
            this.chkModoDesarrollo = new System.Windows.Forms.CheckBox();
            this.chkMostrarMensajesAyuda = new System.Windows.Forms.CheckBox();
            this.chkConfirmarEliminarRegistros = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInactividad)).BeginInit();
            this.pnlFormato.SuspendLayout();
            this.pnlOpcionesInterfaz.SuspendLayout();
            this.pnlInfoSistema.SuspendLayout();
            this.pnlOtrasOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeguridad
            // 
            this.pnlSeguridad.BackColor = System.Drawing.Color.White;
            this.pnlSeguridad.Controls.Add(this.numInactividad);
            this.pnlSeguridad.Controls.Add(this.chkRegistrarAcciones);
            this.pnlSeguridad.Controls.Add(this.chkCerrarSesionMinimizar);
            this.pnlSeguridad.Controls.Add(this.lblTiempoInactividad);
            this.pnlSeguridad.Controls.Add(this.chkSolicitarContraseña);
            this.pnlSeguridad.Controls.Add(this.lblSubTitulo4);
            this.pnlSeguridad.Location = new System.Drawing.Point(477, 189);
            this.pnlSeguridad.Name = "pnlSeguridad";
            this.pnlSeguridad.Size = new System.Drawing.Size(634, 193);
            this.pnlSeguridad.TabIndex = 121;
            // 
            // numInactividad
            // 
            this.numInactividad.Location = new System.Drawing.Point(263, 50);
            this.numInactividad.Name = "numInactividad";
            this.numInactividad.Size = new System.Drawing.Size(66, 20);
            this.numInactividad.TabIndex = 122;
            // 
            // chkRegistrarAcciones
            // 
            this.chkRegistrarAcciones.AutoSize = true;
            this.chkRegistrarAcciones.Location = new System.Drawing.Point(18, 148);
            this.chkRegistrarAcciones.Name = "chkRegistrarAcciones";
            this.chkRegistrarAcciones.Size = new System.Drawing.Size(198, 17);
            this.chkRegistrarAcciones.TabIndex = 121;
            this.chkRegistrarAcciones.Text = "Registrar acciones de usuarios (Log)";
            this.chkRegistrarAcciones.UseVisualStyleBackColor = true;
            // 
            // chkCerrarSesionMinimizar
            // 
            this.chkCerrarSesionMinimizar.AutoSize = true;
            this.chkCerrarSesionMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCerrarSesionMinimizar.Location = new System.Drawing.Point(18, 125);
            this.chkCerrarSesionMinimizar.Name = "chkCerrarSesionMinimizar";
            this.chkCerrarSesionMinimizar.Size = new System.Drawing.Size(143, 17);
            this.chkCerrarSesionMinimizar.TabIndex = 120;
            this.chkCerrarSesionMinimizar.Text = "Cerrar sesión al minimizar";
            this.chkCerrarSesionMinimizar.UseVisualStyleBackColor = true;
            // 
            // lblTiempoInactividad
            // 
            this.lblTiempoInactividad.AutoSize = true;
            this.lblTiempoInactividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTiempoInactividad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoInactividad.Location = new System.Drawing.Point(15, 53);
            this.lblTiempoInactividad.Name = "lblTiempoInactividad";
            this.lblTiempoInactividad.Size = new System.Drawing.Size(221, 15);
            this.lblTiempoInactividad.TabIndex = 119;
            this.lblTiempoInactividad.Text = "Tiempo de inactividad antes de bloqueo:";
            // 
            // chkSolicitarContraseña
            // 
            this.chkSolicitarContraseña.AutoSize = true;
            this.chkSolicitarContraseña.Location = new System.Drawing.Point(18, 102);
            this.chkSolicitarContraseña.Name = "chkSolicitarContraseña";
            this.chkSolicitarContraseña.Size = new System.Drawing.Size(191, 17);
            this.chkSolicitarContraseña.TabIndex = 119;
            this.chkSolicitarContraseña.Text = "Solicitar contraseña al desbloquear";
            this.chkSolicitarContraseña.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo4
            // 
            this.lblSubTitulo4.AutoSize = true;
            this.lblSubTitulo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo4.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo4.Name = "lblSubTitulo4";
            this.lblSubTitulo4.Size = new System.Drawing.Size(175, 20);
            this.lblSubTitulo4.TabIndex = 116;
            this.lblSubTitulo4.Text = "SEGURIDAD Y SESIONES";
            // 
            // pnlFormato
            // 
            this.pnlFormato.BackColor = System.Drawing.Color.White;
            this.pnlFormato.Controls.Add(this.cmbZonaHoraria);
            this.pnlFormato.Controls.Add(this.lblSeparadorDecimal);
            this.pnlFormato.Controls.Add(this.comboBox1);
            this.pnlFormato.Controls.Add(this.lblFormatoHora);
            this.pnlFormato.Controls.Add(this.lblZonaHoraria);
            this.pnlFormato.Controls.Add(this.cmbDiaEnvio);
            this.pnlFormato.Controls.Add(this.lblFormatoFecha);
            this.pnlFormato.Controls.Add(this.rbComa);
            this.pnlFormato.Controls.Add(this.rbPunto);
            this.pnlFormato.Controls.Add(this.lblSubTitulo2);
            this.pnlFormato.Location = new System.Drawing.Point(477, 46);
            this.pnlFormato.Name = "pnlFormato";
            this.pnlFormato.Size = new System.Drawing.Size(634, 137);
            this.pnlFormato.TabIndex = 120;
            // 
            // cmbZonaHoraria
            // 
            this.cmbZonaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonaHoraria.FormattingEnabled = true;
            this.cmbZonaHoraria.Location = new System.Drawing.Point(461, 74);
            this.cmbZonaHoraria.Name = "cmbZonaHoraria";
            this.cmbZonaHoraria.Size = new System.Drawing.Size(129, 21);
            this.cmbZonaHoraria.TabIndex = 113;
            // 
            // lblSeparadorDecimal
            // 
            this.lblSeparadorDecimal.AutoSize = true;
            this.lblSeparadorDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparadorDecimal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparadorDecimal.Location = new System.Drawing.Point(335, 46);
            this.lblSeparadorDecimal.Name = "lblSeparadorDecimal";
            this.lblSeparadorDecimal.Size = new System.Drawing.Size(109, 15);
            this.lblSeparadorDecimal.TabIndex = 112;
            this.lblSeparadorDecimal.Text = "Separador Decimal:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "24 horas",
            "12 horas"});
            this.comboBox1.Location = new System.Drawing.Point(173, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 111;
            // 
            // lblFormatoHora
            // 
            this.lblFormatoHora.AutoSize = true;
            this.lblFormatoHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormatoHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoHora.Location = new System.Drawing.Point(15, 77);
            this.lblFormatoHora.Name = "lblFormatoHora";
            this.lblFormatoHora.Size = new System.Drawing.Size(100, 15);
            this.lblFormatoHora.TabIndex = 110;
            this.lblFormatoHora.Text = "Formato de Hora:";
            // 
            // lblZonaHoraria
            // 
            this.lblZonaHoraria.AutoSize = true;
            this.lblZonaHoraria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblZonaHoraria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonaHoraria.Location = new System.Drawing.Point(335, 80);
            this.lblZonaHoraria.Name = "lblZonaHoraria";
            this.lblZonaHoraria.Size = new System.Drawing.Size(79, 15);
            this.lblZonaHoraria.TabIndex = 95;
            this.lblZonaHoraria.Text = "Zona Horaria:";
            // 
            // cmbDiaEnvio
            // 
            this.cmbDiaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaEnvio.FormattingEnabled = true;
            this.cmbDiaEnvio.Items.AddRange(new object[] {
            "dd/MM/yyyy",
            "MM/dd/yyyy",
            "yyyy-MM-dd"});
            this.cmbDiaEnvio.Location = new System.Drawing.Point(173, 46);
            this.cmbDiaEnvio.Name = "cmbDiaEnvio";
            this.cmbDiaEnvio.Size = new System.Drawing.Size(129, 21);
            this.cmbDiaEnvio.TabIndex = 93;
            // 
            // lblFormatoFecha
            // 
            this.lblFormatoFecha.AutoSize = true;
            this.lblFormatoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormatoFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoFecha.Location = new System.Drawing.Point(15, 49);
            this.lblFormatoFecha.Name = "lblFormatoFecha";
            this.lblFormatoFecha.Size = new System.Drawing.Size(105, 15);
            this.lblFormatoFecha.TabIndex = 92;
            this.lblFormatoFecha.Text = "Formato de Fecha:";
            // 
            // rbComa
            // 
            this.rbComa.AutoSize = true;
            this.rbComa.Location = new System.Drawing.Point(540, 45);
            this.rbComa.Name = "rbComa";
            this.rbComa.Size = new System.Drawing.Size(70, 17);
            this.rbComa.TabIndex = 91;
            this.rbComa.TabStop = true;
            this.rbComa.Text = "Coma ( , )";
            this.rbComa.UseVisualStyleBackColor = true;
            // 
            // rbPunto
            // 
            this.rbPunto.AutoSize = true;
            this.rbPunto.Location = new System.Drawing.Point(461, 45);
            this.rbPunto.Name = "rbPunto";
            this.rbPunto.Size = new System.Drawing.Size(71, 17);
            this.rbPunto.TabIndex = 83;
            this.rbPunto.TabStop = true;
            this.rbPunto.Text = "Punto ( . )";
            this.rbPunto.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(225, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "FORMATO Y REGIONALIZACIÓN";
            // 
            // lblUbicacionBaseDatos
            // 
            this.lblUbicacionBaseDatos.AutoSize = true;
            this.lblUbicacionBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUbicacionBaseDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionBaseDatos.Location = new System.Drawing.Point(192, 103);
            this.lblUbicacionBaseDatos.Name = "lblUbicacionBaseDatos";
            this.lblUbicacionBaseDatos.Size = new System.Drawing.Size(156, 15);
            this.lblUbicacionBaseDatos.TabIndex = 110;
            this.lblUbicacionBaseDatos.Text = "C:\\SistemaPOS\\Data\\pos.db";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 21);
            this.lblTitulo.TabIndex = 119;
            this.lblTitulo.Text = "Configuración General";
            // 
            // pnlOpcionesInterfaz
            // 
            this.pnlOpcionesInterfaz.BackColor = System.Drawing.Color.White;
            this.pnlOpcionesInterfaz.Controls.Add(this.chkIniciarWindows);
            this.pnlOpcionesInterfaz.Controls.Add(this.chkSonidosSistema);
            this.pnlOpcionesInterfaz.Controls.Add(this.chkMostrarNotificacionPantalla);
            this.pnlOpcionesInterfaz.Controls.Add(this.cmbTamañoFuente);
            this.pnlOpcionesInterfaz.Controls.Add(this.lblTamañoFuente);
            this.pnlOpcionesInterfaz.Controls.Add(this.lblSubTitulo3);
            this.pnlOpcionesInterfaz.Location = new System.Drawing.Point(16, 189);
            this.pnlOpcionesInterfaz.Name = "pnlOpcionesInterfaz";
            this.pnlOpcionesInterfaz.Size = new System.Drawing.Size(455, 193);
            this.pnlOpcionesInterfaz.TabIndex = 118;
            // 
            // chkIniciarWindows
            // 
            this.chkIniciarWindows.AutoSize = true;
            this.chkIniciarWindows.Location = new System.Drawing.Point(17, 148);
            this.chkIniciarWindows.Name = "chkIniciarWindows";
            this.chkIniciarWindows.Size = new System.Drawing.Size(122, 17);
            this.chkIniciarWindows.TabIndex = 118;
            this.chkIniciarWindows.Text = "Iniciar con Windows";
            this.chkIniciarWindows.UseVisualStyleBackColor = true;
            // 
            // chkSonidosSistema
            // 
            this.chkSonidosSistema.AutoSize = true;
            this.chkSonidosSistema.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSonidosSistema.Location = new System.Drawing.Point(17, 125);
            this.chkSonidosSistema.Name = "chkSonidosSistema";
            this.chkSonidosSistema.Size = new System.Drawing.Size(119, 17);
            this.chkSonidosSistema.TabIndex = 117;
            this.chkSonidosSistema.Text = "Sonidos del sistema";
            this.chkSonidosSistema.UseVisualStyleBackColor = true;
            // 
            // chkMostrarNotificacionPantalla
            // 
            this.chkMostrarNotificacionPantalla.AutoSize = true;
            this.chkMostrarNotificacionPantalla.Location = new System.Drawing.Point(17, 102);
            this.chkMostrarNotificacionPantalla.Name = "chkMostrarNotificacionPantalla";
            this.chkMostrarNotificacionPantalla.Size = new System.Drawing.Size(184, 17);
            this.chkMostrarNotificacionPantalla.TabIndex = 116;
            this.chkMostrarNotificacionPantalla.Text = "Mostrar notificaciones en pantalla";
            this.chkMostrarNotificacionPantalla.UseVisualStyleBackColor = true;
            // 
            // cmbTamañoFuente
            // 
            this.cmbTamañoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamañoFuente.FormattingEnabled = true;
            this.cmbTamañoFuente.Items.AddRange(new object[] {
            "Pequeño",
            "Normal (Recomendado)",
            "Grande"});
            this.cmbTamañoFuente.Location = new System.Drawing.Point(153, 50);
            this.cmbTamañoFuente.Name = "cmbTamañoFuente";
            this.cmbTamañoFuente.Size = new System.Drawing.Size(226, 21);
            this.cmbTamañoFuente.TabIndex = 115;
            // 
            // lblTamañoFuente
            // 
            this.lblTamañoFuente.AutoSize = true;
            this.lblTamañoFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTamañoFuente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamañoFuente.Location = new System.Drawing.Point(15, 56);
            this.lblTamañoFuente.Name = "lblTamañoFuente";
            this.lblTamañoFuente.Size = new System.Drawing.Size(107, 15);
            this.lblTamañoFuente.TabIndex = 114;
            this.lblTamañoFuente.Text = "Tamaño de Fuente:";
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(175, 20);
            this.lblSubTitulo3.TabIndex = 111;
            this.lblSubTitulo3.Text = "OPCIONES DE INTERFAZ";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(207, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "INFORMACIÓN DEL SISTEMA";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacion.Location = new System.Drawing.Point(195, 46);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(207, 20);
            this.txtUbicacion.TabIndex = 97;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(14, 51);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(117, 15);
            this.lblNombreSistema.TabIndex = 102;
            this.lblNombreSistema.Text = "Nombre del Sistema:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreArchivo.Location = new System.Drawing.Point(195, 72);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(207, 20);
            this.txtNombreArchivo.TabIndex = 104;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(14, 77);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 105;
            this.lblVersion.Text = "Versión:";
            // 
            // pnlInfoSistema
            // 
            this.pnlInfoSistema.BackColor = System.Drawing.Color.White;
            this.pnlInfoSistema.Controls.Add(this.lblUbicacionBaseDatos);
            this.pnlInfoSistema.Controls.Add(this.lblBaseDatos);
            this.pnlInfoSistema.Controls.Add(this.lblVersion);
            this.pnlInfoSistema.Controls.Add(this.txtNombreArchivo);
            this.pnlInfoSistema.Controls.Add(this.lblNombreSistema);
            this.pnlInfoSistema.Controls.Add(this.txtUbicacion);
            this.pnlInfoSistema.Controls.Add(this.lblSubTitulo);
            this.pnlInfoSistema.Location = new System.Drawing.Point(16, 46);
            this.pnlInfoSistema.Name = "pnlInfoSistema";
            this.pnlInfoSistema.Size = new System.Drawing.Size(455, 137);
            this.pnlInfoSistema.TabIndex = 117;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBaseDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDatos.Location = new System.Drawing.Point(14, 103);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(83, 15);
            this.lblBaseDatos.TabIndex = 107;
            this.lblBaseDatos.Text = "Base de Datos:";
            // 
            // pnlOtrasOpciones
            // 
            this.pnlOtrasOpciones.BackColor = System.Drawing.Color.White;
            this.pnlOtrasOpciones.Controls.Add(this.btnExaminarTemp);
            this.pnlOtrasOpciones.Controls.Add(this.lblDirectorioTem);
            this.pnlOtrasOpciones.Controls.Add(this.txtDirectorioTemp);
            this.pnlOtrasOpciones.Controls.Add(this.chkModoDesarrollo);
            this.pnlOtrasOpciones.Controls.Add(this.chkMostrarMensajesAyuda);
            this.pnlOtrasOpciones.Controls.Add(this.chkConfirmarEliminarRegistros);
            this.pnlOtrasOpciones.Controls.Add(this.lblSubTitulo5);
            this.pnlOtrasOpciones.Location = new System.Drawing.Point(16, 388);
            this.pnlOtrasOpciones.Name = "pnlOtrasOpciones";
            this.pnlOtrasOpciones.Size = new System.Drawing.Size(455, 193);
            this.pnlOtrasOpciones.TabIndex = 119;
            // 
            // btnExaminarTemp
            // 
            this.btnExaminarTemp.BackColor = System.Drawing.Color.White;
            this.btnExaminarTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminarTemp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnExaminarTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnExaminarTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminarTemp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExaminarTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnExaminarTemp.Location = new System.Drawing.Point(385, 152);
            this.btnExaminarTemp.Name = "btnExaminarTemp";
            this.btnExaminarTemp.Size = new System.Drawing.Size(22, 20);
            this.btnExaminarTemp.TabIndex = 121;
            this.btnExaminarTemp.Text = "📁";
            this.btnExaminarTemp.UseVisualStyleBackColor = false;
            // 
            // lblDirectorioTem
            // 
            this.lblDirectorioTem.AutoSize = true;
            this.lblDirectorioTem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDirectorioTem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorioTem.Location = new System.Drawing.Point(15, 134);
            this.lblDirectorioTem.Name = "lblDirectorioTem";
            this.lblDirectorioTem.Size = new System.Drawing.Size(187, 15);
            this.lblDirectorioTem.TabIndex = 120;
            this.lblDirectorioTem.Text = "Directorio de archivos temporales:";
            // 
            // txtDirectorioTemp
            // 
            this.txtDirectorioTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectorioTemp.Location = new System.Drawing.Point(18, 152);
            this.txtDirectorioTemp.Name = "txtDirectorioTemp";
            this.txtDirectorioTemp.Size = new System.Drawing.Size(361, 20);
            this.txtDirectorioTemp.TabIndex = 119;
            // 
            // chkModoDesarrollo
            // 
            this.chkModoDesarrollo.AutoSize = true;
            this.chkModoDesarrollo.Location = new System.Drawing.Point(17, 98);
            this.chkModoDesarrollo.Name = "chkModoDesarrollo";
            this.chkModoDesarrollo.Size = new System.Drawing.Size(157, 17);
            this.chkModoDesarrollo.TabIndex = 118;
            this.chkModoDesarrollo.Text = "Modo de desarrollo (Debug)";
            this.chkModoDesarrollo.UseVisualStyleBackColor = true;
            // 
            // chkMostrarMensajesAyuda
            // 
            this.chkMostrarMensajesAyuda.AutoSize = true;
            this.chkMostrarMensajesAyuda.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMostrarMensajesAyuda.Location = new System.Drawing.Point(17, 75);
            this.chkMostrarMensajesAyuda.Name = "chkMostrarMensajesAyuda";
            this.chkMostrarMensajesAyuda.Size = new System.Drawing.Size(155, 17);
            this.chkMostrarMensajesAyuda.TabIndex = 117;
            this.chkMostrarMensajesAyuda.Text = "Mostrar mensajes de ayuda";
            this.chkMostrarMensajesAyuda.UseVisualStyleBackColor = true;
            // 
            // chkConfirmarEliminarRegistros
            // 
            this.chkConfirmarEliminarRegistros.AutoSize = true;
            this.chkConfirmarEliminarRegistros.Location = new System.Drawing.Point(17, 52);
            this.chkConfirmarEliminarRegistros.Name = "chkConfirmarEliminarRegistros";
            this.chkConfirmarEliminarRegistros.Size = new System.Drawing.Size(194, 17);
            this.chkConfirmarEliminarRegistros.TabIndex = 116;
            this.chkConfirmarEliminarRegistros.Text = "Confirmar antes de eliminar registros";
            this.chkConfirmarEliminarRegistros.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo5
            // 
            this.lblSubTitulo5.AutoSize = true;
            this.lblSubTitulo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo5.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo5.Name = "lblSubTitulo5";
            this.lblSubTitulo5.Size = new System.Drawing.Size(130, 20);
            this.lblSubTitulo5.TabIndex = 111;
            this.lblSubTitulo5.Text = "OTRAS OPCIONES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(991, 549);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 123;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(841, 549);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 32);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlOtrasOpciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlSeguridad);
            this.Controls.Add(this.pnlFormato);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlOpcionesInterfaz);
            this.Controls.Add(this.pnlInfoSistema);
            this.Name = "FormGeneral";
            this.Text = "FormGeneral";
            this.pnlSeguridad.ResumeLayout(false);
            this.pnlSeguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInactividad)).EndInit();
            this.pnlFormato.ResumeLayout(false);
            this.pnlFormato.PerformLayout();
            this.pnlOpcionesInterfaz.ResumeLayout(false);
            this.pnlOpcionesInterfaz.PerformLayout();
            this.pnlInfoSistema.ResumeLayout(false);
            this.pnlInfoSistema.PerformLayout();
            this.pnlOtrasOpciones.ResumeLayout(false);
            this.pnlOtrasOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeguridad;
        private System.Windows.Forms.Label lblSubTitulo4;
        private System.Windows.Forms.Panel pnlFormato;
        private System.Windows.Forms.Label lblUbicacionBaseDatos;
        private System.Windows.Forms.Label lblZonaHoraria;
        private System.Windows.Forms.ComboBox cmbDiaEnvio;
        private System.Windows.Forms.Label lblFormatoFecha;
        private System.Windows.Forms.RadioButton rbComa;
        private System.Windows.Forms.RadioButton rbPunto;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlOpcionesInterfaz;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlInfoSistema;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.ComboBox cmbZonaHoraria;
        private System.Windows.Forms.Label lblSeparadorDecimal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFormatoHora;
        private System.Windows.Forms.ComboBox cmbTamañoFuente;
        private System.Windows.Forms.Label lblTamañoFuente;
        private System.Windows.Forms.CheckBox chkIniciarWindows;
        private System.Windows.Forms.CheckBox chkSonidosSistema;
        private System.Windows.Forms.CheckBox chkMostrarNotificacionPantalla;
        private System.Windows.Forms.CheckBox chkRegistrarAcciones;
        private System.Windows.Forms.CheckBox chkCerrarSesionMinimizar;
        private System.Windows.Forms.Label lblTiempoInactividad;
        private System.Windows.Forms.CheckBox chkSolicitarContraseña;
        private System.Windows.Forms.Panel pnlOtrasOpciones;
        private System.Windows.Forms.CheckBox chkModoDesarrollo;
        private System.Windows.Forms.CheckBox chkMostrarMensajesAyuda;
        private System.Windows.Forms.CheckBox chkConfirmarEliminarRegistros;
        private System.Windows.Forms.Label lblSubTitulo5;
        private System.Windows.Forms.Button btnExaminarTemp;
        private System.Windows.Forms.Label lblDirectorioTem;
        private System.Windows.Forms.TextBox txtDirectorioTemp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown numInactividad;
    }
}