namespace SistemaPOS.Forms.Compras
{
    partial class FormHistorialCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.lblNumComprobante = new System.Windows.Forms.Label();
            this.pnlListadoCompras = new System.Windows.Forms.Panel();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAnular = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.txtPorPagar = new System.Windows.Forms.TextBox();
            this.txtTotalCantidad = new System.Windows.Forms.TextBox();
            this.txtEfectivoCantidad = new System.Windows.Forms.TextBox();
            this.txtCreditoCantidad = new System.Windows.Forms.TextBox();
            this.lblPorPagar = new System.Windows.Forms.Label();
            this.txtTransferenciaCantidad = new System.Windows.Forms.TextBox();
            this.txtYapeCantidad = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbllblYape = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlListadoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.pnlResumen.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1184, 68);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historial de Compras";
            //
            // lblHeaderSub
            //
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(22, 42);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(200, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Registro de compras realizadas";
            //
            // pnlFiltro
            //
            this.pnlFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltro.BackColor = System.Drawing.Color.White;
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnLimpiar);
            this.pnlFiltro.Controls.Add(this.lblEstado);
            this.pnlFiltro.Controls.Add(this.cmbEstado);
            this.pnlFiltro.Controls.Add(this.cmbProveedor);
            this.pnlFiltro.Controls.Add(this.lblProveedor);
            this.pnlFiltro.Controls.Add(this.cmbTipoComprobante);
            this.pnlFiltro.Controls.Add(this.lblTipoComprobante);
            this.pnlFiltro.Controls.Add(this.lblSubTitulo);
            this.pnlFiltro.Controls.Add(this.txtNumComprobante);
            this.pnlFiltro.Controls.Add(this.lblNumComprobante);
            this.pnlFiltro.Location = new System.Drawing.Point(16, 80);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(813, 192);
            this.pnlFiltro.TabIndex = 10023;
            //
            // lblSubTitulo
            //
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(14, 11);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(135, 15);
            this.lblSubTitulo.TabIndex = 115;
            this.lblSubTitulo.Text = "FILTRO DE BÚSQUEDA";
            //
            // lblProveedor
            //
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(15, 54);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(64, 15);
            this.lblProveedor.TabIndex = 132;
            this.lblProveedor.Text = "Proveedor:";
            //
            // cmbProveedor
            //
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(150, 51);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(228, 21);
            this.cmbProveedor.TabIndex = 133;
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(437, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 135;
            this.lblEstado.Text = "Estado:";
            //
            // cmbEstado
            //
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(546, 51);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(226, 21);
            this.cmbEstado.TabIndex = 134;
            //
            // lblTipoComprobante
            //
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobante.Location = new System.Drawing.Point(15, 94);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(110, 15);
            this.lblTipoComprobante.TabIndex = 121;
            this.lblTipoComprobante.Text = "Tipo Comprobante:";
            //
            // cmbTipoComprobante
            //
            this.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota de Venta",
            "Nota de Crédito"});
            this.cmbTipoComprobante.Location = new System.Drawing.Point(150, 89);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(228, 21);
            this.cmbTipoComprobante.TabIndex = 122;
            //
            // lblNumComprobante
            //
            this.lblNumComprobante.AutoSize = true;
            this.lblNumComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComprobante.Location = new System.Drawing.Point(437, 91);
            this.lblNumComprobante.Name = "lblNumComprobante";
            this.lblNumComprobante.Size = new System.Drawing.Size(101, 15);
            this.lblNumComprobante.TabIndex = 117;
            this.lblNumComprobante.Text = "N° Comprobante:";
            //
            // txtNumComprobante
            //
            this.txtNumComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumComprobante.Location = new System.Drawing.Point(546, 88);
            this.txtNumComprobante.Multiline = true;
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(226, 20);
            this.txtNumComprobante.TabIndex = 116;
            //
            // btnBuscar
            //
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnBuscar.Location = new System.Drawing.Point(296, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 28);
            this.btnBuscar.TabIndex = 141;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnLimpiar.Location = new System.Drawing.Point(430, 145);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 28);
            this.btnLimpiar.TabIndex = 142;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            //
            // pnlListadoCompras
            //
            this.pnlListadoCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListadoCompras.BackColor = System.Drawing.Color.White;
            this.pnlListadoCompras.Controls.Add(this.lblHasta);
            this.pnlListadoCompras.Controls.Add(this.lblSubTitulo3);
            this.pnlListadoCompras.Controls.Add(this.dgvCompras);
            this.pnlListadoCompras.Controls.Add(this.dtpHasta);
            this.pnlListadoCompras.Controls.Add(this.dtpDesde);
            this.pnlListadoCompras.Controls.Add(this.lblDesde);
            this.pnlListadoCompras.Location = new System.Drawing.Point(16, 280);
            this.pnlListadoCompras.Name = "pnlListadoCompras";
            this.pnlListadoCompras.Size = new System.Drawing.Size(813, 451);
            this.pnlListadoCompras.TabIndex = 10025;
            //
            // lblSubTitulo3
            //
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(14, 17);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(135, 15);
            this.lblSubTitulo3.TabIndex = 145;
            this.lblSubTitulo3.Text = "LISTADO DE COMPRAS";
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(439, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 15);
            this.lblDesde.TabIndex = 10011;
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(491, 17);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(83, 20);
            this.dtpDesde.TabIndex = 10010;
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(671, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 15);
            this.lblHasta.TabIndex = 10013;
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(720, 17);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(82, 20);
            this.dtpHasta.TabIndex = 10012;
            //
            // dgvCompras
            //
            this.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFechaHora,
            this.colComprobante,
            this.colProveedor,
            this.colItems,
            this.colTotal,
            this.colMetodoPago,
            this.colEstado,
            this.colVerDetalle,
            this.colImprimir,
            this.colAnular});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompras.EnableHeadersVisualStyles = false;
            this.dgvCompras.Location = new System.Drawing.Point(-1, 55);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowTemplate.Height = 44;
            this.dgvCompras.Size = new System.Drawing.Size(813, 391);
            this.dgvCompras.TabIndex = 128;
            //
            // colNumero
            //
            this.colNumero.HeaderText = "#";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 25;
            //
            // colFechaHora
            //
            this.colFechaHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFechaHora.HeaderText = "Fecha y Hora";
            this.colFechaHora.Name = "colFechaHora";
            this.colFechaHora.ReadOnly = true;
            //
            // colComprobante
            //
            this.colComprobante.HeaderText = "Comprobante";
            this.colComprobante.Name = "colComprobante";
            this.colComprobante.ReadOnly = true;
            this.colComprobante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colComprobante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colComprobante.Width = 120;
            //
            // colProveedor
            //
            this.colProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            //
            // colItems
            //
            this.colItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItems.FillWeight = 90F;
            this.colItems.HeaderText = "Items";
            this.colItems.Name = "colItems";
            this.colItems.ReadOnly = true;
            this.colItems.Width = 60;
            //
            // colTotal
            //
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 80;
            //
            // colMetodoPago
            //
            this.colMetodoPago.HeaderText = "Método de Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.ReadOnly = true;
            //
            // colEstado
            //
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            //
            // colVerDetalle
            //
            this.colVerDetalle.HeaderText = "";
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.ReadOnly = true;
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVerDetalle.Width = 25;
            //
            // colImprimir
            //
            this.colImprimir.HeaderText = "";
            this.colImprimir.Name = "colImprimir";
            this.colImprimir.ReadOnly = true;
            this.colImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colImprimir.Width = 25;
            //
            // colAnular
            //
            this.colAnular.HeaderText = "";
            this.colAnular.Name = "colAnular";
            this.colAnular.Width = 25;
            //
            // pnlResumen
            //
            this.pnlResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.Controls.Add(this.txtPorPagar);
            this.pnlResumen.Controls.Add(this.txtTotalCantidad);
            this.pnlResumen.Controls.Add(this.txtEfectivoCantidad);
            this.pnlResumen.Controls.Add(this.txtCreditoCantidad);
            this.pnlResumen.Controls.Add(this.lblPorPagar);
            this.pnlResumen.Controls.Add(this.txtTransferenciaCantidad);
            this.pnlResumen.Controls.Add(this.txtYapeCantidad);
            this.pnlResumen.Controls.Add(this.btnCerrar);
            this.pnlResumen.Controls.Add(this.btnExportar);
            this.pnlResumen.Controls.Add(this.lblEfectivo);
            this.pnlResumen.Controls.Add(this.lblCredito);
            this.pnlResumen.Controls.Add(this.lblTransferencia);
            this.pnlResumen.Controls.Add(this.lblSeparador);
            this.pnlResumen.Controls.Add(this.lblTotal);
            this.pnlResumen.Controls.Add(this.lbllblYape);
            this.pnlResumen.Controls.Add(this.lblOperaciones);
            this.pnlResumen.Controls.Add(this.lblSubTitulo2);
            this.pnlResumen.Location = new System.Drawing.Point(835, 80);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(337, 651);
            this.pnlResumen.TabIndex = 10024;
            //
            // lblSubTitulo2
            //
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(14, 11);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(65, 15);
            this.lblSubTitulo2.TabIndex = 115;
            this.lblSubTitulo2.Text = "RESUMEN";
            //
            // lblOperaciones
            //
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOperaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(15, 54);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(136, 15);
            this.lblOperaciones.TabIndex = 161;
            this.lblOperaciones.Text = "Compras del período: 45";
            //
            // lblEfectivo
            //
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(19, 89);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(52, 15);
            this.lblEfectivo.TabIndex = 168;
            this.lblEfectivo.Text = "Efectivo:";
            //
            // txtEfectivoCantidad
            //
            this.txtEfectivoCantidad.BackColor = System.Drawing.Color.White;
            this.txtEfectivoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivoCantidad.Location = new System.Drawing.Point(206, 84);
            this.txtEfectivoCantidad.Multiline = true;
            this.txtEfectivoCantidad.Name = "txtEfectivoCantidad";
            this.txtEfectivoCantidad.ReadOnly = true;
            this.txtEfectivoCantidad.Size = new System.Drawing.Size(110, 20);
            this.txtEfectivoCantidad.TabIndex = 10026;
            this.txtEfectivoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lbllblYape
            //
            this.lbllblYape.AutoSize = true;
            this.lbllblYape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbllblYape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblYape.Location = new System.Drawing.Point(19, 115);
            this.lbllblYape.Name = "lbllblYape";
            this.lbllblYape.Size = new System.Drawing.Size(35, 15);
            this.lbllblYape.TabIndex = 163;
            this.lbllblYape.Text = "Yape:";
            //
            // txtYapeCantidad
            //
            this.txtYapeCantidad.BackColor = System.Drawing.Color.White;
            this.txtYapeCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYapeCantidad.Location = new System.Drawing.Point(206, 109);
            this.txtYapeCantidad.Multiline = true;
            this.txtYapeCantidad.Name = "txtYapeCantidad";
            this.txtYapeCantidad.ReadOnly = true;
            this.txtYapeCantidad.Size = new System.Drawing.Size(110, 20);
            this.txtYapeCantidad.TabIndex = 10027;
            this.txtYapeCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblTransferencia
            //
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTransferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferencia.Location = new System.Drawing.Point(19, 141);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(79, 15);
            this.lblTransferencia.TabIndex = 166;
            this.lblTransferencia.Text = "Transferencia:";
            //
            // txtTransferenciaCantidad
            //
            this.txtTransferenciaCantidad.BackColor = System.Drawing.Color.White;
            this.txtTransferenciaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransferenciaCantidad.Location = new System.Drawing.Point(206, 136);
            this.txtTransferenciaCantidad.Multiline = true;
            this.txtTransferenciaCantidad.Name = "txtTransferenciaCantidad";
            this.txtTransferenciaCantidad.ReadOnly = true;
            this.txtTransferenciaCantidad.Size = new System.Drawing.Size(110, 20);
            this.txtTransferenciaCantidad.TabIndex = 10028;
            this.txtTransferenciaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblCredito
            //
            this.lblCredito.AutoSize = true;
            this.lblCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCredito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(19, 167);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(60, 15);
            this.lblCredito.TabIndex = 167;
            this.lblCredito.Text = "A Crédito:";
            //
            // txtCreditoCantidad
            //
            this.txtCreditoCantidad.BackColor = System.Drawing.Color.White;
            this.txtCreditoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditoCantidad.Location = new System.Drawing.Point(206, 162);
            this.txtCreditoCantidad.Multiline = true;
            this.txtCreditoCantidad.Name = "txtCreditoCantidad";
            this.txtCreditoCantidad.ReadOnly = true;
            this.txtCreditoCantidad.Size = new System.Drawing.Size(110, 20);
            this.txtCreditoCantidad.TabIndex = 10029;
            this.txtCreditoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSeparador
            //
            this.lblSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblSeparador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblSeparador.Location = new System.Drawing.Point(19, 189);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(297, 1);
            this.lblSeparador.TabIndex = 165;
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 164;
            this.lblTotal.Text = "TOTAL:";
            //
            // txtTotalCantidad
            //
            this.txtTotalCantidad.BackColor = System.Drawing.Color.White;
            this.txtTotalCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCantidad.Location = new System.Drawing.Point(206, 208);
            this.txtTotalCantidad.Multiline = true;
            this.txtTotalCantidad.Name = "txtTotalCantidad";
            this.txtTotalCantidad.ReadOnly = true;
            this.txtTotalCantidad.Size = new System.Drawing.Size(110, 20);
            this.txtTotalCantidad.TabIndex = 10030;
            this.txtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblPorPagar
            //
            this.lblPorPagar.AutoSize = true;
            this.lblPorPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorPagar.Location = new System.Drawing.Point(19, 243);
            this.lblPorPagar.Name = "lblPorPagar";
            this.lblPorPagar.Size = new System.Drawing.Size(111, 15);
            this.lblPorPagar.TabIndex = 10017;
            this.lblPorPagar.Text = "Por Pagar (Crédito):";
            //
            // txtPorPagar
            //
            this.txtPorPagar.BackColor = System.Drawing.Color.White;
            this.txtPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorPagar.Location = new System.Drawing.Point(206, 238);
            this.txtPorPagar.Multiline = true;
            this.txtPorPagar.Name = "txtPorPagar";
            this.txtPorPagar.ReadOnly = true;
            this.txtPorPagar.Size = new System.Drawing.Size(110, 20);
            this.txtPorPagar.TabIndex = 10031;
            this.txtPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnExportar
            //
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnExportar.Location = new System.Drawing.Point(17, 611);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(98, 27);
            this.btnExportar.TabIndex = 10014;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            //
            // btnCerrar
            //
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(120, 611);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 27);
            this.btnCerrar.TabIndex = 10015;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            //
            // FormHistorialCompras
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 743);
            this.Controls.Add(this.pnlListadoCompras);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorialCompras";
            this.Text = "FormHistorialCompras";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlListadoCompras.ResumeLayout(false);
            this.pnlListadoCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlListadoCompras;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbllblYape;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtNumComprobante;
        private System.Windows.Forms.Label lblNumComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewImageColumn colVerDetalle;
        private System.Windows.Forms.DataGridViewImageColumn colImprimir;
        private System.Windows.Forms.DataGridViewImageColumn colAnular;
        private System.Windows.Forms.Label lblPorPagar;
        private System.Windows.Forms.TextBox txtTotalCantidad;
        private System.Windows.Forms.TextBox txtEfectivoCantidad;
        private System.Windows.Forms.TextBox txtCreditoCantidad;
        private System.Windows.Forms.TextBox txtTransferenciaCantidad;
        private System.Windows.Forms.TextBox txtYapeCantidad;
        private System.Windows.Forms.TextBox txtPorPagar;
    }
}
