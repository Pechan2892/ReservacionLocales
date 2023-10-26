using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionLocales
{
    // Clase Usuarios que representa la entidad de usuarios
    class Usuarios
    {
        // Propiedades para acceder y modificar los atributos de la clase
        int id, id_tipo;
        string usuario, password, conPassword, nombre;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
