using System;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Principal
{
    public partial class FormRegistroInicial : Form
    {
        public FormRegistroInicial()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            btnRegistrarse.Click += BtnRegistrarse_Click;
            btnMostrarClave.Click += BtnMostrarClave_Click;
            btnMostrarClave2.Click += BtnMostrarClave2_Click;
            txtNombreCompleto.KeyPress += TxtSoloTexto_KeyPress;
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var usuario = new Usuario
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    NombreUsuario = txtNombreUsuario.Text.Trim(),
                    Contraseña = PasswordHelper.HashPassword(txtContraseña.Text.Trim()),
                    DNI = "00000000",
                    RolID = 1,
                    Activo = true
                };

                bool resultado = UsuarioRepository.Crear(usuario);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Cuenta de administrador creada exitosamente!\n\nYa puedes iniciar sesión.",
                        "Registro Exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("Ingresa tu nombre completo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompleto.Focus();
                return false;
            }
            if (txtNombreCompleto.Text.Trim().Length < 3)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompleto.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingresa un nombre de usuario", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return false;
            }
            if (txtNombreUsuario.Text.Trim().Length < 4)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 4 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return false;
            }
            if (UsuarioRepository.ExisteNombreUsuario(txtNombreUsuario.Text.Trim()))
            {
                MessageBox.Show("Este nombre de usuario ya está en uso", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingresa una contraseña", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }
            if (txtContraseña.Text.Length < 3)
            {
                MessageBox.Show("La contraseña debe tener al menos 3 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show("Confirma tu contraseña", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarContraseña.Focus();
                return false;
            }
            if (txtContraseña.Text.Trim() != txtConfirmarContraseña.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarContraseña.Focus();
                return false;
            }
            return true;
        }

        private void BtnMostrarClave_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
                btnMostrarClave.Text = "🙈";
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                btnMostrarClave.Text = "👁";
            }
        }

        private void BtnMostrarClave2_Click(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.PasswordChar == '*')
            {
                txtConfirmarContraseña.PasswordChar = '\0';
                btnMostrarClave2.Text = "🙈";
            }
            else
            {
                txtConfirmarContraseña.PasswordChar = '*';
                btnMostrarClave2.Text = "👁";
            }
        }

        private void TxtSoloTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}