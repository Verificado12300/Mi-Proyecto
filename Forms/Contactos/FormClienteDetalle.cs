using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SistemaPOS.Models;
using SistemaPOS.Data;

namespace SistemaPOS.Forms.Contactos
{
    public partial class FormClienteDetalle : Form
    {
        private int? _clienteID = null;
        private bool _modoEdicion = false;

        public FormClienteDetalle(int? clienteID = null)
        {
            InitializeComponent();
            _clienteID = clienteID;
            _modoEdicion = clienteID.HasValue;

            ConfigurarEventos();
            ConfigurarCamposSegunTipo();

            if (_modoEdicion)
            {
                lblTitulo.Text = "Editar Cliente";
                CargarDatosCliente();
            }
            else
            {
                lblTitulo.Text = "Nuevo Cliente";
                rbDNI.Checked = true;
                chkClienteActivo.Checked = true;
                txtLimiteCredito.Text = "200.00";
            }
        }

        private void ConfigurarEventos()
        {
            rbDNI.CheckedChanged += TipoDocumento_CheckedChanged;
            rbRUC.CheckedChanged += TipoDocumento_CheckedChanged;
            rbCEE.CheckedChanged += TipoDocumento_CheckedChanged;

            txtNumeroDoc.KeyPress += TxtNumeroDoc_KeyPress;
            txtTelefono.KeyPress += TxtNumerico_KeyPress;
            txtLimiteCredito.KeyPress += TxtDecimal_KeyPress;

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnBuscar.Click += BtnBuscar_Click;
        }

        private void TipoDocumento_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarCamposSegunTipo();
        }

        private void ConfigurarCamposSegunTipo()
        {
            if (rbDNI.Checked || rbCEE.Checked)
            {
                txtNombres.Enabled = true;
                txtApellidos.Enabled = true;
                txtRazonSocial.Enabled = false;
                txtRazonSocial.Clear();

                lblNombres.ForeColor = Color.Black;
                lblApellidos.ForeColor = Color.Black;
                lblRazonSocial.ForeColor = Color.Gray;
            }
            else if (rbRUC.Checked)
            {
                txtNombres.Enabled = false;
                txtApellidos.Enabled = false;
                txtRazonSocial.Enabled = true;
                txtNombres.Clear();
                txtApellidos.Clear();

                lblNombres.ForeColor = Color.Gray;
                lblApellidos.ForeColor = Color.Gray;
                lblRazonSocial.ForeColor = Color.Black;
            }
        }

        private void CargarDatosCliente()
        {
            try
            {
                var cliente = ClienteRepository.ObtenerPorID(_clienteID.Value);

                if (cliente != null)
                {
                    if (cliente.TipoDocumento == "DNI")
                        rbDNI.Checked = true;
                    else if (cliente.TipoDocumento == "RUC")
                        rbRUC.Checked = true;
                    else if (cliente.TipoDocumento == "CEE")
                        rbCEE.Checked = true;

                    txtNumeroDoc.Text = cliente.NumeroDocumento;
                    txtNombres.Text = cliente.Nombres;
                    txtApellidos.Text = cliente.Apellidos;
                    txtRazonSocial.Text = cliente.RazonSocial;
                    txtDireccion.Text = cliente.Direccion;
                    txtTelefono.Text = cliente.Telefono;
                    txtEmail.Text = cliente.Email;
                    txtLimiteCredito.Text = cliente.LimiteCredito.ToString("N2");
                    chkClienteActivo.Checked = cliente.Activo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del cliente: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                var cliente = new Cliente
                {
                    TipoDocumento = rbDNI.Checked ? "DNI" : rbRUC.Checked ? "RUC" : "CEE",
                    NumeroDocumento = txtNumeroDoc.Text.Trim(),
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    LimiteCredito = ParseDecimalOrZero(txtLimiteCredito.Text),
                    Activo = chkClienteActivo.Checked
                };

                if (_modoEdicion)
                {
                    cliente.ClienteID = _clienteID.Value;

                    if (ClienteRepository.Actualizar(cliente))
                    {
                        MessageBox.Show("Cliente actualizado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (ClienteRepository.Crear(cliente))
                    {
                        MessageBox.Show("Cliente registrado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            if (!rbDNI.Checked && !rbRUC.Checked && !rbCEE.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroDoc.Text))
            {
                MessageBox.Show("Debe ingresar el número de documento", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }

            // Validar longitud según tipo (con Trim)
            string numeroDoc = txtNumeroDoc.Text.Trim();

            if (rbDNI.Checked && numeroDoc.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }

            if (rbRUC.Checked && numeroDoc.Length != 11)
            {
                MessageBox.Show("El RUC debe tener 11 dígitos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }

            // Validar que el documento no exista (excepto en edición del mismo cliente)
            if (ClienteRepository.ExisteDocumento(numeroDoc, _clienteID))
            {
                MessageBox.Show("Ya existe un cliente con este número de documento", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }

            // Validar nombres o razón social según tipo
            if (rbDNI.Checked || rbCEE.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text))
                {
                    MessageBox.Show("Debe ingresar los nombres", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombres.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    MessageBox.Show("Debe ingresar los apellidos", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellidos.Focus();
                    return false;
                }
            }
            else if (rbRUC.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    MessageBox.Show("Debe ingresar la razón social", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRazonSocial.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtLimiteCredito.Text))
            {
                MessageBox.Show("Debe ingresar el límite de crédito (puede ser 0)", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Focus();
                return false;
            }

            decimal limiteCredito;
            if (!TryParseDecimal(txtLimiteCredito.Text, out limiteCredito) || limiteCredito < 0)
            {
                MessageBox.Show("El límite de crédito debe ser un número válido mayor o igual a 0", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un email válido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de consulta RENIEC/SUNAT próximamente disponible",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            var textBox = sender as TextBox;
            if (textBox == null) return;

            if ((e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                || (e.KeyChar == ',' && textBox.Text.IndexOf(',') > -1)
                || ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains(".") || textBox.Text.Contains(","))))
            {
                e.Handled = true;
            }
        }

        private static bool TryParseDecimal(string texto, out decimal valor)
        {
            if (decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out valor))
                return true;

            return decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
        }

        private static decimal ParseDecimalOrZero(string texto)
        {
            return TryParseDecimal(texto, out decimal valor) ? valor : 0m;
        }
    }
}
