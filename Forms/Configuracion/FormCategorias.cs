using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormCategorias : Form
    {
        private int? _categoriaEditandoID = null;

        public FormCategorias()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarControles();
            CargarCategorias();
            LimpiarFormulario();
        }

        private void ConfigurarEventos()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            dgvCategorias.CellClick += DgvCategorias_CellClick;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarCategorias(txtBuscar.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ConfigurarControles()
        {
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chkActivo.Checked = true;
        }

        private void CargarCategorias(string busqueda = null)
        {
            var categorias = CategoriaRepository.Listar(busqueda);

            dgvCategorias.Rows.Clear();
            int numero = 1;

            foreach (var cat in categorias)
            {
                int index = dgvCategorias.Rows.Add();
                var row = dgvCategorias.Rows[index];

                row.Cells["colNumero"].Value = numero++;
                row.Cells["colNombre"].Value = cat.Nombre;
                row.Cells["colProducto"].Value = cat.CantidadProductos.ToString();
                row.Cells["colEstado"].Value = cat.Activo ? "Activo" : "Inactivo";

                if (!cat.Activo)
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }

                row.Tag = cat.CategoriaID;
            }

            lblCantidadCategoria.Text = $"Mostrando {categorias.Count} Categorías";
        }

        private void LimpiarFormulario()
        {
            _categoriaEditandoID = null;
            txtNombre.Clear();
            chkActivo.Checked = true;

            btnGuardar.Text = "Guardar";
            lblSubTitulo.Text = "NUEVA / EDITAR CATEGORÍA";
            txtNombre.Focus();
        }

        private void CargarCategoriaParaEditar(int categoriaID)
        {
            var categoria = CategoriaRepository.ObtenerPorID(categoriaID);
            if (categoria == null)
            {
                MessageBox.Show("No se encontró la categoría", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _categoriaEditandoID = categoriaID;
            txtNombre.Text = categoria.Nombre;
            chkActivo.Checked = categoria.Activo;

            btnGuardar.Text = "Actualizar";
            lblSubTitulo.Text = "EDITANDO CATEGORÍA";
            txtNombre.Focus();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la categoría", "Validación",
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
            if (CategoriaRepository.ExisteNombre(txtNombre.Text.Trim(), _categoriaEditandoID))
            {
                MessageBox.Show("Ya existe una categoría con ese nombre", "Validación",
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
                var categoria = new Categoria
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = "",
                    Activo = chkActivo.Checked
                };

                if (_categoriaEditandoID.HasValue)
                {
                    // Actualizar
                    categoria.CategoriaID = _categoriaEditandoID.Value;

                    if (CategoriaRepository.Actualizar(categoria))
                    {
                        MessageBox.Show("Categoría actualizada exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias(txtBuscar.Text);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la categoría", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Crear nueva
                    if (CategoriaRepository.Crear(categoria))
                    {
                        MessageBox.Show("Categoría creada exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias(txtBuscar.Text);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la categoría", "Error",
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
            CargarCategorias(txtBuscar.Text);
        }

        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int categoriaID = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Tag);
            string columnName = dgvCategorias.Columns[e.ColumnIndex].Name;

            if (columnName == "colEditar")
            {
                CargarCategoriaParaEditar(categoriaID);
            }
            else if (columnName == "colEliminar")
            {
                EliminarCategoria(categoriaID);
            }
        }

        private void EliminarCategoria(int categoriaID)
        {
            var categoria = CategoriaRepository.ObtenerPorID(categoriaID);
            if (categoria == null) return;

            var result = MessageBox.Show(
                $"¿Está seguro de eliminar la categoría '{categoria.Nombre}'?\n\n" +
                "Si tiene productos asociados, solo será desactivada.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                if (CategoriaRepository.Eliminar(categoriaID))
                {
                    MessageBox.Show("Categoría eliminada/desactivada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCategorias(txtBuscar.Text);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la categoría", "Error",
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
