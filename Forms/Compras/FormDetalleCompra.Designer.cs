namespace SistemaPOS.Forms.Compras
{
    partial class FormDetalleCompra
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblLineaDivisora2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.dgvDetalleProductos = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresentacionDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDNIRUC = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlComprobante = new System.Windows.Forms.Panel();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.chkIGVIncluido = new System.Windows.Forms.CheckBox();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).BeginInit();
            this.pnlProveedor.SuspendLayout();
            this.pnlComprobante.SuspendLayout();
            this.SuspendLayout();
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
            this.btnImprimir.Location = new System.Drawing.Point(161, 673);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(98, 27);
            this.btnImprimir.TabIndex = 10041;
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
            this.btnCerrar.Location = new System.Drawing.Point(307, 673);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 27);
            this.btnCerrar.TabIndex = 10040;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblLineaDivisora2
            // 
            this.lblLineaDivisora2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblLineaDivisora2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblLineaDivisora2.Location = new System.Drawing.Point(341, 566);
            this.lblLineaDivisora2.Name = "lblLineaDivisora2";
            this.lblLineaDivisora2.Size = new System.Drawing.Size(253, 1);
            this.lblLineaDivisora2.TabIndex = 10039;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(19, 594);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(276, 32);
            this.txtObservaciones.TabIndex = 10038;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(16, 576);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(87, 15);
            this.lblObservaciones.TabIndex = 10037;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(16, 545);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(98, 15);
            this.lblMetodoPago.TabIndex = 10032;
            this.lblMetodoPago.Text = "Método de Pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(341, 589);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 17);
            this.lblTotal.TabIndex = 10029;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(341, 545);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(61, 15);
            this.lblIGV.TabIndex = 10028;
            this.lblIGV.Text = "IGV (18%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(341, 515);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(70, 15);
            this.lblSubTotal.TabIndex = 10026;
            this.lblSubTotal.Text = "SUBTOTAL:";
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
            this.lblSubTitulo3.TabIndex = 10023;
            this.lblSubTitulo3.Text = "DETALLE DE PRODUCTOS";
            // 
            // dgvDetalleProductos
            // 
            this.dgvDetalleProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colProductoDV,
            this.colPresentacionDV,
            this.colCantidad,
            this.colCostoUnitario,
            this.colSubTotal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleProductos.EnableHeadersVisualStyles = false;
            this.dgvDetalleProductos.Location = new System.Drawing.Point(16, 352);
            this.dgvDetalleProductos.Name = "dgvDetalleProductos";
            this.dgvDetalleProductos.RowHeadersVisible = false;
            this.dgvDetalleProductos.RowTemplate.Height = 44;
            this.dgvDetalleProductos.Size = new System.Drawing.Size(569, 140);
            this.dgvDetalleProductos.TabIndex = 10025;
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
            this.colPresentacionDV.HeaderText = "Presentación";
            this.colPresentacionDV.Name = "colPresentacionDV";
            this.colPresentacionDV.ReadOnly = true;
            this.colPresentacionDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPresentacionDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 60;
            // 
            // colCostoUnitario
            // 
            this.colCostoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCostoUnitario.FillWeight = 90F;
            this.colCostoUnitario.HeaderText = "Costo Unitario";
            this.colCostoUnitario.Name = "colCostoUnitario";
            this.colCostoUnitario.ReadOnly = true;
            this.colCostoUnitario.Width = 90;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 70;
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.BackColor = System.Drawing.Color.White;
            this.pnlProveedor.Controls.Add(this.txtTelefono);
            this.pnlProveedor.Controls.Add(this.txtDireccion);
            this.pnlProveedor.Controls.Add(this.txtRazonSocial);
            this.pnlProveedor.Controls.Add(this.txtRUC);
            this.pnlProveedor.Controls.Add(this.lblDireccion);
            this.pnlProveedor.Controls.Add(this.lblTelefono);
            this.pnlProveedor.Controls.Add(this.lblRazonSocial);
            this.pnlProveedor.Controls.Add(this.lblDNIRUC);
            this.pnlProveedor.Controls.Add(this.lblSubTitulo2);
            this.pnlProveedor.Location = new System.Drawing.Point(16, 188);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(569, 113);
            this.pnlProveedor.TabIndex = 10024;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Location = new System.Drawing.Point(391, 76);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(173, 20);
            this.txtTelefono.TabIndex = 10052;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(107, 76);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(204, 20);
            this.txtDireccion.TabIndex = 10051;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Location = new System.Drawing.Point(107, 45);
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(204, 20);
            this.txtRazonSocial.TabIndex = 10050;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRUC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRUC.Location = new System.Drawing.Point(391, 45);
            this.txtRUC.Multiline = true;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(173, 20);
            this.txtRUC.TabIndex = 10049;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(14, 81);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 139;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(328, 81);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 138;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazonSocial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(13, 47);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(88, 16);
            this.lblRazonSocial.TabIndex = 136;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // lblDNIRUC
            // 
            this.lblDNIRUC.AutoSize = true;
            this.lblDNIRUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDNIRUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIRUC.Location = new System.Drawing.Point(328, 50);
            this.lblDNIRUC.Name = "lblDNIRUC";
            this.lblDNIRUC.Size = new System.Drawing.Size(33, 15);
            this.lblDNIRUC.TabIndex = 133;
            this.lblDNIRUC.Text = "RUC:";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(95, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "PROVEEDOR";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 21);
            this.lblTitulo.TabIndex = 10022;
            this.lblTitulo.Text = "Detalle de Compra";
            // 
            // pnlComprobante
            // 
            this.pnlComprobante.BackColor = System.Drawing.Color.White;
            this.pnlComprobante.Controls.Add(this.lblNumeroSerie);
            this.pnlComprobante.Controls.Add(this.lblEstado);
            this.pnlComprobante.Controls.Add(this.lblHora);
            this.pnlComprobante.Controls.Add(this.lblEncargado);
            this.pnlComprobante.Controls.Add(this.lblFecha);
            this.pnlComprobante.Controls.Add(this.lblTipoComprobante);
            this.pnlComprobante.Controls.Add(this.lblSubTitulo);
            this.pnlComprobante.Location = new System.Drawing.Point(16, 47);
            this.pnlComprobante.Name = "pnlComprobante";
            this.pnlComprobante.Size = new System.Drawing.Size(569, 135);
            this.pnlComprobante.TabIndex = 10021;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.Location = new System.Drawing.Point(256, 50);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(134, 15);
            this.lblNumeroSerie.TabIndex = 140;
            this.lblNumeroSerie.Text = "Serie-Número: F001-123";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(15, 104);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 15);
            this.lblEstado.TabIndex = 139;
            this.lblEstado.Text = "Estado: ✅ Pagado";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(256, 77);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 15);
            this.lblHora.TabIndex = 138;
            this.lblHora.Text = "Hora: 14:30:25";
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEncargado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.Location = new System.Drawing.Point(256, 103);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(174, 17);
            this.lblEncargado.TabIndex = 136;
            this.lblEncargado.Text = "Encargado: María González";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 15);
            this.lblFecha.TabIndex = 133;
            this.lblFecha.Text = "Fecha: 24/01/2026";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobante.Location = new System.Drawing.Point(15, 50);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(136, 15);
            this.lblTipoComprobante.TabIndex = 130;
            this.lblTipoComprobante.Text = "Tipo: Factura Electrónica";
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
            // chkIGVIncluido
            // 
            this.chkIGVIncluido.AutoSize = true;
            this.chkIGVIncluido.Location = new System.Drawing.Point(19, 515);
            this.chkIGVIncluido.Name = "chkIGVIncluido";
            this.chkIGVIncluido.Size = new System.Drawing.Size(113, 17);
            this.chkIGVIncluido.TabIndex = 10044;
            this.chkIGVIncluido.Text = "IGV Incluido (18%)";
            this.chkIGVIncluido.UseVisualStyleBackColor = true;
            // 
            // txtRecibido
            // 
            this.txtRecibido.BackColor = System.Drawing.Color.White;
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecibido.Location = new System.Drawing.Point(185, 542);
            this.txtRecibido.Multiline = true;
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.ReadOnly = true;
            this.txtRecibido.Size = new System.Drawing.Size(110, 20);
            this.txtRecibido.TabIndex = 10045;
            this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Location = new System.Drawing.Point(446, 510);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(139, 20);
            this.txtSubTotal.TabIndex = 10046;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.Color.White;
            this.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGV.Location = new System.Drawing.Point(446, 540);
            this.txtIGV.Multiline = true;
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(139, 20);
            this.txtIGV.TabIndex = 10047;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(446, 587);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 20);
            this.txtTotal.TabIndex = 10048;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(597, 711);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtRecibido);
            this.Controls.Add(this.chkIGVIncluido);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblLineaDivisora2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTitulo3);
            this.Controls.Add(this.dgvDetalleProductos);
            this.Controls.Add(this.pnlProveedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlComprobante);
            this.Name = "FormDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).EndInit();
            this.pnlProveedor.ResumeLayout(false);
            this.pnlProveedor.PerformLayout();
            this.pnlComprobante.ResumeLayout(false);
            this.pnlComprobante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblLineaDivisora2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.DataGridView dgvDetalleProductos;
        private System.Windows.Forms.Panel pnlProveedor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDNIRUC;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlComprobante;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresentacionDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.CheckBox chkIGVIncluido;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}
