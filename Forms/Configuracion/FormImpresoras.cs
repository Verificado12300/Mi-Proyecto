using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using SistemaPOS.Data;
using SistemaPOS.Models;
using System.Collections.Generic;

namespace SistemaPOS.Forms.Configuracion
{
    public partial class FormImpresoras : Form
    {
        private Empresa _empresa;
        private bool _cargandoDatos;
        private readonly Dictionary<Control, int> _topOriginalVista = new Dictionary<Control, int>();
        private int _topBaseSeparadorEncabezado;
        private int _gapNombreRuc;
        private int _gapRucDireccion;
        private int _gapDireccionTelefono;
        private int _gapTelefonoSeparador;
        private const int LogoCollapseOffset = 103;

        public FormImpresoras()
        {
            InitializeComponent();
            AplicarTemaDashboard();
            InicializarPosicionesVista();
            ConfigurarEventos();
            ConfigurarControles();
            CargarImpresoras();
            CargarDatos();
            ActualizarVistaPrevia();
        }

        private void AplicarTemaDashboard()
        {
            Color fondo = Color.FromArgb(244, 244, 250);
            Color textoPrincipal = Color.FromArgb(45, 52, 54);
            Color textoSecundario = Color.FromArgb(127, 140, 141);
            Color bordeTarjeta = Color.FromArgb(223, 228, 234);

            BackColor = fondo;

            EstilizarTarjeta(pnlImpresora, bordeTarjeta);
            EstilizarTarjeta(pnlContenidoTicket, bordeTarjeta);
            EstilizarTarjeta(pnlOpcionesImpresion, bordeTarjeta);
            EstilizarTarjeta(pnlVistaTicket, bordeTarjeta);

            lblTitulo.ForeColor = textoPrincipal;
            lblVistaPrevia.ForeColor = textoPrincipal;

            EstilizarBotonPrimario(btnGuardarConfiguracion);
            EstilizarBotonSecundario(btnImprimirPrueba);
            EstilizarBotonSecundario(btnConfigurarImpresora);

            EstilizarControlesPanel(pnlImpresora, textoPrincipal, textoSecundario);
            EstilizarControlesPanel(pnlContenidoTicket, textoPrincipal, textoSecundario);
            EstilizarControlesPanel(pnlOpcionesImpresion, textoPrincipal, textoSecundario);
        }

        private static void EstilizarTarjeta(Panel panel, Color borde)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void EstilizarBotonPrimario(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = Color.FromArgb(46, 134, 222);
            boton.ForeColor = Color.White;
        }

        private static void EstilizarBotonSecundario(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.FromArgb(223, 228, 234);
            boton.FlatAppearance.BorderSize = 1;
            boton.BackColor = Color.White;
            boton.ForeColor = Color.FromArgb(45, 52, 54);
        }

        private static void EstilizarControlesPanel(Control root, Color textoPrincipal, Color textoSecundario)
        {
            foreach (Control c in root.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = lbl.Font.Bold ? textoPrincipal : textoSecundario;
                }
                else if (c is CheckBox chk)
                {
                    chk.FlatStyle = FlatStyle.Flat;
                    chk.ForeColor = textoPrincipal;
                }
                else if (c is ComboBox cmb)
                {
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.BackColor = Color.White;
                    cmb.ForeColor = textoPrincipal;
                }
                else if (c is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = textoPrincipal;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is NumericUpDown nud)
                {
                    nud.BackColor = Color.White;
                    nud.ForeColor = textoPrincipal;
                    nud.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        private void InicializarPosicionesVista()
        {
            _topOriginalVista.Clear();
            foreach (Control c in pnlVistaTicket.Controls)
            {
                _topOriginalVista[c] = c.Top;
            }
            _topBaseSeparadorEncabezado = label3.Top;
            _gapNombreRuc = lblRuc.Top - lblNombreNegocio.Top;
            _gapRucDireccion = lblDireccion.Top - lblRuc.Top;
            _gapDireccionTelefono = lblTelfono.Top - lblDireccion.Top;
            _gapTelefonoSeparador = label3.Top - lblTelfono.Top;
        }

        private void ConfigurarEventos()
        {
            btnConfigurarImpresora.Click += BtnConfigurarImpresora_Click;
            btnImprimirPrueba.Click += BtnImprimirPrueba_Click;
            btnGuardarConfiguracion.Click += BtnGuardarConfiguracion_Click;
            cmbImpresoraPredeterminada.SelectedIndexChanged += ConfiguracionCambiada;

            // Eventos de contenido del ticket
            chkMostrarLogo.CheckedChanged += ConfiguracionCambiada;
            chkMostrarNombre.CheckedChanged += ConfiguracionCambiada;
            chkMostrarRUC.CheckedChanged += ConfiguracionCambiada;
            chkMostrarDireccion.CheckedChanged += ConfiguracionCambiada;
            chkMostrarTelefono.CheckedChanged += ConfiguracionCambiada;
            chkMostrarEmail.CheckedChanged += ConfiguracionCambiada;
            chkMostrarQR.CheckedChanged += ConfiguracionCambiada;
            chkMostrarInfoPago.CheckedChanged += ConfiguracionCambiada;
            txtMensajePie1.TextChanged += ConfiguracionCambiada;
            txtMensajePie2.TextChanged += ConfiguracionCambiada;

            // Eventos de opciones de impresion
            cmbNumeroCopias.SelectedIndexChanged += ConfiguracionCambiada;
            tbDensidad.ValueChanged += ConfiguracionCambiada;
            chkCortaPapel.CheckedChanged += ConfiguracionCambiada;
            chkSonidoImprimir.CheckedChanged += ConfiguracionCambiada;
            cmbEspaciadoLineas.SelectedIndexChanged += ConfiguracionCambiada;
            cmbAnchoPapel.SelectedIndexChanged += CmbAnchoPapel_SelectedIndexChanged;
            nudAnchoPersonalizado.ValueChanged += ConfiguracionCambiada;
            nudEscalaAjuste.ValueChanged += ConfiguracionCambiada;
            nudMargenIzquierdo.ValueChanged += ConfiguracionCambiada;
            nudMargenDerecho.ValueChanged += ConfiguracionCambiada;
            nudMargenSuperior.ValueChanged += ConfiguracionCambiada;
            nudMargenInferior.ValueChanged += ConfiguracionCambiada;
        }

        private void ConfigurarControles()
        {
            // Configurar numero de copias
            cmbNumeroCopias.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cmbNumeroCopias.Items.Add(i.ToString());
            }
            cmbNumeroCopias.SelectedIndex = 0;

            // Configurar ancho de papel
            cmbAnchoPapel.Items.Clear();
            cmbAnchoPapel.Items.Add("58 mm");
            cmbAnchoPapel.Items.Add("88 mm");
            cmbAnchoPapel.Items.Add("Personalizado");
            cmbAnchoPapel.SelectedIndex = 1;
            nudAnchoPersonalizado.Minimum = 1;
            nudAnchoPersonalizado.Maximum = 100;
            nudAnchoPersonalizado.Value = 88;
            nudAnchoPersonalizado.Enabled = false;

            // Configurar densidad
            tbDensidad.Minimum = 1;
            tbDensidad.Maximum = 10;
            tbDensidad.Value = 5;

            // Configurar espaciado
            cmbEspaciadoLineas.Items.Clear();
            cmbEspaciadoLineas.Items.Add("Compacto");
            cmbEspaciadoLineas.Items.Add("Normal");
            cmbEspaciadoLineas.Items.Add("Amplio");
            cmbEspaciadoLineas.SelectedIndex = 1;
            nudEscalaAjuste.Minimum = -50;
            nudEscalaAjuste.Maximum = 50;
            nudEscalaAjuste.Value = 0;
            nudMargenIzquierdo.Minimum = 0;
            nudMargenIzquierdo.Maximum = 20;
            nudMargenDerecho.Minimum = 0;
            nudMargenDerecho.Maximum = 20;
            nudMargenSuperior.Minimum = 0;
            nudMargenSuperior.Maximum = 20;
            nudMargenInferior.Minimum = 0;
            nudMargenInferior.Maximum = 20;
            nudMargenIzquierdo.Value = 0;
            nudMargenDerecho.Value = 0;
            nudMargenSuperior.Value = 0;
            nudMargenInferior.Value = 0;

            // Valores por defecto
            chkMostrarLogo.Checked = true;
            chkMostrarNombre.Checked = true;
            chkMostrarRUC.Checked = true;
            chkMostrarDireccion.Checked = true;
            chkMostrarTelefono.Checked = true;
            chkMostrarEmail.Checked = false;
            chkMostrarQR.Checked = false;
            chkMostrarQR.Text = "Mostrar Codigo QR (Negocio)";
            chkMostrarInfoPago.Checked = true;
            chkCortaPapel.Checked = true;
            chkSonidoImprimir.Checked = true;

            txtMensajePie1.Text = "Gracias por su compra";
            txtMensajePie2.Text = "Vuelva pronto";
        }

        private void CargarImpresoras()
        {
            cmbImpresoraPredeterminada.Items.Clear();

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbImpresoraPredeterminada.Items.Add(printer);
            }

            // Seleccionar impresora guardada o la predeterminada del sistema
            string impresoraGuardada = EmpresaRepository.ObtenerConfiguracion("IMPRESORA_PREDETERMINADA", "");

            if (!string.IsNullOrEmpty(impresoraGuardada) && cmbImpresoraPredeterminada.Items.Contains(impresoraGuardada))
            {
                cmbImpresoraPredeterminada.SelectedItem = impresoraGuardada;
            }
            else if (cmbImpresoraPredeterminada.Items.Count > 0)
            {
                // Buscar impresora predeterminada del sistema
                var settings = new PrinterSettings();
                if (cmbImpresoraPredeterminada.Items.Contains(settings.PrinterName))
                {
                    cmbImpresoraPredeterminada.SelectedItem = settings.PrinterName;
                }
                else
                {
                    cmbImpresoraPredeterminada.SelectedIndex = 0;
                }
            }
        }

        private void CargarDatos()
        {
            try
            {
                _cargandoDatos = true;
                // Cargar datos de empresa para la vista previa
                _empresa = EmpresaRepository.ObtenerEmpresa();

                // Cargar configuracion de contenido del ticket
                chkMostrarLogo.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_LOGO", "true") == "true";
                chkMostrarNombre.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_NOMBRE", "true") == "true";
                chkMostrarRUC.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_RUC", "true") == "true";
                chkMostrarDireccion.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_DIRECCION", "true") == "true";
                chkMostrarTelefono.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_TELEFONO", "true") == "true";
                chkMostrarEmail.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_EMAIL", "false") == "true";
                chkMostrarQR.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_QR", "false") == "true";
                chkMostrarInfoPago.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_MOSTRAR_INFO_PAGO", "true") == "true";

                txtMensajePie1.Text = EmpresaRepository.ObtenerConfiguracion("TICKET_PIE_LINEA1", "Gracias por su compra");
                txtMensajePie2.Text = EmpresaRepository.ObtenerConfiguracion("TICKET_PIE_LINEA2", "Vuelva pronto");

                // Cargar opciones de impresion
                string copias = EmpresaRepository.ObtenerConfiguracion("TICKET_COPIAS", "1");
                for (int i = 0; i < cmbNumeroCopias.Items.Count; i++)
                {
                    if (cmbNumeroCopias.Items[i].ToString() == copias)
                    {
                        cmbNumeroCopias.SelectedIndex = i;
                        break;
                    }
                }

                int anchoMm = LeerEnteroConfig("ANCHO_PAPEL_TICKET", 88, 1, 100);
                if (anchoMm == 58)
                {
                    cmbAnchoPapel.SelectedIndex = 0;
                }
                else if (anchoMm == 88 || anchoMm == 80)
                {
                    cmbAnchoPapel.SelectedIndex = 1;
                }
                else
                {
                    cmbAnchoPapel.SelectedIndex = 2;
                    nudAnchoPersonalizado.Value = anchoMm;
                }
                CmbAnchoPapel_SelectedIndexChanged(null, EventArgs.Empty);

                int densidad = int.Parse(EmpresaRepository.ObtenerConfiguracion("TICKET_DENSIDAD", "5"));
                tbDensidad.Value = Math.Max(tbDensidad.Minimum, Math.Min(tbDensidad.Maximum, densidad));

                chkCortaPapel.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_CORTAR_PAPEL", "true") == "true";
                chkSonidoImprimir.Checked = EmpresaRepository.ObtenerConfiguracion("TICKET_SONIDO", "true") == "true";

                string espaciado = EmpresaRepository.ObtenerConfiguracion("TICKET_ESPACIADO", "Normal");
                for (int i = 0; i < cmbEspaciadoLineas.Items.Count; i++)
                {
                    if (cmbEspaciadoLineas.Items[i].ToString() == espaciado)
                    {
                        cmbEspaciadoLineas.SelectedIndex = i;
                        break;
                    }
                }

                nudEscalaAjuste.Value = LeerEnteroConfig("TICKET_ESCALA_AJUSTE", 0, (int)nudEscalaAjuste.Minimum, (int)nudEscalaAjuste.Maximum);
                nudMargenIzquierdo.Value = LeerEnteroConfig("TICKET_MARGEN_IZQ_MM", 0, (int)nudMargenIzquierdo.Minimum, (int)nudMargenIzquierdo.Maximum);
                nudMargenDerecho.Value = LeerEnteroConfig("TICKET_MARGEN_DER_MM", 0, (int)nudMargenDerecho.Minimum, (int)nudMargenDerecho.Maximum);
                nudMargenSuperior.Value = LeerEnteroConfig("TICKET_MARGEN_SUP_MM", 0, (int)nudMargenSuperior.Minimum, (int)nudMargenSuperior.Maximum);
                nudMargenInferior.Value = LeerEnteroConfig("TICKET_MARGEN_INF_MM", 0, (int)nudMargenInferior.Minimum, (int)nudMargenInferior.Maximum);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar configuracion: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoDatos = false;
            }
        }

        private void ConfiguracionCambiada(object sender, EventArgs e)
        {
            if (_cargandoDatos)
            {
                return;
            }

            ActualizarVistaPrevia();
        }

        private void ActualizarVistaPrevia()
        {
            // Logo/QR se pueden ocultar; los datos se enmascaran en lugar de desaparecer.
            pbLogo.Visible = chkMostrarLogo.Checked;
            pbQR.Visible = chkMostrarQR.Checked;
            lblNombreNegocio.Visible = true;
            lblRuc.Visible = true;
            lblDireccion.Visible = true;
            lblTelfono.Visible = true;
            lblEmail.Visible = true;

            // Info de pago visible, pero enmascarada cuando se desactiva.
            lblMetodoPago.Visible = true;
            lblMetodoPagoSeleccion.Visible = true;
            lblRecibidoCantidad.Visible = true;
            lblVueltoCantidad.Visible = true;

            // Actualizar pie de pagina
            lblPiePagina.Text = txtMensajePie1.Text;

            // Cargar datos de empresa si estan disponibles
            string nombre = _empresa?.RazonSocial ?? "MI NEGOCIO SAC";
            string ruc = _empresa?.RUC ?? "20123456789";
            string direccion = _empresa?.Direccion ?? "Av. Principal 123";
            string telefono = _empresa?.Telefono ?? "999-999-999";
            string email = _empresa?.Email ?? "negocio@correo.com";

            lblNombreNegocio.Text = chkMostrarNombre.Checked ? nombre : MascaraX(Math.Max(8, nombre.Length));
            lblRuc.Text = chkMostrarRUC.Checked ? $"RUC: {ruc}" : $"RUC: {MascaraX(Math.Max(11, ruc.Length))}";
            lblDireccion.Text = chkMostrarDireccion.Checked ? $"Direccion: {direccion}" : $"Direccion: {MascaraX(Math.Max(12, direccion.Length))}";
            lblTelfono.Text = chkMostrarTelefono.Checked ? $"Tel: {telefono}" : $"Tel: {MascaraX(Math.Max(9, SoloDigitos(telefono).Length))}";
            lblEmail.Text = chkMostrarEmail.Checked ? $"Email: {email}" : $"Email: {MascaraX(Math.Max(10, email.Length))}";

            if (chkMostrarInfoPago.Checked)
            {
                lblMetodoPagoSeleccion.Text = "Efectivo";
                lblRecibidoCantidad.Text = "S/ 150.00";
                lblVueltoCantidad.Text = "S/ 22.00";
            }
            else
            {
                lblMetodoPagoSeleccion.Text = MascaraX(7);
                lblRecibidoCantidad.Text = MascaraX(8);
                lblVueltoCantidad.Text = MascaraX(8);
            }

            if (_empresa != null)
            {
                // Cargar logo si existe
                if (_empresa.Logo != null && _empresa.Logo.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(_empresa.Logo))
                        {
                            pbLogo.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        pbLogo.Image = null;
                    }
                }
            }

            AjustarLayoutVistaCabecera();
            pnlVistaTicket.Invalidate();
        }

        private void AjustarLayoutVistaCabecera()
        {
            if (_topOriginalVista.Count == 0)
            {
                return;
            }

            int delta = chkMostrarLogo.Checked ? 0 : -LogoCollapseOffset;
            int yNombre = _topOriginalVista[lblNombreNegocio] + delta;
            int yRuc = yNombre + _gapNombreRuc;
            int yDireccion = yRuc + _gapRucDireccion;
            int yTelefono = yDireccion + _gapDireccionTelefono;
            int yEmail = yTelefono + _gapDireccionTelefono;
            int ySeparador = yEmail + _gapTelefonoSeparador;
            int deltaBloque = ySeparador - _topBaseSeparadorEncabezado;

            lblNombreNegocio.Top = yNombre;
            lblRuc.Top = yRuc;
            lblDireccion.Top = yDireccion;
            lblTelfono.Top = yTelefono;
            lblEmail.Top = yEmail;
            label3.Top = ySeparador;

            foreach (var kv in _topOriginalVista)
            {
                Control c = kv.Key;
                int topBase = kv.Value;

                if (c == pbLogo || c == lblNombreNegocio || c == lblRuc || c == lblDireccion || c == lblTelfono || c == lblEmail || c == label3)
                {
                    continue;
                }

                if (topBase > _topBaseSeparadorEncabezado)
                {
                    c.Top = topBase + deltaBloque;
                }
                else
                {
                    c.Top = topBase;
                }
            }
        }

        private void GuardarConfiguracion()
        {
            try
            {
                // Guardar impresora predeterminada
                EmpresaRepository.GuardarConfiguracion("IMPRESORA_PREDETERMINADA",
                    cmbImpresoraPredeterminada.SelectedItem?.ToString() ?? "", "STRING", "Impresion", "Impresora predeterminada");

                // Guardar contenido del ticket
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_LOGO", chkMostrarLogo.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar logo en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_NOMBRE", chkMostrarNombre.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar nombre en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_RUC", chkMostrarRUC.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar RUC en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_DIRECCION", chkMostrarDireccion.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar direccion en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_TELEFONO", chkMostrarTelefono.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar telefono en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_EMAIL", chkMostrarEmail.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar email en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_QR", chkMostrarQR.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar QR en ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_MOSTRAR_INFO_PAGO", chkMostrarInfoPago.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Mostrar info de pago en ticket");

                EmpresaRepository.GuardarConfiguracion("TICKET_PIE_LINEA1", txtMensajePie1.Text, "STRING", "Impresion", "Primera linea del pie del ticket");
                EmpresaRepository.GuardarConfiguracion("TICKET_PIE_LINEA2", txtMensajePie2.Text, "STRING", "Impresion", "Segunda linea del pie del ticket");

                // Guardar opciones de impresion
                EmpresaRepository.GuardarConfiguracion("TICKET_COPIAS", cmbNumeroCopias.SelectedItem?.ToString() ?? "1", "INTEGER", "Impresion", "Numero de copias");
                EmpresaRepository.GuardarConfiguracion("ANCHO_PAPEL_TICKET", ObtenerAnchoPapelMm().ToString(), "INTEGER", "Impresion", "Ancho del papel en mm");
                EmpresaRepository.GuardarConfiguracion("TICKET_DENSIDAD", tbDensidad.Value.ToString(), "INTEGER", "Impresion", "Densidad de impresion");
                EmpresaRepository.GuardarConfiguracion("TICKET_CORTAR_PAPEL", chkCortaPapel.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Cortar papel automaticamente");
                EmpresaRepository.GuardarConfiguracion("TICKET_SONIDO", chkSonidoImprimir.Checked ? "true" : "false", "BOOLEAN", "Impresion", "Sonido al imprimir");
                EmpresaRepository.GuardarConfiguracion("TICKET_ESPACIADO", cmbEspaciadoLineas.SelectedItem?.ToString() ?? "Normal", "STRING", "Impresion", "Espaciado entre lineas");
                EmpresaRepository.GuardarConfiguracion("TICKET_ESCALA_AJUSTE", nudEscalaAjuste.Value.ToString(), "INTEGER", "Impresion", "Ajuste de escala en porcentaje");
                EmpresaRepository.GuardarConfiguracion("TICKET_MARGEN_IZQ_MM", nudMargenIzquierdo.Value.ToString(), "INTEGER", "Impresion", "Margen izquierdo en mm");
                EmpresaRepository.GuardarConfiguracion("TICKET_MARGEN_DER_MM", nudMargenDerecho.Value.ToString(), "INTEGER", "Impresion", "Margen derecho en mm");
                EmpresaRepository.GuardarConfiguracion("TICKET_MARGEN_SUP_MM", nudMargenSuperior.Value.ToString(), "INTEGER", "Impresion", "Margen superior en mm");
                EmpresaRepository.GuardarConfiguracion("TICKET_MARGEN_INF_MM", nudMargenInferior.Value.ToString(), "INTEGER", "Impresion", "Margen inferior en mm");
            }
            catch
            {
                // Silenciar errores de guardado automatico
            }
        }

        private void BtnConfigurarImpresora_Click(object sender, EventArgs e)
        {
            if (cmbImpresoraPredeterminada.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una impresora primero", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var printDialog = new PrintDialog();
                printDialog.PrinterSettings.PrinterName = cmbImpresoraPredeterminada.SelectedItem.ToString();

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar la impresora seleccionada si cambio
                    if (cmbImpresoraPredeterminada.Items.Contains(printDialog.PrinterSettings.PrinterName))
                    {
                        cmbImpresoraPredeterminada.SelectedItem = printDialog.PrinterSettings.PrinterName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir configuracion de impresora: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimirPrueba_Click(object sender, EventArgs e)
        {
            if (cmbImpresoraPredeterminada.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una impresora primero", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var printDocument = new PrintDocument();
                printDocument.PrinterSettings.PrinterName = cmbImpresoraPredeterminada.SelectedItem.ToString();

                int copias = int.Parse(cmbNumeroCopias.SelectedItem?.ToString() ?? "1");
                printDocument.PrinterSettings.Copies = (short)copias;
                printDocument.OriginAtMargins = false;
                printDocument.DefaultPageSettings.Landscape = false;

                int anchoMm = ObtenerAnchoPapelMm();
                int anchoPapel = MmAHundredthsInch(anchoMm);
                int ajusteEscala = (int)nudEscalaAjuste.Value;
                double factorEscala = Math.Max(0.5d, 1d + (ajusteEscala / 100d));
                int margenIzq = MmAHundredthsInch((int)nudMargenIzquierdo.Value);
                int margenDer = MmAHundredthsInch((int)nudMargenDerecho.Value);
                int margenSup = MmAHundredthsInch((int)nudMargenSuperior.Value);
                int margenInf = MmAHundredthsInch((int)nudMargenInferior.Value);

                int anchoBase = Math.Max(1, anchoPapel - margenIzq - margenDer);
                int anchoContenido = Math.Max(1, (int)Math.Round(anchoBase * factorEscala));
                anchoContenido = Math.Min(anchoBase, anchoContenido);
                int altoContenidoVista = ObtenerAlturaContenidoVistaTicket();
                double relacionVista = (double)altoContenidoVista / Math.Max(1, pnlVistaTicket.Width);
                int altoContenido = (int)Math.Ceiling(anchoContenido * relacionVista);
                int altoPapel = Math.Max(200, altoContenido + margenSup + margenInf);

                printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("TicketPersonalizado", anchoPapel, altoPapel);

                printDocument.PrintPage += (s, ev) =>
                {
                    ev.Graphics.Clear(Color.White);
                    ev.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    ev.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    ev.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    ev.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    ev.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    // Compensa margenes fisicos del cabezal para empezar realmente en el origen del papel.
                    ev.Graphics.TranslateTransform(-ev.PageSettings.HardMarginX, -ev.PageSettings.HardMarginY);

                    int anchoDriver = Math.Max(1, ev.PageBounds.Width);
                    int diferenciaAncho = Math.Abs(anchoDriver - anchoPapel);
                    int anchoBaseReal = diferenciaAncho > (anchoPapel / 4) ? anchoDriver : anchoPapel;
                    int anchoImprimibleReal = Math.Max(1, anchoBaseReal - margenIzq - margenDer);
                    int anchoDestino = Math.Max(1, (int)Math.Round(anchoImprimibleReal * factorEscala));
                    anchoDestino = Math.Min(anchoImprimibleReal, anchoDestino);

                    Rectangle destino = new Rectangle
                    {
                        X = margenIzq,
                        Y = margenSup,
                        Width = anchoDestino,
                        Height = (int)Math.Round(anchoDestino * relacionVista)
                    };

                    int altoMaximo = Math.Max(1, ev.PageBounds.Height - margenSup - margenInf);
                    destino.Height = Math.Min(destino.Height, altoMaximo);

                    // Render fiel al diseno del panel para que coincida con el Designer.
                    DibujarPanelDiseno(ev.Graphics, destino, altoContenidoVista);

                    ev.HasMorePages = false;
                };

                printDocument.Print();

                if (chkSonidoImprimir.Checked)
                {
                    System.Media.SystemSounds.Beep.Play();
                }

                MessageBox.Show("Ticket de prueba enviado a la impresora", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int MmAHundredthsInch(int mm)
        {
            return (int)Math.Round(mm * 3.937d);
        }

        private void DibujarTicketDinamico(Graphics g, Rectangle destino)
        {
            if (destino.Width <= 0 || destino.Height <= 0)
            {
                return;
            }

            float y = destino.Top;
            float xLeft = destino.Left;
            float width = destino.Width;

            using (var fontNormal = new Font("Segoe UI", 9f, FontStyle.Regular))
            using (var fontSmall = new Font("Segoe UI", 8f, FontStyle.Regular))
            using (var fontBold = new Font("Segoe UI", 9f, FontStyle.Bold))
            using (var fontTitle = new Font("Segoe UI", 11f, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.Black))
            {
                // Encabezado (logo y datos de empresa)
                if (chkMostrarLogo.Checked && pbLogo.Image != null)
                {
                    float logoW = Math.Min(width * 0.55f, 180f);
                    float logoH = logoW * (pbLogo.Image.Height / (float)Math.Max(1, pbLogo.Image.Width));
                    if (logoH > 95f)
                    {
                        logoH = 95f;
                        logoW = logoH * (pbLogo.Image.Width / (float)Math.Max(1, pbLogo.Image.Height));
                    }

                    float logoX = xLeft + ((width - logoW) / 2f);
                    g.DrawImage(pbLogo.Image, logoX, y, logoW, logoH);
                    y += logoH + 4f;
                }

                y = DibujarTextoOpcionalCentrado(g, chkMostrarNombre.Checked, lblNombreNegocio.Text, fontTitle, brush, xLeft, width, y, 2f);
                y = DibujarTextoOpcionalCentrado(g, chkMostrarRUC.Checked, lblRuc.Text, fontNormal, brush, xLeft, width, y, 2f);
                y = DibujarTextoOpcionalCentrado(g, chkMostrarDireccion.Checked, lblDireccion.Text, fontNormal, brush, xLeft, width, y, 2f);
                y = DibujarTextoOpcionalCentrado(g, chkMostrarTelefono.Checked, lblTelfono.Text, fontNormal, brush, xLeft, width, y, 4f);

                DibujarLineaSeparador(g, xLeft, width, ref y);

                // Documento y cliente
                DibujarTextoCentrado(g, lblComprobante.Text, fontTitle, brush, xLeft, width, ref y, 2f);
                DibujarTextoCentrado(g, lblnumSerie.Text, fontBold, brush, xLeft, width, ref y, 4f);

                DibujarTextoIzquierda(g, lblFecha.Text, fontNormal, brush, xLeft, ref y, 1f);
                DibujarTextoIzquierda(g, lblCliente.Text, fontNormal, brush, xLeft, ref y, 1f);
                DibujarTextoIzquierda(g, lblDNI.Text, fontNormal, brush, xLeft, ref y, 3f);

                DibujarLineaSeparador(g, xLeft, width, ref y);

                // Cabecera de productos
                g.DrawString(lblDescripcion.Text, fontSmall, brush, xLeft + 2f, y);
                g.DrawString(lblUnidad.Text, fontSmall, brush, xLeft + (width * 0.40f), y);
                g.DrawString(lblCantidad.Text, fontSmall, brush, xLeft + (width * 0.62f), y);
                g.DrawString(lblCosto.Text, fontSmall, brush, xLeft + (width * 0.80f), y);
                y += fontSmall.GetHeight(g) + 2f;
                DibujarLineaContinuaFina(g, xLeft, width, ref y);

                // Filas de ejemplo
                DibujarItemEjemplo(g, fontNormal, brush, xLeft, width, "Fina Postura", "Saco (50Kg)", "1", "S/ 100", ref y);
                DibujarItemEjemplo(g, fontNormal, brush, xLeft, width, "Crecimiento Pollo", "Granel", "10Kg", "S/ 28", ref y);

                DibujarLineaSeparador(g, xLeft, width, ref y);
                // Totales
                DibujarEtiquetaValor(g, lblSubTotal.Text, lblSubTotalCantidad.Text, fontBold, brush, xLeft, width, ref y, false);
                DibujarEtiquetaValor(g, lblIGV.Text, lblIGVCantidad.Text, fontNormal, brush, xLeft, width, ref y, false);
                DibujarEtiquetaValor(g, lblTotal.Text, lblTotalCantidad.Text, fontTitle, brush, xLeft, width, ref y, false);
                DibujarLineaSeparador(g, xLeft, width, ref y);

                if (chkMostrarInfoPago.Checked)
                {
                    DibujarEtiquetaValor(g, lblMetodoPago.Text, lblMetodoPagoSeleccion.Text, fontNormal, brush, xLeft, width, ref y, false);
                    DibujarEtiquetaValor(g, "Recibido:", lblRecibidoCantidad.Text, fontNormal, brush, xLeft, width, ref y, false);
                    DibujarEtiquetaValor(g, "Vuelto:", lblVueltoCantidad.Text, fontNormal, brush, xLeft, width, ref y, false);
                }

                DibujarLineaSeparador(g, xLeft, width, ref y);

                // Pie
                if (!string.IsNullOrWhiteSpace(txtMensajePie1.Text))
                {
                    DibujarTextoCentrado(g, txtMensajePie1.Text.Trim(), fontBold, brush, xLeft, width, ref y, 1f);
                }

                if (!string.IsNullOrWhiteSpace(txtMensajePie2.Text))
                {
                    DibujarTextoCentrado(g, txtMensajePie2.Text.Trim(), fontNormal, brush, xLeft, width, ref y, 1f);
                }

                if (chkMostrarQR.Checked)
                {
                    y += 3f;
                    string urlNegocio = EmpresaRepository.ObtenerConfiguracion("TICKET_QR_NEGOCIO", $"https://wa.me/{SoloDigitos(_empresa?.Telefono)}");
                    DibujarTextoCentrado(g, "QR del negocio", fontBold, brush, xLeft, width, ref y, 2f);

                    float qrSize = Math.Min(90f, width * 0.36f);
                    float qrX = xLeft + ((width - qrSize) / 2f);
                    var qrRect = new RectangleF(qrX, y, qrSize, qrSize);
                    g.DrawRectangle(Pens.Black, qrRect.X, qrRect.Y, qrRect.Width, qrRect.Height);
                    g.DrawString("QR", fontBold, brush, qrRect.X + (qrRect.Width / 2f) - 10f, qrRect.Y + (qrRect.Height / 2f) - 8f);
                    y += qrSize + 2f;
                    DibujarTextoCentrado(g, urlNegocio, fontSmall, brush, xLeft, width, ref y, 0f);
                }
            }
        }

        private static float DibujarTextoOpcionalCentrado(Graphics g, bool mostrar, string texto, Font font, Brush brush, float x, float ancho, float y, float extraEspacio)
        {
            if (!mostrar || string.IsNullOrWhiteSpace(texto))
            {
                return y;
            }

            SizeF s = g.MeasureString(texto, font, (int)ancho);
            g.DrawString(texto, font, brush, new RectangleF(x, y, ancho, s.Height), StringFormatCenter);
            return y + s.Height + extraEspacio;
        }

        private static void DibujarTextoCentrado(Graphics g, string texto, Font font, Brush brush, float x, float ancho, ref float y, float extra)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return;
            }

            SizeF s = g.MeasureString(texto, font, (int)ancho);
            g.DrawString(texto, font, brush, new RectangleF(x, y, ancho, s.Height), StringFormatCenter);
            y += s.Height + extra;
        }

        private static void DibujarTextoIzquierda(Graphics g, string texto, Font font, Brush brush, float x, ref float y, float extra)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return;
            }

            SizeF s = g.MeasureString(texto, font);
            g.DrawString(texto, font, brush, x, y);
            y += s.Height + extra;
        }

        private static void DibujarLineaSeparador(Graphics g, float x, float width, ref float y)
        {
            float pad = Math.Max(0.5f, width * 0.02f);
            float yLine = y + 3f;
            using (var pen = new Pen(Color.Black, 1f))
            {
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new[] { 3f, 2f };
                g.DrawLine(pen, x + pad, yLine, x + width - pad, yLine);
            }

            y += 7f;
        }

        private static void DibujarLineaContinuaFina(Graphics g, float x, float width, ref float y)
        {
            float pad = Math.Max(0.5f, width * 0.02f);
            float yLine = y + 1.5f;
            using (var pen = new Pen(Color.Black, 0.5f))
            {
                pen.DashStyle = DashStyle.Solid;
                g.DrawLine(pen, x + pad, yLine, x + width - pad, yLine);
            }

            y += 4f;
        }

        private static void DibujarItemEjemplo(Graphics g, Font font, Brush brush, float x, float width, string descripcion, string unidad, string cant, string precio, ref float y)
        {
            float colUnidad = x + (width * 0.40f);
            float colCant = x + (width * 0.62f);
            float colPrecio = x + (width * 0.80f);
            float lineHeight = font.GetHeight(g) + 1f;

            var rectDesc = new RectangleF(x + 2f, y, Math.Max(1f, colUnidad - x - 4f), lineHeight);
            var rectUnidad = new RectangleF(colUnidad, y, Math.Max(1f, colCant - colUnidad - 4f), lineHeight);
            var rectCant = new RectangleF(colCant, y, Math.Max(1f, colPrecio - colCant - 4f), lineHeight);
            var rectPrecio = new RectangleF(colPrecio, y, Math.Max(1f, (x + width) - colPrecio - 2f), lineHeight);

            g.DrawString(descripcion, font, brush, rectDesc, StringFormatLeft);
            g.DrawString(unidad, font, brush, rectUnidad, StringFormatLeft);
            g.DrawString(cant, font, brush, rectCant, StringFormatLeft);
            g.DrawString(precio, font, brush, rectPrecio, StringFormatRight);
            y += lineHeight;
        }

        private static void DibujarEtiquetaValor(Graphics g, string etiqueta, string valor, Font font, Brush brush, float x, float width, ref float y, bool soloEtiqueta)
        {
            float lineHeight = font.GetHeight(g) + 1f;
            if (!string.IsNullOrWhiteSpace(etiqueta))
            {
                g.DrawString(etiqueta, font, brush, x + 2f, y, StringFormatLeft);
            }

            if (!soloEtiqueta && !string.IsNullOrWhiteSpace(valor))
            {
                var rectValor = new RectangleF(x + (width * 0.52f), y, width * 0.48f - 2f, lineHeight);
                g.DrawString(valor, font, brush, rectValor, StringFormatRight);
            }

            y += lineHeight;
        }

        private static string SoloDigitos(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return string.Empty;
            }

            char[] chars = valor.ToCharArray();
            var buffer = new char[chars.Length];
            int idx = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    buffer[idx++] = chars[i];
                }
            }

            return new string(buffer, 0, idx);
        }

        private static string MascaraX(int longitud)
        {
            return new string('x', Math.Max(1, longitud));
        }

        private static readonly StringFormat StringFormatCenter = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Near,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private static readonly StringFormat StringFormatLeft = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private static readonly StringFormat StringFormatRight = new StringFormat
        {
            Alignment = StringAlignment.Far,
            LineAlignment = StringAlignment.Near,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private int ObtenerAnchoPapelMm()
        {
            if (cmbAnchoPapel.SelectedIndex == 0)
            {
                return 58;
            }

            if (cmbAnchoPapel.SelectedIndex == 1)
            {
                return 88;
            }

            return (int)nudAnchoPersonalizado.Value;
        }

        private void CmbAnchoPapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudAnchoPersonalizado.Enabled = cmbAnchoPapel.SelectedIndex == 2;
        }

        private void BtnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
            MessageBox.Show("Configuracion guardada correctamente.", "Informacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DibujarPanelDiseno(Graphics g, Rectangle destino, int sourceHeight)
        {
            if (destino.Width <= 0 || destino.Height <= 0)
            {
                return;
            }

            if (pnlVistaTicket is SistemaPOS.Controls.TicketDesignPanel panelVectorial)
            {
                panelVectorial.RenderForPrint(g, destino, sourceHeight);
                return;
            }

            int altoOrigen = Math.Max(1, Math.Min(sourceHeight, pnlVistaTicket.Height));
            using (var bmpBase = new Bitmap(Math.Max(1, pnlVistaTicket.Width), altoOrigen))
            {
                pnlVistaTicket.DrawToBitmap(bmpBase, new Rectangle(0, 0, bmpBase.Width, bmpBase.Height));
                g.DrawImage(bmpBase, destino);
            }
        }

        private int ObtenerAlturaContenidoVistaTicket()
        {
            int maxBottom = 0;
            foreach (Control c in pnlVistaTicket.Controls)
            {
                if (!c.Visible)
                {
                    continue;
                }

                maxBottom = Math.Max(maxBottom, c.Bottom);
            }

            return Math.Max(220, maxBottom + 8);
        }

        private int LeerEnteroConfig(string clave, int valorDefecto, int min, int max)
        {
            string valor = EmpresaRepository.ObtenerConfiguracion(clave, valorDefecto.ToString());
            if (!int.TryParse(valor, out int numero))
            {
                numero = valorDefecto;
            }

            return Math.Max(min, Math.Min(max, numero));
        }

    }
}
