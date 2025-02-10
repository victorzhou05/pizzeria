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

namespace Pizzería.Vistas
{
    public partial class VerPizzas : Form
    {
        private int idPedido;
        public VerPizzas(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
        }

        private void VerPizzas_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Program.url);
            SqlCommand comando = new SqlCommand();
            List<int> idPizzas = new List<int>();

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "SELECT p.ID, p.Nombre from PedidoPizza pp INNER JOIN Pizza p on pp.Id_Pizza = p.ID where Id_Pedido = @id";
            comando.Parameters.AddWithValue("@id", this.idPedido);


            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                TreeNode nodoPadre = new TreeNode(reader.GetString(1));
                anadirIngredientes(id, nodoPadre);
                treeView1.Nodes.Add(nodoPadre);
            }


        }

        private void anadirIngredientes(int id, TreeNode node)
        {
            SqlConnection conexion = new SqlConnection(Program.url);
            SqlCommand comando = new SqlCommand();

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "SELECT i.Nombre_ingrediente, p_i.Cantidad, i.Precio_ingrediente " +
                "from PedidoPizza pp " +
                "INNER JOIN Pizza p on pp.Id_Pizza = p.ID " +
                "inner join Pizza_Ingredientes p_i on p.ID = p_i.Id_pizza " +
                "inner join Ingredientes i on i.Id_Ingrediente = p_i.Id_ingrediente " +
                "where pp.Id_Pedido = @idPedido and p.ID = @idPizza";
            comando.Parameters.AddWithValue("@idPedido", this.idPedido);
            comando.Parameters.AddWithValue("@idPizza", id);


            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                int cantidad = reader.GetInt32(1);
                decimal precio = reader.GetDecimal(2);
                string ingr =  nombre + ": " + cantidad.ToString() + "x" + precio.ToString() + "€ = " + (precio*cantidad) + "€";
                node.Nodes.Add(ingr);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
