namespace SistemaPOS.Forms.Ventas
{
    partial class FormVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            // ── Control declarations ──────────────────────────────────
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.lblTitulo          = new System.Windows.Forms.Label();
            this.btnHistorial       = new System.Windows.Forms.Button();

            this.pnlBusqueda        = new System.Windows.Forms.Panel();
            this.lblBuscar          = new System.Windows.Forms.Label();
            this.txtBuscar          = new System.Windows.Forms.TextBox();
            this.flpCategorias      = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlViewToggle      = new System.Windows.Forms.Panel();
            this.btnVistaLista      = new System.Windows.Forms.Button();
            this.btnVistaCards      = new System.Windows.Forms.Button();
            this.dgvProductos       = new System.Windows.Forms.DataGridView();
            this.colNumero          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen          = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProducto        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresentacion    = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPrecioUnit      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpProductCards    = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlDetalleVenta    = new System.Windows.Forms.Panel();
            this.lblSubTitulo2      = new System.Windows.Forms.Label();
            this.pnlDetalleCliente  = new System.Windows.Forms.Panel();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblCliente         = new System.Windows.Forms.Label();
            this.cmbClientes        = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente   = new System.Windows.Forms.Button();
            this.lblNombreCliente   = new System.Windows.Forms.Label();
            this.lblDNICliente      = new System.Windows.Forms.Label();
            this.lblCarritoTitulo   = new System.Windows.Forms.Label();
            this.dgvCarritoVenta    = new System.Windows.Forms.DataGridView();
            this.colProductoDV      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresentacionDV  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPres        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisminuir       = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCantidad        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAumentar        = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTotalDV         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar        = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblLineaDivisora   = new System.Windows.Forms.Label();
            this.lblSubTotal        = new System.Windows.Forms.Label();
            this.txtSubtotal        = new System.Windows.Forms.TextBox();
            this.lblDescuento       = new System.Windows.Forms.Label();
            this.txtDescuento       = new System.Windows.Forms.TextBox();
            this.lblIGV             = new System.Windows.Forms.Label();
            this.cboIGV             = new System.Windows.Forms.ComboBox();
            this.txtIGV             = new System.Windows.Forms.TextBox();
            this.lblLineaDivisora2  = new System.Windows.Forms.Label();
            this.lblTotalPagar      = new System.Windows.Forms.Label();
            this.txtTotalPagar      = new System.Windows.Forms.TextBox();
            // Hidden payment controls (kept for logic compatibility)
            this.grpMetodoPago      = new System.Windows.Forms.GroupBox();
            this.rbEfectivo         = new System.Windows.Forms.RadioButton();
            this.rbYape             = new System.Windows.Forms.RadioButton();
            this.rbTransferencia    = new System.Windows.Forms.RadioButton();
            this.rbTarjeta          = new System.Windows.Forms.RadioButton();
            this.rbMixto            = new System.Windows.Forms.RadioButton();
            this.rbCredito          = new System.Windows.Forms.RadioButton();
            this.txtEfectivo        = new System.Windows.Forms.TextBox();
            this.txtYape            = new System.Windows.Forms.TextBox();
            this.txtTransferencia   = new System.Windows.Forms.TextBox();
            this.txtTarjeta         = new System.Windows.Forms.TextBox();
            this.lblRecibido        = new System.Windows.Forms.Label();
            this.txtRecibido        = new System.Windows.Forms.TextBox();
            this.lblVuelto          = new System.Windows.Forms.Label();
            this.txtVuelto          = new System.Windows.Forms.TextBox();
            this.lblLineaDivisora3  = new System.Windows.Forms.Label();
            this.lblLineaDivisora4  = new System.Windows.Forms.Label();
            // Buttons
            this.btnPrevia          = new System.Windows.Forms.Button();
            this.btnCobrar          = new System.Windows.Forms.Button();
            this.btnCancelar        = new System.Windows.Forms.Button();

            this.pnlBusqueda.SuspendLayout();
            this.pnlViewToggle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlDetalleVenta.SuspendLayout();
            this.pnlDetalleCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoVenta)).BeginInit();
            this.grpMetodoPago.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ═══════════════════════════════════════════════════════════
            // pnlHeader  (docked top, 55px)
            // ═══════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.btnHistorial);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 55;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Padding  = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.pnlHeader.TabIndex = 144;

            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblTitulo.Location  = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "Punto de Venta";

            this.btnHistorial.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnHistorial.BackColor = System.Drawing.Color.White;
            this.btnHistorial.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.btnHistorial.Location  = new System.Drawing.Point(1142, 10);
            this.btnHistorial.Name      = "btnHistorial";
            this.btnHistorial.Size      = new System.Drawing.Size(120, 32);
            this.btnHistorial.TabIndex  = 141;
            this.btnHistorial.Text      = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;

            // ═══════════════════════════════════════════════════════════
            // pnlBusqueda  (left panel)
            // ═══════════════════════════════════════════════════════════
            this.pnlBusqueda.Anchor = (System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.flpCategorias);
            this.pnlBusqueda.Controls.Add(this.pnlViewToggle);
            this.pnlBusqueda.Controls.Add(this.dgvProductos);
            this.pnlBusqueda.Controls.Add(this.flpProductCards);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 66);
            this.pnlBusqueda.Name     = "pnlBusqueda";
            this.pnlBusqueda.Padding  = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlBusqueda.Size     = new System.Drawing.Size(747, 738);
            this.pnlBusqueda.TabIndex = 120;

            // lblBuscar — repurposed as search prefix icon/label
            this.lblBuscar.AutoSize  = true;
            this.lblBuscar.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBuscar.Location  = new System.Drawing.Point(16, 16);
            this.lblBuscar.Name      = "lblBuscar";
            this.lblBuscar.TabIndex  = 112;
            this.lblBuscar.Text      = "🔍";

            // txtBuscar — search input
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font        = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBuscar.Location    = new System.Drawing.Point(44, 12);
            this.txtBuscar.Name        = "txtBuscar";
            this.txtBuscar.Size        = new System.Drawing.Size(693, 26);
            this.txtBuscar.TabIndex    = 111;

            // flpCategorias — horizontal chips
            this.flpCategorias.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.flpCategorias.AutoScroll   = false;
            this.flpCategorias.BackColor    = System.Drawing.Color.White;
            this.flpCategorias.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpCategorias.Location     = new System.Drawing.Point(12, 46);
            this.flpCategorias.Name         = "flpCategorias";
            this.flpCategorias.Padding      = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flpCategorias.Size         = new System.Drawing.Size(723, 42);
            this.flpCategorias.TabIndex     = 200;
            this.flpCategorias.WrapContents = false;

            // pnlViewToggle — list/card switch
            this.pnlViewToggle.BackColor = System.Drawing.Color.White;
            this.pnlViewToggle.Controls.Add(this.btnVistaLista);
            this.pnlViewToggle.Controls.Add(this.btnVistaCards);
            this.pnlViewToggle.Location = new System.Drawing.Point(12, 94);
            this.pnlViewToggle.Name     = "pnlViewToggle";
            this.pnlViewToggle.Size     = new System.Drawing.Size(200, 30);
            this.pnlViewToggle.TabIndex = 201;

            this.btnVistaLista.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnVistaLista.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnVistaLista.FlatAppearance.BorderSize = 0;
            this.btnVistaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistaLista.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnVistaLista.ForeColor = System.Drawing.Color.White;
            this.btnVistaLista.Location  = new System.Drawing.Point(0, 1);
            this.btnVistaLista.Name      = "btnVistaLista";
            this.btnVistaLista.Size      = new System.Drawing.Size(95, 26);
            this.btnVistaLista.TabIndex  = 0;
            this.btnVistaLista.Text      = "≡  Lista";

            this.btnVistaCards.BackColor = System.Drawing.Color.White;
            this.btnVistaCards.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnVistaCards.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnVistaCards.FlatAppearance.BorderSize  = 1;
            this.btnVistaCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistaCards.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnVistaCards.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.btnVistaCards.Location  = new System.Drawing.Point(100, 1);
            this.btnVistaCards.Name      = "btnVistaCards";
            this.btnVistaCards.Size      = new System.Drawing.Size(95, 26);
            this.btnVistaCards.TabIndex  = 1;
            this.btnVistaCards.Text      = "⊞  Cards";

            // dgvProductos — list view
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.Anchor = (System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.dgvProductos.AutoSizeRowsMode           = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor            = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle                = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle            = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle  = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNumero, this.colImagen, this.colProducto,
                this.colPresentacion, this.colPrecioUnit });
            dataGridViewCellStyle1.Alignment       = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor       = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor       = System.Drawing.Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle1.WrapMode        = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.DefaultCellStyle     = dataGridViewCellStyle1;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location             = new System.Drawing.Point(12, 130);
            this.dgvProductos.Name                 = "dgvProductos";
            this.dgvProductos.ReadOnly             = false;
            this.dgvProductos.RowHeadersVisible    = false;
            this.dgvProductos.RowTemplate.Height   = 48;
            this.dgvProductos.SelectionMode        = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size                 = new System.Drawing.Size(723, 592);
            this.dgvProductos.TabIndex             = 113;

            // flpProductCards — card view (hidden by default)
            this.flpProductCards.Anchor = (System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.flpProductCards.AutoScroll   = true;
            this.flpProductCards.BackColor    = System.Drawing.Color.FromArgb(248, 249, 252);
            this.flpProductCards.Location     = new System.Drawing.Point(12, 130);
            this.flpProductCards.Name         = "flpProductCards";
            this.flpProductCards.Padding      = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flpProductCards.Size         = new System.Drawing.Size(723, 592);
            this.flpProductCards.TabIndex     = 202;
            this.flpProductCards.Visible      = false;
            this.flpProductCards.WrapContents = true;

            // dgvProductos columns
            this.colNumero.HeaderText = "#";
            this.colNumero.Name       = "colNumero";
            this.colNumero.ReadOnly   = true;
            this.colNumero.Width      = 32;

            this.colImagen.HeaderText   = "";
            this.colImagen.ImageLayout  = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImagen.Name         = "colImagen";
            this.colImagen.ReadOnly     = true;
            this.colImagen.Resizable    = System.Windows.Forms.DataGridViewTriState.True;
            this.colImagen.SortMode     = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colImagen.Width        = 48;

            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText   = "Producto";
            this.colProducto.Name         = "colProducto";
            this.colProducto.ReadOnly     = true;

            this.colPresentacion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colPresentacion.FlatStyle    = System.Windows.Forms.FlatStyle.Flat;
            this.colPresentacion.HeaderText   = "Presentación";
            this.colPresentacion.Name         = "colPresentacion";
            this.colPresentacion.Width        = 185;

            this.colPrecioUnit.HeaderText = "Precio";
            this.colPrecioUnit.Name       = "colPrecioUnit";
            this.colPrecioUnit.ReadOnly   = true;
            this.colPrecioUnit.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrecioUnit.SortMode   = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrecioUnit.Width      = 80;

            // ═══════════════════════════════════════════════════════════
            // pnlDetalleVenta  (right panel)
            // ═══════════════════════════════════════════════════════════
            this.pnlDetalleVenta.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Right));
            this.pnlDetalleVenta.BackColor = System.Drawing.Color.White;
            this.pnlDetalleVenta.Controls.Add(this.lblSubTitulo2);
            this.pnlDetalleVenta.Controls.Add(this.pnlDetalleCliente);
            this.pnlDetalleVenta.Controls.Add(this.lblCarritoTitulo);
            this.pnlDetalleVenta.Controls.Add(this.dgvCarritoVenta);
            this.pnlDetalleVenta.Controls.Add(this.lblLineaDivisora);
            this.pnlDetalleVenta.Controls.Add(this.lblSubTotal);
            this.pnlDetalleVenta.Controls.Add(this.txtSubtotal);
            this.pnlDetalleVenta.Controls.Add(this.lblDescuento);
            this.pnlDetalleVenta.Controls.Add(this.txtDescuento);
            this.pnlDetalleVenta.Controls.Add(this.lblIGV);
            this.pnlDetalleVenta.Controls.Add(this.cboIGV);
            this.pnlDetalleVenta.Controls.Add(this.txtIGV);
            this.pnlDetalleVenta.Controls.Add(this.lblLineaDivisora2);
            this.pnlDetalleVenta.Controls.Add(this.lblTotalPagar);
            this.pnlDetalleVenta.Controls.Add(this.txtTotalPagar);
            // Hidden controls
            this.pnlDetalleVenta.Controls.Add(this.grpMetodoPago);
            this.pnlDetalleVenta.Controls.Add(this.lblRecibido);
            this.pnlDetalleVenta.Controls.Add(this.txtRecibido);
            this.pnlDetalleVenta.Controls.Add(this.lblVuelto);
            this.pnlDetalleVenta.Controls.Add(this.txtVuelto);
            this.pnlDetalleVenta.Controls.Add(this.lblLineaDivisora3);
            this.pnlDetalleVenta.Controls.Add(this.lblLineaDivisora4);
            // Buttons
            this.pnlDetalleVenta.Controls.Add(this.btnCancelar);
            this.pnlDetalleVenta.Controls.Add(this.btnPrevia);
            this.pnlDetalleVenta.Controls.Add(this.btnCobrar);
            this.pnlDetalleVenta.Location  = new System.Drawing.Point(770, 66);
            this.pnlDetalleVenta.Name      = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size      = new System.Drawing.Size(502, 738);
            this.pnlDetalleVenta.TabIndex  = 121;

            // lblSubTitulo2
            this.lblSubTitulo2.AutoSize  = true;
            this.lblSubTitulo2.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblSubTitulo2.Location  = new System.Drawing.Point(15, 10);
            this.lblSubTitulo2.Name      = "lblSubTitulo2";
            this.lblSubTitulo2.TabIndex  = 12;
            this.lblSubTitulo2.Text      = "DETALLE DE VENTA";

            // ── pnlDetalleCliente ─────────────────────────────────────
            this.pnlDetalleCliente.BackColor = System.Drawing.Color.White;
            this.pnlDetalleCliente.Controls.Add(this.lblTipoComprobante);
            this.pnlDetalleCliente.Controls.Add(this.cmbTipoComprobante);
            this.pnlDetalleCliente.Controls.Add(this.lblCliente);
            this.pnlDetalleCliente.Controls.Add(this.cmbClientes);
            this.pnlDetalleCliente.Controls.Add(this.btnBuscarCliente);
            this.pnlDetalleCliente.Controls.Add(this.lblNombreCliente);
            this.pnlDetalleCliente.Controls.Add(this.lblDNICliente);
            this.pnlDetalleCliente.Location = new System.Drawing.Point(15, 28);
            this.pnlDetalleCliente.Name     = "pnlDetalleCliente";
            this.pnlDetalleCliente.Size     = new System.Drawing.Size(472, 110);
            this.pnlDetalleCliente.TabIndex = 117;

            this.lblTipoComprobante.AutoSize  = true;
            this.lblTipoComprobante.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoComprobante.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTipoComprobante.Location  = new System.Drawing.Point(0, 5);
            this.lblTipoComprobante.Name      = "lblTipoComprobante";
            this.lblTipoComprobante.TabIndex  = 118;
            this.lblTipoComprobante.Text      = "Tipo Comprobante:";

            this.cmbTipoComprobante.BackColor = System.Drawing.Color.White;
            this.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComprobante.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Items.AddRange(new object[] { "BOLETA", "FACTURA", "NOTA_VENTA" });
            this.cmbTipoComprobante.Location  = new System.Drawing.Point(125, 2);
            this.cmbTipoComprobante.Name      = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size      = new System.Drawing.Size(200, 25);
            this.cmbTipoComprobante.TabIndex  = 2;

            this.lblCliente.AutoSize  = true;
            this.lblCliente.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblCliente.Location  = new System.Drawing.Point(0, 36);
            this.lblCliente.Name      = "lblCliente";
            this.lblCliente.TabIndex  = 113;
            this.lblCliente.Text      = "Cliente:";

            this.cmbClientes.BackColor = System.Drawing.Color.White;
            this.cmbClientes.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location  = new System.Drawing.Point(56, 33);
            this.cmbClientes.Name      = "cmbClientes";
            this.cmbClientes.Size      = new System.Drawing.Size(376, 25);
            this.cmbClientes.TabIndex  = 119;

            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarCliente.Location  = new System.Drawing.Point(438, 33);
            this.btnBuscarCliente.Name      = "btnBuscarCliente";
            this.btnBuscarCliente.Size      = new System.Drawing.Size(28, 25);
            this.btnBuscarCliente.TabIndex  = 114;
            this.btnBuscarCliente.Text      = "🔍";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;

            this.lblNombreCliente.AutoSize  = true;
            this.lblNombreCliente.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblNombreCliente.Location  = new System.Drawing.Point(0, 68);
            this.lblNombreCliente.Name      = "lblNombreCliente";
            this.lblNombreCliente.TabIndex  = 115;
            this.lblNombreCliente.Text      = "CLIENTE GENERAL";

            this.lblDNICliente.AutoSize  = true;
            this.lblDNICliente.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDNICliente.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblDNICliente.Location  = new System.Drawing.Point(350, 68);
            this.lblDNICliente.Name      = "lblDNICliente";
            this.lblDNICliente.TabIndex  = 116;
            this.lblDNICliente.Text      = "00000000";

            // ── Cart section ──────────────────────────────────────────
            this.lblCarritoTitulo.AutoSize  = true;
            this.lblCarritoTitulo.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCarritoTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCarritoTitulo.Location  = new System.Drawing.Point(15, 146);
            this.lblCarritoTitulo.Name      = "lblCarritoTitulo";
            this.lblCarritoTitulo.TabIndex  = 300;
            this.lblCarritoTitulo.Text      = "CARRITO";

            // dgvCarritoVenta — cart grid
            this.dgvCarritoVenta.AllowUserToAddRows = false;
            this.dgvCarritoVenta.AutoSizeRowsMode   = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarritoVenta.BackgroundColor    = System.Drawing.Color.White;
            this.dgvCarritoVenta.BorderStyle        = System.Windows.Forms.BorderStyle.None;
            this.dgvCarritoVenta.CellBorderStyle    = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarritoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCarritoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductoDV, this.colPresentacionDV, this.colCantPres,
                this.colDisminuir, this.colCantidad, this.colAumentar,
                this.colTotalDV, this.colEliminar });
            dataGridViewCellStyle3.Alignment       = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor       = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor       = System.Drawing.Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle3.WrapMode        = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarritoVenta.DefaultCellStyle  = dataGridViewCellStyle3;
            this.dgvCarritoVenta.EnableHeadersVisualStyles = false;
            this.dgvCarritoVenta.Location          = new System.Drawing.Point(15, 164);
            this.dgvCarritoVenta.Name              = "dgvCarritoVenta";
            this.dgvCarritoVenta.RowHeadersVisible = false;
            this.dgvCarritoVenta.RowTemplate.Height = 48;
            this.dgvCarritoVenta.SelectionMode     = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCarritoVenta.Size              = new System.Drawing.Size(472, 268);
            this.dgvCarritoVenta.TabIndex          = 114;

            // Cart columns
            this.colProductoDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductoDV.HeaderText   = "Producto";
            this.colProductoDV.Name         = "colProductoDV";
            this.colProductoDV.ReadOnly     = true;

            this.colPresentacionDV.HeaderText = "Presentación";
            this.colPresentacionDV.Name       = "colPresentacionDV";
            this.colPresentacionDV.ReadOnly   = true;
            this.colPresentacionDV.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.colPresentacionDV.SortMode   = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPresentacionDV.Width      = 65;

            this.colCantPres.HeaderText = "Pres.";
            this.colCantPres.Name       = "colCantPres";
            this.colCantPres.ReadOnly   = true;
            this.colCantPres.Visible    = false;
            this.colCantPres.Width      = 55;

            this.colDisminuir.HeaderText = "";
            this.colDisminuir.Name       = "colDisminuir";
            this.colDisminuir.ReadOnly   = true;
            this.colDisminuir.Width      = 26;

            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name       = "colCantidad";
            this.colCantidad.Width      = 60;

            this.colAumentar.HeaderText = "";
            this.colAumentar.Name       = "colAumentar";
            this.colAumentar.ReadOnly   = true;
            this.colAumentar.Width      = 26;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotalDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotalDV.HeaderText       = "Total";
            this.colTotalDV.Name             = "colTotalDV";
            this.colTotalDV.Resizable        = System.Windows.Forms.DataGridViewTriState.True;
            this.colTotalDV.SortMode         = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotalDV.Width            = 68;

            this.colEliminar.HeaderText = "";
            this.colEliminar.Name       = "colEliminar";
            this.colEliminar.Width      = 28;

            // ── Totals section ────────────────────────────────────────
            // Separator
            this.lblLineaDivisora.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblLineaDivisora.Location  = new System.Drawing.Point(15, 437);
            this.lblLineaDivisora.Name      = "lblLineaDivisora";
            this.lblLineaDivisora.Size      = new System.Drawing.Size(472, 1);
            this.lblLineaDivisora.TabIndex  = 119;

            // Subtotal / Op. Gravada
            this.lblSubTotal.AutoSize  = false;
            this.lblSubTotal.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblSubTotal.Location  = new System.Drawing.Point(15, 444);
            this.lblSubTotal.Name      = "lblSubTotal";
            this.lblSubTotal.Size      = new System.Drawing.Size(200, 22);
            this.lblSubTotal.TabIndex  = 118;
            this.lblSubTotal.Text      = "Op. Gravada";

            this.txtSubtotal.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSubtotal.Location  = new System.Drawing.Point(335, 444);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name      = "txtSubtotal";
            this.txtSubtotal.ReadOnly  = true;
            this.txtSubtotal.Size      = new System.Drawing.Size(150, 22);
            this.txtSubtotal.TabIndex  = 117;
            this.txtSubtotal.Text      = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Descuento
            this.lblDescuento.AutoSize  = false;
            this.lblDescuento.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblDescuento.Location  = new System.Drawing.Point(15, 472);
            this.lblDescuento.Name      = "lblDescuento";
            this.lblDescuento.Size      = new System.Drawing.Size(200, 22);
            this.lblDescuento.TabIndex  = 121;
            this.lblDescuento.Text      = "Descuento";

            this.txtDescuento.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescuento.Location  = new System.Drawing.Point(335, 471);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name      = "txtDescuento";
            this.txtDescuento.Size      = new System.Drawing.Size(150, 22);
            this.txtDescuento.TabIndex  = 120;
            this.txtDescuento.Text      = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // IGV row (label + cboIGV selector + value)
            this.lblIGV.AutoSize  = false;
            this.lblIGV.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIGV.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblIGV.Location  = new System.Drawing.Point(15, 500);
            this.lblIGV.Name      = "lblIGV";
            this.lblIGV.Size      = new System.Drawing.Size(65, 22);
            this.lblIGV.TabIndex  = 123;
            this.lblIGV.Text      = "IGV:";

            this.cboIGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIGV.Font          = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cboIGV.Items.AddRange(new object[] { "Sin IGV", "IGV Incluido", "IGV Adicional" });
            this.cboIGV.Location      = new System.Drawing.Point(80, 497);
            this.cboIGV.Name          = "cboIGV";
            this.cboIGV.Size          = new System.Drawing.Size(130, 24);
            this.cboIGV.SelectedIndex = 0;
            this.cboIGV.TabIndex      = 142;

            this.txtIGV.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.txtIGV.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGV.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIGV.Location  = new System.Drawing.Point(335, 500);
            this.txtIGV.Multiline = true;
            this.txtIGV.Name      = "txtIGV";
            this.txtIGV.ReadOnly  = true;
            this.txtIGV.Size      = new System.Drawing.Size(150, 22);
            this.txtIGV.TabIndex  = 122;
            this.txtIGV.Text      = "0.00";
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Separator 2
            this.lblLineaDivisora2.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblLineaDivisora2.Location  = new System.Drawing.Point(15, 528);
            this.lblLineaDivisora2.Name      = "lblLineaDivisora2";
            this.lblLineaDivisora2.Size      = new System.Drawing.Size(472, 2);
            this.lblLineaDivisora2.TabIndex  = 124;

            // TOTAL
            this.lblTotalPagar.AutoSize  = false;
            this.lblTotalPagar.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblTotalPagar.Location  = new System.Drawing.Point(15, 536);
            this.lblTotalPagar.Name      = "lblTotalPagar";
            this.lblTotalPagar.Size      = new System.Drawing.Size(150, 30);
            this.lblTotalPagar.TabIndex  = 126;
            this.lblTotalPagar.Text      = "TOTAL";

            this.txtTotalPagar.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.txtTotalPagar.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTotalPagar.Location  = new System.Drawing.Point(250, 532);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name      = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly  = true;
            this.txtTotalPagar.Size      = new System.Drawing.Size(235, 34);
            this.txtTotalPagar.TabIndex  = 125;
            this.txtTotalPagar.Text      = "0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // ── Hidden payment controls (logic compatibility) ─────────
            this.grpMetodoPago.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.rbEfectivo, this.rbYape, this.rbTransferencia,
                this.rbMixto, this.rbCredito, this.rbTarjeta,
                this.txtEfectivo, this.txtYape, this.txtTransferencia, this.txtTarjeta });
            this.grpMetodoPago.Location = new System.Drawing.Point(15, 900);
            this.grpMetodoPago.Name     = "grpMetodoPago";
            this.grpMetodoPago.Size     = new System.Drawing.Size(248, 170);
            this.grpMetodoPago.TabIndex = 141;
            this.grpMetodoPago.Text     = "Método de Pago";
            this.grpMetodoPago.Visible  = false;

            this.rbEfectivo.AutoSize = true; this.rbEfectivo.Location = new System.Drawing.Point(8, 22);
            this.rbEfectivo.Name = "rbEfectivo"; this.rbEfectivo.Text = "Efectivo"; this.rbEfectivo.TabIndex = 129;
            this.rbYape.AutoSize = true; this.rbYape.Location = new System.Drawing.Point(8, 46);
            this.rbYape.Name = "rbYape"; this.rbYape.Text = "Yape"; this.rbYape.TabIndex = 130;
            this.rbTransferencia.AutoSize = true; this.rbTransferencia.Location = new System.Drawing.Point(8, 70);
            this.rbTransferencia.Name = "rbTransferencia"; this.rbTransferencia.Text = "Transferencia"; this.rbTransferencia.TabIndex = 131;
            this.rbMixto.AutoSize = true; this.rbMixto.Location = new System.Drawing.Point(8, 119);
            this.rbMixto.Name = "rbMixto"; this.rbMixto.Text = "Mixto"; this.rbMixto.TabIndex = 132;
            this.rbCredito.AutoSize = true; this.rbCredito.Location = new System.Drawing.Point(8, 143);
            this.rbCredito.Name = "rbCredito"; this.rbCredito.Text = "Crédito"; this.rbCredito.TabIndex = 133;
            this.rbTarjeta.AutoSize = true; this.rbTarjeta.Location = new System.Drawing.Point(8, 94);
            this.rbTarjeta.Name = "rbTarjeta"; this.rbTarjeta.Text = "Tarjeta"; this.rbTarjeta.TabIndex = 136;

            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivo.Location = new System.Drawing.Point(155, 25); this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(87, 21); this.txtEfectivo.TabIndex = 117;
            this.txtYape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYape.Location = new System.Drawing.Point(155, 48); this.txtYape.Name = "txtYape";
            this.txtYape.Size = new System.Drawing.Size(87, 21); this.txtYape.TabIndex = 134;
            this.txtTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransferencia.Location = new System.Drawing.Point(155, 71); this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(87, 21); this.txtTransferencia.TabIndex = 135;
            this.txtTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarjeta.Location = new System.Drawing.Point(155, 94); this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(87, 21); this.txtTarjeta.TabIndex = 137;

            this.lblRecibido.Location = new System.Drawing.Point(15, 900); this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Text = "RECIBIDO:"; this.lblRecibido.Visible = false; this.lblRecibido.Size = new System.Drawing.Size(80, 17);
            this.txtRecibido.Location = new System.Drawing.Point(100, 900); this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(90, 20); this.txtRecibido.Visible = false;
            this.lblVuelto.Location = new System.Drawing.Point(15, 920); this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Text = "VUELTO:"; this.lblVuelto.Visible = false; this.lblVuelto.Size = new System.Drawing.Size(80, 17);
            this.txtVuelto.Location = new System.Drawing.Point(100, 920); this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(90, 20); this.txtVuelto.Visible = false;
            this.lblLineaDivisora3.Location = new System.Drawing.Point(15, 950); this.lblLineaDivisora3.Name = "lblLineaDivisora3";
            this.lblLineaDivisora3.Size = new System.Drawing.Size(0, 1); this.lblLineaDivisora3.Visible = false;
            this.lblLineaDivisora4.Location = new System.Drawing.Point(15, 960); this.lblLineaDivisora4.Name = "lblLineaDivisora4";
            this.lblLineaDivisora4.Size = new System.Drawing.Size(0, 1); this.lblLineaDivisora4.Visible = false;

            // ── Action buttons ────────────────────────────────────────
            this.btnCancelar.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location  = new System.Drawing.Point(15, 694);
            this.btnCancelar.Name      = "btnCancelar";
            this.btnCancelar.Size      = new System.Drawing.Size(130, 34);
            this.btnCancelar.TabIndex  = 142;
            this.btnCancelar.Text      = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            this.btnPrevia.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnPrevia.BackColor = System.Drawing.Color.White;
            this.btnPrevia.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPrevia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            this.btnPrevia.FlatAppearance.BorderSize  = 1;
            this.btnPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevia.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevia.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPrevia.Location  = new System.Drawing.Point(154, 694);
            this.btnPrevia.Name      = "btnPrevia";
            this.btnPrevia.Size      = new System.Drawing.Size(130, 34);
            this.btnPrevia.TabIndex  = 303;
            this.btnPrevia.Text      = "Vista Previa";
            this.btnPrevia.UseVisualStyleBackColor = false;

            this.btnCobrar.Anchor    = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnCobrar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 150, 80);
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location  = new System.Drawing.Point(295, 688);
            this.btnCobrar.Name      = "btnCobrar";
            this.btnCobrar.Size      = new System.Drawing.Size(192, 40);
            this.btnCobrar.TabIndex  = 139;
            this.btnCobrar.Text      = "COBRAR / EMITIR";
            this.btnCobrar.UseVisualStyleBackColor = false;

            // ═══════════════════════════════════════════════════════════
            // FormVentas
            // ═══════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode  = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor      = System.Drawing.Color.FromArgb(244, 244, 250);
            this.ClientSize     = new System.Drawing.Size(1284, 824);
            this.Controls.Add(this.pnlDetalleVenta);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormVentas";
            this.Text = "Punto de Venta";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlViewToggle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.PerformLayout();
            this.pnlDetalleCliente.ResumeLayout(false);
            this.pnlDetalleCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoVenta)).EndInit();
            this.grpMetodoPago.ResumeLayout(false);
            this.grpMetodoPago.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Control declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel              pnlHeader;
        private System.Windows.Forms.Label              lblTitulo;
        private System.Windows.Forms.Button             btnHistorial;
        private System.Windows.Forms.Panel              pnlBusqueda;
        private System.Windows.Forms.Label              lblBuscar;
        private System.Windows.Forms.TextBox            txtBuscar;
        private System.Windows.Forms.FlowLayoutPanel    flpCategorias;
        private System.Windows.Forms.Panel              pnlViewToggle;
        private System.Windows.Forms.Button             btnVistaLista;
        private System.Windows.Forms.Button             btnVistaCards;
        private System.Windows.Forms.DataGridView       dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colNumero;
        private System.Windows.Forms.DataGridViewImageColumn    colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colProducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colPrecioUnit;
        private System.Windows.Forms.FlowLayoutPanel    flpProductCards;
        private System.Windows.Forms.Panel              pnlDetalleVenta;
        private System.Windows.Forms.Label              lblSubTitulo2;
        private System.Windows.Forms.Panel              pnlDetalleCliente;
        private System.Windows.Forms.Label              lblTipoComprobante;
        private System.Windows.Forms.ComboBox           cmbTipoComprobante;
        private System.Windows.Forms.Label              lblCliente;
        private System.Windows.Forms.ComboBox           cmbClientes;
        private System.Windows.Forms.Button             btnBuscarCliente;
        private System.Windows.Forms.Label              lblNombreCliente;
        private System.Windows.Forms.Label              lblDNICliente;
        private System.Windows.Forms.Label              lblCarritoTitulo;
        private System.Windows.Forms.DataGridView       dgvCarritoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colProductoDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colPresentacionDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colCantPres;
        private System.Windows.Forms.DataGridViewImageColumn    colDisminuir;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colCantidad;
        private System.Windows.Forms.DataGridViewImageColumn    colAumentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn  colTotalDV;
        private System.Windows.Forms.DataGridViewImageColumn    colEliminar;
        private System.Windows.Forms.Label              lblLineaDivisora;
        private System.Windows.Forms.Label              lblSubTotal;
        private System.Windows.Forms.TextBox            txtSubtotal;
        private System.Windows.Forms.Label              lblDescuento;
        private System.Windows.Forms.TextBox            txtDescuento;
        private System.Windows.Forms.Label              lblIGV;
        private System.Windows.Forms.ComboBox           cboIGV;
        private System.Windows.Forms.TextBox            txtIGV;
        private System.Windows.Forms.Label              lblLineaDivisora2;
        private System.Windows.Forms.Label              lblTotalPagar;
        private System.Windows.Forms.TextBox            txtTotalPagar;
        // Hidden payment controls
        private System.Windows.Forms.GroupBox           grpMetodoPago;
        private System.Windows.Forms.RadioButton        rbEfectivo;
        private System.Windows.Forms.RadioButton        rbYape;
        private System.Windows.Forms.RadioButton        rbTransferencia;
        private System.Windows.Forms.RadioButton        rbTarjeta;
        private System.Windows.Forms.RadioButton        rbMixto;
        private System.Windows.Forms.RadioButton        rbCredito;
        private System.Windows.Forms.TextBox            txtEfectivo;
        private System.Windows.Forms.TextBox            txtYape;
        private System.Windows.Forms.TextBox            txtTransferencia;
        private System.Windows.Forms.TextBox            txtTarjeta;
        private System.Windows.Forms.Label              lblRecibido;
        private System.Windows.Forms.TextBox            txtRecibido;
        private System.Windows.Forms.Label              lblVuelto;
        private System.Windows.Forms.TextBox            txtVuelto;
        private System.Windows.Forms.Label              lblLineaDivisora3;
        private System.Windows.Forms.Label              lblLineaDivisora4;
        // Buttons
        private System.Windows.Forms.Button             btnPrevia;
        private System.Windows.Forms.Button             btnCobrar;
        private System.Windows.Forms.Button             btnCancelar;
    }
}
