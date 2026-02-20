namespace SistemaPOS.Forms.Contactos
{
    partial class FormEstadoCuenta
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBadgeEstado = new System.Windows.Forms.Label();
            this.lblSubtituloHeader = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlInfoCliente = new System.Windows.Forms.Panel();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblSepInfo = new System.Windows.Forms.Label();
            this.lblNombreLabel = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblDocumentoLabel = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblTelefonoLabel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEstadoLabel = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();

            this.pnlResumenFinanciero = new System.Windows.Forms.Panel();
            this.lblResumenTitulo = new System.Windows.Forms.Label();
            this.lblSepResumen = new System.Windows.Forms.Label();
            this.lblTotalVentasLabel = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.lblTotalPagosLabel = new System.Windows.Forms.Label();
            this.txtTotalPagos = new System.Windows.Forms.TextBox();
            this.pnlSaldoDestacado = new System.Windows.Forms.Panel();
            this.lblSaldoPendienteLabel = new System.Windows.Forms.Label();
            this.txtSaldoPendiente = new System.Windows.Forms.TextBox();
            this.lblSepCredito = new System.Windows.Forms.Label();
            this.lblLimiteCreditoLabel = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblCreditoUtilizadoLabel = new System.Windows.Forms.Label();
            this.txtCreditoUtilizado = new System.Windows.Forms.TextBox();
            this.lblCreditoDisponibleLabel = new System.Windows.Forms.Label();
            this.txtCreditoDisponible = new System.Windows.Forms.TextBox();

            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFiltroFechas = new System.Windows.Forms.Panel();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorialMovimientos = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnImprimirEstado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlInfoCliente.SuspendLayout();
            this.pnlResumenFinanciero.SuspendLayout();
            this.pnlSaldoDestacado.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlFiltroFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMovimientos)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // =====================================================================
            // pnlHeader
            // =====================================================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.pnlHeader.Controls.Add(this.lblBadgeEstado);
            this.pnlHeader.Controls.Add(this.lblSubtituloHeader);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 72;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estado de Cuenta";
            //
            // lblSubtituloHeader
            //
            this.lblSubtituloHeader.AutoSize = true;
            this.lblSubtituloHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloHeader.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblSubtituloHeader.Location = new System.Drawing.Point(22, 44);
            this.lblSubtituloHeader.Name = "lblSubtituloHeader";
            this.lblSubtituloHeader.TabIndex = 1;
            this.lblSubtituloHeader.Text = "Resumen de cuenta y movimientos del cliente";
            //
            // lblBadgeEstado
            //
            this.lblBadgeEstado.AutoSize = false;
            this.lblBadgeEstado.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblBadgeEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBadgeEstado.ForeColor = System.Drawing.Color.White;
            this.lblBadgeEstado.Location = new System.Drawing.Point(900, 22);
            this.lblBadgeEstado.Name = "lblBadgeEstado";
            this.lblBadgeEstado.Size = new System.Drawing.Size(80, 26);
            this.lblBadgeEstado.TabIndex = 2;
            this.lblBadgeEstado.Text = "ACTIVO";
            this.lblBadgeEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================================
            // pnlLeft
            // =====================================================================
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlLeft.Controls.Add(this.pnlResumenFinanciero);
            this.pnlLeft.Controls.Add(this.pnlInfoCliente);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.Width = 320;

            // =====================================================================
            // pnlInfoCliente  (8, 8)  302 x 220
            // =====================================================================
            this.pnlInfoCliente.BackColor = System.Drawing.Color.White;
            this.pnlInfoCliente.Controls.Add(this.txtEstado);
            this.pnlInfoCliente.Controls.Add(this.lblEstadoLabel);
            this.pnlInfoCliente.Controls.Add(this.txtEmail);
            this.pnlInfoCliente.Controls.Add(this.lblEmailLabel);
            this.pnlInfoCliente.Controls.Add(this.txtTelefono);
            this.pnlInfoCliente.Controls.Add(this.lblTelefonoLabel);
            this.pnlInfoCliente.Controls.Add(this.txtDocumento);
            this.pnlInfoCliente.Controls.Add(this.lblDocumentoLabel);
            this.pnlInfoCliente.Controls.Add(this.txtCliente);
            this.pnlInfoCliente.Controls.Add(this.lblNombreLabel);
            this.pnlInfoCliente.Controls.Add(this.lblSepInfo);
            this.pnlInfoCliente.Controls.Add(this.lblInfoTitulo);
            this.pnlInfoCliente.Location = new System.Drawing.Point(8, 8);
            this.pnlInfoCliente.Name = "pnlInfoCliente";
            this.pnlInfoCliente.Size = new System.Drawing.Size(302, 220);
            this.pnlInfoCliente.TabIndex = 0;
            //
            // lblInfoTitulo
            //
            this.lblInfoTitulo.AutoSize = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblInfoTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.TabIndex = 0;
            this.lblInfoTitulo.Text = "INFORMACIÓN DEL CLIENTE";
            //
            // lblSepInfo
            //
            this.lblSepInfo.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSepInfo.Location = new System.Drawing.Point(12, 32);
            this.lblSepInfo.Name = "lblSepInfo";
            this.lblSepInfo.Size = new System.Drawing.Size(278, 1);
            this.lblSepInfo.TabIndex = 1;
            //
            // Row 1: Nombre  y=40
            //
            this.lblNombreLabel.AutoSize = true;
            this.lblNombreLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombreLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblNombreLabel.Location = new System.Drawing.Point(12, 43);
            this.lblNombreLabel.Name = "lblNombreLabel";
            this.lblNombreLabel.TabIndex = 2;
            this.lblNombreLabel.Text = "Nombre:";

            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtCliente.Location = new System.Drawing.Point(100, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(190, 22);
            this.txtCliente.TabIndex = 3;
            //
            // Row 2: Documento  y=68
            //
            this.lblDocumentoLabel.AutoSize = true;
            this.lblDocumentoLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDocumentoLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblDocumentoLabel.Location = new System.Drawing.Point(12, 71);
            this.lblDocumentoLabel.Name = "lblDocumentoLabel";
            this.lblDocumentoLabel.TabIndex = 4;
            this.lblDocumentoLabel.Text = "Documento:";

            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtDocumento.Location = new System.Drawing.Point(100, 70);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(190, 22);
            this.txtDocumento.TabIndex = 5;
            //
            // Row 3: Teléfono  y=96
            //
            this.lblTelefonoLabel.AutoSize = true;
            this.lblTelefonoLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTelefonoLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTelefonoLabel.Location = new System.Drawing.Point(12, 99);
            this.lblTelefonoLabel.Name = "lblTelefonoLabel";
            this.lblTelefonoLabel.TabIndex = 6;
            this.lblTelefonoLabel.Text = "Teléfono:";

            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtTelefono.Location = new System.Drawing.Point(100, 98);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(190, 22);
            this.txtTelefono.TabIndex = 7;
            //
            // Row 4: Email  y=124
            //
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblEmailLabel.Location = new System.Drawing.Point(12, 127);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.TabIndex = 8;
            this.lblEmailLabel.Text = "Email:";

            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtEmail.Location = new System.Drawing.Point(100, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(190, 22);
            this.txtEmail.TabIndex = 9;
            //
            // Row 5: Estado  y=152
            //
            this.lblEstadoLabel.AutoSize = true;
            this.lblEstadoLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstadoLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblEstadoLabel.Location = new System.Drawing.Point(12, 155);
            this.lblEstadoLabel.Name = "lblEstadoLabel";
            this.lblEstadoLabel.TabIndex = 10;
            this.lblEstadoLabel.Text = "Estado:";

            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtEstado.Location = new System.Drawing.Point(100, 154);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(190, 22);
            this.txtEstado.TabIndex = 11;

            // =====================================================================
            // pnlResumenFinanciero  (8, 236)  302 x 286
            // =====================================================================
            this.pnlResumenFinanciero.BackColor = System.Drawing.Color.White;
            this.pnlResumenFinanciero.Controls.Add(this.txtCreditoDisponible);
            this.pnlResumenFinanciero.Controls.Add(this.lblCreditoDisponibleLabel);
            this.pnlResumenFinanciero.Controls.Add(this.txtCreditoUtilizado);
            this.pnlResumenFinanciero.Controls.Add(this.lblCreditoUtilizadoLabel);
            this.pnlResumenFinanciero.Controls.Add(this.txtLimiteCredito);
            this.pnlResumenFinanciero.Controls.Add(this.lblLimiteCreditoLabel);
            this.pnlResumenFinanciero.Controls.Add(this.lblSepCredito);
            this.pnlResumenFinanciero.Controls.Add(this.pnlSaldoDestacado);
            this.pnlResumenFinanciero.Controls.Add(this.txtTotalPagos);
            this.pnlResumenFinanciero.Controls.Add(this.lblTotalPagosLabel);
            this.pnlResumenFinanciero.Controls.Add(this.txtTotalVentas);
            this.pnlResumenFinanciero.Controls.Add(this.lblTotalVentasLabel);
            this.pnlResumenFinanciero.Controls.Add(this.lblSepResumen);
            this.pnlResumenFinanciero.Controls.Add(this.lblResumenTitulo);
            this.pnlResumenFinanciero.Location = new System.Drawing.Point(8, 236);
            this.pnlResumenFinanciero.Name = "pnlResumenFinanciero";
            this.pnlResumenFinanciero.Size = new System.Drawing.Size(302, 286);
            this.pnlResumenFinanciero.TabIndex = 1;
            //
            // lblResumenTitulo
            //
            this.lblResumenTitulo.AutoSize = true;
            this.lblResumenTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblResumenTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblResumenTitulo.Name = "lblResumenTitulo";
            this.lblResumenTitulo.TabIndex = 0;
            this.lblResumenTitulo.Text = "RESUMEN FINANCIERO";
            //
            // lblSepResumen
            //
            this.lblSepResumen.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSepResumen.Location = new System.Drawing.Point(12, 32);
            this.lblSepResumen.Name = "lblSepResumen";
            this.lblSepResumen.Size = new System.Drawing.Size(278, 1);
            this.lblSepResumen.TabIndex = 1;
            //
            // Row 1: Total Ventas  y=40
            //
            this.lblTotalVentasLabel.AutoSize = true;
            this.lblTotalVentasLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalVentasLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTotalVentasLabel.Location = new System.Drawing.Point(12, 43);
            this.lblTotalVentasLabel.Name = "lblTotalVentasLabel";
            this.lblTotalVentasLabel.TabIndex = 2;
            this.lblTotalVentasLabel.Text = "Total Ventas:";

            this.txtTotalVentas.BackColor = System.Drawing.Color.White;
            this.txtTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVentas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTotalVentas.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtTotalVentas.Location = new System.Drawing.Point(170, 42);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(118, 22);
            this.txtTotalVentas.TabIndex = 3;
            this.txtTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // Row 2: Total Pagos  y=68
            //
            this.lblTotalPagosLabel.AutoSize = true;
            this.lblTotalPagosLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalPagosLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblTotalPagosLabel.Location = new System.Drawing.Point(12, 71);
            this.lblTotalPagosLabel.Name = "lblTotalPagosLabel";
            this.lblTotalPagosLabel.TabIndex = 4;
            this.lblTotalPagosLabel.Text = "Total Pagos:";

            this.txtTotalPagos.BackColor = System.Drawing.Color.White;
            this.txtTotalPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTotalPagos.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtTotalPagos.Location = new System.Drawing.Point(170, 70);
            this.txtTotalPagos.Name = "txtTotalPagos";
            this.txtTotalPagos.ReadOnly = true;
            this.txtTotalPagos.Size = new System.Drawing.Size(118, 22);
            this.txtTotalPagos.TabIndex = 5;
            this.txtTotalPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlSaldoDestacado  y=100  282 x 48
            //
            this.pnlSaldoDestacado.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.pnlSaldoDestacado.Controls.Add(this.txtSaldoPendiente);
            this.pnlSaldoDestacado.Controls.Add(this.lblSaldoPendienteLabel);
            this.pnlSaldoDestacado.Location = new System.Drawing.Point(10, 100);
            this.pnlSaldoDestacado.Name = "pnlSaldoDestacado";
            this.pnlSaldoDestacado.Size = new System.Drawing.Size(282, 48);
            this.pnlSaldoDestacado.TabIndex = 10;
            //
            // lblSaldoPendienteLabel
            //
            this.lblSaldoPendienteLabel.AutoSize = true;
            this.lblSaldoPendienteLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSaldoPendienteLabel.ForeColor = System.Drawing.Color.FromArgb(214, 48, 49);
            this.lblSaldoPendienteLabel.Location = new System.Drawing.Point(10, 8);
            this.lblSaldoPendienteLabel.Name = "lblSaldoPendienteLabel";
            this.lblSaldoPendienteLabel.TabIndex = 0;
            this.lblSaldoPendienteLabel.Text = "SALDO PENDIENTE:";
            //
            // txtSaldoPendiente
            //
            this.txtSaldoPendiente.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.txtSaldoPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldoPendiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtSaldoPendiente.ForeColor = System.Drawing.Color.FromArgb(214, 48, 49);
            this.txtSaldoPendiente.Location = new System.Drawing.Point(155, 8);
            this.txtSaldoPendiente.Name = "txtSaldoPendiente";
            this.txtSaldoPendiente.ReadOnly = true;
            this.txtSaldoPendiente.Size = new System.Drawing.Size(118, 26);
            this.txtSaldoPendiente.TabIndex = 1;
            this.txtSaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSepCredito  y=158
            //
            this.lblSepCredito.BackColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.lblSepCredito.Location = new System.Drawing.Point(12, 158);
            this.lblSepCredito.Name = "lblSepCredito";
            this.lblSepCredito.Size = new System.Drawing.Size(278, 1);
            this.lblSepCredito.TabIndex = 11;
            //
            // Row: Límite Crédito  y=166
            //
            this.lblLimiteCreditoLabel.AutoSize = true;
            this.lblLimiteCreditoLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLimiteCreditoLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblLimiteCreditoLabel.Location = new System.Drawing.Point(12, 169);
            this.lblLimiteCreditoLabel.Name = "lblLimiteCreditoLabel";
            this.lblLimiteCreditoLabel.TabIndex = 12;
            this.lblLimiteCreditoLabel.Text = "Límite de Crédito:";

            this.txtLimiteCredito.BackColor = System.Drawing.Color.White;
            this.txtLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtLimiteCredito.Location = new System.Drawing.Point(170, 168);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.ReadOnly = true;
            this.txtLimiteCredito.Size = new System.Drawing.Size(118, 22);
            this.txtLimiteCredito.TabIndex = 13;
            this.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // Row: Crédito Utilizado  y=194
            //
            this.lblCreditoUtilizadoLabel.AutoSize = true;
            this.lblCreditoUtilizadoLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCreditoUtilizadoLabel.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCreditoUtilizadoLabel.Location = new System.Drawing.Point(12, 197);
            this.lblCreditoUtilizadoLabel.Name = "lblCreditoUtilizadoLabel";
            this.lblCreditoUtilizadoLabel.TabIndex = 14;
            this.lblCreditoUtilizadoLabel.Text = "Crédito Utilizado:";

            this.txtCreditoUtilizado.BackColor = System.Drawing.Color.White;
            this.txtCreditoUtilizado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditoUtilizado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCreditoUtilizado.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.txtCreditoUtilizado.Location = new System.Drawing.Point(170, 196);
            this.txtCreditoUtilizado.Name = "txtCreditoUtilizado";
            this.txtCreditoUtilizado.ReadOnly = true;
            this.txtCreditoUtilizado.Size = new System.Drawing.Size(118, 22);
            this.txtCreditoUtilizado.TabIndex = 15;
            this.txtCreditoUtilizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // Row: Crédito Disponible  y=222
            //
            this.lblCreditoDisponibleLabel.AutoSize = true;
            this.lblCreditoDisponibleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCreditoDisponibleLabel.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblCreditoDisponibleLabel.Location = new System.Drawing.Point(12, 225);
            this.lblCreditoDisponibleLabel.Name = "lblCreditoDisponibleLabel";
            this.lblCreditoDisponibleLabel.TabIndex = 16;
            this.lblCreditoDisponibleLabel.Text = "Crédito Disponible:";

            this.txtCreditoDisponible.BackColor = System.Drawing.Color.White;
            this.txtCreditoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditoDisponible.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCreditoDisponible.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtCreditoDisponible.Location = new System.Drawing.Point(158, 222);
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.ReadOnly = true;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(130, 26);
            this.txtCreditoDisponible.TabIndex = 17;
            this.txtCreditoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // =====================================================================
            // pnlRight
            // =====================================================================
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvHistorialMovimientos);
            this.pnlRight.Controls.Add(this.pnlFiltroFechas);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.TabIndex = 2;
            //
            // pnlFiltroFechas
            //
            this.pnlFiltroFechas.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlFiltroFechas.Controls.Add(this.dtpHasta);
            this.pnlFiltroFechas.Controls.Add(this.lblHasta);
            this.pnlFiltroFechas.Controls.Add(this.dtpDesde);
            this.pnlFiltroFechas.Controls.Add(this.lblDesde);
            this.pnlFiltroFechas.Controls.Add(this.lblHistorialTitulo);
            this.pnlFiltroFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroFechas.Height = 50;
            this.pnlFiltroFechas.Name = "pnlFiltroFechas";
            this.pnlFiltroFechas.TabIndex = 0;
            //
            // lblHistorialTitulo
            //
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistorialTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblHistorialTitulo.Location = new System.Drawing.Point(12, 16);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "HISTORIAL DE MOVIMIENTOS";
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesde.Location = new System.Drawing.Point(290, 17);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(340, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 23);
            this.dtpDesde.TabIndex = 2;
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHasta.Location = new System.Drawing.Point(450, 17);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(498, 13);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(100, 23);
            this.dtpHasta.TabIndex = 4;
            //
            // dgvHistorialMovimientos
            //
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);

            this.dgvHistorialMovimientos.AllowUserToAddRows = false;
            this.dgvHistorialMovimientos.AllowUserToDeleteRows = false;
            this.dgvHistorialMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHistorialMovimientos.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvHistorialMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFechaHora,
            this.colTipo,
            this.colDetalle,
            this.colCargo,
            this.colAbono,
            this.colSaldo});
            this.dgvHistorialMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialMovimientos.EnableHeadersVisualStyles = false;
            this.dgvHistorialMovimientos.GridColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.dgvHistorialMovimientos.Name = "dgvHistorialMovimientos";
            this.dgvHistorialMovimientos.ReadOnly = true;
            this.dgvHistorialMovimientos.RowHeadersVisible = false;
            this.dgvHistorialMovimientos.RowTemplate.Height = 34;
            this.dgvHistorialMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialMovimientos.TabIndex = 1;
            //
            // colNumero
            //
            this.colNumero.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumero.HeaderText = "#";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 40;
            //
            // colFechaHora
            //
            this.colFechaHora.HeaderText = "Fecha / Hora";
            this.colFechaHora.Name = "colFechaHora";
            this.colFechaHora.ReadOnly = true;
            this.colFechaHora.Width = 135;
            //
            // colTipo
            //
            this.colTipo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 100;
            //
            // colDetalle
            //
            this.colDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            //
            // colCargo
            //
            this.colCargo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.ReadOnly = true;
            this.colCargo.Width = 110;
            //
            // colAbono
            //
            this.colAbono.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAbono.HeaderText = "Abono";
            this.colAbono.Name = "colAbono";
            this.colAbono.ReadOnly = true;
            this.colAbono.Width = 110;
            //
            // colSaldo
            //
            this.colSaldo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Width = 110;

            // =====================================================================
            // pnlFooter
            // =====================================================================
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnCerrar);
            this.pnlFooter.Controls.Add(this.btnImprimirEstado);
            this.pnlFooter.Controls.Add(this.btnRegistrarPago);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 56;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.TabIndex = 3;
            //
            // btnRegistrarPago
            //
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(0, 184, 148);
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 160, 130);
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.Location = new System.Drawing.Point(15, 11);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(160, 34);
            this.btnRegistrarPago.TabIndex = 0;
            this.btnRegistrarPago.Text = "Registrar Cobro";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            //
            // btnImprimirEstado
            //
            this.btnImprimirEstado.BackColor = System.Drawing.Color.White;
            this.btnImprimirEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.btnImprimirEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.btnImprimirEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnImprimirEstado.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.btnImprimirEstado.Location = new System.Drawing.Point(185, 11);
            this.btnImprimirEstado.Name = "btnImprimirEstado";
            this.btnImprimirEstado.Size = new System.Drawing.Size(140, 34);
            this.btnImprimirEstado.TabIndex = 1;
            this.btnImprimirEstado.Text = "Exportar Estado";
            this.btnImprimirEstado.UseVisualStyleBackColor = false;
            //
            // btnCerrar
            //
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(870, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 34);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;

            // =====================================================================
            // FormEstadoCuenta
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadoCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estado de Cuenta";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlInfoCliente.ResumeLayout(false);
            this.pnlInfoCliente.PerformLayout();
            this.pnlResumenFinanciero.ResumeLayout(false);
            this.pnlResumenFinanciero.PerformLayout();
            this.pnlSaldoDestacado.ResumeLayout(false);
            this.pnlSaldoDestacado.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlFiltroFechas.ResumeLayout(false);
            this.pnlFiltroFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMovimientos)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // =====================================================================
        // Field declarations
        // =====================================================================
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtituloHeader;
        private System.Windows.Forms.Label lblBadgeEstado;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlInfoCliente;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Label lblSepInfo;
        private System.Windows.Forms.Label lblNombreLabel;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblDocumentoLabel;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblTelefonoLabel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEstadoLabel;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel pnlResumenFinanciero;
        private System.Windows.Forms.Label lblResumenTitulo;
        private System.Windows.Forms.Label lblSepResumen;
        private System.Windows.Forms.Label lblTotalVentasLabel;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label lblTotalPagosLabel;
        private System.Windows.Forms.TextBox txtTotalPagos;
        private System.Windows.Forms.Panel pnlSaldoDestacado;
        private System.Windows.Forms.Label lblSaldoPendienteLabel;
        private System.Windows.Forms.TextBox txtSaldoPendiente;
        private System.Windows.Forms.Label lblSepCredito;
        private System.Windows.Forms.Label lblLimiteCreditoLabel;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label lblCreditoUtilizadoLabel;
        private System.Windows.Forms.TextBox txtCreditoUtilizado;
        private System.Windows.Forms.Label lblCreditoDisponibleLabel;
        private System.Windows.Forms.TextBox txtCreditoDisponible;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFiltroFechas;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DataGridView dgvHistorialMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnImprimirEstado;
        private System.Windows.Forms.Button btnCerrar;
    }
}
