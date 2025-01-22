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
    public partial class CrearPizza : Form
    {

        private List<string> ingrBase;
        private List<string> ingrIngr;

        public CrearPizza()
        {
            InitializeComponent();
        }
        private void CrearPizza_Load(object sender, EventArgs e)
        {
            gbBase.Visible = true;
            gbIngredientes.Visible = false;
            gbCompletar.Visible = false;
            ingrBase = new List<string>();
            ingrIngr = new List<string>();
        }

        private void btnIngrAtras_Click(object sender, EventArgs e)
        {
            gbIngredientes.Visible = false;
            gbBase.Visible = true;
        }

        private void btnCompAtras_Click(object sender, EventArgs e)
        {
            gbCompletar.Visible = false;
            gbIngredientes.Visible = true;
        }

        private void btnIngrSig_Click(object sender, EventArgs e)
        {
            ingrIngr.Clear();
            lvCarnes.Clear();
            lvVerduras.Clear();

            if (clbCarnes.CheckedItems.Count > 0)
            {
                for(int i = 0; i<clbCarnes.CheckedItems.Count; i++)
                {
                    ingrIngr.Add(clbCarnes.CheckedItems[i].ToString());
                    lvCarnes.Items.Add(clbCarnes.CheckedItems[i].ToString());
                }
            }

            if (clbVerduras.CheckedItems.Count > 0)
            {
                for (int i = 0; i < clbVerduras.CheckedItems.Count; i++)
                {
                    ingrIngr.Add(clbVerduras.CheckedItems[i].ToString());
                    lvVerduras.Items.Add(clbVerduras.CheckedItems[i].ToString());
                }
            }


            gbIngredientes.Visible = false;
            gbCompletar.Visible = true;

        }

        private void btnMasaSig_Click(object sender, EventArgs e)
        {
      
            string masa = cbMasa.Text;
            string queso = cbQueso.Text;
            string salsa = cbSalsa.Text;

            if (masa == "" || queso == "" || salsa == "")
            {
                MessageBox.Show("Seleccione todos los datos");
                return;
            }

            ingrBase.Clear();
            
            ingrBase.Add(masa);
            ingrBase.Add(queso);
            ingrBase.Add(salsa);

            lvBase.Clear();
            lvBase.Items.Add("Tamaño: " + cbTamano.Text);
            lvBase.Items.Add("Masa: " + cbMasa.Text);
            lvBase.Items.Add("Queso: " + cbQueso.Text);
            lvBase.Items.Add("Salsa: " + cbSalsa.Text);


            gbBase.Visible = false;
            gbIngredientes.Visible = true;
        }

        private void btnCompFin_Click(object sender, EventArgs e)
        {

            //Insertar los datos en la base de datos
            this.Close();
        }
    }
}
