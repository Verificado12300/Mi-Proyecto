namespace SistemaPOS.Forms.Inventario
{
    partial class FormAlertas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlertas));
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocktotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVer = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbFiltroStock = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblStockCrítico = new System.Windows.Forms.Label();
            this.lblStockAlerta = new System.Windows.Forms.Label();
            this.lblStockNormal = new System.Windows.Forms.Label();
            this.lblMotivosDisponibles = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colProducto,
            this.colCategoria,
            this.colStocktotal,
            this.colStockMinimo,
            this.colEstado,
            this.colVer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(12, 134);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowTemplate.Height = 50;
            this.dgvInventario.Size = new System.Drawing.Size(763, 465);
            this.dgvInventario.TabIndex = 3;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "#";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 50;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 150;
            // 
            // colStocktotal
            // 
            this.colStocktotal.HeaderText = "Stock Total";
            this.colStocktotal.Name = "colStocktotal";
            this.colStocktotal.ReadOnly = true;
            this.colStocktotal.Width = 120;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock Mínimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle1;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 120;
            // 
            // colVer
            // 
            this.colVer.HeaderText = "";
            this.colVer.Image = ((System.Drawing.Image)(resources.GetObject("colVer.Image")));
            this.colVer.Name = "colVer";
            this.colVer.ReadOnly = true;
            this.colVer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVer.Width = 25;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.lblEstado);
            this.pnlBusqueda.Controls.Add(this.lblCategoria);
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.cmbFiltroStock);
            this.pnlBusqueda.Controls.Add(this.cmbCategoria);
            this.pnlBusqueda.Controls.Add(this.btnActualizar);
            this.pnlBusqueda.Controls.Add(this.lblTitulo);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1184, 109);
            this.pnlBusqueda.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(787, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(566, 54);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 15);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(27, 54);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(42, 15);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar";
            // 
            // cmbFiltroStock
            // 
            this.cmbFiltroStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroStock.FormattingEnabled = true;
            this.cmbFiltroStock.Items.AddRange(new object[] {
            "Todos",
            "Crítico",
            "Alerta",
            "Normal"});
            this.cmbFiltroStock.Location = new System.Drawing.Point(790, 72);
            this.cmbFiltroStock.Name = "cmbFiltroStock";
            this.cmbFiltroStock.Size = new System.Drawing.Size(141, 21);
            this.cmbFiltroStock.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(569, 72);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(141, 21);
            this.cmbCategoria.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnActualizar.Location = new System.Drawing.Point(1081, 71);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Alertas de Inventario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(30, 72);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(490, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnExportar.Location = new System.Drawing.Point(290, 274);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(76, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.Controls.Add(this.lblStockCrítico);
            this.pnlResumen.Controls.Add(this.lblStockAlerta);
            this.pnlResumen.Controls.Add(this.lblStockNormal);
            this.pnlResumen.Controls.Add(this.btnExportar);
            this.pnlResumen.Controls.Add(this.lblMotivosDisponibles);
            this.pnlResumen.Controls.Add(this.lblSubTitulo2);
            this.pnlResumen.Location = new System.Drawing.Point(790, 134);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(382, 314);
            this.pnlResumen.TabIndex = 124;
            // 
            // lblStockCrítico
            // 
            this.lblStockCrítico.AutoSize = true;
            this.lblStockCrítico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStockCrítico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCrítico.Location = new System.Drawing.Point(15, 132);
            this.lblStockCrítico.Name = "lblStockCrítico";
            this.lblStockCrítico.Size = new System.Drawing.Size(162, 15);
            this.lblStockCrítico.TabIndex = 143;
            this.lblStockCrítico.Text = "🔴 Stock crítico:   0 productos";
            // 
            // lblStockAlerta
            // 
            this.lblStockAlerta.AutoSize = true;
            this.lblStockAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStockAlerta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAlerta.Location = new System.Drawing.Point(15, 106);
            this.lblStockAlerta.Name = "lblStockAlerta";
            this.lblStockAlerta.Size = new System.Drawing.Size(160, 15);
            this.lblStockAlerta.TabIndex = 142;
            this.lblStockAlerta.Text = "🔴 Stock Alerta:   0 productos";
            // 
            // lblStockNormal
            // 
            this.lblStockNormal.AutoSize = true;
            this.lblStockNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStockNormal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockNormal.Location = new System.Drawing.Point(15, 81);
            this.lblStockNormal.Name = "lblStockNormal";
            this.lblStockNormal.Size = new System.Drawing.Size(169, 15);
            this.lblStockNormal.TabIndex = 141;
            this.lblStockNormal.Text = "🔴 Stock Normal:   0 productos";
            // 
            // lblMotivosDisponibles
            // 
            this.lblMotivosDisponibles.AutoSize = true;
            this.lblMotivosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivosDisponibles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivosDisponibles.Location = new System.Drawing.Point(15, 49);
            this.lblMotivosDisponibles.Name = "lblMotivosDisponibles";
            this.lblMotivosDisponibles.Size = new System.Drawing.Size(178, 15);
            this.lblMotivosDisponibles.TabIndex = 110;
            this.lblMotivosDisponibles.Text = "Total productos monitoreados: 0";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(79, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "RESUMEN";
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pnlBusqueda);
            this.Name = "FormAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlertas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocktotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewImageColumn colVer;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblStockNormal;
        private System.Windows.Forms.Label lblMotivosDisponibles;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblStockAlerta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbFiltroStock;
        private System.Windows.Forms.Label lblStockCrítico;
    }
}