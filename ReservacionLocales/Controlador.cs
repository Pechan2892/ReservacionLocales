using System.Security.Cryptography;
using System.Text;

namespace ReservacionLocales
{
    // Clase Controlador que gestiona la lógica de negocio
    class Controlador
    {
        // Método para controlar el registro de usuarios
        public string ctrlRegistro(Usuarios usuario)
        {
            // Se crea una instancia del modelo
            Modelo modelo = new Modelo();
            string respuesta = "";

            // Verifica si alguno de los campos obligatorios está vacío
            if (string.IsNullOrEmpty(usuario.Usuario) ||
                string.IsNullOrEmpty(usuario.Password) ||
                string.IsNullOrEmpty(usuario.ConPassword) ||
                string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                // Verifica si las contraseñas coinciden
                if (usuario.Password == usuario.ConPassword)
                {
                    // Verifica si el usuario ya existe en el modelo
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "Usuario ya existe";
                    }
                    else
                    {
                        // Aplica hash SHA1 a la contraseña y realiza el registro
                        usuario.Password = generarSHA1(usuario.Password);
                        usuario.Id_tipo = 2; // Asigna un tipo de usuario (posiblemente usuario regular)
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "La contraseña no coinciden";
                }
            }
            return respuesta;
        }

        // Método para controlar el inicio de sesión
        public string ctrlLogin(string usuario, string password)
        {
            // Se crea una instancia del modelo
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            // Verifica si los campos de usuario y contraseña están vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Ingresa todos los Campos";
            }
            else
            {
                // Busca al usuario en el modelo por su nombre de usuario
                datosUsuario = modelo.porUsuario(usuario);
                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    // Verifica si la contraseña coincide con la almacenada en el modelo
                    if (datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "Usuario y Contraseña no Coinciden";
                    }
                    else
                    {
                        // Establece la sesión con los datos del usuario autenticado
                        Session.id = datosUsuario.Id;
                        Session.usuario = usuario;
                        Session.nombre = datosUsuario.Nombre;
                        Session.id_tipo = datosUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        // Método privado para generar un hash SHA1 de una cadena
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
