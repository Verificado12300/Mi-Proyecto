using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using SistemaPOS.Utils;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormUsuarios : Form
    {
        private int? _usuarioEditandoID = null;
        private string _dniActual = null;
        private List<Rol> _roles;
        private bool _cargandoDatos = false;

        public FormUsuarios()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ConfigurarEventos();
            ConfigurarControles();
            CargarRoles();
            CargarUsuarios();
            LimpiarFormulario();
        }

        private void ConfigurarEventos()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnNuevo.Click += BtnNuevo_Click;
            btnMostrarClave.Click += BtnMostrarClave_Click;
            dgvUsuarios.CellClick += DgvUsuarios_CellClick;
            cmbRol.SelectedIndexChanged += CmbRol_SelectedIndexChanged;
        }

        private void ConfigurarControles()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chkUsuarioActivo.Checked = true;
        }

        private void CargarRoles()
        {
            _roles = UsuarioRepository.ObtenerRoles();

            cmbRol.Items.Clear();
            foreach (var rol in _roles)
            {
                cmbRol.Items.Add(rol.Nombre);
            }

            if (cmbRol.Items.Count > 0)
                cmbRol.SelectedIndex = 0;
        }

        private void CargarUsuarios()
        {
            var usuarios = UsuarioRepository.Listar();

            dgvUsuarios.Rows.Clear();
            int numero = 1;

            foreach (var u in usuarios)
            {
                int index = dgvUsuarios.Rows.Add();
                var row = dgvUsuarios.Rows[index];

                row.Cells["colNumero"].Value = numero++;
                row.Cells["colNombre"].Value = u.NombreCompleto;
                row.Cells["colUsuario"].Value = u.NombreUsuario;
                row.Cells["colRol"].Value = u.NombreRol;
                row.Cells["colEstado"].Value = u.Activo ? "Activo" : "Inactivo";

                if (!u.Activo)
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }

                row.Tag = u.UsuarioID;
            }
        }

        private void LimpiarFormulario()
        {
            _usuarioEditandoID = null;
            _dniActual = null;
            _cargandoDatos = true;

            txtNombreCompleto.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseña.PasswordChar = '*';

            if (cmbRol.Items.Count > 0)
                cmbRol.SelectedIndex = 0;

            chkUsuarioActivo.Checked = true;

            // Limpiar permisos
            chkVentas.Checked = false;
            chkClientes.Checked = false;
            chkCompras.Checked = false;
            chkInventario.Checked = false;
            chkReportes.Checked = false;
            chkConfiguracion.Checked = false;
            chkProveedores.Checked = false;
            chkFinanzas.Checked = false;

            chkAplicarDescuentos.Checked = false;
            chkAnularVentas.Checked = false;
            chkEliminarRegistros.Checked = false;
            chkVerCostos.Checked = false;
            chkModificarPrecios.Checked = false;
            chkAccederFueraHorario.Checked = false;

            _cargandoDatos = false;

            // Aplicar permisos por defecto del rol seleccionado
            AplicarPermisosRol();

            txtNombreCompleto.Focus();
            btnGuardar.Text = "Guardar";
        }

        private void CargarUsuarioParaEditar(int usuarioID)
        {
            var usuario = UsuarioRepository.ObtenerPorID(usuarioID);
            if (usuario == null)
            {
                MessageBox.Show("No se encontró el usuario", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _usuarioEditandoID = usuarioID;
            _cargandoDatos = true;

            txtNombreCompleto.Text = usuario.NombreCompleto;
            txtUsuario.Text = usuario.NombreUsuario;
            txtContraseña.Clear(); // No mostramos la contraseña
            _dniActual = usuario.DNI;

            // Seleccionar rol
            for (int i = 0; i < _roles.Count; i++)
            {
                if (_roles[i].RolID == usuario.RolID)
                {
                    cmbRol.SelectedIndex = i;
                    break;
                }
            }

            chkUsuarioActivo.Checked = usuario.Activo;

            // Cargar permisos de módulos
            chkVentas.Checked = usuario.PermisoVentas;
            chkClientes.Checked = usuario.PermisoClientes;
            chkCompras.Checked = usuario.PermisoCompras;
            chkInventario.Checked = usuario.PermisoInventario;
            chkReportes.Checked = usuario.PermisoReportes;
            chkConfiguracion.Checked = usuario.PermisoConfiguracion;
            chkProveedores.Checked = usuario.PermisoProveedores;
            chkFinanzas.Checked = usuario.PermisoFinanzas;

            // Cargar permisos de acciones especiales
            chkAplicarDescuentos.Checked = usuario.PermisoDescuentos;
            chkAnularVentas.Checked = usuario.PermisoAnularVentas;
            chkEliminarRegistros.Checked = usuario.PermisoEliminarRegistros;
            chkVerCostos.Checked = usuario.PermisoVerCostos;
            chkModificarPrecios.Checked = usuario.PermisoModificarPrecios;
            chkAccederFueraHorario.Checked = usuario.PermisoFueraHorario;

            _cargandoDatos = false;

            btnGuardar.Text = "Actualizar";
            txtNombreCompleto.Focus();
        }

        private void CmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_cargandoDatos && _usuarioEditandoID == null)
            {
                AplicarPermisosRol();
            }
        }

        private void AplicarPermisosRol()
        {
            if (cmbRol.SelectedIndex < 0 || cmbRol.SelectedIndex >= _roles.Count)
                return;

            var rol = _roles[cmbRol.SelectedIndex];
            string nombreRol = rol.Nombre.ToUpper();

            // Permisos por defecto según el rol
            switch (nombreRol)
            {
                case "ADMINISTRADOR":
                    // Todos los permisos
                    chkVentas.Checked = true;
                    chkClientes.Checked = true;
                    chkCompras.Checked = true;
                    chkInventario.Checked = true;
                    chkReportes.Checked = true;
                    chkConfiguracion.Checked = true;
                    chkProveedores.Checked = true;
                    chkFinanzas.Checked = true;
                    chkAplicarDescuentos.Checked = true;
                    chkAnularVentas.Checked = true;
                    chkEliminarRegistros.Checked = true;
                    chkVerCostos.Checked = true;
                    chkModificarPrecios.Checked = true;
                    chkAccederFueraHorario.Checked = true;
                    break;

                case "VENDEDOR":
                    chkVentas.Checked = true;
                    chkClientes.Checked = true;
                    chkCompras.Checked = false;
                    chkInventario.Checked = false;
                    chkReportes.Checked = false;
                    chkConfiguracion.Checked = false;
                    chkProveedores.Checked = false;
                    chkFinanzas.Checked = false;
                    chkAplicarDescuentos.Checked = true;
                    chkAnularVentas.Checked = false;
                    chkEliminarRegistros.Checked = false;
                    chkVerCostos.Checked = false;
                    chkModificarPrecios.Checked = false;
                    chkAccederFueraHorario.Checked = false;
                    break;

                case "ALMACENERO":
                    chkVentas.Checked = false;
                    chkClientes.Checked = false;
                    chkCompras.Checked = true;
                    chkInventario.Checked = true;
                    chkReportes.Checked = false;
                    chkConfiguracion.Checked = false;
                    chkProveedores.Checked = true;
                    chkFinanzas.Checked = false;
                    chkAplicarDescuentos.Checked = false;
                    chkAnularVentas.Checked = false;
                    chkEliminarRegistros.Checked = false;
                    chkVerCostos.Checked = true;
                    chkModificarPrecios.Checked = false;
                    chkAccederFueraHorario.Checked = false;
                    break;

                case "CAJERO":
                    chkVentas.Checked = true;
                    chkClientes.Checked = true;
                    chkCompras.Checked = false;
                    chkInventario.Checked = false;
                    chkReportes.Checked = false;
                    chkConfiguracion.Checked = false;
                    chkProveedores.Checked = false;
                    chkFinanzas.Checked = true;
                    chkAplicarDescuentos.Checked = false;
                    chkAnularVentas.Checked = false;
                    chkEliminarRegistros.Checked = false;
                    chkVerCostos.Checked = false;
                    chkModificarPrecios.Checked = false;
                    chkAccederFueraHorario.Checked = false;
                    break;

                default:
                    // Permisos mínimos
                    chkVentas.Checked = true;
                    chkClientes.Checked = true;
                    chkCompras.Checked = false;
                    chkInventario.Checked = false;
                    chkReportes.Checked = false;
                    chkConfiguracion.Checked = false;
                    chkProveedores.Checked = false;
                    chkFinanzas.Checked = false;
                    chkAplicarDescuentos.Checked = false;
                    chkAnularVentas.Checked = false;
                    chkEliminarRegistros.Checked = false;
                    chkVerCostos.Checked = false;
                    chkModificarPrecios.Checked = false;
                    chkAccederFueraHorario.Checked = false;
                    break;
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("Ingrese el nombre completo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (txtUsuario.Text.Length < 3)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 3 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            // Validar contraseña solo para usuarios nuevos
            if (!_usuarioEditandoID.HasValue && string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese la contraseña", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtContraseña.Text) && txtContraseña.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            if (cmbRol.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rol", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRol.Focus();
                return false;
            }

            // Validar nombre de usuario único
            if (UsuarioRepository.ExisteNombreUsuario(txtUsuario.Text.Trim(), _usuarioEditandoID))
            {
                MessageBox.Show("Ya existe un usuario con ese nombre", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
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
                var usuario = new Usuario
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    NombreUsuario = txtUsuario.Text.Trim(),
                    DNI = _usuarioEditandoID.HasValue
                        ? (string.IsNullOrWhiteSpace(_dniActual) ? GenerarDniTecnicoUnico() : _dniActual)
                        : GenerarDniTecnicoUnico(),
                    RolID = _roles[cmbRol.SelectedIndex].RolID,
                    Activo = chkUsuarioActivo.Checked,

                    // Permisos de módulos
                    PermisoVentas = chkVentas.Checked,
                    PermisoClientes = chkClientes.Checked,
                    PermisoCompras = chkCompras.Checked,
                    PermisoInventario = chkInventario.Checked,
                    PermisoReportes = chkReportes.Checked,
                    PermisoConfiguracion = chkConfiguracion.Checked,
                    PermisoProveedores = chkProveedores.Checked,
                    PermisoFinanzas = chkFinanzas.Checked,

                    // Permisos de acciones especiales
                    PermisoDescuentos = chkAplicarDescuentos.Checked,
                    PermisoAnularVentas = chkAnularVentas.Checked,
                    PermisoEliminarRegistros = chkEliminarRegistros.Checked,
                    PermisoVerCostos = chkVerCostos.Checked,
                    PermisoModificarPrecios = chkModificarPrecios.Checked,
                    PermisoFueraHorario = chkAccederFueraHorario.Checked
                };

                if (_usuarioEditandoID.HasValue)
                {
                    // Actualizar
                    usuario.UsuarioID = _usuarioEditandoID.Value;

                    if (UsuarioRepository.Actualizar(usuario))
                    {
                        // Si se ingresó nueva contraseña, actualizarla
                        if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
                        {
                            string hash = PasswordHelper.HashPassword(txtContraseña.Text);
                            UsuarioRepository.ActualizarContraseña(usuario.UsuarioID, hash);
                        }

                        MessageBox.Show("Usuario actualizado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Crear nuevo
                    usuario.Contraseña = PasswordHelper.HashPassword(txtContraseña.Text);

                    if (UsuarioRepository.Crear(usuario))
                    {
                        MessageBox.Show("Usuario creado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el usuario", "Error",
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void BtnMostrarClave_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
                btnMostrarClave.Text = "🔒";
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                btnMostrarClave.Text = "👁";
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int usuarioID = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Tag);
            string columnName = dgvUsuarios.Columns[e.ColumnIndex].Name;

            if (columnName == "colEditar")
            {
                CargarUsuarioParaEditar(usuarioID);
            }
            else if (columnName == "colEliminar")
            {
                EliminarUsuario(usuarioID);
            }
        }

        private void EliminarUsuario(int usuarioID)
        {
            // No permitir eliminar el usuario actual
            if (SesionActual.Usuario != null && SesionActual.Usuario.UsuarioID == usuarioID)
            {
                MessageBox.Show("No puede eliminar su propio usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = UsuarioRepository.ObtenerPorID(usuarioID);
            if (usuario == null) return;

            var result = MessageBox.Show(
                $"¿Está seguro de eliminar al usuario '{usuario.NombreCompleto}'?\n\n" +
                "Si el usuario tiene operaciones asociadas, solo será desactivado.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                if (UsuarioRepository.Eliminar(usuarioID))
                {
                    MessageBox.Show("Usuario eliminado/desactivado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarDniTecnicoUnico()
        {
            for (int i = 0; i < 20; i++)
            {
                string candidato = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpperInvariant();
                if (!UsuarioRepository.ExisteDNI(candidato, _usuarioEditandoID))
                    return candidato;
            }

            return DateTime.Now.Ticks.ToString().Substring(0, 8);
        }
    }
}
