namespace SistemaPOS.Forms.Principal
{
    partial class FormRegistroInicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroInicial));
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblCreaAdmin = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMostrarClave2 = new System.Windows.Forms.Button();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            //
            // pnlCentral
            //
            this.pnlCentral.BackColor = System.Drawing.Color.White;
            this.pnlCentral.Controls.Add(this.pbLogo);
            this.pnlCentral.Controls.Add(this.lblCreaAdmin);
            this.pnlCentral.Controls.Add(this.lblNombreCompleto);
            this.pnlCentral.Controls.Add(this.txtNombreCompleto);
            this.pnlCentral.Controls.Add(this.lblNombreUsuario);
            this.pnlCentral.Controls.Add(this.txtNombreUsuario);
            this.pnlCentral.Controls.Add(this.lblContraseña);
            this.pnlCentral.Controls.Add(this.txtContraseña);
            this.pnlCentral.Controls.Add(this.btnMostrarClave);
            this.pnlCentral.Controls.Add(this.lblConfirmarContraseña);
            this.pnlCentral.Controls.Add(this.txtConfirmarContraseña);
            this.pnlCentral.Controls.Add(this.btnMostrarClave2);
            this.pnlCentral.Controls.Add(this.btnRegistrarse);
            this.pnlCentral.Location = new System.Drawing.Point(50, 30);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(380, 490);
            this.pnlCentral.TabIndex = 0;
            this.pnlCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            //
            // lblRegistro
            //
            this.lblRegistro.Visible = false;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblRegistro.Location = new System.Drawing.Point(170, 10);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(105, 25);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "REGISTRO";
            //
            // pbLogo
            //
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(72, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(236, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 88;
            this.pbLogo.TabStop = false;
            //
            // lblCreaAdmin
            //
            this.lblCreaAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCreaAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblCreaAdmin.Location = new System.Drawing.Point(0, 100);
            this.lblCreaAdmin.Name = "lblCreaAdmin";
            this.lblCreaAdmin.Size = new System.Drawing.Size(380, 25);
            this.lblCreaAdmin.TabIndex = 87;
            this.lblCreaAdmin.Text = "Crea tu cuenta de administrador";
            this.lblCreaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblNombreCompleto
            //
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(45, 140);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(115, 17);
            this.lblNombreCompleto.TabIndex = 78;
            this.lblNombreCompleto.Text = "Nombre Completo";
            //
            // txtNombreCompleto
            //
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(45, 160);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(290, 25);
            this.txtNombreCompleto.TabIndex = 1;
            //
            // lblNombreUsuario
            //
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(45, 198);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(126, 17);
            this.lblNombreUsuario.TabIndex = 83;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            //
            // txtNombreUsuario
            //
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(45, 218);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(290, 25);
            this.txtNombreUsuario.TabIndex = 2;
            //
            // lblContraseña
            //
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblContraseña.Location = new System.Drawing.Point(45, 256);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 17);
            this.lblContraseña.TabIndex = 81;
            this.lblContraseña.Text = "Contrasena";
            //
            // txtContraseña
            //
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContraseña.Location = new System.Drawing.Point(45, 276);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(290, 25);
            this.txtContraseña.TabIndex = 3;
            //
            // btnMostrarClave
            //
            this.btnMostrarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarClave.FlatAppearance.BorderSize = 0;
            this.btnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarClave.Location = new System.Drawing.Point(315, 276);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(20, 25);
            this.btnMostrarClave.TabIndex = 79;
            this.btnMostrarClave.Text = "*";
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            //
            // lblConfirmarContraseña
            //
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblConfirmarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(45, 314);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(143, 17);
            this.lblConfirmarContraseña.TabIndex = 91;
            this.lblConfirmarContraseña.Text = "Confirmar Contrasena";
            //
            // txtConfirmarContraseña
            //
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(45, 334);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(290, 25);
            this.txtConfirmarContraseña.TabIndex = 4;
            //
            // btnMostrarClave2
            //
            this.btnMostrarClave2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarClave2.FlatAppearance.BorderSize = 0;
            this.btnMostrarClave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClave2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarClave2.Location = new System.Drawing.Point(315, 334);
            this.btnMostrarClave2.Name = "btnMostrarClave2";
            this.btnMostrarClave2.Size = new System.Drawing.Size(20, 25);
            this.btnMostrarClave2.TabIndex = 89;
            this.btnMostrarClave2.Text = "*";
            this.btnMostrarClave2.UseVisualStyleBackColor = true;
            //
            // btnRegistrarse
            //
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnRegistrarse.Location = new System.Drawing.Point(45, 395);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(290, 40);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            //
            // FormRegistroInicial
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.pnlCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS - Registro";
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnMostrarClave;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblCreaAdmin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMostrarClave2;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
    }
}
