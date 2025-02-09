using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        private int idPizzaSeleccionada = 0;

        public SeleccionarPizza()
        {
            InitializeComponent();
            conexion = new SqlConnection("Data Source=DESKTOP-1R0R5VE;Initial Catalog=pizzeria;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;");
            comando = new SqlCommand { Connection = conexion };
        }

        private void bt_siguiente_Click(object sender, EventArgs e)
        {
            if (idPizzaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, selecciona una pizza.");
                return;
            }

            try
            {
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO [PedidoPizza] ([Id_Pedido],[Id_Pizza],[Cantidad]) " +
                    "VALUES ((SELECT MAX(([ID_Pedido])) FROM ([Pedido])), @idPizza, @cantidad)";
                comando.Parameters.AddWithValue("@idPizza", idPizzaSeleccionada);
                comando.Parameters.AddWithValue("@cantidad", 1);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            Pedido pedido = new Pedido();
            pedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idPizzaSeleccionada = 1;
            MessageBox.Show("Pizza seleccionada: 4 quesos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idPizzaSeleccionada = 2;
            MessageBox.Show("Pizza seleccionada: Barbacoa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idPizzaSeleccionada = 3;
            MessageBox.Show("Pizza seleccionada: Carbonara");
        }

        private void SeleccionarPizza_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT I.Nombre_ingrediente " +
                    "FROM Pizza_Ingredientes PI INNER JOIN Ingredientes I ON PI.Id_ingrediente = I.Id_Ingrediente WHERE PI.Id_pizza = @id;";

                MostrarDatosLabels(query, label4, 3);
                MostrarDatosLabels(query, label5, 2);
                MostrarDatosLabels(query, label6, 1);
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

        private void MostrarDatosLabels(string consultaSQL, Label label, int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = consultaSQL;
                comando.Parameters.AddWithValue("@id", id);

                List<string> ingredientes = new List<string>();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ingredientes.Add(reader["Nombre_ingrediente"].ToString());
                }

                label.Text = ingredientes.Count > 0 ? string.Join(", ", ingredientes) : "No disponible";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }
    }
}

