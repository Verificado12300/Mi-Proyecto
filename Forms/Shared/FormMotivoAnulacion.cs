using System;
using System.Windows.Forms;

namespace SistemaPOS.Forms.Shared
{
    public partial class FormMotivoAnulacion : Form
    {
        public string Motivo => txtMotivo.Text.Trim();

        public FormMotivoAnulacion(string titulo, string mensaje)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(titulo))
                Text = titulo;

            if (!string.IsNullOrWhiteSpace(mensaje))
                lblMensaje.Text = mensaje;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivo.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
