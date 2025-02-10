using Pizzería.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzería.Vistas
{
    public partial class formMenuMiCuenta : Form
    {
        // Atributos de conexión
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();
        public formMenuMiCuenta()
        {
            InitializeComponent();

            this.cargarDatosUsuario();
            this.controlesDeEdicionContraseña();
        }

        // Recuperamos los datos del usuario con el que hemos iniciado sesión (está su info. en el caché)
        private void cargarDatosUsuario()
        {
            // Vista principal
            lab_nombre.Text = UsuarioCache.nombre;
            lab_apellido1.Text = UsuarioCache.apellido1;
            lab_apellido2.Text = UsuarioCache.apellido2;
            lab_correo.Text = UsuarioCache.correo;
            lab_telf.Text = UsuarioCache.telefono;

            // Panel de edición
            tb_nombre.Text = UsuarioCache.nombre;
            tb_apellido1.Text = UsuarioCache.apellido1;
            tb_apellido2.Text = UsuarioCache.apellido2;
            tb_correo.Text = UsuarioCache.correo;
            tb_telefono.Text = UsuarioCache.telefono;
            tb_contraseña.Text = UsuarioCache.contraseña;
            tb_confirmarContraseña.Text = UsuarioCache.contraseña;

        }

        private void controlesDeEdicionContraseña()
        {
            lb_activarEdicionContraseña.Text = "Editar";
            tb_contraseña.UseSystemPasswordChar = true;
            tb_contraseña.Enabled = false;

            tb_contraseñaActual.UseSystemPasswordChar = true;

            tb_confirmarContraseña.UseSystemPasswordChar = true;
            tb_confirmarContraseña.Enabled = false;
            tb_contraseñaActual.Text = "";
        }

        private void reiniciar()
        {
            this.cargarDatosUsuario();
            this.controlesDeEdicionContraseña();
        }
        private void formMenuMiCuenta_Load(object sender, EventArgs e)
        {

        }

        // Label para editar la contraseña
        private void lb_activarEdicionContraseña_Click(object sender, EventArgs e)
        {
            if (lb_activarEdicionContraseña.Text == "Editar")
            {
                lb_activarEdicionContraseña.Text = "Cancelar";
                tb_contraseña.Enabled = true;
                tb_contraseña.Text = "";
                tb_confirmarContraseña.Enabled = true;
                tb_confirmarContraseña.Text = "";
            }
            else
            {
                this.reiniciar();
            }
        }
        // Botón para mostrar el panel de edición
        private void bt_modificarDatos_Click(object sender, EventArgs e)
        {
            panel_editarPerfil.Visible = true;
            this.cargarDatosUsuario();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            Boolean validados = this.camposValidados();
            if (!validados) 
            {
                MessageBox.Show("Por favor, introduzca valor en todos los campos");
                return;
            }

            // Si los campos están validados
            if (tb_contraseña.Text == tb_confirmarContraseña.Text)
            {
                if (tb_contraseñaActual.Text == UsuarioCache.contraseña)
                {
                    // Primero creamos un objeto Usuario que contiene los datos a modificar en la base de datos
                    Usuario usuario = new Usuario();
                    usuario.id = UsuarioCache.id;
                    usuario.nombre = tb_nombre.Text;
                    usuario.apellido1 = tb_apellido1.Text;
                    usuario.apellido2 = tb_apellido2.Text;
                    usuario.correo = tb_correo.Text;
                    usuario.telefono = tb_telefono.Text;
                    usuario.contraseña = tb_contraseña.Text;
                    usuario.correo = tb_correo.Text;
                    usuario.telefono = tb_telefono.Text;

                    Boolean actualizado = this.actualizarInfoUsuario(usuario.id, usuario.nombre, usuario.apellido1, usuario.apellido2, usuario.correo,
                        usuario.telefono, usuario.contraseña);

                    if (actualizado) // Si se ha actualizado el objeto en base de datos, actualizamos la información en caché de nuestra aplicación
                    {
                        UsuarioCache.nombre = tb_nombre.Text;
                        UsuarioCache.apellido1 = tb_apellido1.Text;
                        UsuarioCache.apellido2 = tb_apellido2.Text;
                        UsuarioCache.contraseña = tb_contraseña.Text;
                        UsuarioCache.correo = tb_correo.Text;
                        UsuarioCache.telefono = tb_telefono.Text;
                        this.reiniciar();
                    }

                    panel_editarPerfil.Visible = false;
                }
                else
                {
                    MessageBox.Show("Contraseña actual incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor indíquelo nuevamente");
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            panel_editarPerfil.Visible = false;
            this.reiniciar();
        }

        private Boolean camposValidados() 
        {
            if (String.IsNullOrEmpty(tb_nombre.Text) || String.IsNullOrEmpty(tb_apellido1.Text) || String.IsNullOrEmpty(tb_apellido2.Text) || String.IsNullOrEmpty(tb_correo.Text) || String.IsNullOrEmpty(tb_telefono.Text) || String.IsNullOrEmpty(tb_contraseña.Text) || String.IsNullOrEmpty(tb_confirmarContraseña.Text) || String.IsNullOrEmpty(tb_contraseñaActual.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private const string ACTUALIZAR_INFO_USUARIO = @"update Usuarios set Nombre = @Nombre, Apellido1 = @Apellido1, 
        Apellido2 = @Apellido2, Correo = @Correo, Telefono = @Telefono, Contrasena = @Contrasena where ID = @ID;";

        private Boolean actualizarInfoUsuario(int id, string nombre, string apellido1, string apellido2,
                                           string correo, string telefono, string contrasena)
        {
            try
            {
                conexion.Open();
                // Usamos using para eliminar los recursos cuando finalice la consulta
                using (SqlCommand comando = new SqlCommand(ACTUALIZAR_INFO_USUARIO, conexion))
                {

                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido1", apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", apellido2);
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);
                    comando.Parameters.AddWithValue("@ID", id);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Información actualizada correctamente");
                        return true;
                    }

                    
                    else
                    {
                        MessageBox.Show("No se encontró el usuario");
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lo sentimos, ese correo ya está registrado en la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return false;
        }
    }
}
