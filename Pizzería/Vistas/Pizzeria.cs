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
    public partial class Pizzeria : Form
    {

        public Pizzeria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearPizza crearPizza = new CrearPizza();
            crearPizza.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarPizza seleccionaPizza = new SeleccionarPizza();
            seleccionaPizza.Show();
            this.Close();
        }
    }
}
