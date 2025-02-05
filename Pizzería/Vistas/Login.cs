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
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-7E96FO2;Initial Catalog=Pizzeria;Persist Security Info=True;User ID=sa;Password=di2024;TrustServerCertificate=True;Encrypt=False;");
        SqlCommand comando = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinMaxLogin_Click(object sender, EventArgs e)
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

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            int anchoVentana = this.ClientSize.Width;
            int altoVentana = this.ClientSize.Height;


            if (WindowState == FormWindowState.Maximized)
            {

                panel1.Location = new Point(anchoVentana * 23 / 100, altoVentana * 38 / 100);
                btnLogin.Location = new Point(anchoVentana * 30 / 100, altoVentana * 50 / 100);
                btnCerrarLogin.Location = new Point(anchoVentana * 90 / 100, altoVentana * 5 / 100);
                btnMinMaxLogin.Location = new Point(anchoVentana * 85 / 100, altoVentana * 5 / 100);
                btnMinimizarLogin.Location = new Point(anchoVentana * 80 / 100, altoVentana * 5 / 100);
            }
            else
            {

                panel1.Location = new Point(anchoVentana * 20 / 100, altoVentana * 40 / 100);
                btnLogin.Location = new Point(anchoVentana * 32 / 100, altoVentana * 60 / 100);
                btnCerrarLogin.Location = new Point(anchoVentana * 90 / 100, altoVentana * 5 / 100);
                btnMinMaxLogin.Location = new Point(anchoVentana * 85 / 100, altoVentana * 5 / 100);
                btnMinimizarLogin.Location = new Point(anchoVentana * 80 / 100, altoVentana * 5 / 100);
            }
        }

        private void lineShape6_Click(object sender, EventArgs e)
        {

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM [Usuarios]";
            List<Usuario> usuarioList= new List<Usuario>();
            SqlDataReader sqlReader= comando.ExecuteReader();
            while (sqlReader.Read())
            {
                Usuario usuario = new Usuario();
                String[] apellidos= sqlReader.GetString(2).Split(' ');
                usuario.id = sqlReader.GetInt32(0);
                usuario.nombre = sqlReader.GetString(1);
                usuario.apellido1 = apellidos[0];
                if (apellidos.Length > 1)
                {
                usuario.apellido2 = apellidos[1];
                }
                usuario.correo=sqlReader.GetString(3);
                usuario.telefono=sqlReader.GetString(4);
                usuario.direccion=sqlReader.GetString(5);
                usuario.contraseña=sqlReader.GetString(6);
                usuario.rol = sqlReader.GetString(7);
                usuarioList.Add(usuario);
            }
            conexion.Close();
            bool acceso=false;
            foreach (Usuario user in usuarioList) {
                if (user.correo.Equals(tbMail.Text.ToString()) && user.contraseña.Equals(tbContraseña.Text.ToString()))
                {
                    UsuarioCache.id = user.id;
                    UsuarioCache.nombre=user.nombre;
                    UsuarioCache.apellido1=user.apellido1;
                    UsuarioCache.apellido2=user.apellido2;
                    UsuarioCache.correo=user.correo;
                    UsuarioCache.telefono=user.telefono;
                    UsuarioCache.direccion=user.direccion;
                    UsuarioCache.contraseña=user.contraseña;
                    UsuarioCache.rol=user.rol;
                    acceso = true;
                }
                else
                {
                    acceso = false;
                }            
            }
            if (acceso==false)
            {
                MessageBox.Show("Correo o Contraseña Incorrectos");
            }

        }
    }
}
