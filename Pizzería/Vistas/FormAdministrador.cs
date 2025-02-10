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
    public partial class FormAdministrador : Form
    {
        // Atributos de conexión
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();
        public FormAdministrador()
        {
            InitializeComponent();
            this.cargarListaDeUsuarios();
        }

        private void bt_seleccionarUsuario_Click(object sender, EventArgs e)
        {
            comando.Parameters.Clear();
            if (lv_usuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Indique el usuario que desea administrar");
                return;
            }

            // Guardamos el id del usuario que se va a cargar
            int idUsuario = int.Parse(lv_usuarios.SelectedItems[0].Text);
            SqlDataReader resultado = null;

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                
                comando.CommandText = "select Nombre, Apellido1, Apellido2, Correo, Telefono, Contrasena from Usuarios where ID = @ID";
                comando.Parameters.AddWithValue("@ID", idUsuario);
                
                resultado = comando.ExecuteReader();
                resultado.Read();

                // Actualizamos los datos en caché
                UsuarioCache.id = idUsuario;
                UsuarioCache.nombre = resultado.GetString(0);
                UsuarioCache.apellido1 = resultado.GetString(1);
                UsuarioCache.apellido2 = resultado.GetString(2) == null ? "" : resultado.GetString(2);
                UsuarioCache.correo = resultado.GetString(3);
                UsuarioCache.telefono = resultado.GetString(4);
                UsuarioCache.contraseña = resultado.GetString(5);


                MessageBox.Show("Usuario cargado correctamente", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                if (resultado != null && !resultado.IsClosed)
                {
                    resultado.Close();
                }
            }
        }

        private void cargarListaDeUsuarios()
        {
            comando.Parameters.Clear();

            lv_usuarios.Items.Clear();

            SqlDataReader resultado = null;

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "Select ID, Nombre from Usuarios";

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    int idUsuario = resultado.GetInt32(0);
                    String nombre = resultado.GetString(1);

                    ListViewItem item = new ListViewItem(idUsuario.ToString());
                    item.SubItems.Add(nombre.ToString());

                    lv_usuarios.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                if (resultado != null && !resultado.IsClosed)
                {
                    resultado.Close();
                }
            }
        }
    }
}
