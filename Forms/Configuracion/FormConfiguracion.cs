using System;
using System.Windows.Forms;
using SistemaPOS.Forms.Reportes;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormConfiguracion : Form
    {
        private Form _formActual = null;

        public FormConfiguracion()
        {
            InitializeComponent();
            ConfigurarEventos();
            ResaltarBoton(btnEmpresa);
            MostrarFormulario(new FormEmpresa());
        }

        private void ConfigurarEventos()
        {
            btnReportes.Click += btnReportes_Click;
            btnUnidadBase.Click += btnUnidadBase_Click;
            btnRespaldo.Click += btnRespaldo_Click;
            btnGeneral.Click += btnGeneral_Click;
            btnLicencia.Click += btnLicencia_Click;
        }

        private void MostrarFormulario(Form form)
        {
            if (_formActual != null)
            {
                _formActual.Close();
                _formActual.Dispose();
            }

            _formActual = form;
            _formActual.TopLevel = false;
            _formActual.FormBorderStyle = FormBorderStyle.None;
            _formActual.Dock = DockStyle.Fill;

            pnlContenidoConfiguracion.Controls.Add(_formActual);
            _formActual.BringToFront();
            _formActual.Show();
        }

        private void ResaltarBoton(Button botonActivo)
        {
            // Resetear todos los botones
            foreach (Control ctrl in pnlBotonesConfiguracion.Controls)
            {
                if (ctrl is Button btn && btn != botonActivo)
                {
                    btn.BackColor = System.Drawing.SystemColors.Control;
                    btn.ForeColor = System.Drawing.SystemColors.ControlText;
                }
            }

            // Resaltar el botón activo
            botonActivo.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            botonActivo.ForeColor = System.Drawing.Color.White;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnEmpresa);
            MostrarFormulario(new FormEmpresa());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnReportes);
            MostrarFormulario(new FormReportes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnUsuarios);
            MostrarFormulario(new FormUsuarios());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnCategorias);
            MostrarFormulario(new FormCategorias());
        }

        private void btnPresentaciones_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnPresentaciones);
            MostrarFormulario(new FormPresentaciones());
        }

        private void btnUnidadBase_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnUnidadBase);
            MostrarFormulario(new FormUnidades());
        }

        private void btnImpresoras_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnImpresoras);
            MostrarFormulario(new FormImpresoras());
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnRespaldo);
            MostrarFormulario(new FormRespaldo());
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnGeneral);
            MostrarFormulario(new FormGeneral());
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnLicencia);
            MostrarFormulario(new FormLicencia());
        }

        private void pnlBotonesConfiguracion_Paint(object sender, PaintEventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (_formActual != null)
            {
                _formActual.Close();
                _formActual.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}
