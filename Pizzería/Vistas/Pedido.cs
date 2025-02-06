using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pizzería.Vistas
{
    public partial class Pedido : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1R0R5VE;Initial Catalog=pizzeria;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;");
        SqlCommand comando = new SqlCommand();
        public Pedido()
        {
            InitializeComponent();
            
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            MostrarDatosLabels();
        }

        private void MostrarDatosLabels()
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;

                comando.CommandText = "SELECT [ID_pedido] FROM [Pedido]"; 

                SqlDataReader reader = comando.ExecuteReader();

                
                if (reader.Read()) 
                {
                   
                    label_numped.Text = reader["ID_pedido"].ToString();
                    
                }
                else
                {
                    
                    label_numped.Text = "No disponible";
                   
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
                conexion.Close();
            }
        }

        

        private void bt_seguirComprando_Click(object sender, EventArgs e)
        {
            CrearPizza crearPizza = new CrearPizza();
            crearPizza.Show();
        }

        private void bt_factura_Click(object sender, EventArgs e)
        {
            try
            {

                string plantillaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "excelfactura.xlsx");
                string destinoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FacturaGenerada.xlsx");


                if (!File.Exists(plantillaPath))
                {
                    MessageBox.Show("No se encontró la plantilla de Excel.");
                    return;
                }


                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;


                Excel.Workbook workbook = excelApp.Workbooks.Open(plantillaPath);
                Excel.Worksheet hoja = (Excel.Worksheet)workbook.Sheets[1];

                //String correo = .Text;
                //String nombre = .Text;



                //hoja.Cells[2, 2] = DateTime.Now.ToString("dd/MM/yyyy");  
                //hoja.Cells[11, 7] = correo;  
                //hoja.Cells[12, 7] = nombre;  
                //Formula = $"=B6*C6";  

                // Guardar con otro nombre para no sobrescribir la plantilla
                workbook.SaveAs(destinoPath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show($"Factura generada en: {destinoPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label_pedido_Click(object sender, EventArgs e)
        {

        }
    }
}
