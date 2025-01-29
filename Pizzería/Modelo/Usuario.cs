using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzería
{
    internal class Usuario
    {
        public long id {  get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string contraseña { get; set; }
        public string correo  { get; set; }
        public int telefono { get; set; }
        public string direccion  { get; set; }
    }
}
