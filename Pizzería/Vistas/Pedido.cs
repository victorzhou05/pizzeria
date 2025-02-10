using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using Pizzería.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Excel = Microsoft.Office.Interop.Excel;
using Label = System.Windows.Forms.Label;

namespace Pizzería.Vistas
{
    public partial class Pedido : Form
    {
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();

        private List<String> labels = new List<string>();

         
        public Pedido()
        {
            InitializeComponent();
            if (labels != null)
            {
                labels.Clear();
            }

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();  

                
                string query1 = "SELECT TOP 1 ID_Pedido FROM Pedido WHERE id_usuario = @id " +
                                "ORDER BY Fecha DESC;";
                MostrarDatosLabels(query1, "ID_pedido", label_numped, conexion);
                

                
                string query2 = "SELECT COUNT(pp.Id_PedidoPizza) FROM Pedido p JOIN PedidoPizza pp ON p.ID_Pedido = pp.Id_Pedido " +
                                "WHERE p.id_usuario = @id AND p.ID_Pedido = (SELECT MAX(ID_Pedido) " +
                                "FROM Pedido WHERE id_usuario = @id);";
                MostrarDatosLabels(query2, "Id_PedidoPizza", label_numpizzas, conexion);

                
                string query3 = "SELECT SUM(pp.Cantidad * i.Precio_ingrediente) AS PrecioFinal FROM Pedido p " +
                                "JOIN PedidoPizza pp ON p.ID_Pedido = pp.Id_Pedido JOIN Pizza pi ON pp.Id_Pizza = pi.ID " +
                                "JOIN Pizza_Ingredientes p_ing ON pi.ID = p_ing.Id_pizza JOIN Ingredientes i ON " +
                                "p_ing.Id_ingrediente = i.Id_Ingrediente WHERE p.id_usuario = @id " +
                                "AND p.ID_Pedido = (SELECT MAX(ID_Pedido) FROM Pedido WHERE id_usuario = " +
                                "@id);";
                MostrarDatosLabels(query3, "PrecioFinal", label_dinero, conexion);
                label_dinero.Text += "€";
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

        private void MostrarDatosLabels(string consultaSQL, string columna, Label label, SqlConnection conexion)
        {
            try
            {
                
                comando.Connection = conexion;

               
                comando.CommandText = consultaSQL;
                comando.Parameters.Clear(); 
                comando.Parameters.AddWithValue("@id", UsuarioCache.id);

                SqlDataReader reader = comando.ExecuteReader();

                

                if (reader.Read())
                {

                    label.Text = reader[0].ToString();
                    String cadaLabel = label.Text;

                    labels.Add(cadaLabel);
                    
                }
                else
                {
                    
                    label.Text = "No disponible";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
                
            }
        }




        private void bt_seguirComprando_Click(object sender, EventArgs e)
        {
            Pizzeria crearPizza = new Pizzeria();
            crearPizza.Show();
            this.Close();
        }

        private void bt_factura_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now.AddMinutes(30);
            string horaFormato = hora.ToString("HH:mm:ss");


            if (tb_direccion.Text != "") { 

                string direccion = tb_direccion.Text.ToString();

                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "UPDATE [Pedido] SET [Direccion] = @direccion WHERE ID_Pedido = (SELECT MAX(ID_Pedido) FROM Pedido WHERE " +
                "id_usuario = @id);";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@id", UsuarioCache.id);
            

                comando.ExecuteNonQuery();
                


            
                try
                {

                    string plantillaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\franc\\source\\repos\\pizzeriaDefinitiva\\Pizzería\\excelfactura.xlsx");
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

                //#######################################################################################

                    comando.Parameters.Clear();
                    comando.CommandText = "SELECT TOP 1 Fecha FROM Pedido WHERE id_usuario = 1 ORDER BY Fecha DESC";
                    comando.Parameters.AddWithValue("@id", UsuarioCache.id);

                    SqlDataReader reader = comando.ExecuteReader();
                    String fecha = " ";

                    if (reader.Read())
                    {
                        fecha = reader[0].ToString();

                    }
                    reader.Close();

                    comando.Parameters.Clear();
                    comando.CommandText = "SELECT P.Nombre FROM Pedido PD INNER JOIN Usuarios U ON PD.id_usuario = U.ID INNER JOIN PedidoPizza PP " +
                        "ON PD.ID_Pedido = PP.Id_Pedido INNER JOIN Pizza P ON PP.Id_Pizza = P.ID WHERE PD.Id_pedido = (SELECT MAX(ID_Pedido) FROM Pedido WHERE id_usuario = @id)";
                    comando.Parameters.AddWithValue("@id", UsuarioCache.id);

                    reader = comando.ExecuteReader();
                    int row = 14; 

                    while (reader.Read())
                    {
                        
                        hoja.Cells[row, 3].Value = reader.GetString(0);

                        
                        row++;
                    }
                    reader.Close();

                    comando.Parameters.Clear();
                    comando.CommandText = "SELECT SUM(p_ing.Cantidad * i.Precio_ingrediente) FROM Pedido p INNER JOIN PedidoPizza pp " +
                        "ON p.ID_Pedido = pp.Id_Pedido INNER JOIN Pizza pi ON pp.Id_Pizza = pi.ID INNER JOIN Pizza_Ingredientes p_ing " +
                        "ON pi.ID = p_ing.Id_pizza INNER JOIN Ingredientes i ON p_ing.Id_ingrediente = i.Id_Ingrediente " +
                        "WHERE p.id_usuario = @id AND p.ID_Pedido = (SELECT MAX(ID_Pedido) FROM Pedido WHERE id_usuario = @id) GROUP BY pp.Id_Pizza;";
                    comando.Parameters.AddWithValue("@id", UsuarioCache.id);

                    reader = comando.ExecuteReader();
                    row = 14;

                    while (reader.Read())
                    {

                        hoja.Cells[row, 4].Value = reader.GetDecimal(0);


                        row++;
                    }
                    reader.Close();

                    comando.Parameters.Clear();
                    comando.CommandText = "SELECT pp.Cantidad FROM Pedido p INNER JOIN PedidoPizza pp ON p.ID_Pedido = pp.Id_Pedido " +
                        "WHERE p.id_usuario = @id AND p.ID_Pedido = (SELECT TOP 1 ID_Pedido FROM Pedido WHERE id_usuario = @id ORDER BY Fecha DESC);";
                    comando.Parameters.AddWithValue("@id", UsuarioCache.id);

                    reader = comando.ExecuteReader();
                    row = 14;

                    while (reader.Read())
                    {

                        hoja.Cells[row, 5].Value = reader.GetInt32(0);


                        row++;
                    }
                    reader.Close();


                    //########################################################################################

                    hoja.Cells[2, 2] = DateTime.Now.ToString("dd/MM/yyyy");
                    hoja.Cells[7, 3] = labels[0];
                    hoja.Cells[10, 3] = fecha;
                    hoja.Cells[15, 8] = UsuarioCache.nombre + " " + UsuarioCache.apellido1 + " " + UsuarioCache.apellido2;
                    hoja.Cells[16, 8] = UsuarioCache.correo;
                    hoja.Cells[17, 8] = direccion;
                    hoja.Cells[18, 8] = UsuarioCache.telefono;
                    hoja.Cells[22, 8] = horaFormato;
                    hoja.Cells[27, 4] = (double.Parse(labels[2]));
                    hoja.Cells[28, 4] = (double.Parse(labels[2])*0.21);
                    hoja.Cells[29, 4] = (double.Parse(labels[2])) + (double.Parse(labels[2])*0.21);
                    


                    // Guardar con otro nombre para no sobrescribir la plantilla
                    workbook.SaveAs(destinoPath);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show($"Factura generada en: {destinoPath}");
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Escriba su dirección para continuar");
            }
            conexion.Close();
            
        }

        private void label_pedido_Click(object sender, EventArgs e)
        {

        }
    }
}
