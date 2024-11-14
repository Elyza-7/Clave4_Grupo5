using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaCafeteria.Clases
{
    internal class ClasePedidos
    {
        public void listarPedidos(DataGridView TablaPedidos)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "SELECT * FROM pedidos";
                TablaPedidos.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion.realizarConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                TablaPedidos.DataSource = dt;
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la lista de pedidos registrados en el servidor: ", ex.ToString());
            }

        }
        public void guardarPedidos(TextBox txtProducto, NumericUpDown PrecioUnitario, TextBox NombreCliente, NumericUpDown CantidadProducto, TextBox Locales)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                //String consulta = "INSERT INTO locales (nombreLocal, ubicacion, horarioApertura,horarioCierre, telefono) values" + "('" + nombreLocal.Text + "','" + ubicacion.Text + "','" + horarioApertura.Text + "','" + horarioCierre.Text + "','" + telefono.Text + "');";
                String consultaInfoProductos = "SELECT cantidadMaxima, tipoProducto FROM productos WHERE nombre ='" + txtProducto.Text + "' LIMIT 1";

                MySqlCommand comandoProducto = new MySqlCommand(consultaInfoProductos, conexion.realizarConexion());
                MySqlDataReader dataProducto = comandoProducto.ExecuteReader();

                if (dataProducto.Read())
                {
                    string cantidadMaxima = dataProducto["cantidadMaxima"].ToString();
                    int tipoProducto = int.TryParse(dataProducto["tipoProducto"].ToString(), out tipoProducto);
                    
                    if(tipoProducto == "antojito")
                    {
                        if(cantidadMaxima < CantidadProducto)
                        {
                            MessageBox.Show("La cantidad de producto no puede ser mayor que la definida.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
                }


                //MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                //MySqlDataReader reader = comando.ExecuteReader();

                //MessageBox.Show("Se guardo el local.");


                //while (reader.Read())
                //{


                //}



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar  el local: ", ex.ToString());
            }

        }
    }
}
