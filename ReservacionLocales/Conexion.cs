using MySql.Data.MySqlClient;

namespace ReservacionLocales
{
    // Clase para gestionar la conexión a la base de datos MySQL
    class Conexion
    {
        // Método estático para obtener una instancia de MySqlConnection
        public static MySqlConnection getConexion()
        {
            // Definición de parámetros de conexión
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "pass123";
            string db = "localmanagerdb";

            // Construcción de la cadena de conexión
            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario +
                                     "; password=" + password + "; database=" + db;

            // Creación de la instancia de MySqlConnection con la cadena de conexión
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            // Devuelve la instancia de conexión creada
            return conexion;
        }
    }
}
