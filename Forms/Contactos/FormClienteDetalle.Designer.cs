namespace SistemaPOS.Forms.Contactos
{
    partial class FormClienteDetalle
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlDatosIdentificacion = new System.Windows.Forms.Panel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblParaEmpresa = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblPersonaNatural = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.rbCEE = new System.Windows.Forms.RadioButton();
            this.rbRUC = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pnlDatosContacto = new System.Windows.Forms.Panel();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.pnlConfigCredito = new System.Windows.Forms.Panel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblCeroSoloContado = new System.Windows.Forms.Label();
            this.chkClienteActivo = new System.Windows.Forms.CheckBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlDatosIdentificacion.SuspendLayout();
            this.pnlDatosContacto.SuspendLayout();
            this.pnlConfigCredito.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(734, 68);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Cliente / Editar Cliente";
            //
            // lblHeaderSub
            //
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(22, 42);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(220, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Registro y datos del cliente";
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnGuardar);
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 727);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(734, 55);
            this.pnlFooter.TabIndex = 1;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(242, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 32);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(372, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // pnlDatosIdentificacion
            //
            this.pnlDatosIdentificacion.BackColor = System.Drawing.Color.White;
            this.pnlDatosIdentificacion.Controls.Add(this.lblRazonSocial);
            this.pnlDatosIdentificacion.Controls.Add(this.txtRazonSocial);
            this.pnlDatosIdentificacion.Controls.Add(this.lblParaEmpresa);
            this.pnlDatosIdentificacion.Controls.Add(this.lblApellidos);
            this.pnlDatosIdentificacion.Controls.Add(this.txtApellidos);
            this.pnlDatosIdentificacion.Controls.Add(this.lblNombres);
            this.pnlDatosIdentificacion.Controls.Add(this.btnBuscar);
            this.pnlDatosIdentificacion.Controls.Add(this.txtNombres);
            this.pnlDatosIdentificacion.Controls.Add(this.lblPersonaNatural);
            this.pnlDatosIdentificacion.Controls.Add(this.txtNumeroDoc);
            this.pnlDatosIdentificacion.Controls.Add(this.lblNumeroDoc);
            this.pnlDatosIdentificacion.Controls.Add(this.rbCEE);
            this.pnlDatosIdentificacion.Controls.Add(this.rbRUC);
            this.pnlDatosIdentificacion.Controls.Add(this.rbDNI);
            this.pnlDatosIdentificacion.Controls.Add(this.lblTipoDoc);
            this.pnlDatosIdentificacion.Controls.Add(this.lblSubTitulo);
            this.pnlDatosIdentificacion.Location = new System.Drawing.Point(16, 80);
            this.pnlDatosIdentificacion.Name = "pnlDatosIdentificacion";
            this.pnlDatosIdentificacion.Size = new System.Drawing.Size(708, 289);
            this.pnlDatosIdentificacion.TabIndex = 127;
            //
            // lblSubTitulo
            //
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(175, 15);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "DATOS DE IDENTIFICACIÓN";
            //
            // lblTipoDoc
            //
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTipoDoc.Location = new System.Drawing.Point(13, 49);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(103, 15);
            this.lblTipoDoc.TabIndex = 110;
            this.lblTipoDoc.Text = "Tipo Documento:";
            //
            // rbDNI
            //
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.rbDNI.Location = new System.Drawing.Point(152, 48);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 156;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            //
            // rbRUC
            //
            this.rbRUC.AutoSize = true;
            this.rbRUC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.rbRUC.Location = new System.Drawing.Point(216, 48);
            this.rbRUC.Name = "rbRUC";
            this.rbRUC.Size = new System.Drawing.Size(48, 17);
            this.rbRUC.TabIndex = 157;
            this.rbRUC.TabStop = true;
            this.rbRUC.Text = "RUC";
            this.rbRUC.UseVisualStyleBackColor = true;
            //
            // rbCEE
            //
            this.rbCEE.AutoSize = true;
            this.rbCEE.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.rbCEE.Location = new System.Drawing.Point(284, 48);
            this.rbCEE.Name = "rbCEE";
            this.rbCEE.Size = new System.Drawing.Size(46, 17);
            this.rbCEE.TabIndex = 158;
            this.rbCEE.TabStop = true;
            this.rbCEE.Text = "CEE";
            this.rbCEE.UseVisualStyleBackColor = true;
            //
            // txtNumeroDoc
            //
            this.txtNumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDoc.Location = new System.Drawing.Point(129, 79);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(484, 24);
            this.txtNumeroDoc.TabIndex = 128;
            //
            // lblNumeroDoc
            //
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroDoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNumeroDoc.Location = new System.Drawing.Point(13, 82);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(92, 15);
            this.lblNumeroDoc.TabIndex = 129;
            this.lblNumeroDoc.Text = "N° Documento:";
            //
            // btnBuscar
            //
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnBuscar.FlatAppearance.BorderSize = 1;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(618, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnBuscar.TabIndex = 170;
            this.btnBuscar.Text = "🔍";
            this.btnBuscar.UseVisualStyleBackColor = false;
            //
            // lblPersonaNatural
            //
            this.lblPersonaNatural.AutoSize = true;
            this.lblPersonaNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonaNatural.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaNatural.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblPersonaNatural.Location = new System.Drawing.Point(13, 121);
            this.lblPersonaNatural.Name = "lblPersonaNatural";
            this.lblPersonaNatural.Size = new System.Drawing.Size(227, 15);
            this.lblPersonaNatural.TabIndex = 160;
            this.lblPersonaNatural.Text = "";
            //
            // txtNombres
            //
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(129, 152);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(484, 24);
            this.txtNombres.TabIndex = 159;
            //
            // lblNombres
            //
            this.lblNombres.AutoSize = true;
            this.lblNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNombres.Location = new System.Drawing.Point(13, 154);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(60, 15);
            this.lblNombres.TabIndex = 171;
            this.lblNombres.Text = "Nombres:";
            //
            // txtApellidos
            //
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(129, 180);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(484, 24);
            this.txtApellidos.TabIndex = 172;
            //
            // lblApellidos
            //
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblApellidos.Location = new System.Drawing.Point(13, 185);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(61, 15);
            this.lblApellidos.TabIndex = 173;
            this.lblApellidos.Text = "Apellidos:";
            //
            // lblParaEmpresa
            //
            this.lblParaEmpresa.AutoSize = true;
            this.lblParaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParaEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblParaEmpresa.Location = new System.Drawing.Point(13, 224);
            this.lblParaEmpresa.Name = "lblParaEmpresa";
            this.lblParaEmpresa.Size = new System.Drawing.Size(163, 15);
            this.lblParaEmpresa.TabIndex = 178;
            this.lblParaEmpresa.Text = "";
            //
            // lblRazonSocial
            //
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblRazonSocial.Location = new System.Drawing.Point(13, 255);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(84, 15);
            this.lblRazonSocial.TabIndex = 180;
            this.lblRazonSocial.Text = "Razón Social:";
            //
            // txtRazonSocial
            //
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(129, 253);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(484, 24);
            this.txtRazonSocial.TabIndex = 179;
            //
            // pnlDatosContacto
            //
            this.pnlDatosContacto.BackColor = System.Drawing.Color.White;
            this.pnlDatosContacto.Controls.Add(this.lblSubTitulo2);
            this.pnlDatosContacto.Controls.Add(this.txtEmail);
            this.pnlDatosContacto.Controls.Add(this.lblEmail);
            this.pnlDatosContacto.Controls.Add(this.txtDireccion);
            this.pnlDatosContacto.Controls.Add(this.lblDireccion);
            this.pnlDatosContacto.Controls.Add(this.txtTelefono);
            this.pnlDatosContacto.Controls.Add(this.lblTelefono);
            this.pnlDatosContacto.Location = new System.Drawing.Point(16, 375);
            this.pnlDatosContacto.Name = "pnlDatosContacto";
            this.pnlDatosContacto.Size = new System.Drawing.Size(708, 169);
            this.pnlDatosContacto.TabIndex = 171;
            //
            // lblSubTitulo2
            //
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(150, 15);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "DATOS DE CONTACTO";
            //
            // txtDireccion
            //
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(129, 46);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(484, 24);
            this.txtDireccion.TabIndex = 161;
            //
            // lblDireccion
            //
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblDireccion.Location = new System.Drawing.Point(13, 49);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 15);
            this.lblDireccion.TabIndex = 162;
            this.lblDireccion.Text = "Dirección:";
            //
            // txtTelefono
            //
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(129, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(484, 24);
            this.txtTelefono.TabIndex = 166;
            //
            // lblTelefono
            //
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTelefono.Location = new System.Drawing.Point(13, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 15);
            this.lblTelefono.TabIndex = 167;
            this.lblTelefono.Text = "Teléfono:";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(129, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(484, 24);
            this.txtEmail.TabIndex = 168;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblEmail.Location = new System.Drawing.Point(13, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 15);
            this.lblEmail.TabIndex = 169;
            this.lblEmail.Text = "Email:";
            //
            // pnlConfigCredito
            //
            this.pnlConfigCredito.BackColor = System.Drawing.Color.White;
            this.pnlConfigCredito.Controls.Add(this.lblDetalle);
            this.pnlConfigCredito.Controls.Add(this.lblCeroSoloContado);
            this.pnlConfigCredito.Controls.Add(this.chkClienteActivo);
            this.pnlConfigCredito.Controls.Add(this.txtLimiteCredito);
            this.pnlConfigCredito.Controls.Add(this.lblLimiteCredito);
            this.pnlConfigCredito.Controls.Add(this.lblSubTitulo3);
            this.pnlConfigCredito.Location = new System.Drawing.Point(16, 550);
            this.pnlConfigCredito.Name = "pnlConfigCredito";
            this.pnlConfigCredito.Size = new System.Drawing.Size(708, 171);
            this.pnlConfigCredito.TabIndex = 172;
            //
            // lblSubTitulo3
            //
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(13, 17);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(195, 15);
            this.lblSubTitulo3.TabIndex = 170;
            this.lblSubTitulo3.Text = "CONFIGURACIÓN DE CRÉDITO";
            //
            // txtLimiteCredito
            //
            this.txtLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteCredito.Location = new System.Drawing.Point(129, 53);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(79, 24);
            this.txtLimiteCredito.TabIndex = 170;
            //
            // lblLimiteCredito
            //
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimiteCredito.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblLimiteCredito.Location = new System.Drawing.Point(13, 54);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(105, 15);
            this.lblLimiteCredito.TabIndex = 171;
            this.lblLimiteCredito.Text = "Límite de Crédito:";
            //
            // lblCeroSoloContado
            //
            this.lblCeroSoloContado.AutoSize = true;
            this.lblCeroSoloContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCeroSoloContado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeroSoloContado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblCeroSoloContado.Location = new System.Drawing.Point(225, 54);
            this.lblCeroSoloContado.Name = "lblCeroSoloContado";
            this.lblCeroSoloContado.Size = new System.Drawing.Size(126, 15);
            this.lblCeroSoloContado.TabIndex = 172;
            this.lblCeroSoloContado.Text = "(S/ 0 = Solo contado)";
            //
            // chkClienteActivo
            //
            this.chkClienteActivo.AutoSize = true;
            this.chkClienteActivo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClienteActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.chkClienteActivo.Location = new System.Drawing.Point(16, 139);
            this.chkClienteActivo.Name = "chkClienteActivo";
            this.chkClienteActivo.Size = new System.Drawing.Size(90, 17);
            this.chkClienteActivo.TabIndex = 171;
            this.chkClienteActivo.Text = "Cliente activo";
            this.chkClienteActivo.UseVisualStyleBackColor = true;
            //
            // lblDetalle
            //
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblDetalle.Location = new System.Drawing.Point(14, 89);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(528, 30);
            this.lblDetalle.TabIndex = 173;
            this.lblDetalle.Text = "ℹ️  El límite de crédito es el monto máximo que este cliente puede deber. Si exce" +
    "de este límite,\r\nno podrá comprar a crédito hasta que cancele la deuda.";
            //
            // FormClienteDetalle
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(734, 782);
            this.Controls.Add(this.pnlDatosIdentificacion);
            this.Controls.Add(this.pnlDatosContacto);
            this.Controls.Add(this.pnlConfigCredito);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClienteDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlDatosIdentificacion.ResumeLayout(false);
            this.pnlDatosIdentificacion.PerformLayout();
            this.pnlDatosContacto.ResumeLayout(false);
            this.pnlDatosContacto.PerformLayout();
            this.pnlConfigCredito.ResumeLayout(false);
            this.pnlConfigCredito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlDatosIdentificacion;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.RadioButton rbCEE;
        private System.Windows.Forms.RadioButton rbRUC;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblPersonaNatural;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblParaEmpresa;
        private System.Windows.Forms.Panel pnlDatosContacto;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlConfigCredito;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblCeroSoloContado;
        private System.Windows.Forms.CheckBox chkClienteActivo;
        private System.Windows.Forms.Label lblDetalle;
    }
}
