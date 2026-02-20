namespace SistemaPOS.Forms.Inventario
{
    partial class FormAjustes
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
            this.pnlMotivo = new System.Windows.Forms.Panel();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.rbDevolucionCliente = new System.Windows.Forms.RadioButton();
            this.rbErrorAnterior = new System.Windows.Forms.RadioButton();
            this.rbProductoDañado = new System.Windows.Forms.RadioButton();
            this.rbInventarioFisico = new System.Windows.Forms.RadioButton();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblMotivosDisponibles = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.pnlTipoAjuste = new System.Windows.Forms.Panel();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblLineaDivisora2 = new System.Windows.Forms.Label();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.lblNuevoStock = new System.Windows.Forms.Label();
            this.txtAjuste = new System.Windows.Forms.TextBox();
            this.lblAjuste = new System.Windows.Forms.Label();
            this.txtStockActualResumen = new System.Windows.Forms.TextBox();
            this.lblStockActualResumen = new System.Windows.Forms.Label();
            this.numCantidadAjustar = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadAjustar = new System.Windows.Forms.Label();
            this.rbSalida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.pnlDatosAjuste = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarAjuste = new System.Windows.Forms.Button();
            this.cmbBuscarProducto = new System.Windows.Forms.ComboBox();
            this.pnlMotivo.SuspendLayout();
            this.pnlTipoAjuste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAjustar)).BeginInit();
            this.pnlDatosAjuste.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMotivo
            // 
            this.pnlMotivo.BackColor = System.Drawing.Color.White;
            this.pnlMotivo.Controls.Add(this.rbOtros);
            this.pnlMotivo.Controls.Add(this.rbDevolucionCliente);
            this.pnlMotivo.Controls.Add(this.rbErrorAnterior);
            this.pnlMotivo.Controls.Add(this.rbProductoDañado);
            this.pnlMotivo.Controls.Add(this.rbInventarioFisico);
            this.pnlMotivo.Controls.Add(this.txtMotivo);
            this.pnlMotivo.Controls.Add(this.lblMotivo);
            this.pnlMotivo.Controls.Add(this.lblMotivosDisponibles);
            this.pnlMotivo.Controls.Add(this.lblSubTitulo2);
            this.pnlMotivo.Location = new System.Drawing.Point(620, 47);
            this.pnlMotivo.Name = "pnlMotivo";
            this.pnlMotivo.Size = new System.Drawing.Size(552, 314);
            this.pnlMotivo.TabIndex = 123;
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(18, 173);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(139, 17);
            this.rbOtros.TabIndex = 157;
            this.rbOtros.TabStop = true;
            this.rbOtros.Text = "Otros (especificar abajo)";
            this.rbOtros.UseVisualStyleBackColor = true;
            // 
            // rbDevolucionCliente
            // 
            this.rbDevolucionCliente.AutoSize = true;
            this.rbDevolucionCliente.Location = new System.Drawing.Point(18, 151);
            this.rbDevolucionCliente.Name = "rbDevolucionCliente";
            this.rbDevolucionCliente.Size = new System.Drawing.Size(128, 17);
            this.rbDevolucionCliente.TabIndex = 156;
            this.rbDevolucionCliente.TabStop = true;
            this.rbDevolucionCliente.Text = "Devolución de cliente";
            this.rbDevolucionCliente.UseVisualStyleBackColor = true;
            // 
            // rbErrorAnterior
            // 
            this.rbErrorAnterior.AutoSize = true;
            this.rbErrorAnterior.Location = new System.Drawing.Point(18, 127);
            this.rbErrorAnterior.Name = "rbErrorAnterior";
            this.rbErrorAnterior.Size = new System.Drawing.Size(137, 17);
            this.rbErrorAnterior.TabIndex = 155;
            this.rbErrorAnterior.TabStop = true;
            this.rbErrorAnterior.Text = "Error en registro anterior";
            this.rbErrorAnterior.UseVisualStyleBackColor = true;
            // 
            // rbProductoDañado
            // 
            this.rbProductoDañado.AutoSize = true;
            this.rbProductoDañado.Location = new System.Drawing.Point(18, 104);
            this.rbProductoDañado.Name = "rbProductoDañado";
            this.rbProductoDañado.Size = new System.Drawing.Size(150, 17);
            this.rbProductoDañado.TabIndex = 154;
            this.rbProductoDañado.TabStop = true;
            this.rbProductoDañado.Text = "Producto dañado / Merma";
            this.rbProductoDañado.UseVisualStyleBackColor = true;
            // 
            // rbInventarioFisico
            // 
            this.rbInventarioFisico.AutoSize = true;
            this.rbInventarioFisico.Location = new System.Drawing.Point(18, 80);
            this.rbInventarioFisico.Name = "rbInventarioFisico";
            this.rbInventarioFisico.Size = new System.Drawing.Size(213, 17);
            this.rbInventarioFisico.TabIndex = 153;
            this.rbInventarioFisico.TabStop = true;
            this.rbInventarioFisico.Text = "Inventario físico (diferencia encontrada)";
            this.rbInventarioFisico.UseVisualStyleBackColor = true;
            // 
            // txtMotivo
            // 
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Location = new System.Drawing.Point(17, 236);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(485, 42);
            this.txtMotivo.TabIndex = 142;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(14, 218);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(136, 15);
            this.lblMotivo.TabIndex = 141;
            this.lblMotivo.Text = "Motivo / Observaciones:";
            // 
            // lblMotivosDisponibles
            // 
            this.lblMotivosDisponibles.AutoSize = true;
            this.lblMotivosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivosDisponibles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivosDisponibles.Location = new System.Drawing.Point(15, 49);
            this.lblMotivosDisponibles.Name = "lblMotivosDisponibles";
            this.lblMotivosDisponibles.Size = new System.Drawing.Size(116, 15);
            this.lblMotivosDisponibles.TabIndex = 110;
            this.lblMotivosDisponibles.Text = "Motivos disponibles:";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(152, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "MOTIVO DEL AJUSTE";
            // 
            // pnlTipoAjuste
            // 
            this.pnlTipoAjuste.BackColor = System.Drawing.Color.White;
            this.pnlTipoAjuste.Controls.Add(this.lblSeparador1);
            this.pnlTipoAjuste.Controls.Add(this.lblLineaDivisora2);
            this.pnlTipoAjuste.Controls.Add(this.txtNuevoStock);
            this.pnlTipoAjuste.Controls.Add(this.lblNuevoStock);
            this.pnlTipoAjuste.Controls.Add(this.txtAjuste);
            this.pnlTipoAjuste.Controls.Add(this.lblAjuste);
            this.pnlTipoAjuste.Controls.Add(this.txtStockActualResumen);
            this.pnlTipoAjuste.Controls.Add(this.lblStockActualResumen);
            this.pnlTipoAjuste.Controls.Add(this.numCantidadAjustar);
            this.pnlTipoAjuste.Controls.Add(this.lblCantidadAjustar);
            this.pnlTipoAjuste.Controls.Add(this.rbSalida);
            this.pnlTipoAjuste.Controls.Add(this.rbEntrada);
            this.pnlTipoAjuste.Controls.Add(this.lblSubTitulo3);
            this.pnlTipoAjuste.Location = new System.Drawing.Point(16, 240);
            this.pnlTipoAjuste.Name = "pnlTipoAjuste";
            this.pnlTipoAjuste.Size = new System.Drawing.Size(598, 359);
            this.pnlTipoAjuste.TabIndex = 122;
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblSeparador1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSeparador1.Location = new System.Drawing.Point(16, 117);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(286, 1);
            this.lblSeparador1.TabIndex = 152;
            // 
            // lblLineaDivisora2
            // 
            this.lblLineaDivisora2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.lblLineaDivisora2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLineaDivisora2.Location = new System.Drawing.Point(17, 203);
            this.lblLineaDivisora2.Name = "lblLineaDivisora2";
            this.lblLineaDivisora2.Size = new System.Drawing.Size(286, 1);
            this.lblLineaDivisora2.TabIndex = 151;
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevoStock.Location = new System.Drawing.Point(217, 220);
            this.txtNuevoStock.Multiline = true;
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.Size = new System.Drawing.Size(76, 20);
            this.txtNuevoStock.TabIndex = 150;
            // 
            // lblNuevoStock
            // 
            this.lblNuevoStock.AutoSize = true;
            this.lblNuevoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoStock.Location = new System.Drawing.Point(15, 219);
            this.lblNuevoStock.Name = "lblNuevoStock";
            this.lblNuevoStock.Size = new System.Drawing.Size(102, 20);
            this.lblNuevoStock.TabIndex = 149;
            this.lblNuevoStock.Text = "Nuevo Stock:";
            // 
            // txtAjuste
            // 
            this.txtAjuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAjuste.Location = new System.Drawing.Point(217, 181);
            this.txtAjuste.Multiline = true;
            this.txtAjuste.Name = "txtAjuste";
            this.txtAjuste.Size = new System.Drawing.Size(76, 20);
            this.txtAjuste.TabIndex = 148;
            // 
            // lblAjuste
            // 
            this.lblAjuste.AutoSize = true;
            this.lblAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAjuste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuste.Location = new System.Drawing.Point(15, 180);
            this.lblAjuste.Name = "lblAjuste";
            this.lblAjuste.Size = new System.Drawing.Size(43, 15);
            this.lblAjuste.TabIndex = 147;
            this.lblAjuste.Text = "Ajuste:";
            // 
            // txtStockActualResumen
            // 
            this.txtStockActualResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockActualResumen.Location = new System.Drawing.Point(217, 144);
            this.txtStockActualResumen.Multiline = true;
            this.txtStockActualResumen.Name = "txtStockActualResumen";
            this.txtStockActualResumen.Size = new System.Drawing.Size(76, 20);
            this.txtStockActualResumen.TabIndex = 146;
            // 
            // lblStockActualResumen
            // 
            this.lblStockActualResumen.AutoSize = true;
            this.lblStockActualResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStockActualResumen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActualResumen.Location = new System.Drawing.Point(15, 145);
            this.lblStockActualResumen.Name = "lblStockActualResumen";
            this.lblStockActualResumen.Size = new System.Drawing.Size(76, 15);
            this.lblStockActualResumen.TabIndex = 145;
            this.lblStockActualResumen.Text = "Stock Actual:";
            // 
            // numCantidadAjustar
            // 
            this.numCantidadAjustar.Location = new System.Drawing.Point(218, 90);
            this.numCantidadAjustar.Name = "numCantidadAjustar";
            this.numCantidadAjustar.Size = new System.Drawing.Size(76, 20);
            this.numCantidadAjustar.TabIndex = 142;
            // 
            // lblCantidadAjustar
            // 
            this.lblCantidadAjustar.AutoSize = true;
            this.lblCantidadAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidadAjustar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAjustar.Location = new System.Drawing.Point(16, 91);
            this.lblCantidadAjustar.Name = "lblCantidadAjustar";
            this.lblCantidadAjustar.Size = new System.Drawing.Size(105, 15);
            this.lblCantidadAjustar.TabIndex = 141;
            this.lblCantidadAjustar.Text = "Cantidad a ajustar:";
            // 
            // rbSalida
            // 
            this.rbSalida.AutoSize = true;
            this.rbSalida.Location = new System.Drawing.Point(128, 56);
            this.rbSalida.Name = "rbSalida";
            this.rbSalida.Size = new System.Drawing.Size(72, 17);
            this.rbSalida.TabIndex = 139;
            this.rbSalida.TabStop = true;
            this.rbSalida.Text = "Salida ( - )";
            this.rbSalida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(20, 56);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(86, 17);
            this.rbEntrada.TabIndex = 138;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = " Entrada ( + )";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.AutoSize = true;
            this.lblSubTitulo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(13, 16);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(120, 20);
            this.lblSubTitulo3.TabIndex = 111;
            this.lblSubTitulo3.Text = "TIPO DE AJUSTE";
            // 
            // pnlDatosAjuste
            // 
            this.pnlDatosAjuste.BackColor = System.Drawing.Color.White;
            this.pnlDatosAjuste.Controls.Add(this.cmbBuscarProducto);
            this.pnlDatosAjuste.Controls.Add(this.lblFecha);
            this.pnlDatosAjuste.Controls.Add(this.dtpFecha);
            this.pnlDatosAjuste.Controls.Add(this.lblProducto);
            this.pnlDatosAjuste.Controls.Add(this.lblSubTitulo);
            this.pnlDatosAjuste.Location = new System.Drawing.Point(16, 47);
            this.pnlDatosAjuste.Name = "pnlDatosAjuste";
            this.pnlDatosAjuste.Size = new System.Drawing.Size(598, 187);
            this.pnlDatosAjuste.TabIndex = 121;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(17, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 133;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(128, 106);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 20);
            this.dtpFecha.TabIndex = 132;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(15, 52);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 130;
            this.lblProducto.Text = "Producto:";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(141, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "DATOS DEL AJUSTE";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 21);
            this.lblTitulo.TabIndex = 134;
            this.lblTitulo.Text = "Ajuste de Inventario";
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
            this.btnCancelar.Location = new System.Drawing.Point(1052, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 144;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarAjuste
            // 
            this.btnGuardarAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnGuardarAjuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAjuste.FlatAppearance.BorderSize = 0;
            this.btnGuardarAjuste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnGuardarAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAjuste.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarAjuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnGuardarAjuste.Location = new System.Drawing.Point(902, 567);
            this.btnGuardarAjuste.Name = "btnGuardarAjuste";
            this.btnGuardarAjuste.Size = new System.Drawing.Size(120, 32);
            this.btnGuardarAjuste.TabIndex = 143;
            this.btnGuardarAjuste.Text = "Guardar";
            this.btnGuardarAjuste.UseVisualStyleBackColor = false;
            // 
            // cmbBuscarProducto
            // 
            this.cmbBuscarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarProducto.FormattingEnabled = true;
            this.cmbBuscarProducto.Location = new System.Drawing.Point(128, 50);
            this.cmbBuscarProducto.Name = "cmbBuscarProducto";
            this.cmbBuscarProducto.Size = new System.Drawing.Size(444, 21);
            this.cmbBuscarProducto.TabIndex = 146;
            // 
            // FormAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardarAjuste);
            this.Controls.Add(this.pnlMotivo);
            this.Controls.Add(this.pnlTipoAjuste);
            this.Controls.Add(this.pnlDatosAjuste);
            this.Name = "FormAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjustes";
            this.pnlMotivo.ResumeLayout(false);
            this.pnlMotivo.PerformLayout();
            this.pnlTipoAjuste.ResumeLayout(false);
            this.pnlTipoAjuste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAjustar)).EndInit();
            this.pnlDatosAjuste.ResumeLayout(false);
            this.pnlDatosAjuste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMotivo;
        private System.Windows.Forms.Label lblMotivosDisponibles;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Panel pnlTipoAjuste;
        private System.Windows.Forms.Label lblSubTitulo3;
        private System.Windows.Forms.Panel pnlDatosAjuste;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.RadioButton rbSalida;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.NumericUpDown numCantidadAjustar;
        private System.Windows.Forms.Label lblCantidadAjustar;
        private System.Windows.Forms.Label lblLineaDivisora2;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.Label lblNuevoStock;
        private System.Windows.Forms.TextBox txtAjuste;
        private System.Windows.Forms.Label lblAjuste;
        private System.Windows.Forms.TextBox txtStockActualResumen;
        private System.Windows.Forms.Label lblStockActualResumen;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarAjuste;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.RadioButton rbDevolucionCliente;
        private System.Windows.Forms.RadioButton rbErrorAnterior;
        private System.Windows.Forms.RadioButton rbProductoDañado;
        private System.Windows.Forms.RadioButton rbInventarioFisico;
        private System.Windows.Forms.ComboBox cmbBuscarProducto;
    }
}