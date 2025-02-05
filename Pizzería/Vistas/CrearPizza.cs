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
        private string Masa;
        private string Tamano;
        private Dictionary<string, int> ingrBase;
        private Dictionary<string, int> ingrCarne;
        private Dictionary<string, int> ingrVerdura;

        public CrearPizza()
        {
            InitializeComponent();
        }
        private void CrearPizza_Load(object sender, EventArgs e)
        {
            gbBase.Visible = true;
            gbIngredientes.Visible = false;
            gbCompletar.Visible = false;
            ingrBase = new Dictionary<string, int>();
            ingrCarne = new Dictionary<string, int>();
            ingrVerdura = new Dictionary<string, int>();
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
            
            lvCarnes.Clear();
            lvVerduras.Clear();

            if (ingrCarne.Count > 0)
            {
                
                foreach (KeyValuePair<string, int> par in ingrCarne)
                {
                    string ingredientes = par.Key + ": " + par.Value;
                    lvCarnes.Items.Add(ingredientes);
                }
            }

            if (ingrVerdura.Count > 0)
            {
                foreach (KeyValuePair<string, int> par in ingrVerdura)
                {
                    string ingredientes = par.Key + ": " + par.Value;
                    lvVerduras.Items.Add(ingredientes);
                }
            }

            gbIngredientes.Visible = false;
            gbCompletar.Visible = true;
            
        }

        private void btnMasaSig_Click(object sender, EventArgs e)
        {

            this.Masa = cbMasa.Text;
            this.Tamano = cbTamano.Text;

            if (ingrBase.Count <= 0 || Masa == "" || Tamano == "")
            {
                MessageBox.Show("Complete los campos y añada una salsa o un queso");
                return;
            }



            lvBase.Clear();
            lvBase.Items.Add("Tamaño: " + cbTamano.Text);
            lvBase.Items.Add("Masa: " + cbMasa.Text);
            foreach (KeyValuePair<string, int> par in ingrBase)
            {
                string ingredientes = par.Key + ": " + par.Value;
                lvBase.Items.Add(ingredientes);
            }

            gbIngredientes.Visible = true;
            gbBase.Visible = false;
        }
        private void btnCompFin_Click(object sender, EventArgs e)
        {

            //Insertar los datos en la base de datos
            this.Close();
        }

        private void ModificarIngrediente(Dictionary<string, int> dic, string ingrediente, bool incrementar, Label label)
        {
            
            if (dic.ContainsKey(ingrediente)){
                int numero = int.Parse(label.Text);
                if (incrementar)
                {

                    dic[ingrediente] += 1;
                    label.Text = (numero + 1).ToString();
                }
                else
                {
                    if (dic[ingrediente] > 0)
                    {
                        dic[ingrediente] -= 1;
                        label.Text = (numero - 1).ToString();
                        if (dic[ingrediente] == 0)
                        {
                            dic.Remove(ingrediente);
                        }
                    }
                }
                return;
            }

            if (incrementar)
            {
                dic.Add(ingrediente, 1);
                label.Text = "1";
            }
        }


        //Boton Salsas

        private void btnTomateMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Tomate", false, labelTomate);

        }

        private void btnTomateMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Tomate", true, labelTomate);
        }

        private void btnCarbonaraMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Carbonara", false, labelCarbonara);
        }

        private void btnCarbonaraMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Carbonara", true, labelCarbonara);
        }

        private void btnBarbacoaMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Barbacoa", false, labelBarbacoa);
        }

        private void btnBarbacoaMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Barbacoa", true, labelBarbacoa);
        }

        //Boton Quesos

        private void btnMozzarelaMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Mozzarela", false, labelMozzarela);
        }

        private void btnMozzarelaMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Mozzarela", true, labelMozzarela);
        }

        private void btnCheddarMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Cheddar", false, labelCheddar);
        }

        private void btnCheddarMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Cheddar", true, labelCheddar);
        }

        private void btnProvoloneMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Provolone", false, labelProvolone);
        }

        private void btnProvoloneMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Provolone", true, labelProvolone);
        }

        private void btnSuizoMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Suizo", false, labelSuizo);
        }

        private void btnSuizoMas_Click(object sender, EventArgs e) { 
        
            ModificarIngrediente(ingrBase, "Suizo", true, labelSuizo);
        }

        //Botones Carne
        private void btnTerneraMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Ternera", false, labelTernera);
        }

        private void btnTerneraMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Ternera", true, labelTernera);
        }
        private void btnPolloMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Pollo", false, labelPollo);
        }

        private void btnPolloMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Pollo", true, labelPollo);
        }

        private void btnPepperoniMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Pepperoni", false, labelPepperoni);
        }

        private void btnPepperoniMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Pepperoni", true, labelPepperoni);
        }

        private void btnCerdoMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Cerdo", false, labelCerdo);
        }

        private void btnCerdoMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Cerdo", true, labelCerdo);
        }

        private void btnAtunMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Atun", false, labelAtun);
        }

        private void btnAtunMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrCarne, "Atun", true, labelAtun);
        }

        //Verduras

        private void btnChampinonesMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Champiñones", false, labelChampinon);
        }

        private void btnChampinonesMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Champiñones", true, labelChampinon);
        }

        private void btnPimientoMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Pimiento", false, labelPimiento);
        }

        private void btnPimientoMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Pimiento", true, labelPimiento);
        }

        private void btnCebollaMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Cebolla", false, labelCebolla);
        }

        private void btnCebollaMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Cebolla", true, labelCebolla);
        }

        private void btnAceitunasMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Aceitunas", false, labelAceitunas);
        }

        private void btnAceitunasMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Aceitunas", true, labelAceitunas);
        }

        private void gbBase_Enter(object sender, EventArgs e)
        {

        }
    }
}
