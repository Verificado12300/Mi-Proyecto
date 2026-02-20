using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using SistemaPOS.Data;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormRespaldo : Form
    {
        private string _rutaRespaldos;
        private string _rutaBaseDatos;

        public FormRespaldo()
        {
            InitializeComponent();
            ConfigurarEventos();
            ConfigurarControles();
            CargarDatos();
            CargarHistorialRespaldos();
        }

        private void ConfigurarEventos()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnCrearRespaldo.Click += BtnCrearRespaldo_Click;
            btnRestaurarDatos.Click += BtnRestaurarDatos_Click;
            btnUbicacionRespaldo.Click += BtnUbicacionRespaldo_Click;
            btnArchivoRespaldo.Click += BtnArchivoRespaldo_Click;
            chkActivarRespaldoAuto.CheckedChanged += ChkActivarRespaldoAuto_CheckedChanged;
            rbDiario.CheckedChanged += RbFrecuencia_CheckedChanged;
            rbSemanal.CheckedChanged += RbFrecuencia_CheckedChanged;
            rbMensual.CheckedChanged += RbFrecuencia_CheckedChanged;
        }

        private void ConfigurarControles()
        {
            // Configurar DataGridView
            dgvHistorialRespaldos.AutoGenerateColumns = false;
            dgvHistorialRespaldos.AllowUserToAddRows = false;
            dgvHistorialRespaldos.ReadOnly = true;
            dgvHistorialRespaldos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Valores por defecto
            chkIncluirDatosVentas.Checked = true;
            chkIncluirDatosInventario.Checked = true;
            chkIncluirConfiguraciones.Checked = true;
            rbDiario.Checked = true;
            cmbDiaEnvio.SelectedIndex = 0;
            txtDiasRespaldo.Text = "7";
            dtpHora.Value = DateTime.Today.AddHours(2); // 02:00 AM

            // Rutas por defecto
            _rutaBaseDatos = DatabaseConnection.GetDatabasePath();
            _rutaRespaldos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Respaldos");

            // Crear directorio de respaldos si no existe
            if (!Directory.Exists(_rutaRespaldos))
            {
                Directory.CreateDirectory(_rutaRespaldos);
            }

            txtUbicacion.Text = _rutaRespaldos;
            txtNombreArchivo.Text = $"respaldo_{DateTime.Now:yyyyMMdd_HHmmss}.db";

            // Habilitar/deshabilitar controles de respaldo automático
            ActualizarEstadoRespaldoAuto();
            ActualizarEstadoDia();
        }

        private void CargarDatos()
        {
            try
            {
                // Cargar configuración de respaldo automático
                chkActivarRespaldoAuto.Checked = EmpresaRepository.ObtenerConfiguracion("RESPALDO_AUTOMATICO", "false") == "true";

                string frecuencia = EmpresaRepository.ObtenerConfiguracion("FRECUENCIA_RESPALDO", "DIARIO");
                rbDiario.Checked = frecuencia == "DIARIO";
                rbSemanal.Checked = frecuencia == "SEMANAL";
                rbMensual.Checked = frecuencia == "MENSUAL";

                string dia = EmpresaRepository.ObtenerConfiguracion("DIA_RESPALDO", "0");
                if (int.TryParse(dia, out int diaIndex) && diaIndex >= 0 && diaIndex < cmbDiaEnvio.Items.Count)
                {
                    cmbDiaEnvio.SelectedIndex = diaIndex;
                }

                string hora = EmpresaRepository.ObtenerConfiguracion("HORA_RESPALDO", "02:00");
                if (TimeSpan.TryParse(hora, out TimeSpan horaRespaldo))
                {
                    dtpHora.Value = DateTime.Today.Add(horaRespaldo);
                }

                txtDiasRespaldo.Text = EmpresaRepository.ObtenerConfiguracion("CANTIDAD_RESPALDOS", "7");

                string rutaGuardada = EmpresaRepository.ObtenerConfiguracion("RUTA_RESPALDO", "");
                if (!string.IsNullOrEmpty(rutaGuardada) && Directory.Exists(rutaGuardada))
                {
                    _rutaRespaldos = rutaGuardada;
                    txtUbicacion.Text = rutaGuardada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar configuración: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialRespaldos()
        {
            dgvHistorialRespaldos.Rows.Clear();

            try
            {
                if (!Directory.Exists(_rutaRespaldos))
                    return;

                var archivos = Directory.GetFiles(_rutaRespaldos, "*.db");
                Array.Sort(archivos);
                Array.Reverse(archivos);

                foreach (var archivo in archivos)
                {
                    var info = new FileInfo(archivo);
                    int index = dgvHistorialRespaldos.Rows.Add();
                    var row = dgvHistorialRespaldos.Rows[index];

                    row.Cells["colFechayHora"].Value = info.CreationTime.ToString("dd/MM/yyyy HH:mm:ss");
                    row.Cells["colTamaño"].Value = FormatearTamaño(info.Length);
                    row.Cells["colUbicacion"].Value = info.FullName;
                    row.Tag = info.FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar historial: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatearTamaño(long bytes)
        {
            string[] sufijos = { "B", "KB", "MB", "GB" };
            int i = 0;
            double tamaño = bytes;

            while (tamaño >= 1024 && i < sufijos.Length - 1)
            {
                tamaño /= 1024;
                i++;
            }

            return $"{tamaño:F2} {sufijos[i]}";
        }

        private void ActualizarEstadoRespaldoAuto()
        {
            bool activo = chkActivarRespaldoAuto.Checked;
            rbDiario.Enabled = activo;
            rbSemanal.Enabled = activo;
            rbMensual.Enabled = activo;
            cmbDiaEnvio.Enabled = activo && (rbSemanal.Checked || rbMensual.Checked);
            dtpHora.Enabled = activo;
            txtDiasRespaldo.Enabled = activo;
        }

        private void ActualizarEstadoDia()
        {
            if (rbDiario.Checked)
            {
                lblDiaEnvio.Visible = false;
                cmbDiaEnvio.Visible = false;
            }
            else if (rbSemanal.Checked)
            {
                lblDiaEnvio.Visible = true;
                cmbDiaEnvio.Visible = true;
                lblDiaEnvio.Text = "Día:";
            }
            else if (rbMensual.Checked)
            {
                lblDiaEnvio.Visible = true;
                cmbDiaEnvio.Visible = true;
                lblDiaEnvio.Text = "Día:";
            }
        }

        private void ChkActivarRespaldoAuto_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarEstadoRespaldoAuto();
        }

        private void RbFrecuencia_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarEstadoDia();
        }

        private void BtnUbicacionRespaldo_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione la carpeta de respaldos";
                folderDialog.SelectedPath = txtUbicacion.Text;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtUbicacion.Text = folderDialog.SelectedPath;
                    _rutaRespaldos = folderDialog.SelectedPath;
                    CargarHistorialRespaldos();
                }
            }
        }

        private void BtnArchivoRespaldo_Click(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Seleccionar archivo de respaldo";
                openDialog.Filter = "Archivos de base de datos|*.db|Todos los archivos|*.*";
                openDialog.InitialDirectory = _rutaRespaldos;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtArchivoRespaldo.Text = openDialog.FileName;
                }
            }
        }

        private void BtnCrearRespaldo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Seleccione una ubicación para el respaldo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el archivo de respaldo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombreArchivo = txtNombreArchivo.Text;
                if (!nombreArchivo.EndsWith(".db"))
                {
                    nombreArchivo += ".db";
                }

                string rutaDestino = Path.Combine(txtUbicacion.Text, nombreArchivo);

                if (File.Exists(rutaDestino))
                {
                    var result = MessageBox.Show("El archivo ya existe. ¿Desea reemplazarlo?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                        return;
                }

                // Crear el directorio si no existe
                if (!Directory.Exists(txtUbicacion.Text))
                {
                    Directory.CreateDirectory(txtUbicacion.Text);
                }

                if (!File.Exists(_rutaBaseDatos))
                    throw new FileNotFoundException($"No se encontró la base de datos en: {_rutaBaseDatos}");

                RespaldarBaseDatos(_rutaBaseDatos, rutaDestino);

                MessageBox.Show($"Respaldo creado exitosamente:\n{rutaDestino}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar nombre para el próximo respaldo
                txtNombreArchivo.Text = $"respaldo_{DateTime.Now:yyyyMMdd_HHmmss}.db";

                // Actualizar historial
                CargarHistorialRespaldos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear respaldo: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRestaurarDatos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArchivoRespaldo.Text))
            {
                MessageBox.Show("Seleccione un archivo de respaldo", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtArchivoRespaldo.Text))
            {
                MessageBox.Show("El archivo de respaldo no existe", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show(
                "ADVERTENCIA: Esta acción reemplazará todos los datos actuales con el respaldo seleccionado.\n\n" +
                "Se recomienda crear un respaldo antes de continuar.\n\n" +
                "¿Está seguro de que desea restaurar?",
                "Confirmar restauración",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                if (!File.Exists(_rutaBaseDatos))
                    throw new FileNotFoundException($"No se encontró la base de datos en: {_rutaBaseDatos}");

                // Crear respaldo antes de restaurar
                string respaldoActual = Path.Combine(_rutaRespaldos, $"pre_restauracion_{DateTime.Now:yyyyMMdd_HHmmss}.db");
                RespaldarBaseDatos(_rutaBaseDatos, respaldoActual);

                // Restaurar
                RestaurarBaseDatos(txtArchivoRespaldo.Text, _rutaBaseDatos);

                MessageBox.Show("Base de datos restaurada exitosamente.\n\n" +
                    "Se ha creado un respaldo de los datos anteriores.\n\n" +
                    "Por favor, reinicie la aplicación para aplicar los cambios.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarHistorialRespaldos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar configuración de respaldo automático
                EmpresaRepository.GuardarConfiguracion("RESPALDO_AUTOMATICO", chkActivarRespaldoAuto.Checked ? "true" : "false", "BOOLEAN", "Respaldo", "Activar respaldo automático");

                string frecuencia = "DIARIO";
                if (rbSemanal.Checked) frecuencia = "SEMANAL";
                if (rbMensual.Checked) frecuencia = "MENSUAL";
                EmpresaRepository.GuardarConfiguracion("FRECUENCIA_RESPALDO", frecuencia, "STRING", "Respaldo", "Frecuencia de respaldo");

                EmpresaRepository.GuardarConfiguracion("DIA_RESPALDO", cmbDiaEnvio.SelectedIndex.ToString(), "INTEGER", "Respaldo", "Día de respaldo");
                EmpresaRepository.GuardarConfiguracion("HORA_RESPALDO", dtpHora.Value.ToString("HH:mm"), "STRING", "Respaldo", "Hora de respaldo");
                EmpresaRepository.GuardarConfiguracion("CANTIDAD_RESPALDOS", txtDiasRespaldo.Text.Trim(), "INTEGER", "Respaldo", "Cantidad de respaldos a conservar");
                EmpresaRepository.GuardarConfiguracion("RUTA_RESPALDO", txtUbicacion.Text.Trim(), "STRING", "Respaldo", "Ruta de respaldos");

                MessageBox.Show("Configuración de respaldo guardada exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar configuración: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea descartar los cambios realizados?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CargarDatos();
            }
        }

        private static string BuildConnectionString(string databasePath)
        {
            return $"Data Source={databasePath};Version=3;BusyTimeout=5000;";
        }

        private static void RespaldarBaseDatos(string rutaOrigen, string rutaDestino)
        {
            if (File.Exists(rutaDestino))
                File.Delete(rutaDestino);

            using (var origen = new SQLiteConnection(BuildConnectionString(rutaOrigen)))
            using (var destino = new SQLiteConnection(BuildConnectionString(rutaDestino)))
            {
                origen.Open();
                destino.Open();
                origen.BackupDatabase(destino, "main", "main", -1, null, 0);
            }
        }

        private static void RestaurarBaseDatos(string rutaRespaldo, string rutaDestino)
        {
            using (var origen = new SQLiteConnection(BuildConnectionString(rutaRespaldo)))
            using (var destino = new SQLiteConnection(BuildConnectionString(rutaDestino)))
            {
                origen.Open();
                destino.Open();
                origen.BackupDatabase(destino, "main", "main", -1, null, 0);
            }
        }
    }
}
