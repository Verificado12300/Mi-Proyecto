namespace SistemaPOS.Forms.Configuracion
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.chkUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkEliminarRegistros = new System.Windows.Forms.CheckBox();
            this.chkAnularVentas = new System.Windows.Forms.CheckBox();
            this.chkAplicarDescuentos = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAccionesEspeciales = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkAccederFueraHorario = new System.Windows.Forms.CheckBox();
            this.chkModificarPrecios = new System.Windows.Forms.CheckBox();
            this.chkVerCostos = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkCompras = new System.Windows.Forms.CheckBox();
            this.chkClientes = new System.Windows.Forms.CheckBox();
            this.chkVentas = new System.Windows.Forms.CheckBox();
            this.lblPermisosModulos = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRolBase = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.chkFinanzas = new System.Windows.Forms.CheckBox();
            this.chkProveedores = new System.Windows.Forms.CheckBox();
            this.chkConfiguracion = new System.Windows.Forms.CheckBox();
            this.chkReportes = new System.Windows.Forms.CheckBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.pnlListaUsuarios = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatosUsuario.SuspendLayout();
            this.pnlListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.White;
            this.pnlDatosUsuario.Controls.Add(this.chkUsuarioActivo);
            this.pnlDatosUsuario.Controls.Add(this.btnNuevo);
            this.pnlDatosUsuario.Controls.Add(this.chkEliminarRegistros);
            this.pnlDatosUsuario.Controls.Add(this.chkAnularVentas);
            this.pnlDatosUsuario.Controls.Add(this.chkAplicarDescuentos);
            this.pnlDatosUsuario.Controls.Add(this.btnGuardar);
            this.pnlDatosUsuario.Controls.Add(this.lblAccionesEspeciales);
            this.pnlDatosUsuario.Controls.Add(this.btnCancelar);
            this.pnlDatosUsuario.Controls.Add(this.chkAccederFueraHorario);
            this.pnlDatosUsuario.Controls.Add(this.chkModificarPrecios);
            this.pnlDatosUsuario.Controls.Add(this.chkVerCostos);
            this.pnlDatosUsuario.Controls.Add(this.chkInventario);
            this.pnlDatosUsuario.Controls.Add(this.chkCompras);
            this.pnlDatosUsuario.Controls.Add(this.chkClientes);
            this.pnlDatosUsuario.Controls.Add(this.chkVentas);
            this.pnlDatosUsuario.Controls.Add(this.lblPermisosModulos);
            this.pnlDatosUsuario.Controls.Add(this.cmbRol);
            this.pnlDatosUsuario.Controls.Add(this.lblRolBase);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.btnMostrarClave);
            this.pnlDatosUsuario.Controls.Add(this.lblContraseña);
            this.pnlDatosUsuario.Controls.Add(this.txtContraseña);
            this.pnlDatosUsuario.Controls.Add(this.chkFinanzas);
            this.pnlDatosUsuario.Controls.Add(this.chkProveedores);
            this.pnlDatosUsuario.Controls.Add(this.chkConfiguracion);
            this.pnlDatosUsuario.Controls.Add(this.chkReportes);
            this.pnlDatosUsuario.Controls.Add(this.lblNombreCompleto);
            this.pnlDatosUsuario.Controls.Add(this.txtNombreCompleto);
            this.pnlDatosUsuario.Controls.Add(this.lblSubTitulo2);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(16, 46);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(455, 490);
            this.pnlDatosUsuario.TabIndex = 69;
            // 
            // chkUsuarioActivo
            // 
            this.chkUsuarioActivo.AutoSize = true;
            this.chkUsuarioActivo.Location = new System.Drawing.Point(216, 138);
            this.chkUsuarioActivo.Name = "chkUsuarioActivo";
            this.chkUsuarioActivo.Size = new System.Drawing.Size(95, 17);
            this.chkUsuarioActivo.TabIndex = 93;
            this.chkUsuarioActivo.Text = "Usuario Activo";
            this.chkUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnNuevo.Location = new System.Drawing.Point(278, 451);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 21);
            this.btnNuevo.TabIndex = 91;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // chkEliminarRegistros
            // 
            this.chkEliminarRegistros.AutoSize = true;
            this.chkEliminarRegistros.Location = new System.Drawing.Point(18, 397);
            this.chkEliminarRegistros.Name = "chkEliminarRegistros";
            this.chkEliminarRegistros.Size = new System.Drawing.Size(104, 17);
            this.chkEliminarRegistros.TabIndex = 90;
            this.chkEliminarRegistros.Text = "Eliminar registros";
            this.chkEliminarRegistros.UseVisualStyleBackColor = true;
            // 
            // chkAnularVentas
            // 
            this.chkAnularVentas.AutoSize = true;
            this.chkAnularVentas.Location = new System.Drawing.Point(18, 374);
            this.chkAnularVentas.Name = "chkAnularVentas";
            this.chkAnularVentas.Size = new System.Drawing.Size(91, 17);
            this.chkAnularVentas.TabIndex = 89;
            this.chkAnularVentas.Text = "Anular ventas";
            this.chkAnularVentas.UseVisualStyleBackColor = true;
            // 
            // chkAplicarDescuentos
            // 
            this.chkAplicarDescuentos.AutoSize = true;
            this.chkAplicarDescuentos.Location = new System.Drawing.Point(18, 351);
            this.chkAplicarDescuentos.Name = "chkAplicarDescuentos";
            this.chkAplicarDescuentos.Size = new System.Drawing.Size(116, 17);
            this.chkAplicarDescuentos.TabIndex = 88;
            this.chkAplicarDescuentos.Text = "Aplicar descuentos";
            this.chkAplicarDescuentos.UseVisualStyleBackColor = true;
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
            this.btnGuardar.Location = new System.Drawing.Point(96, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 21);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblAccionesEspeciales
            // 
            this.lblAccionesEspeciales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblAccionesEspeciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccionesEspeciales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionesEspeciales.Location = new System.Drawing.Point(15, 321);
            this.lblAccionesEspeciales.Name = "lblAccionesEspeciales";
            this.lblAccionesEspeciales.Size = new System.Drawing.Size(162, 1);
            this.lblAccionesEspeciales.TabIndex = 87;
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
            this.btnCancelar.Location = new System.Drawing.Point(187, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 21);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // chkAccederFueraHorario
            // 
            this.chkAccederFueraHorario.AutoSize = true;
            this.chkAccederFueraHorario.Location = new System.Drawing.Point(228, 397);
            this.chkAccederFueraHorario.Name = "chkAccederFueraHorario";
            this.chkAccederFueraHorario.Size = new System.Drawing.Size(143, 17);
            this.chkAccederFueraHorario.TabIndex = 86;
            this.chkAccederFueraHorario.Text = "Acceder fuera de horario";
            this.chkAccederFueraHorario.UseVisualStyleBackColor = true;
            // 
            // chkModificarPrecios
            // 
            this.chkModificarPrecios.AutoSize = true;
            this.chkModificarPrecios.Location = new System.Drawing.Point(228, 374);
            this.chkModificarPrecios.Name = "chkModificarPrecios";
            this.chkModificarPrecios.Size = new System.Drawing.Size(106, 17);
            this.chkModificarPrecios.TabIndex = 85;
            this.chkModificarPrecios.Text = "Modificar precios";
            this.chkModificarPrecios.UseVisualStyleBackColor = true;
            // 
            // chkVerCostos
            // 
            this.chkVerCostos.AutoSize = true;
            this.chkVerCostos.Location = new System.Drawing.Point(228, 351);
            this.chkVerCostos.Name = "chkVerCostos";
            this.chkVerCostos.Size = new System.Drawing.Size(76, 17);
            this.chkVerCostos.TabIndex = 84;
            this.chkVerCostos.Text = "Ver costos";
            this.chkVerCostos.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(18, 283);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(116, 17);
            this.chkInventario.TabIndex = 83;
            this.chkInventario.Text = "Inventario (Ajustes)";
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkCompras
            // 
            this.chkCompras.AutoSize = true;
            this.chkCompras.Location = new System.Drawing.Point(18, 260);
            this.chkCompras.Name = "chkCompras";
            this.chkCompras.Size = new System.Drawing.Size(67, 17);
            this.chkCompras.TabIndex = 82;
            this.chkCompras.Text = "Compras";
            this.chkCompras.UseVisualStyleBackColor = true;
            // 
            // chkClientes
            // 
            this.chkClientes.AutoSize = true;
            this.chkClientes.Location = new System.Drawing.Point(18, 237);
            this.chkClientes.Name = "chkClientes";
            this.chkClientes.Size = new System.Drawing.Size(63, 17);
            this.chkClientes.TabIndex = 81;
            this.chkClientes.Text = "Clientes";
            this.chkClientes.UseVisualStyleBackColor = true;
            // 
            // chkVentas
            // 
            this.chkVentas.AutoSize = true;
            this.chkVentas.Location = new System.Drawing.Point(18, 214);
            this.chkVentas.Name = "chkVentas";
            this.chkVentas.Size = new System.Drawing.Size(142, 17);
            this.chkVentas.TabIndex = 80;
            this.chkVentas.Text = "Ventas (Punto de Venta)";
            this.chkVentas.UseVisualStyleBackColor = true;
            // 
            // lblPermisosModulos
            // 
            this.lblPermisosModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblPermisosModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPermisosModulos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisosModulos.Location = new System.Drawing.Point(15, 184);
            this.lblPermisosModulos.Name = "lblPermisosModulos";
            this.lblPermisosModulos.Size = new System.Drawing.Size(170, 1);
            this.lblPermisosModulos.TabIndex = 79;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Almacenero",
            "Cajero"});
            this.cmbRol.Location = new System.Drawing.Point(80, 134);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 78;
            // 
            // lblRolBase
            // 
            this.lblRolBase.AutoSize = true;
            this.lblRolBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRolBase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolBase.Location = new System.Drawing.Point(15, 136);
            this.lblRolBase.Name = "lblRolBase";
            this.lblRolBase.Size = new System.Drawing.Size(54, 15);
            this.lblRolBase.TabIndex = 77;
            this.lblRolBase.Text = "Rol Base:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 99);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 76;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(80, 97);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 21);
            this.txtUsuario.TabIndex = 75;
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarClave.FlatAppearance.BorderSize = 0;
            this.btnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClave.Location = new System.Drawing.Point(422, 97);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(21, 21);
            this.btnMostrarClave.TabIndex = 70;
            this.btnMostrarClave.Text = "👁";
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(213, 100);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 15);
            this.lblContraseña.TabIndex = 72;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Location = new System.Drawing.Point(296, 97);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(121, 21);
            this.txtContraseña.TabIndex = 71;
            // 
            // chkFinanzas
            // 
            this.chkFinanzas.AutoSize = true;
            this.chkFinanzas.Location = new System.Drawing.Point(228, 283);
            this.chkFinanzas.Name = "chkFinanzas";
            this.chkFinanzas.Size = new System.Drawing.Size(68, 17);
            this.chkFinanzas.TabIndex = 67;
            this.chkFinanzas.Text = "Finanzas";
            this.chkFinanzas.UseVisualStyleBackColor = true;
            // 
            // chkProveedores
            // 
            this.chkProveedores.AutoSize = true;
            this.chkProveedores.Location = new System.Drawing.Point(228, 260);
            this.chkProveedores.Name = "chkProveedores";
            this.chkProveedores.Size = new System.Drawing.Size(86, 17);
            this.chkProveedores.TabIndex = 66;
            this.chkProveedores.Text = "Proveedores";
            this.chkProveedores.UseVisualStyleBackColor = true;
            // 
            // chkConfiguracion
            // 
            this.chkConfiguracion.AutoSize = true;
            this.chkConfiguracion.Location = new System.Drawing.Point(228, 237);
            this.chkConfiguracion.Name = "chkConfiguracion";
            this.chkConfiguracion.Size = new System.Drawing.Size(91, 17);
            this.chkConfiguracion.TabIndex = 65;
            this.chkConfiguracion.Text = "Configuración";
            this.chkConfiguracion.UseVisualStyleBackColor = true;
            // 
            // chkReportes
            // 
            this.chkReportes.AutoSize = true;
            this.chkReportes.Location = new System.Drawing.Point(228, 214);
            this.chkReportes.Name = "chkReportes";
            this.chkReportes.Size = new System.Drawing.Size(69, 17);
            this.chkReportes.TabIndex = 64;
            this.chkReportes.Text = "Reportes";
            this.chkReportes.UseVisualStyleBackColor = true;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(15, 63);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(110, 15);
            this.lblNombreCompleto.TabIndex = 56;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Location = new System.Drawing.Point(132, 60);
            this.txtNombreCompleto.Multiline = true;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(287, 21);
            this.txtNombreCompleto.TabIndex = 46;
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(153, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "DATOS DEL USUARIO";
            // 
            // pnlListaUsuarios
            // 
            this.pnlListaUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlListaUsuarios.Controls.Add(this.lblSubTitulo);
            this.pnlListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlListaUsuarios.Location = new System.Drawing.Point(503, 46);
            this.pnlListaUsuarios.Name = "pnlListaUsuarios";
            this.pnlListaUsuarios.Size = new System.Drawing.Size(669, 490);
            this.pnlListaUsuarios.TabIndex = 70;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(23, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(144, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "LISTA DE USUARIOS";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colNombre,
            this.colUsuario,
            this.colRol,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(27, 52);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 50;
            this.dgvUsuarios.Size = new System.Drawing.Size(613, 181);
            this.dgvUsuarios.TabIndex = 44;
            // 
            // colNumero
            // 
            this.colNumero.Frozen = true;
            this.colNumero.HeaderText = "#";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 30;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditar.Width = 25;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Image = ((System.Drawing.Image)(resources.GetObject("colEliminar.Image")));
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Width = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 21);
            this.lblTitulo.TabIndex = 75;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlListaUsuarios);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.pnlListaUsuarios.ResumeLayout(false);
            this.pnlListaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.CheckBox chkFinanzas;
        private System.Windows.Forms.CheckBox chkProveedores;
        private System.Windows.Forms.CheckBox chkConfiguracion;
        private System.Windows.Forms.CheckBox chkReportes;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Panel pnlListaUsuarios;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrarClave;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRolBase;
        private System.Windows.Forms.Label lblPermisosModulos;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkCompras;
        private System.Windows.Forms.CheckBox chkClientes;
        private System.Windows.Forms.CheckBox chkVentas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkEliminarRegistros;
        private System.Windows.Forms.CheckBox chkAnularVentas;
        private System.Windows.Forms.CheckBox chkAplicarDescuentos;
        private System.Windows.Forms.Label lblAccionesEspeciales;
        private System.Windows.Forms.CheckBox chkAccederFueraHorario;
        private System.Windows.Forms.CheckBox chkModificarPrecios;
        private System.Windows.Forms.CheckBox chkVerCostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
        private System.Windows.Forms.CheckBox chkUsuarioActivo;
    }
}