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
    public partial class Register : Form
    {
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();
        
        public Register()
        {
            InitializeComponent();
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Nombre")
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Gray;
                tbNombre.Font = new Font("MV boli", 14);
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                tbNombre.Text = "Nombre";
                tbNombre.ForeColor = Color.Gray;
                tbNombre.Font = new Font("MV boli", 14);
            }
        }

        private void tbApellidos_Enter(object sender, EventArgs e)
        {
            if (tbApellidos.Text == "Apellidos")
            {
                tbApellidos.Text = "";
                tbApellidos.ForeColor = Color.Gray;
                tbApellidos.Font = new Font("MV boli", 14);
            }

        }

        private void tbApellidos_Leave(object sender, EventArgs e)
        {
            if (tbApellidos.Text == "")
            {
                tbApellidos.Text = "Apellidos";
                tbApellidos.ForeColor = Color.Gray;
                tbApellidos.Font = new Font("MV boli", 14);
            }
        }

        private void Register_SizeChanged(object sender, EventArgs e)
        {
            
                
                int anchoVentana = this.ClientSize.Width;
                int altoVentana = this.ClientSize.Height;

               
                if (WindowState == FormWindowState.Maximized)
                {
                    
                    panel1.Location = new Point(anchoVentana * 23 / 100, altoVentana * 40 / 100);
                    btnRegistrarse.Location = new Point(anchoVentana * 35 / 100, altoVentana * 55 / 100);
                    linkLabelYaTienesCuenta.Location = new Point(anchoVentana * 23 / 100, altoVentana * 55 / 100);
                    btnCerrar.Location = new Point(anchoVentana * 90 / 100, altoVentana * 5 / 100);
                    btnMinMax.Location = new Point(anchoVentana * 85 / 100, altoVentana * 5 / 100);
                    btnMinimizar.Location = new Point(anchoVentana * 80 / 100, altoVentana * 5 / 100);
                }
                else
                {
                    
                    panel1.Location = new Point(anchoVentana * 20 / 100, altoVentana * 35 / 100);
                    btnRegistrarse.Location = new Point(anchoVentana * 38 / 100, altoVentana * 67 / 100);
                    linkLabelYaTienesCuenta.Location = new Point(anchoVentana * 25 / 100, altoVentana * 67 / 100);
                    btnCerrar.Location = new Point(anchoVentana * 90 / 100, altoVentana * 5 / 100);
                    btnMinMax.Location = new Point(anchoVentana * 85 / 100, altoVentana * 5 / 100);
                    btnMinimizar.Location = new Point(anchoVentana * 80 / 100, altoVentana * 5 / 100);
                }
            

        }

        private void tbTelefono_Enter(object sender, EventArgs e)
        {
            if (tbTelefono.Text == "Telefono")
            {
                tbTelefono.Text = "";
                tbTelefono.ForeColor = Color.Gray;
                tbTelefono.Font = new Font("MV boli", 14); 
            }
        }

        private void tbTelefono_Leave(object sender, EventArgs e)
        {
            if (tbTelefono.Text == "")
            {
                tbTelefono.Text = "Telefono";
                tbTelefono.ForeColor = Color.Gray;
                tbTelefono.Font = new Font("MV boli", 14);
            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "Contraseña")
            {
                tbContraseña.Text = "";
                tbContraseña.ForeColor = Color.Gray;
                tbContraseña.Font = new Font("MV boli", 14);
                tbContraseña.UseSystemPasswordChar = false;
                tbContraseña.PasswordChar = '*';
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "Contraseña";
                tbContraseña.ForeColor = Color.Gray;
                tbContraseña.Font = new Font("MV boli", 14);
                tbContraseña.UseSystemPasswordChar = true;
                
            }
        }

        private void tbMail_Enter(object sender, EventArgs e)
        {
            if (tbMail.Text == "Correo Electronico")
            {
                tbMail.Text = "";
                tbMail.ForeColor = Color.Gray;
                tbMail.Font = new Font("MV boli", 14);
            }
        }

        private void tbMail_Leave(object sender, EventArgs e)
        {
            if (tbMail.Text == "")
            {
                tbMail.Text = "Correo Electronico";
                tbMail.ForeColor = Color.Gray;
                tbMail.Font = new Font("MV boli", 14);
            }
        }

      

       

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bool error = false;
            String apellidos = tbApellidos.Text.ToString();
            String[] apellidosSeparados = apellidos.Split(' ');
            Usuario user = new Usuario();
            if (tbNombre.Text == "" || tbApellidos.Text == "" || tbContraseña.Text == ""  || tbMail.Text == "" || tbTelefono.Text == ""|| tbNombre.Text == "Nombre" || tbApellidos.Text == "Apellidos" || tbContraseña.Text == "Contraseña" ||  tbMail.Text == "Correo Electronico" || tbTelefono.Text == "Telefono")
            {
                MessageBox.Show("Faltan datos a introducir");
                error = true;
            }
            else
            {

            user.nombre = tbNombre.Text.ToString();
            user.apellido1 = apellidosSeparados[0];
            if (apellidosSeparados.Length == 2)
            {
            user.apellido2 = apellidosSeparados[1];
            }
            else
            {
                user.apellido2 = "Null";
            }
            user.contraseña = tbContraseña.Text.ToString();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "SELECT [Correo] FROM [Usuarios]";
                SqlDataReader sqlData= comando.ExecuteReader();
                while (sqlData.Read())
                {
                    String sqlCorreo = sqlData.GetString(0);
                    if (sqlCorreo == tbMail.Text)
                    {
                        MessageBox.Show("Error correo electronico ya en uso");
                        error=true;
                        break;
                    }
                }
                conexion.Close();
            user.correo = tbMail.Text.ToString();
            user.telefono = tbTelefono.Text;
            }
            

            if (error==false)
            {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "INSERT INTO [Usuarios] ([Nombre],[Apellido1],[Apellido2],[Contrasena],[Correo],[Telefono],[Rol]) VALUES" +
                " (@Nombre,@Apellido1,@Apellido2,@Contrasena,@Correo,@Telefono,@Rol)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Nombre", user.nombre);
            comando.Parameters.AddWithValue("@Apellido1", user.apellido1);
            comando.Parameters.AddWithValue("@Apellido2", user.apellido2);
            comando.Parameters.AddWithValue("@Contrasena", user.contraseña);
            comando.Parameters.AddWithValue("@Correo", user.correo);
            comando.Parameters.AddWithValue("@Telefono", user.telefono);
            comando.Parameters.AddWithValue("@Rol", "user");

            comando.ExecuteNonQuery();
            conexion.Close();

                Form login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void linkLabelYaTienesCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
