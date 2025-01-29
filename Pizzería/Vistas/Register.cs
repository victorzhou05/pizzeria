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
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-7E96FO2;Initial Catalog=Pizzeria;Persist Security Info=True;User ID=sa;Password=di2024;TrustServerCertificate=True;Encrypt=False;");
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
            if (WindowState == FormWindowState.Maximized)
            {
                // Ajustar la posición del panel cuando está maximizado
                panel1.Location = new Point(300, 300); // Cambia esto a la ubicación que prefieras
                btnRegistrarse.Location = new Point(400, 480);
            }
            else
            {
                // Puedes cambiar el comportamiento si no está maximizado
                panel1.Location = new Point(160, 150); // Ubicación en tamaño normal
                btnRegistrarse.Location = new Point(270, 310);
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

        private void tbDireccion_Enter(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "Direccion")
            {
                tbDireccion.Text = "";
                tbDireccion.ForeColor = Color.Gray;
                tbDireccion.Font = new Font("MV boli", 14);
            }
        }

        private void tbDireccion_Leave(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                tbDireccion.Text = "Direccion";
                tbDireccion.ForeColor = Color.Gray;
                tbDireccion.Font = new Font("MV boli", 14);
            }
        }

       

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            String apellidos = tbApellidos.Text.ToString();
            String[] apellidosSeparados = apellidos.Split(' ');
            Usuario user = new Usuario();
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
            user.correo = tbMail.Text.ToString();
            user.telefono = int.Parse(tbTelefono.Text);
            user.direccion = tbDireccion.Text.ToString();

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "INSERT INTO [Usuarios] ([Nombre],[Apellido1],[Apellido2],[Contrasena],[Correo],[Telefono],[Direccion],[Rol]) VALUES" +
                " (@Nombre,@Apellido1,@Apellido2,@Contrasena,@Correo,@Telefono,@Direccion,@Rol)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Nombre", user.nombre);
            comando.Parameters.AddWithValue("@Apellido1", user.apellido1);
            comando.Parameters.AddWithValue("@Apellido2", user.apellido2);
            comando.Parameters.AddWithValue("@Contrasena", user.contraseña);
            comando.Parameters.AddWithValue("@Correo", user.correo);
            comando.Parameters.AddWithValue("@Telefono", user.telefono);
            comando.Parameters.AddWithValue("@Direccion", user.direccion);
            comando.Parameters.AddWithValue("@Rol", "User");

            comando.ExecuteNonQuery();
            conexion.Close();

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
    }
}
