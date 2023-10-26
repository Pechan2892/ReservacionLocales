using System;
using System.Windows.Forms;

namespace ReservacionLocales
{
    // Clase parcial Loguear que representa el formulario de inicio de sesión
    public partial class Loguear : Form
    {
        // Constructor del formulario de inicio de sesión
        public Loguear()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();
        }

        // Manejador de clic en el botón de inicio de sesión
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre de usuario y la contraseña ingresados en los cuadros de texto
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                // Crea una instancia del controlador para gestionar la lógica de inicio de sesión
                Controlador controlador = new Controlador();
                // Intenta realizar el inicio de sesión y obtiene la respuesta
                string respuesta = controlador.ctrlLogin(usuario, password);

                // Verifica si hay un mensaje de respuesta
                if (respuesta.Length > 0)
                {
                    // Muestra un cuadro de diálogo con el mensaje de respuesta en caso de error
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si no hay errores, crea una instancia del formulario principal y lo muestra
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Visible = true;
                    // Oculta el formulario de inicio de sesión
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // En caso de excepción, muestra un cuadro de diálogo con el mensaje de la excepción
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
