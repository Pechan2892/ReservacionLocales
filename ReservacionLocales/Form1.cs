using System;
using System.Windows.Forms;

namespace ReservacionLocales
{
    // Clase parcial frmRegistro que representa el formulario de registro de usuarios
    public partial class frmRegistro : Form
    {
        // Constructor del formulario de registro
        public frmRegistro()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();
        }

        // Manejador de clic en el botón de registro
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de la clase Usuarios y asigna los valores desde los cuadros de texto
            Usuarios usuario = new Usuarios();
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPasword.Text;
            usuario.ConPassword = txtConfirmar.Text;
            usuario.Nombre = txtNombre.Text;

            try
            {
                // Crea una instancia del controlador para gestionar la lógica de registro
                Controlador controlador = new Controlador();
                // Intenta realizar el registro y obtiene la respuesta
                string respuesta = controlador.ctrlRegistro(usuario);

                // Verifica si hay un mensaje de respuesta
                if (respuesta.Length > 0)
                {
                    // Muestra un cuadro de diálogo con el mensaje de respuesta en caso de error
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si no hay errores, muestra un cuadro de diálogo indicando que el usuario fue registrado
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de excepción, muestra un cuadro de diálogo con el mensaje de la excepción
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
