using System;
using System.Windows.Forms;

namespace ReservacionLocales
{
    public partial class FrmPrincipal : Form
    {
        // Variable para almacenar el tipo de usuario
        int tipoUsuario;

        // Constructor del formulario principal
        public FrmPrincipal()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();

            // Asigna el nombre de usuario desde la sesión al cuadro de texto
            txtNombre.Text = Session.nombre;

            // Obtiene el tipo de usuario desde la sesión
            tipoUsuario = Session.id_tipo;

            // Configura la visibilidad de elementos del menú según el tipo de usuario
            if (tipoUsuario == 1)
            {
                // Si es tipo 1 (presumiblemente un administrador), muestra el submenú de registro de usuarios
                this.subMenuRegistarUsuario.Visible = true;
            }
            else
            {
                // Si no es tipo 1, oculta el submenú de registro de usuarios y el menú de configuración
                this.subMenuRegistarUsuario.Visible = false;
               
            }
        }

        // Manejador de clic en el submenú para registrar usuarios
        private void subMenuRegistarUsuario_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de usuarios
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
        }

        // Manejador de cierre del formulario principal
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra la aplicación al cerrar el formulario principal
            Application.Exit();
        }

        // Manejador de clic en el menú para cerrar sesión
        private void menuCerrarSecion_Click(object sender, EventArgs e)
        {
            // Cierra el formulario principal
            this.Close();

            // Crea un nuevo formulario de inicio de sesión
            Loguear login = new Loguear();
            login.Visible = true;

            // Crea una nueva sesión (posiblemente para reiniciar datos de sesión)
            Session ss = new Session();
        }

       

        private void menuCerrarSecion_Click_1(object sender, EventArgs e)
        {

        }

        private void subMenuconsultarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
