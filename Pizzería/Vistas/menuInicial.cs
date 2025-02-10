using Pizzería.Modelo;
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

    public partial class menuInicial : Form
    {
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();
        public menuInicial()
        {
            InitializeComponent();
        }

        private void bt_infoUsuario_Click(object sender, EventArgs e)
        {
            FormMenuInfoUsuario form = new FormMenuInfoUsuario();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO [Pedido] ([id_usuario],[Fecha],[PrecioFinal],[Estado]) VALUES" +
                    " (@id,@fecha,@preciofinal,@estado)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", UsuarioCache.id);
                comando.Parameters.AddWithValue("@fecha", fechaActual);
                comando.Parameters.AddWithValue("@precioFinal", 0);
                comando.Parameters.AddWithValue("@estado", "En preparación");

                comando.ExecuteNonQuery();
                conexion.Close();
                Form pizerria= new Pizzeria();
                pizerria.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
