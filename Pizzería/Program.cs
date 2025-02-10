using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using Pizzería.Vistas;

namespace Pizzería
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
        }

        public static string url = "Data Source=pc-fran;Initial Catalog=pizzeriaDefinitiva;Integrated Security=True;TrustServerCertificate=True";

    }
}
