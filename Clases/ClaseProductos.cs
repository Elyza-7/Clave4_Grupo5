using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCafeteria.Clases
{
    internal class ClaseProductos
    {
        public void listarProductos(DataGridView TablaProductos)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "SELECT * FROM productos";
                TablaProductos.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion.realizarConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                TablaProductos.DataSource = dt;
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la lista de productos registrados en el servidor: ", ex.ToString());
            }

        }

        //(txtNombre, numPrecio, numDisponible,cbxTipoProducto, dtHorario, numCantidadMaxima)
        public void guardarProductos(TextBox nombre, TextBox descripcion, NumericUpDown precio, NumericUpDown disponible, ComboBox tipoProducto, DateTimePicker horarioDisponible, NumericUpDown cantidadMaxima)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                
                string horaString = horarioDisponible.Value.ToString("HH:mm");
                string tiposelect = tipoProducto.SelectedItem.ToString();




                String consulta = "INSERT INTO productos (nombre, descripcion, precio, disponible, tipoProducto, horarioDisponible, cantidadMaxima) values" + "('" + nombre.Text + "','" + descripcion.Text + "','" + precio.Text + "','" + disponible.Text + "','"+ tiposelect+"','"+horaString+"','"+ cantidadMaxima.Text +"');";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se guardó el producto.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar  el producto: "+ ex.ToString());
            }

        }


        public void seleccionarProductos(DataGridView tablaProductos, TextBox idProducto,TextBox nombre, TextBox descripcion, NumericUpDown precio, NumericUpDown disponible, ComboBox tipoProducto, DateTimePicker horarioDisponible, NumericUpDown cantidadMaxima)
        {

            try
            {
                idProducto.Text = tablaProductos.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaProductos.CurrentRow.Cells[1].Value.ToString();
                descripcion.Text = tablaProductos.CurrentRow.Cells[2].Value.ToString();
                precio.Text = tablaProductos.CurrentRow.Cells[3].Value.ToString();
                disponible.Text = tablaProductos.CurrentRow.Cells[4].Value.ToString();
                tipoProducto.Text = tablaProductos.CurrentRow.Cells[5].Value.ToString();
                horarioDisponible.Text = tablaProductos.CurrentRow.Cells[6].Value.ToString();
                cantidadMaxima.Text = tablaProductos.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el producto: ", ex.ToString());
            }

        }

        public void seleccionarProducto(DataGridView tablaProductos, TextBox nombre, NumericUpDown precio)
        {

            try
            {
                
                nombre.Text = tablaProductos.CurrentRow.Cells[1].Value.ToString();
               
                precio.Text = tablaProductos.CurrentRow.Cells[3].Value.ToString();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el producto: ", ex.ToString());
            }

        }

        public void editarProductos(TextBox idProducto, TextBox nombre, TextBox descripcion, NumericUpDown precio, NumericUpDown disponible, ComboBox tipoProducto, DateTimePicker horarioDisponible, NumericUpDown cantidadMaxima)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                string horaString = horarioDisponible.Value.ToString("HH:mm");

                String consulta = "UPDATE productos SET nombre ='" + nombre.Text + "', descripcion ='" + descripcion.Text + "',precio='" + precio.Text + "', disponible= '" + disponible.Text + "', tipoProducto= '" + tipoProducto.Text + "', horarioDisponible= '" + horaString + "', cantidadMaxima= '" + cantidadMaxima.Text + "' WHERE idProducto='" + idProducto.Text + "' LIMIT 1";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se actualizó el producto.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el producto: ", ex.ToString());
            }

        }


        public void eliminarProductos(TextBox idProducto)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "DELETE FROM productos WHERE idProducto='" + idProducto.Text + "' LIMIT 1;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se eliminó el producto.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el producto: ", ex.ToString());
            }

        }
    }
}
