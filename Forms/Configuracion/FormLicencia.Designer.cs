namespace SistemaPOS.Forms.Configuracion
{
    partial class FormLicencia
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCodigoLicencia = new System.Windows.Forms.Label();
            this.txtCodigoLicencia = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblDiasRestantes = new System.Windows.Forms.Label();
            this.pnlVersionActualizacion = new System.Windows.Forms.Panel();
            this.lblActualizacion = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlInformacion.SuspendLayout();
            this.pnlVersionActualizacion.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(174, 21);
            this.lblTitulo.TabIndex = 53;
            this.lblTitulo.Text = "Activación del Sistema";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.White;
            this.pnlInformacion.Controls.Add(this.btnActivar);
            this.pnlInformacion.Controls.Add(this.lblSubTitulo);
            this.pnlInformacion.Controls.Add(this.lblEstado);
            this.pnlInformacion.Controls.Add(this.lblCodigoLicencia);
            this.pnlInformacion.Controls.Add(this.txtCodigoLicencia);
            this.pnlInformacion.Controls.Add(this.lblVencimiento);
            this.pnlInformacion.Controls.Add(this.lblDiasRestantes);
            this.pnlInformacion.Location = new System.Drawing.Point(16, 46);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(636, 199);
            this.pnlInformacion.TabIndex = 65;
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.White;
            this.btnActivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnActivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnActivar.Location = new System.Drawing.Point(481, 151);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(127, 30);
            this.btnActivar.TabIndex = 61;
            this.btnActivar.Text = "Activar Licencia";
            this.btnActivar.UseVisualStyleBackColor = false;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(224, 20);
            this.lblSubTitulo.TabIndex = 12;
            this.lblSubTitulo.Text = "INFORMACIÓN DE LA LICENCIA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(14, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(229, 15);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado:                     ⚠️ Sistema no activado";
            // 
            // lblCodigoLicencia
            // 
            this.lblCodigoLicencia.AutoSize = true;
            this.lblCodigoLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigoLicencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoLicencia.Location = new System.Drawing.Point(14, 60);
            this.lblCodigoLicencia.Name = "lblCodigoLicencia";
            this.lblCodigoLicencia.Size = new System.Drawing.Size(95, 15);
            this.lblCodigoLicencia.TabIndex = 47;
            this.lblCodigoLicencia.Text = "Codigo Licencia:";
            // 
            // txtCodigoLicencia
            // 
            this.txtCodigoLicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLicencia.Location = new System.Drawing.Point(121, 59);
            this.txtCodigoLicencia.Multiline = true;
            this.txtCodigoLicencia.Name = "txtCodigoLicencia";
            this.txtCodigoLicencia.Size = new System.Drawing.Size(315, 21);
            this.txtCodigoLicencia.TabIndex = 46;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(14, 131);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(156, 15);
            this.lblVencimiento.TabIndex = 52;
            this.lblVencimiento.Text = "Vencimiento:          --/--/----";
            // 
            // lblDiasRestantes
            // 
            this.lblDiasRestantes.AutoSize = true;
            this.lblDiasRestantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiasRestantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRestantes.Location = new System.Drawing.Point(14, 166);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(113, 15);
            this.lblDiasRestantes.TabIndex = 56;
            this.lblDiasRestantes.Text = "Días restantes:       --";
            // 
            // pnlVersionActualizacion
            // 
            this.pnlVersionActualizacion.BackColor = System.Drawing.Color.White;
            this.pnlVersionActualizacion.Controls.Add(this.lblActualizacion);
            this.pnlVersionActualizacion.Controls.Add(this.lblSubTitulo2);
            this.pnlVersionActualizacion.Controls.Add(this.lblVersion);
            this.pnlVersionActualizacion.Location = new System.Drawing.Point(658, 46);
            this.pnlVersionActualizacion.Name = "pnlVersionActualizacion";
            this.pnlVersionActualizacion.Size = new System.Drawing.Size(514, 199);
            this.pnlVersionActualizacion.TabIndex = 66;
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.AutoSize = true;
            this.lblActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActualizacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizacion.Location = new System.Drawing.Point(14, 95);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(178, 15);
            this.lblActualizacion.TabIndex = 49;
            this.lblActualizacion.Text = "Última actualización: 20/01/2026";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(13, 13);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(165, 20);
            this.lblSubTitulo2.TabIndex = 12;
            this.lblSubTitulo2.Text = "VERSIÓN DEL SISTEMA";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(14, 59);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(90, 15);
            this.lblVersion.TabIndex = 47;
            this.lblVersion.Text = "Versión:      1.0.0";
            // 
            // FormLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnlVersionActualizacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlInformacion);
            this.Name = "FormLicencia";
            this.Text = "FormLicencia";
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.pnlVersionActualizacion.ResumeLayout(false);
            this.pnlVersionActualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCodigoLicencia;
        private System.Windows.Forms.TextBox txtCodigoLicencia;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblDiasRestantes;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Panel pnlVersionActualizacion;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblActualizacion;
    }
}