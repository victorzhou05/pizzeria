
﻿using Pizzería.Modelo;
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
    public partial class formMenuPedidos : Form
    {
        // Atributos de conexión
        SqlConnection conexion = new SqlConnection(Program.url);
        SqlCommand comando = new SqlCommand();
        public formMenuPedidos()
        {
            InitializeComponent();
            actualizarPedidosEntregados();
            actualizarPedidosEnPreparacion();
        }

        private void actualizarPedidosEntregados()
        {
            comando.Parameters.Clear();

            lv_pedidosEntregados.Items.Clear();

            SqlDataReader resultado = null;

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "Select PrecioFinal, Fecha, Direccion from Pedido where id_usuario = @ID and Estado = 'Entregado' and Direccion != 'micasa'";

                comando.Parameters.AddWithValue("@ID", UsuarioCache.id);
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    decimal precio = resultado.GetDecimal(0);
                    DateTime fecha = resultado.GetDateTime(1);
                    String direccion = resultado.GetString(2);

                    ListViewItem item = new ListViewItem(precio.ToString());
                    item.SubItems.Add(fecha.ToString());
                    item.SubItems.Add(direccion);

                    lv_pedidosEntregados.Items.Add(item);
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

        private void actualizarPedidosEnPreparacion()
        {
            comando.Parameters.Clear();

            lv_pedidosEnPreparacion.Items.Clear();

            SqlDataReader resultado = null;

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "Select PrecioFinal, Direccion, ID_Pedido from Pedido where id_usuario = @ID and Estado = 'Pedido'";

                comando.Parameters.AddWithValue("@ID", UsuarioCache.id);
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    decimal precio = resultado.GetDecimal(0);
                    String direccion = resultado.GetString(1);
                    int idPedido = resultado.GetInt32(2);


                    ListViewItem item = new ListViewItem(precio.ToString());
                    item.SubItems.Add(direccion.ToString());
                    item.SubItems.Add(idPedido.ToString());

                    lv_pedidosEnPreparacion.Items.Add(item);
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
        private void bt_recibirPedido_Click(object sender, EventArgs e)
        {
            comando.Parameters.Clear();

            if (lv_pedidosEnPreparacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, indique el producto que desea recibir");
                return;
            }

            // Guardamos el id del pedido que se va a recibir
            int pedidoARecibir = int.Parse(lv_pedidosEnPreparacion.SelectedItems[0].SubItems[2].Text);

            try
            {
                conexion.Open();
                comando.Connection = conexion;

                comando.CommandText = "update Pedido set Estado = 'Entregado' where id_usuario = @ID and id_pedido = @PedidoID";
                comando.Parameters.AddWithValue("@ID", UsuarioCache.id);
                comando.Parameters.AddWithValue("@PedidoID", pedidoARecibir);

                int actualizado = comando.ExecuteNonQuery();

                if (actualizado > 0)
                {
                    lv_pedidosEnPreparacion.Items.Remove(lv_pedidosEnPreparacion.SelectedItems[0]);
                    conexion.Close();
                    MessageBox.Show("Pedido recibido satisfactoriamente. ¡Que aproveche🍕👌!", "VUELVA PRONTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                actualizarPedidosEnPreparacion();
                actualizarPedidosEntregados();

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}