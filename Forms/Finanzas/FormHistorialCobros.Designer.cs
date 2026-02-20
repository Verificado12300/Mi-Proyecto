namespace SistemaPOS.Forms.Finanzas
{
    partial class FormHistorialCobros
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
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlCardSaldo = new System.Windows.Forms.Panel();
            this.lblCardSaldo = new System.Windows.Forms.Label();
            this.lblCardSaldoTitulo = new System.Windows.Forms.Label();
            this.pnlCardPagado = new System.Windows.Forms.Panel();
            this.lblCardPagado = new System.Windows.Forms.Label();
            this.lblCardPagadoTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.lblCardTotalTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblSinPagos = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardSaldo.SuspendLayout();
            this.pnlCardPagado.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.pnlHeader.Controls.Add(this.lblEstado);
            this.pnlHeader.Controls.Add(this.lblFechaVenta);
            this.pnlHeader.Controls.Add(this.lblVencimiento);
            this.pnlHeader.Controls.Add(this.lblNumeroVenta);
            this.pnlHeader.Controls.Add(this.lblNombreCliente);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            //
            // lblNombreCliente
            //
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 12);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(200, 24);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Cliente";
            //
            // lblNumeroVenta
            //
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNumeroVenta.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblNumeroVenta.Location = new System.Drawing.Point(20, 42);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(100, 15);
            this.lblNumeroVenta.TabIndex = 1;
            this.lblNumeroVenta.Text = "Venta: -";
            //
            // lblFechaVenta
            //
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFechaVenta.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblFechaVenta.Location = new System.Drawing.Point(200, 42);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(100, 15);
            this.lblFechaVenta.TabIndex = 2;
            this.lblFechaVenta.Text = "Fecha: -";
            //
            // lblVencimiento
            //
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVencimiento.ForeColor = System.Drawing.Color.FromArgb(178, 190, 195);
            this.lblVencimiento.Location = new System.Drawing.Point(380, 42);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(100, 15);
            this.lblVencimiento.TabIndex = 3;
            this.lblVencimiento.Text = "Vence: -";
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = false;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(580, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(90, 26);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "PENDIENTE";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlCards
            //
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.pnlCards.Controls.Add(this.pnlCardTotal);
            this.pnlCards.Controls.Add(this.pnlCardPagado);
            this.pnlCards.Controls.Add(this.pnlCardSaldo);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Height = 90;
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.TabIndex = 1;
            this.pnlCards.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            //
            // pnlCardTotal
            //
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.Controls.Add(this.lblCardTotalTitulo);
            this.pnlCardTotal.Controls.Add(this.lblCardTotal);
            this.pnlCardTotal.Location = new System.Drawing.Point(15, 12);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(200, 65);
            this.pnlCardTotal.TabIndex = 0;
            //
            // lblCardTotalTitulo
            //
            this.lblCardTotalTitulo.AutoSize = true;
            this.lblCardTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCardTotalTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblCardTotalTitulo.Name = "lblCardTotalTitulo";
            this.lblCardTotalTitulo.Text = "TOTAL CRÉDITO";
            //
            // lblCardTotal
            //
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCardTotal.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblCardTotal.Location = new System.Drawing.Point(10, 30);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Text = "S/ 0.00";
            //
            // pnlCardPagado
            //
            this.pnlCardPagado.BackColor = System.Drawing.Color.White;
            this.pnlCardPagado.Controls.Add(this.lblCardPagadoTitulo);
            this.pnlCardPagado.Controls.Add(this.lblCardPagado);
            this.pnlCardPagado.Location = new System.Drawing.Point(230, 12);
            this.pnlCardPagado.Name = "pnlCardPagado";
            this.pnlCardPagado.Size = new System.Drawing.Size(200, 65);
            this.pnlCardPagado.TabIndex = 1;
            //
            // lblCardPagadoTitulo
            //
            this.lblCardPagadoTitulo.AutoSize = true;
            this.lblCardPagadoTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardPagadoTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCardPagadoTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblCardPagadoTitulo.Name = "lblCardPagadoTitulo";
            this.lblCardPagadoTitulo.Text = "TOTAL PAGADO";
            //
            // lblCardPagado
            //
            this.lblCardPagado.AutoSize = true;
            this.lblCardPagado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCardPagado.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblCardPagado.Location = new System.Drawing.Point(10, 30);
            this.lblCardPagado.Name = "lblCardPagado";
            this.lblCardPagado.Text = "S/ 0.00";
            //
            // pnlCardSaldo
            //
            this.pnlCardSaldo.BackColor = System.Drawing.Color.White;
            this.pnlCardSaldo.Controls.Add(this.lblCardSaldoTitulo);
            this.pnlCardSaldo.Controls.Add(this.lblCardSaldo);
            this.pnlCardSaldo.Location = new System.Drawing.Point(445, 12);
            this.pnlCardSaldo.Name = "pnlCardSaldo";
            this.pnlCardSaldo.Size = new System.Drawing.Size(200, 65);
            this.pnlCardSaldo.TabIndex = 2;
            //
            // lblCardSaldoTitulo
            //
            this.lblCardSaldoTitulo.AutoSize = true;
            this.lblCardSaldoTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardSaldoTitulo.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblCardSaldoTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblCardSaldoTitulo.Name = "lblCardSaldoTitulo";
            this.lblCardSaldoTitulo.Text = "SALDO PENDIENTE";
            //
            // lblCardSaldo
            //
            this.lblCardSaldo.AutoSize = true;
            this.lblCardSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCardSaldo.ForeColor = System.Drawing.Color.FromArgb(214, 48, 49);
            this.lblCardSaldo.Location = new System.Drawing.Point(10, 30);
            this.lblCardSaldo.Name = "lblCardSaldo";
            this.lblCardSaldo.Text = "S/ 0.00";
            //
            // pnlBody
            //
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblSinPagos);
            this.pnlBody.Controls.Add(this.dgvPagos);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            //
            // lblSinPagos
            //
            this.lblSinPagos.AutoSize = false;
            this.lblSinPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinPagos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSinPagos.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblSinPagos.Name = "lblSinPagos";
            this.lblSinPagos.Text = "No hay pagos registrados para esta venta";
            this.lblSinPagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinPagos.Visible = false;
            this.lblSinPagos.TabIndex = 1;
            //
            // dgvPagos
            //
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            hdrStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.ForeColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.dgvPagos.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colFecha,
            this.colHora,
            this.colMetodo,
            this.colMonto,
            this.colObs});
            this.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(223, 228, 234);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowTemplate.Height = 36;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.TabIndex = 0;
            //
            // colNum
            //
            this.colNum.HeaderText = "#";
            this.colNum.Name = "colNum";
            this.colNum.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNum.Width = 40;
            //
            // colFecha
            //
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFecha.Width = 100;
            //
            // colHora
            //
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHora.Width = 70;
            //
            // colMetodo
            //
            this.colMetodo.HeaderText = "Método de Pago";
            this.colMetodo.Name = "colMetodo";
            this.colMetodo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMetodo.Width = 130;
            //
            // colMonto
            //
            this.colMonto.HeaderText = "Monto Cobrado";
            this.colMonto.Name = "colMonto";
            this.colMonto.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMonto.Width = 130;
            //
            // colObs
            //
            this.colObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObs.HeaderText = "Observaciones";
            this.colObs.Name = "colObs";
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.lblResumen);
            this.pnlFooter.Controls.Add(this.btnCerrar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 52;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.TabIndex = 3;
            //
            // lblResumen
            //
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            this.lblResumen.Location = new System.Drawing.Point(15, 16);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Text = "0 pagos registrados";
            this.lblResumen.TabIndex = 0;
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
            this.btnCerrar.Location = new System.Drawing.Point(590, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            //
            // FormHistorialCobros
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 250);
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistorialCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Cobros";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCardSaldo.ResumeLayout(false);
            this.pnlCardSaldo.PerformLayout();
            this.pnlCardPagado.ResumeLayout(false);
            this.pnlCardPagado.PerformLayout();
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblCardTotalTitulo;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.Panel pnlCardPagado;
        private System.Windows.Forms.Label lblCardPagadoTitulo;
        private System.Windows.Forms.Label lblCardPagado;
        private System.Windows.Forms.Panel pnlCardSaldo;
        private System.Windows.Forms.Label lblCardSaldoTitulo;
        private System.Windows.Forms.Label lblCardSaldo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblSinPagos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnCerrar;
    }
}
