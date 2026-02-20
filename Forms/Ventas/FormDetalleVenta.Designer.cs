namespace SistemaPOS.Forms.Ventas
{
    partial class FormDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlComprobante = new System.Windows.Forms.Panel();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDNIRUC = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreRazonSocial = new System.Windows.Forms.Label();
            this.lblDNIRUC = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.dgvDetalleProductos = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresentacionDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblLineaDivisora2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.pnlComprobante.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 21);
            this.lblTitulo.TabIndex = 139;
            this.lblTitulo.Text = "Detalle de Venta";
            // 
            // pnlComprobante
            // 
            this.pnlComprobante.BackColor = System.Drawing.Color.White;
            this.pnlComprobante.Controls.Add(this.txtEncargado);
            this.pnlComprobante.Controls.Add(this.txtEstado);
            this.pnlComprobante.Controls.Add(this.txtHora);
            this.pnlComprobante.Controls.Add(this.txtFecha);
            this.pnlComprobante.Controls.Add(this.txtNumeroSerie);
            this.pnlComprobante.Controls.Add(this.txtTipoComprobante);
            this.pnlComprobante.Controls.Add(this.lblNumeroSerie);
            this.pnlComprobante.Controls.Add(this.lblEstado);
            this.pnlComprobante.Controls.Add(this.lblHora);
            this.pnlComprobante.Controls.Add(this.lblEncargado);
            this.pnlComprobante.Controls.Add(this.lblFecha);
            this.pnlComprobante.Controls.Add(this.lblTipoComprobante);
            this.pnlComprobante.Controls.Add(this.lblSubTitulo);
            this.pnlComprobante.Location = new System.Drawing.Point(16, 47);
            this.pnlComprobante.Name = "pnlComprobante";
            this.pnlComprobante.Size = new System.Drawing.Size(551, 135);
            this.pnlComprobante.TabIndex = 138;
            // 
            // txtEncargado
            // 
            this.txtEncargado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEncargado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncargado.Location = new System.Drawing.Point(365, 100);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.ReadOnly = true;
            this.txtEncargado.Size = new System.Drawing.Size(170, 16);
            this.txtEncargado.TabIndex = 205;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(100, 100);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(145, 16);
            this.txtEstado.TabIndex = 204;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(365, 75);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(170, 16);
            this.txtHora.TabIndex = 203;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(100, 75);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(145, 16);
            this.txtFecha.TabIndex = 202;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(365, 50);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.ReadOnly = true;
            this.txtNumeroSerie.Size = new System.Drawing.Size(170, 16);
            this.txtNumeroSerie.TabIndex = 201;
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoComprobante.Location = new System.Drawing.Point(100, 50);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.ReadOnly = true;
            this.txtTipoComprobante.Size = new System.Drawing.Size(145, 16);
            this.txtTipoComprobante.TabIndex = 200;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.Location = new System.Drawing.Point(260, 50);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(84, 15);
            this.lblNumeroSerie.TabIndex = 140;
            this.lblNumeroSerie.Text = "Serie-Numero:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(15, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 139;
            this.lblEstado.Text = "Estado:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(260, 75);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 15);
            this.lblHora.TabIndex = 138;
            this.lblHora.Text = "Hora:";
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEncargado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.Location = new System.Drawing.Point(260, 100);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(66, 15);
            this.lblEncargado.TabIndex = 136;
            this.lblEncargado.Text = "Encargado:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 133;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobante.Location = new System.Drawing.Point(15, 50);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(33, 15);
            this.lblTipoComprobante.TabIndex = 130;
            this.lblTipoComprobante.Text = "Tipo:";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(119, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "COMPROBANTE";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.White;
            this.pnlCliente.Controls.Add(this.txtDireccion);
            this.pnlCliente.Controls.Add(this.txtTelefono);
            this.pnlCliente.Controls.Add(this.txtNombreRazonSocial);
            this.pnlCliente.Controls.Add(this.txtDNIRUC);
            this.pnlCliente.Controls.Add(this.lblDireccion);
            this.pnlCliente.Controls.Add(this.lblTelefono);
            this.pnlCliente.Controls.Add(this.lblNombreRazonSocial);
            this.pnlCliente.Controls.Add(this.lblDNIRUC);
            this.pnlCliente.Controls.Add(this.lblSubTitulo2);
            this.pnlCliente.Location = new System.Drawing.Point(16, 188);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(551, 113);
            this.pnlCliente.TabIndex = 143;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(300, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(235, 16);
            this.txtDireccion.TabIndex = 209;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(85, 77);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(130, 16);
            this.txtTelefono.TabIndex = 208;
            // 
            // txtNombreRazonSocial
            // 
            this.txtNombreRazonSocial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRazonSocial.Location = new System.Drawing.Point(85, 50);
            this.txtNombreRazonSocial.Name = "txtNombreRazonSocial";
            this.txtNombreRazonSocial.ReadOnly = true;
            this.txtNombreRazonSocial.Size = new System.Drawing.Size(235, 16);
            this.txtNombreRazonSocial.TabIndex = 206;
            // 
            // txtDNIRUC
            // 
            this.txtDNIRUC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDNIRUC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNIRUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIRUC.Location = new System.Drawing.Point(405, 50);
            this.txtDNIRUC.Name = "txtDNIRUC";
            this.txtDNIRUC.ReadOnly = true;
            this.txtDNIRUC.Size = new System.Drawing.Size(130, 16);
            this.txtDNIRUC.TabIndex = 207;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(225, 77);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 139;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(15, 77);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 138;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblNombreRazonSocial
            // 
            this.lblNombreRazonSocial.AutoSize = true;
            this.lblNombreRazonSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRazonSocial.Location = new System.Drawing.Point(15, 50);
            this.lblNombreRazonSocial.Name = "lblNombreRazonSocial";
            this.lblNombreRazonSocial.Size = new System.Drawing.Size(54, 15);
            this.lblNombreRazonSocial.TabIndex = 136;
            this.lblNombreRazonSocial.Text = "Nombre:";
            // 
            // lblDNIRUC
            // 
            this.lblDNIRUC.AutoSize = true;
            this.lblDNIRUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDNIRUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIRUC.Location = new System.Drawing.Point(335, 50);
            this.lblDNIRUC.Name = "lblDNIRUC";
            this.lblDNIRUC.Size = new System.Drawing.Size(58, 15);
            this.lblDNIRUC.TabIndex = 133;
            this.lblDNIRUC.Text = "DNI/RUC:";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(65, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "CLIENTE";
            // 
            // dgvDetalleProductos
            // 
            this.dgvDetalleProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colProductoDV,
            this.colPresentacionDV,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleProductos.EnableHeadersVisualStyles = false;
            this.dgvDetalleProductos.Location = new System.Drawing.Point(16, 352);
            this.dgvDetalleProductos.Name = "dgvDetalleProductos";
            this.dgvDetalleProductos.RowHeadersVisible = false;
            this.dgvDetalleProductos.RowTemplate.Height = 50;
            this.dgvDetalleProductos.Size = new System.Drawing.Size(551, 140);
            this.dgvDetalleProductos.TabIndex = 144;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "#";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 25;
            // 
            // colProductoDV
            // 
            this.colProductoDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductoDV.HeaderText = "Productos";
            this.colProductoDV.Name = "colProductoDV";
            this.colProductoDV.ReadOnly = true;
            // 
            // colPresentacionDV
            // 
            this.colPresentacionDV.HeaderText = "Presentacion";
            this.colPresentacionDV.Name = "colPresentacionDV";
            this.colPresentacionDV.ReadOnly = true;
            this.colPresentacionDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPresentacionDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPresentacionDV.Width = 120;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 60;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrecioUnitario.FillWeight = 90F;
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 90;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 70;
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(12, 319);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(180, 20);
            this.lblSubTitulo3.TabIndex = 140;
            this.lblSubTitulo3.Text = "DETALLE DE PRODUCTOS";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(13, 561);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(44, 15);
            this.lblVuelto.TabIndex = 150;
            this.lblVuelto.Text = "Vuelto:";
            // 
            // lblRecibido
            // 
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecibido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibido.Location = new System.Drawing.Point(13, 540);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(56, 15);
            this.lblRecibido.TabIndex = 149;
            this.lblRecibido.Text = "Recibido:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(338, 608);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 17);
            this.lblTotal.TabIndex = 148;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(338, 566);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(61, 15);
            this.lblIGV.TabIndex = 147;
            this.lblIGV.Text = "IGV (18%):";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(338, 540);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(75, 15);
            this.lblDescuento.TabIndex = 146;
            this.lblDescuento.Text = "DESCUENTO:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(338, 514);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(70, 15);
            this.lblSubTotal.TabIndex = 145;
            this.lblSubTotal.Text = "SUBTOTAL:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(13, 514);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(98, 15);
            this.lblMetodoPago.TabIndex = 151;
            this.lblMetodoPago.Text = "Metodo de Pago:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Location = new System.Drawing.Point(16, 608);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(276, 32);
            this.txtObservaciones.TabIndex = 157;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(13, 590);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(87, 15);
            this.lblObservaciones.TabIndex = 156;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblLineaDivisora2
            // 
            this.lblLineaDivisora2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblLineaDivisora2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblLineaDivisora2.Location = new System.Drawing.Point(338, 587);
            this.lblLineaDivisora2.Name = "lblLineaDivisora2";
            this.lblLineaDivisora2.Size = new System.Drawing.Size(215, 1);
            this.lblLineaDivisora2.TabIndex = 158;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnImprimir.Location = new System.Drawing.Point(158, 672);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(98, 27);
            this.btnImprimir.TabIndex = 10018;
            this.btnImprimir.Text = "Exportar";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(304, 672);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 27);
            this.btnCerrar.TabIndex = 10017;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // txtRecibido
            // 
            this.txtRecibido.BackColor = System.Drawing.Color.White;
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecibido.Location = new System.Drawing.Point(182, 537);
            this.txtRecibido.Multiline = true;
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.ReadOnly = true;
            this.txtRecibido.Size = new System.Drawing.Size(110, 20);
            this.txtRecibido.TabIndex = 10025;
            this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVuelto
            // 
            this.txtVuelto.BackColor = System.Drawing.Color.White;
            this.txtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVuelto.Location = new System.Drawing.Point(182, 561);
            this.txtVuelto.Multiline = true;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(110, 20);
            this.txtVuelto.TabIndex = 10026;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Location = new System.Drawing.Point(443, 509);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(110, 20);
            this.txtSubTotal.TabIndex = 10027;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Location = new System.Drawing.Point(443, 536);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(110, 20);
            this.txtDescuento.TabIndex = 10028;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.Color.White;
            this.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGV.Location = new System.Drawing.Point(443, 562);
            this.txtIGV.Multiline = true;
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(110, 20);
            this.txtIGV.TabIndex = 10029;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(443, 604);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(110, 20);
            this.txtTotal.TabIndex = 10030;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.BackColor = System.Drawing.Color.White;
            this.txtMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetodoPago.Location = new System.Drawing.Point(182, 509);
            this.txtMetodoPago.Multiline = true;
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.ReadOnly = true;
            this.txtMetodoPago.Size = new System.Drawing.Size(110, 20);
            this.txtMetodoPago.TabIndex = 10031;
            this.txtMetodoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(584, 711);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtRecibido);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblLineaDivisora2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.lblRecibido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTitulo3);
            this.Controls.Add(this.dgvDetalleProductos);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlComprobante);
            this.Name = "FormDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnlComprobante.ResumeLayout(false);
            this.pnlComprobante.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlComprobante;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreRazonSocial;
        private System.Windows.Forms.Label lblDNIRUC;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombreRazonSocial;
        private System.Windows.Forms.TextBox txtDNIRUC;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvDetalleProductos;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblLineaDivisora2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresentacionDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMetodoPago;
    }
}
