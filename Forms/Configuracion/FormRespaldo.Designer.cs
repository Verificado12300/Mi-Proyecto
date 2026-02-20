namespace SistemaPOS.Forms.Configuracion
{
    partial class FormRespaldo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRestaurarBaseDatos = new System.Windows.Forms.Panel();
            this.btnRestaurarDatos = new System.Windows.Forms.Button();
            this.btnArchivoRespaldo = new System.Windows.Forms.Button();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.lblArchivoRespaldo = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.txtArchivoRespaldo = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.pnlRespaldoManual = new System.Windows.Forms.Panel();
            this.btnCrearRespaldo = new System.Windows.Forms.Button();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnUbicacionRespaldo = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.chkIncluirConfiguraciones = new System.Windows.Forms.CheckBox();
            this.chkIncluirDatosInventario = new System.Windows.Forms.CheckBox();
            this.chkIncluirDatosVentas = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlRespaldoAuto = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblRespaldos = new System.Windows.Forms.Label();
            this.lblConservarUltimos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDiasRespaldo = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cmbDiaEnvio = new System.Windows.Forms.ComboBox();
            this.lblDiaEnvio = new System.Windows.Forms.Label();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.rbSemanal = new System.Windows.Forms.RadioButton();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.chkActivarRespaldoAuto = new System.Windows.Forms.CheckBox();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.dgvHistorialRespaldos = new System.Windows.Forms.DataGridView();
            this.colFechayHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHistorialRespaldos = new System.Windows.Forms.Panel();
            this.lblSubTitulo4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlRestaurarBaseDatos.SuspendLayout();
            this.pnlRespaldoManual.SuspendLayout();
            this.pnlRespaldoAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRespaldos)).BeginInit();
            this.pnlHistorialRespaldos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRestaurarBaseDatos
            // 
            this.pnlRestaurarBaseDatos.BackColor = System.Drawing.Color.White;
            this.pnlRestaurarBaseDatos.Controls.Add(this.btnRestaurarDatos);
            this.pnlRestaurarBaseDatos.Controls.Add(this.btnArchivoRespaldo);
            this.pnlRestaurarBaseDatos.Controls.Add(this.lblSubTitulo3);
            this.pnlRestaurarBaseDatos.Controls.Add(this.lblArchivoRespaldo);
            this.pnlRestaurarBaseDatos.Controls.Add(this.lblAdvertencia);
            this.pnlRestaurarBaseDatos.Controls.Add(this.txtArchivoRespaldo);
            this.pnlRestaurarBaseDatos.Location = new System.Drawing.Point(16, 324);
            this.pnlRestaurarBaseDatos.Name = "pnlRestaurarBaseDatos";
            this.pnlRestaurarBaseDatos.Size = new System.Drawing.Size(455, 237);
            this.pnlRestaurarBaseDatos.TabIndex = 72;
            // 
            // btnRestaurarDatos
            // 
            this.btnRestaurarDatos.BackColor = System.Drawing.Color.White;
            this.btnRestaurarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnRestaurarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnRestaurarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarDatos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRestaurarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnRestaurarDatos.Location = new System.Drawing.Point(171, 189);
            this.btnRestaurarDatos.Name = "btnRestaurarDatos";
            this.btnRestaurarDatos.Size = new System.Drawing.Size(113, 31);
            this.btnRestaurarDatos.TabIndex = 107;
            this.btnRestaurarDatos.Text = "Restaurar";
            this.btnRestaurarDatos.UseVisualStyleBackColor = false;
            // 
            // btnArchivoRespaldo
            // 
            this.btnArchivoRespaldo.BackColor = System.Drawing.Color.White;
            this.btnArchivoRespaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivoRespaldo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnArchivoRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnArchivoRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivoRespaldo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnArchivoRespaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnArchivoRespaldo.Location = new System.Drawing.Point(384, 72);
            this.btnArchivoRespaldo.Name = "btnArchivoRespaldo";
            this.btnArchivoRespaldo.Size = new System.Drawing.Size(22, 20);
            this.btnArchivoRespaldo.TabIndex = 114;
            this.btnArchivoRespaldo.Text = "📁";
            this.btnArchivoRespaldo.UseVisualStyleBackColor = false;
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(202, 20);
            this.lblSubTitulo3.TabIndex = 111;
            this.lblSubTitulo3.Text = "RESTAURAR BASE DE DATOS";
            // 
            // lblArchivoRespaldo
            // 
            this.lblArchivoRespaldo.AutoSize = true;
            this.lblArchivoRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArchivoRespaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoRespaldo.Location = new System.Drawing.Point(14, 54);
            this.lblArchivoRespaldo.Name = "lblArchivoRespaldo";
            this.lblArchivoRespaldo.Size = new System.Drawing.Size(115, 15);
            this.lblArchivoRespaldo.TabIndex = 113;
            this.lblArchivoRespaldo.Text = "Archivo de respaldo:";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdvertencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(14, 133);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(358, 30);
            this.lblAdvertencia.TabIndex = 115;
            this.lblAdvertencia.Text = "⚠️ ADVERTENCIA: Esta acción reemplazará todos los datos actuales\r\ncon el respaldo" +
    " seleccionado";
            // 
            // txtArchivoRespaldo
            // 
            this.txtArchivoRespaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArchivoRespaldo.Location = new System.Drawing.Point(17, 72);
            this.txtArchivoRespaldo.Name = "txtArchivoRespaldo";
            this.txtArchivoRespaldo.Size = new System.Drawing.Size(361, 20);
            this.txtArchivoRespaldo.TabIndex = 112;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacion.Location = new System.Drawing.Point(17, 69);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(361, 20);
            this.txtUbicacion.TabIndex = 97;
            // 
            // pnlRespaldoManual
            // 
            this.pnlRespaldoManual.BackColor = System.Drawing.Color.White;
            this.pnlRespaldoManual.Controls.Add(this.btnCrearRespaldo);
            this.pnlRespaldoManual.Controls.Add(this.lblNombreArchivo);
            this.pnlRespaldoManual.Controls.Add(this.txtNombreArchivo);
            this.pnlRespaldoManual.Controls.Add(this.btnUbicacionRespaldo);
            this.pnlRespaldoManual.Controls.Add(this.lblUbicacion);
            this.pnlRespaldoManual.Controls.Add(this.txtUbicacion);
            this.pnlRespaldoManual.Controls.Add(this.chkIncluirConfiguraciones);
            this.pnlRespaldoManual.Controls.Add(this.chkIncluirDatosInventario);
            this.pnlRespaldoManual.Controls.Add(this.chkIncluirDatosVentas);
            this.pnlRespaldoManual.Controls.Add(this.lblSubTitulo);
            this.pnlRespaldoManual.Location = new System.Drawing.Point(16, 46);
            this.pnlRespaldoManual.Name = "pnlRespaldoManual";
            this.pnlRespaldoManual.Size = new System.Drawing.Size(455, 272);
            this.pnlRespaldoManual.TabIndex = 70;
            // 
            // btnCrearRespaldo
            // 
            this.btnCrearRespaldo.BackColor = System.Drawing.Color.White;
            this.btnCrearRespaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearRespaldo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnCrearRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnCrearRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRespaldo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCrearRespaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnCrearRespaldo.Location = new System.Drawing.Point(171, 231);
            this.btnCrearRespaldo.Name = "btnCrearRespaldo";
            this.btnCrearRespaldo.Size = new System.Drawing.Size(113, 31);
            this.btnCrearRespaldo.TabIndex = 106;
            this.btnCrearRespaldo.Text = "Crear Respaldo";
            this.btnCrearRespaldo.UseVisualStyleBackColor = false;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(14, 95);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(115, 15);
            this.lblNombreArchivo.TabIndex = 105;
            this.lblNombreArchivo.Text = "Nombre del archivo:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreArchivo.Location = new System.Drawing.Point(17, 113);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(361, 20);
            this.txtNombreArchivo.TabIndex = 104;
            // 
            // btnUbicacionRespaldo
            // 
            this.btnUbicacionRespaldo.BackColor = System.Drawing.Color.White;
            this.btnUbicacionRespaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbicacionRespaldo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnUbicacionRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnUbicacionRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacionRespaldo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUbicacionRespaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnUbicacionRespaldo.Location = new System.Drawing.Point(384, 69);
            this.btnUbicacionRespaldo.Name = "btnUbicacionRespaldo";
            this.btnUbicacionRespaldo.Size = new System.Drawing.Size(22, 20);
            this.btnUbicacionRespaldo.TabIndex = 103;
            this.btnUbicacionRespaldo.Text = "📁";
            this.btnUbicacionRespaldo.UseVisualStyleBackColor = false;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(14, 51);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(132, 15);
            this.lblUbicacion.TabIndex = 102;
            this.lblUbicacion.Text = "Ubicación de respaldos:";
            // 
            // chkIncluirConfiguraciones
            // 
            this.chkIncluirConfiguraciones.AutoSize = true;
            this.chkIncluirConfiguraciones.Location = new System.Drawing.Point(17, 205);
            this.chkIncluirConfiguraciones.Name = "chkIncluirConfiguraciones";
            this.chkIncluirConfiguraciones.Size = new System.Drawing.Size(132, 17);
            this.chkIncluirConfiguraciones.TabIndex = 86;
            this.chkIncluirConfiguraciones.Text = "Incluir configuraciones";
            this.chkIncluirConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // chkIncluirDatosInventario
            // 
            this.chkIncluirDatosInventario.AutoSize = true;
            this.chkIncluirDatosInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIncluirDatosInventario.Location = new System.Drawing.Point(17, 182);
            this.chkIncluirDatosInventario.Name = "chkIncluirDatosInventario";
            this.chkIncluirDatosInventario.Size = new System.Drawing.Size(147, 17);
            this.chkIncluirDatosInventario.TabIndex = 85;
            this.chkIncluirDatosInventario.Text = "Incluir datos de inventario";
            this.chkIncluirDatosInventario.UseVisualStyleBackColor = true;
            // 
            // chkIncluirDatosVentas
            // 
            this.chkIncluirDatosVentas.AutoSize = true;
            this.chkIncluirDatosVentas.Location = new System.Drawing.Point(17, 159);
            this.chkIncluirDatosVentas.Name = "chkIncluirDatosVentas";
            this.chkIncluirDatosVentas.Size = new System.Drawing.Size(133, 17);
            this.chkIncluirDatosVentas.TabIndex = 84;
            this.chkIncluirDatosVentas.Text = "Incluir datos de ventas";
            this.chkIncluirDatosVentas.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(149, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "RESPALDO MANUAL";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 21);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "Respaldo y Restauración";
            // 
            // pnlRespaldoAuto
            // 
            this.pnlRespaldoAuto.BackColor = System.Drawing.Color.White;
            this.pnlRespaldoAuto.Controls.Add(this.lblMensaje);
            this.pnlRespaldoAuto.Controls.Add(this.lblRespaldos);
            this.pnlRespaldoAuto.Controls.Add(this.lblConservarUltimos);
            this.pnlRespaldoAuto.Controls.Add(this.lblHora);
            this.pnlRespaldoAuto.Controls.Add(this.txtDiasRespaldo);
            this.pnlRespaldoAuto.Controls.Add(this.dtpHora);
            this.pnlRespaldoAuto.Controls.Add(this.cmbDiaEnvio);
            this.pnlRespaldoAuto.Controls.Add(this.lblDiaEnvio);
            this.pnlRespaldoAuto.Controls.Add(this.rbMensual);
            this.pnlRespaldoAuto.Controls.Add(this.lblFrecuencia);
            this.pnlRespaldoAuto.Controls.Add(this.rbSemanal);
            this.pnlRespaldoAuto.Controls.Add(this.rbDiario);
            this.pnlRespaldoAuto.Controls.Add(this.chkActivarRespaldoAuto);
            this.pnlRespaldoAuto.Controls.Add(this.lblSubTitulo2);
            this.pnlRespaldoAuto.Location = new System.Drawing.Point(477, 46);
            this.pnlRespaldoAuto.Name = "pnlRespaldoAuto";
            this.pnlRespaldoAuto.Size = new System.Drawing.Size(634, 272);
            this.pnlRespaldoAuto.TabIndex = 102;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(14, 220);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(267, 15);
            this.lblMensaje.TabIndex = 110;
            this.lblMensaje.Text = "(Los más antiguos se eliminan automáticamente)";
            // 
            // lblRespaldos
            // 
            this.lblRespaldos.AutoSize = true;
            this.lblRespaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespaldos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespaldos.Location = new System.Drawing.Point(170, 192);
            this.lblRespaldos.Name = "lblRespaldos";
            this.lblRespaldos.Size = new System.Drawing.Size(60, 15);
            this.lblRespaldos.TabIndex = 109;
            this.lblRespaldos.Text = "Respaldos";
            // 
            // lblConservarUltimos
            // 
            this.lblConservarUltimos.AutoSize = true;
            this.lblConservarUltimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConservarUltimos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConservarUltimos.Location = new System.Drawing.Point(14, 192);
            this.lblConservarUltimos.Name = "lblConservarUltimos";
            this.lblConservarUltimos.Size = new System.Drawing.Size(106, 15);
            this.lblConservarUltimos.TabIndex = 108;
            this.lblConservarUltimos.Text = "Conservar últimos:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(211, 147);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 15);
            this.lblHora.TabIndex = 95;
            this.lblHora.Text = "Hora:";
            // 
            // txtDiasRespaldo
            // 
            this.txtDiasRespaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiasRespaldo.Location = new System.Drawing.Point(129, 189);
            this.txtDiasRespaldo.Name = "txtDiasRespaldo";
            this.txtDiasRespaldo.Size = new System.Drawing.Size(35, 20);
            this.txtDiasRespaldo.TabIndex = 107;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(269, 144);
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
            this.cmbDiaEnvio.Location = new System.Drawing.Point(49, 144);
            this.cmbDiaEnvio.Name = "cmbDiaEnvio";
            this.cmbDiaEnvio.Size = new System.Drawing.Size(129, 21);
            this.cmbDiaEnvio.TabIndex = 93;
            // 
            // lblDiaEnvio
            // 
            this.lblDiaEnvio.AutoSize = true;
            this.lblDiaEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiaEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaEnvio.Location = new System.Drawing.Point(14, 147);
            this.lblDiaEnvio.Name = "lblDiaEnvio";
            this.lblDiaEnvio.Size = new System.Drawing.Size(27, 15);
            this.lblDiaEnvio.TabIndex = 92;
            this.lblDiaEnvio.Text = "Día:";
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(335, 101);
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
            this.lblFrecuencia.Location = new System.Drawing.Point(14, 102);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(67, 15);
            this.lblFrecuencia.TabIndex = 83;
            this.lblFrecuencia.Text = "Frecuencia:";
            // 
            // rbSemanal
            // 
            this.rbSemanal.AutoSize = true;
            this.rbSemanal.Location = new System.Drawing.Point(227, 101);
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
            this.rbDiario.Location = new System.Drawing.Point(126, 101);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 82;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            // 
            // chkActivarRespaldoAuto
            // 
            this.chkActivarRespaldoAuto.AutoSize = true;
            this.chkActivarRespaldoAuto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivarRespaldoAuto.Location = new System.Drawing.Point(17, 57);
            this.chkActivarRespaldoAuto.Name = "chkActivarRespaldoAuto";
            this.chkActivarRespaldoAuto.Size = new System.Drawing.Size(195, 21);
            this.chkActivarRespaldoAuto.TabIndex = 81;
            this.chkActivarRespaldoAuto.Text = "Activar Respaldo Automático";
            this.chkActivarRespaldoAuto.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(179, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "RESPALDO AUTOMÁTICO";
            // 
            // dgvHistorialRespaldos
            // 
            this.dgvHistorialRespaldos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorialRespaldos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialRespaldos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHistorialRespaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialRespaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechayHora,
            this.colTamaño,
            this.colUbicacion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialRespaldos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialRespaldos.EnableHeadersVisualStyles = false;
            this.dgvHistorialRespaldos.Location = new System.Drawing.Point(-1, 54);
            this.dgvHistorialRespaldos.Name = "dgvHistorialRespaldos";
            this.dgvHistorialRespaldos.RowHeadersVisible = false;
            this.dgvHistorialRespaldos.RowTemplate.Height = 50;
            this.dgvHistorialRespaldos.Size = new System.Drawing.Size(634, 178);
            this.dgvHistorialRespaldos.TabIndex = 103;
            // 
            // colFechayHora
            // 
            this.colFechayHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFechayHora.HeaderText = "Fecha y Hora";
            this.colFechayHora.Name = "colFechayHora";
            this.colFechayHora.ReadOnly = true;
            this.colFechayHora.Width = 150;
            // 
            // colTamaño
            // 
            this.colTamaño.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTamaño.HeaderText = "Tamaño";
            this.colTamaño.Name = "colTamaño";
            this.colTamaño.ReadOnly = true;
            this.colTamaño.Width = 150;
            // 
            // colUbicacion
            // 
            this.colUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUbicacion.HeaderText = "Ubicación";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            // 
            // pnlHistorialRespaldos
            // 
            this.pnlHistorialRespaldos.BackColor = System.Drawing.Color.White;
            this.pnlHistorialRespaldos.Controls.Add(this.lblSubTitulo4);
            this.pnlHistorialRespaldos.Controls.Add(this.dgvHistorialRespaldos);
            this.pnlHistorialRespaldos.Location = new System.Drawing.Point(477, 324);
            this.pnlHistorialRespaldos.Name = "pnlHistorialRespaldos";
            this.pnlHistorialRespaldos.Size = new System.Drawing.Size(634, 237);
            this.pnlHistorialRespaldos.TabIndex = 116;
            // 
            // lblSubTitulo4
            // 
            this.lblSubTitulo4.AutoSize = true;
            this.lblSubTitulo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo4.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo4.Name = "lblSubTitulo4";
            this.lblSubTitulo4.Size = new System.Drawing.Size(187, 20);
            this.lblSubTitulo4.TabIndex = 116;
            this.lblSubTitulo4.Text = "HISTORIAL DE RESPALDOS";
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
            this.btnCancelar.Location = new System.Drawing.Point(991, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 108;
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
            this.btnGuardar.Location = new System.Drawing.Point(841, 570);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 32);
            this.btnGuardar.TabIndex = 107;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlHistorialRespaldos);
            this.Controls.Add(this.pnlRespaldoAuto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlRestaurarBaseDatos);
            this.Controls.Add(this.pnlRespaldoManual);
            this.Name = "FormRespaldo";
            this.Text = "FormRespaldo";
            this.pnlRestaurarBaseDatos.ResumeLayout(false);
            this.pnlRestaurarBaseDatos.PerformLayout();
            this.pnlRespaldoManual.ResumeLayout(false);
            this.pnlRespaldoManual.PerformLayout();
            this.pnlRespaldoAuto.ResumeLayout(false);
            this.pnlRespaldoAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialRespaldos)).EndInit();
            this.pnlHistorialRespaldos.ResumeLayout(false);
            this.pnlHistorialRespaldos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRestaurarBaseDatos;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Panel pnlRespaldoManual;
        private System.Windows.Forms.CheckBox chkIncluirConfiguraciones;
        private System.Windows.Forms.CheckBox chkIncluirDatosInventario;
        private System.Windows.Forms.CheckBox chkIncluirDatosVentas;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnUbicacionRespaldo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnCrearRespaldo;
        private System.Windows.Forms.Panel pnlRespaldoAuto;
        private System.Windows.Forms.Label lblConservarUltimos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDiasRespaldo;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ComboBox cmbDiaEnvio;
        private System.Windows.Forms.Label lblDiaEnvio;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.RadioButton rbSemanal;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.CheckBox chkActivarRespaldoAuto;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblRespaldos;
        private System.Windows.Forms.Button btnArchivoRespaldo;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.Label lblArchivoRespaldo;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox txtArchivoRespaldo;
        private System.Windows.Forms.Button btnRestaurarDatos;
        private System.Windows.Forms.DataGridView dgvHistorialRespaldos;
        private System.Windows.Forms.Panel pnlHistorialRespaldos;
        private System.Windows.Forms.Label lblSubTitulo4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechayHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}