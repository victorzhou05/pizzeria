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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pizzería.Vistas
{
    public partial class SeleccionarPizza : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        public SeleccionarPizza()
        {
            InitializeComponent();
            conexion = new SqlConnection(Program.url);
            comando = new SqlCommand { Connection = conexion };
        }

        private void bt_siguiente_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Seleccione una pizza");
                return;
            }

            string nombre = listView1.SelectedItems[0].Text.ToString();

            try
            {


                string query = "SELECT ID from Pizza where Nombre = @nombre";
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = query;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader reader = comando.ExecuteReader();

                int idPizza = 0;

                if (reader.Read())
                {
                    idPizza = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Hubo un error al seleccionar la pizza");
                    return;
                }
                reader.Close();


                query = "INSERT INTO [PedidoPizza] ([Id_Pedido], [Id_Pizza], [Cantidad]) " +
                        "VALUES ((SELECT MAX([ID_Pedido]) FROM [Pedido]), @idPizza, @cantidad)";
                comando.CommandText = query;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idPizza", idPizza);
                comando.Parameters.AddWithValue("@cantidad", 1);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos de las pizzas");
            }
            finally
            {
                conexion.Close();
            }

            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();

        }


        private void SeleccionarPizza_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT Nombre from Pizza ORDER BY Nombre ASC";
                comando.Connection = conexion;
                comando.CommandText = query;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listView1.Items.Add(reader.GetString(0));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}

