using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzería.Modelo
{
    public static class UsuarioCache
    {
        public static int id { get; set; }
        public  static string nombre { get; set; }
        public static string apellido1 { get; set; }
        public static string apellido2 { get; set; }
        public static string contraseña { get; set; }
        public static string correo { get; set; }
        public static string telefono { get; set; }
        public static string direccion { get; set; }
        public static string rol { get; set; }
    }
}
