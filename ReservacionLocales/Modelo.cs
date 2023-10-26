using MySql.Data.MySqlClient;

namespace ReservacionLocales
{
    // Clase Modelo que gestiona las operaciones relacionadas con la base de datos
    class Modelo
    {
        // Método para registrar un usuario en la base de datos
        public int registro(Usuarios usuario)
        {
            // Obtiene una instancia de conexión a la base de datos
            MySqlConnection conexion = Conexion.getConexion();
            // Abre la conexión
            conexion.Open();

            // Define la consulta SQL para insertar un nuevo usuario
            string sql = "INSERT INTO usuarios (usuario, password, nombre, id_tipo) " +
                         "VALUES (@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            // Asigna los parámetros de la consulta con los valores del usuario
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);

            // Ejecuta la consulta y obtiene el número de filas afectadas
            int resultado = comando.ExecuteNonQuery();

            // Cierra la conexión después de usarla
            conexion.Close();

            // Devuelve el resultado de la operación
            return resultado;
        }

        // Método para verificar si un usuario ya existe en la base de datos
        public bool existeUsuario(string usuario)
        {
            // Objeto para leer los resultados de la consulta
            MySqlDataReader reader;
            // Obtiene una instancia de conexión a la base de datos
            MySqlConnection conexion = Conexion.getConexion();
            // Abre la conexión
            conexion.Open();

            // Define la consulta SQL para buscar un usuario por nombre de usuario
            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Asigna el parámetro de la consulta con el valor del nombre de usuario
            comando.Parameters.AddWithValue("@usuario", usuario);

            // Ejecuta la consulta y obtiene el lector de resultados
            reader = comando.ExecuteReader();

            // Verifica si hay filas en el resultado
            if (reader.HasRows)
            {
                // El usuario existe
                return true;
            }
            else
            {
                // El usuario no existe
                return false;
            }
        }

        // Método para obtener información de un usuario por nombre de usuario
        public Usuarios porUsuario(string usuario)
        {
            // Objeto para leer los resultados de la consulta
            MySqlDataReader reader;
            // Obtiene una instancia de conexión a la base de datos
            MySqlConnection conexion = Conexion.getConexion();
            // Abre la conexión
            conexion.Open();

            // Define la consulta SQL para obtener información de un usuario por nombre de usuario
            string sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Asigna el parámetro de la consulta con el valor del nombre de usuario
            comando.Parameters.AddWithValue("@usuario", usuario);

            // Ejecuta la consulta y obtiene el lector de resultados
            reader = comando.ExecuteReader();

            // Objeto para almacenar la información del usuario
            Usuarios usr = null;

            // Lee los resultados y asigna la información al objeto de usuario
            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }

            // Devuelve el objeto de usuario
            return usr;
        }
    }
}
