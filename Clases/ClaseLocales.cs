using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria.Clases
{
    internal class ClaseLocales
    {

        public void listarLocales(DataGridView TablaLocales)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "SELECT * FROM locales";
                TablaLocales.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion.realizarConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                TablaLocales.DataSource = dt;
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la lista de locales registrados en el servidor: ", ex.ToString());
            }

        }


        public void guardarLocales(TextBox nombreLocal, TextBox ubicacion, DateTimePicker horarioApertura, TextBox horarioCierre, TextBox telefono)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "INSERT INTO locales (nombreLocal, ubicacion, horarioApertura,horarioCierre, telefono) values" + "('" + nombreLocal.Text + "','" + ubicacion.Text + "','" + horarioApertura.Text + "','" + horarioCierre.Text + "','" + telefono.Text  + "');";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se guardo el local.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar  el local: ", ex.ToString());
            }

        }


        public void seleccionarLocales(DataGridView tablaLocales, TextBox idLocal, TextBox nombreLocal, TextBox ubicacion, TextBox horarioApertura, TextBox horarioCierre, TextBox telefono, TextBox fechaRegistro)
        {

            try
            {
                idLocal.Text = tablaLocales.CurrentRow.Cells[0].Value.ToString();
                nombreLocal.Text = tablaLocales.CurrentRow.Cells[1].Value.ToString();
                ubicacion.Text = tablaLocales.CurrentRow.Cells[2].Value.ToString();
                horarioApertura.Text = tablaLocales.CurrentRow.Cells[3].Value.ToString();
                horarioCierre.Text = tablaLocales.CurrentRow.Cells[4].Value.ToString();
                telefono.Text = tablaLocales.CurrentRow.Cells[5].Value.ToString();
                fechaRegistro.Text = tablaLocales.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el local: ", ex.ToString());
            }

        }
        public void seleccionarLocal(DataGridView tablaLocales, TextBox nombreLocal)
        {

            try
            {
                
                nombreLocal.Text = tablaLocales.CurrentRow.Cells[1].Value.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el local: ", ex.ToString());
            }

        }


        public void editarLocales(TextBox idLocal, TextBox nombreLocal, TextBox ubicacion, TextBox horarioApertura,TextBox horarioCierre, TextBox telefono)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "UPDATE locales SET nombreLocal ='" + nombreLocal.Text + "', ubicacion ='" + ubicacion.Text + "',horarioApertura='" + horarioApertura.Text + "', horariocierre= '" + horarioCierre.Text + "',telefono='" + telefono.Text  + "' WHERE idLocal='" + idLocal.Text + "' LIMIT 1";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se actualizó el local.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el local: ", ex.ToString());
            }

        }


        public void eliminarLocales(TextBox idLocal)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "DELETE FROM locales WHERE idLocal='" + idLocal.Text + "' LIMIT 1;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se eliminó el local.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el local: ", ex.ToString());
            }

        }

    }
}
