using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzería.Vistas
{
    public partial class FormMenuInfoUsuario : Form
    {
        public FormMenuInfoUsuario()
        {
            InitializeComponent();
            // Por defecto hacemos que nos muestre directamente el formulario de nuestra información de usuario
            AbrirPanel(new formMenuMiCuenta());
        }

        // Método para abrir un formulario dentro de nuestro panel
        private void AbrirPanel(Form formHijo)
        {
            if (panel_contenedor.Controls.Count > 0)
            {
                panel_contenedor.Controls.Clear();
            }

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(formHijo);
            panel_contenedor.Tag = formHijo; // Para referenciarlo si es necesario
            formHijo.Show();
        }

        private void bt_miCuenta_Click(object sender, EventArgs e)
        {
            AbrirPanel(new formMenuMiCuenta());
        }

        private void bt_pedidos_Click(object sender, EventArgs e)
        {
            AbrirPanel(new formMenuPedidos());
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
