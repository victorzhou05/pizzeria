using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzería.Vistas
{
    public partial class CrearPizza : Form
    {

      
        String url = "Data Source=DESKTOP-1R0R5VE;Initial Catalog=pizzeria;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;";

        private string Masa;
        private string Tamano;
        private Dictionary<string, int> ingrBase;
        private Dictionary<string, int> ingrCarne;
        private Dictionary<string, int> ingrVerdura;
        private Dictionary<string, string> dictImagenes;
        private Bitmap pizzaBase;
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
            dictImagenes = new Dictionary<string, string>();
            insertarImagenes();
        }

        private void insertarImagenes()
        {
            dictImagenes.Add("4Quesos", "C:\\Users\\saul\\Source\\Repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\4quesos.png");
            dictImagenes.Add("Aceitunas", "C:\\Users\\saul\\Source\\Repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\aceitunas.png");
            dictImagenes.Add("Atun", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\atun.png");
            dictImagenes.Add("Cerdo", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\bacon.png");
            dictImagenes.Add("Cebolla", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\cebolla.png");
            dictImagenes.Add("Champinon", "C:\\Users\\saul\\Source\\Repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\champiñon.png");
            dictImagenes.Add("Mozzarela", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\image.png");
            dictImagenes.Add("Masa", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\masa.png");
            dictImagenes.Add("Pimiento", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\pimiento.png");
            dictImagenes.Add("Pollo", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\pollo.png");
            dictImagenes.Add("Cheddar", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\quesCheddaro.png");
            dictImagenes.Add("Suizo", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\quesoSuizo.png");
            dictImagenes.Add("Barbacoa", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\salsaBarbacoa.png");
            dictImagenes.Add("Carbonara", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\salsaCarbonara.png");
            dictImagenes.Add("Tomate", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\salsaTomate.png");
            dictImagenes.Add("Ternera", "C:\\Users\\saul\\source\\repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\Ternera.png");
            dictImagenes.Add("Pepperoni", "C:\\Users\\saul\\Source\\Repos\\pizzeria\\Pizzería\\Recursos\\Ingredientes\\peperoni.png");


        }


        private void btnIngrAtras_Click(object sender, EventArgs e)
        {
            imagenPizza.Image = pizzaBase;
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

            Bitmap pizzaIngr = (Bitmap)this.pizzaBase.Clone();
            using (Graphics g = Graphics.FromImage(pizzaIngr))
            {
                g.DrawImage(pizzaIngr, 0, 0);
                if (ingrCarne.Count > 0)
                {
                    foreach (KeyValuePair<string, int> par in ingrCarne)
                    {
                        string ingredientes = par.Key + ": " + par.Value;
                        lvCarnes.Items.Add(ingredientes);
                        g.DrawImage(Image.FromFile(dictImagenes[par.Key]), 0, 0);
                    }

                }

                if (ingrVerdura.Count > 0)
                {
                    foreach (KeyValuePair<string, int> par in ingrVerdura)
                    {
                        string ingredientes = par.Key + ": " + par.Value;
                        lvVerduras.Items.Add(ingredientes);
                        g.DrawImage(Image.FromFile(dictImagenes[par.Key]), 0, 0);
                    }
                }
                imagenPizza.Image = pizzaIngr;
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


            Image imgMasa = Image.FromFile(dictImagenes["Masa"]);
            this.pizzaBase = new Bitmap(imgMasa.Width, imgMasa.Height);

            using (Graphics g = Graphics.FromImage(this.pizzaBase))
            {
                g.DrawImage(imgMasa, 0, 0);
                foreach (KeyValuePair<string, int> par in ingrBase)
                {
                    string ingredientes = par.Key + ": " + par.Value;
                    lvBase.Items.Add(ingredientes);
                    g.DrawImage(Image.FromFile(dictImagenes[par.Key]), 0, 0);

                }
            }

            imagenPizza.Image = this.pizzaBase;

            gbIngredientes.Visible = true;
            gbBase.Visible = false;
        }
        private void btnCompFin_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(url);
            SqlCommand comandosql = new SqlCommand();
            // SqlTransaction mitransaccion;
            String nombre = tbCompNombre.Text;

            if (buscarNombreRepetido(nombre))
            {
                MessageBox.Show("Este nombre ya ha sido usado, pruebe con otro");
                return;
            }

            //Insertar los datos en la base de datos
            conexion.Open();
            // mitransaccion = conexion.BeginTransaction();
            try
            {
                comandosql.Connection = conexion;
                // comandosql.Transaction = mitransaccion;
                comandosql.CommandText = "INSERT INTO Pizza (Nombre, Tamano) VALUES (@nombre, @tamano)";

                comandosql.Parameters.AddWithValue("@nombre", nombre);
                comandosql.Parameters.AddWithValue("@tamano", this.Tamano);

                comandosql.ExecuteNonQuery();


                // mitransaccion.Commit();

            }
            catch (Exception ex)
            {
                //      mitransaccion.Rollback();
            }

            comandosql.Parameters.Clear();
            comandosql.CommandText = "SELECT id FROM Pizza where Nombre = @nombre";
            comandosql.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader reader = comandosql.ExecuteReader();

            int pizzaId = 0;
            if (reader.Read())
            {
                pizzaId = reader.GetInt32(0);
            }
            

            comandosql.Parameters.Clear();
            comandosql.CommandText = "INSERT INTO [PedidoPizza] ([Id_Pedido],[Id_Pizza],[Cantidad]) " +
                "VALUES ((SELECT MAX([ID_Pedido]) FROM [Pedido]), @idPizza, @cantidad)";
            comandosql.Parameters.AddWithValue("@idPizza", pizzaId);
            comandosql.Parameters.AddWithValue("@cantidad", 1);
            conexion.Close();


            foreach (KeyValuePair<string, int> par in ingrBase)
            {
                conexion.Open();
                //    SqlTransaction transaccionIngr = conexion.BeginTransaction();
                //    comandosql.Transaction = mitransaccion;

                int id = obtenerIdIngrediente(par.Key);
                int cantidad = par.Value;

                comandosql.Parameters.Clear();
                comandosql.CommandText = "INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (@idPizza, @idIngrediente, @Cantidad);";
                comandosql.Parameters.AddWithValue("@idPizza", pizzaId);
                comandosql.Parameters.AddWithValue("@idIngrediente", id);
                comandosql.Parameters.AddWithValue("@Cantidad", cantidad);
                comandosql.ExecuteNonQuery();
                //  transaccionIngr.Commit();
                conexion.Close();
            }

            foreach (KeyValuePair<string, int> par in ingrCarne)
            {
                conexion.Open();
                //    SqlTransaction transaccionIngr = conexion.BeginTransaction();
                //    comandosql.Transaction = mitransaccion;

                int id = obtenerIdIngrediente(par.Key);
                int cantidad = par.Value;

                comandosql.Parameters.Clear();
                comandosql.CommandText = "INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (@idPizza, @idIngrediente, @Cantidad);";
                comandosql.Parameters.AddWithValue("@idPizza", pizzaId);
                comandosql.Parameters.AddWithValue("@idIngrediente", id);
                comandosql.Parameters.AddWithValue("@Cantidad", cantidad);
                comandosql.ExecuteNonQuery();
                //  transaccionIngr.Commit();
                conexion.Close();
            }

            foreach (KeyValuePair<string, int> par in ingrVerdura)
            {
                conexion.Open();
                //    SqlTransaction transaccionIngr = conexion.BeginTransaction();
                //    comandosql.Transaction = mitransaccion;

                int id = obtenerIdIngrediente(par.Key);
                int cantidad = par.Value;

                comandosql.Parameters.Clear();
                comandosql.CommandText = "INSERT INTO Pizza_Ingredientes (Id_pizza, Id_ingrediente, Cantidad) VALUES (@idPizza, @idIngrediente, @Cantidad);";
                comandosql.Parameters.AddWithValue("@idPizza", pizzaId);
                comandosql.Parameters.AddWithValue("@idIngrediente", id);
                comandosql.Parameters.AddWithValue("@Cantidad", cantidad);
                comandosql.ExecuteNonQuery();
                //  transaccionIngr.Commit();
                conexion.Close();
            }
            Pedido pedido = new Pedido();
            pedido.Show();

            this.Close();
        }

        private PictureBox anadirPictureBox(String imagen)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile(imagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            return pictureBox1;
        }

        private int obtenerIdIngrediente(String nombre)
        {
            SqlConnection conexion = new SqlConnection(url);
            SqlCommand comandosql = new SqlCommand();
            //SqlTransaction mitransaccion;
            int id = 0;
            conexion.Open();
            //mitransaccion = conexion.BeginTransaction();

            comandosql.Connection = conexion;
            //comandosql.Transaction = mitransaccion;
            comandosql.CommandText = "SELECT Id_Ingrediente from Ingredientes where Nombre_ingrediente = @nombre";
            comandosql.Parameters.AddWithValue("@nombre", nombre);

            SqlDataReader reader = comandosql.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            conexion.Close();
            // mitransaccion.Commit();

            return id;
        }

        private bool buscarNombreRepetido(String nombre)
        {
            SqlConnection conn = new SqlConnection(url);
            SqlCommand comando = new SqlCommand();
            // SqlTransaction mitransaccion;

            conn.Open();
            // mitransaccion = conn.BeginTransaction();

            comando.Connection = conn;
            // comando.Transaction = mitransaccion;
            comando.CommandText = "SELECT * from Pizza where Nombre = @nombre";
            comando.Parameters.AddWithValue("@nombre", nombre);

            SqlDataReader reader = comando.ExecuteReader();
            // mitransaccion.Commit();
            if (reader.Read())
            {
                reader.Close();
                conn.Close();
                return true;
            }

            return false;

        }

        private void ModificarIngrediente(Dictionary<string, int> dic, string ingrediente, bool incrementar, Label label)
        {

            if (dic.ContainsKey(ingrediente))
            {
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
            ModificarIngrediente(ingrBase, "4Quesos", false, labelProvolone);
        }

        private void btnProvoloneMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "4Quesos", true, labelProvolone);
        }

        private void btnSuizoMenos_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrBase, "Suizo", false, labelSuizo);
        }

        private void btnSuizoMas_Click(object sender, EventArgs e)
        {

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
            ModificarIngrediente(ingrVerdura, "Champinon", false, labelChampinon);
        }

        private void btnChampinonesMas_Click(object sender, EventArgs e)
        {
            ModificarIngrediente(ingrVerdura, "Champinon", true, labelChampinon);
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

        private void gbCompletar_Enter(object sender, EventArgs e)
        {

        }
    }
}