using System;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Finanzas
{
    public partial class FormRegistrarGasto : Form
    {
        public FormRegistrarGasto()
        {
            InitializeComponent();
        }

        private void FormRegistrarGasto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCategorias();
                ConfigurarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                cmbCategoria.Items.Clear();
                foreach (var cat in GastoRepository.CategoriasDisponibles)
                {
                    cmbCategoria.Items.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            // Configurar fecha y hora actuales
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            // Configurar monto
            numMonto.Value = 0;
            numMonto.Minimum = 0;
            numMonto.Maximum = 999999;
            numMonto.DecimalPlaces = 2;

            // Seleccionar primer método de pago por defecto
            if (cmbMetodoPago.Items.Count > 0)
                cmbMetodoPago.SelectedIndex = 0;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                MessageBox.Show("Ingrese el concepto del gasto", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConcepto.Focus();
                return false;
            }

            if (numMonto.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMonto.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una categoría", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (cmbMetodoPago.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un método de pago", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMetodoPago.Focus();
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                Gasto gasto = new Gasto
                {
                    Fecha = dtpFecha.Value.Date,
                    Hora = dtpHora.Value.TimeOfDay,
                    Concepto = txtConcepto.Text.Trim(),
                    Monto = numMonto.Value,
                    Categoria = cmbCategoria.Text,
                    MetodoPago = cmbMetodoPago.Text,
                    Comprobante = string.IsNullOrWhiteSpace(txtComprobante.Text) ? null : txtComprobante.Text.Trim(),
                    Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text) ? null : txtObservaciones.Text.Trim(),
                    CajaID = CajaRepository.ObtenerCajaAbierta()?.CajaID,
                    UsuarioID = SesionActual.Usuario.UsuarioID
                };

                if (GastoRepository.Crear(gasto))
                {
                    MessageBox.Show("Gasto registrado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el gasto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
