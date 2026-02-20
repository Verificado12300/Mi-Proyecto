using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormPresentaciones : Form
    {
        private int? _presentacionEditandoID = null;

        public FormPresentaciones()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarControles();
            CargarPresentaciones();
            LimpiarFormulario();
        }

        private void ConfigurarEventos()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            dgvPresentaciones.CellClick += DgvPresentaciones_CellClick;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarPresentaciones(txtBuscar.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ConfigurarControles()
        {
            dgvPresentaciones.AutoGenerateColumns = false;
            dgvPresentaciones.AllowUserToAddRows = false;
            dgvPresentaciones.ReadOnly = true;
            dgvPresentaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chkActivo.Checked = true;
        }

        private void CargarPresentaciones(string busqueda = null)
        {
            var presentaciones = PresentacionRepository.Listar(busqueda);

            dgvPresentaciones.Rows.Clear();
            int numero = 1;

            foreach (var p in presentaciones)
            {
                int index = dgvPresentaciones.Rows.Add();
                var row = dgvPresentaciones.Rows[index];

                row.Cells["colNumero"].Value = numero++;
                row.Cells["colNombre"].Value = p.Nombre;
                row.Cells["colAbreviatura"].Value = p.Descripcion;
                row.Cells["colProducto"].Value = p.CantidadProductos.ToString();
                row.Cells["colEstado"].Value = p.Activo ? "Activo" : "Inactivo";

                if (!p.Activo)
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }

                row.Tag = p.PresentacionID;
            }

            lblTotal.Text = $"Mostrando {presentaciones.Count} Presentaciones";
        }

        private void LimpiarFormulario()
        {
            _presentacionEditandoID = null;
            txtNombre.Clear();
            txtAbreviatura.Clear();
            chkActivo.Checked = true;

            btnGuardar.Text = "Guardar";
            lblSubTitulo.Text = "NUEVA / EDITAR PRESENTACIÓN";
            txtNombre.Focus();
        }

        private void CargarPresentacionParaEditar(int presentacionID)
        {
            var presentacion = PresentacionRepository.ObtenerPorID(presentacionID);
            if (presentacion == null)
            {
                MessageBox.Show("No se encontró la presentación", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _presentacionEditandoID = presentacionID;
            txtNombre.Text = presentacion.Nombre;
            txtAbreviatura.Text = presentacion.Descripcion;
            chkActivo.Checked = presentacion.Activo;

            btnGuardar.Text = "Actualizar";
            lblSubTitulo.Text = "EDITANDO PRESENTACIÓN";
            txtNombre.Focus();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la presentación", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length < 2)
            {
                MessageBox.Show("El nombre debe tener al menos 2 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            // Validar nombre único
            if (PresentacionRepository.ExisteNombre(txtNombre.Text.Trim(), _presentacionEditandoID))
            {
                MessageBox.Show("Ya existe una presentación con ese nombre", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                var presentacion = new Presentacion
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtAbreviatura.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                if (_presentacionEditandoID.HasValue)
                {
                    // Actualizar
                    presentacion.PresentacionID = _presentacionEditandoID.Value;

                    if (PresentacionRepository.Actualizar(presentacion))
                    {
                        MessageBox.Show("Presentación actualizada exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPresentaciones(txtBuscar.Text);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la presentación", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Crear nueva
                    if (PresentacionRepository.Crear(presentacion))
                    {
                        MessageBox.Show("Presentación creada exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPresentaciones(txtBuscar.Text);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la presentación", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPresentaciones(txtBuscar.Text);
        }

        private void DgvPresentaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int presentacionID = Convert.ToInt32(dgvPresentaciones.Rows[e.RowIndex].Tag);
            string columnName = dgvPresentaciones.Columns[e.ColumnIndex].Name;

            if (columnName == "colEditar")
            {
                CargarPresentacionParaEditar(presentacionID);
            }
            else if (columnName == "colEliminar")
            {
                EliminarPresentacion(presentacionID);
            }
        }

        private void EliminarPresentacion(int presentacionID)
        {
            var presentacion = PresentacionRepository.ObtenerPorID(presentacionID);
            if (presentacion == null) return;

            var result = MessageBox.Show(
                $"¿Está seguro de eliminar la presentación '{presentacion.Nombre}'?\n\n" +
                "Si tiene productos asociados, solo será desactivada.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                if (PresentacionRepository.Eliminar(presentacionID))
                {
                    MessageBox.Show("Presentación eliminada/desactivada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPresentaciones(txtBuscar.Text);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la presentación", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
