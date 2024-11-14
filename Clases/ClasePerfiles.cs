using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SistemaCafeteria.Clases
{
    internal class ClasePerfiles
    {
        public void listarPerfiles(DataGridView TablaPerfiles)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "SELECT * FROM perfiles";
                TablaPerfiles.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion.realizarConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                TablaPerfiles.DataSource = dt;
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el perfil de los usuarios registrados en el servidor: ", ex.ToString());
            }

        }


        public void guardarPerfiles(TextBox tipoPerfil, TextBox descripcion)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "INSERT INTO perfiles (tipoPerfil, descripcion) values" + "('" + tipoPerfil.Text + "','" + descripcion.Text + "');";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se guardo el perfil de usuario.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar  el perfil de usuario: ", ex.ToString());
            }

        }


        public void seleccionarPerfiles(DataGridView tablaPerfiles, TextBox idPerfil, TextBox tipoPerfil, TextBox descripcion, TextBox fechaRegistro)
        {

            try
            {
                idPerfil.Text = tablaPerfiles.CurrentRow.Cells[0].Value.ToString();
                tipoPerfil.Text = tablaPerfiles.CurrentRow.Cells[1].Value.ToString();
                descripcion.Text = tablaPerfiles.CurrentRow.Cells[2].Value.ToString();
                fechaRegistro.Text = tablaPerfiles.CurrentRow.Cells[3].Value.ToString();
     
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el perfil de usuario: ", ex.ToString());
            }

        }



        public void editarPerfiles(TextBox idPerfil, TextBox tipoPerfil, TextBox descripcion)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "UPDATE perfiles SET tipoPerfil ='" + tipoPerfil.Text + "', descripcion ='" + descripcion.Text + "' WHERE idPerfil='" + idPerfil.Text + "' LIMIT 1";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se actualizó el perfil de usuario.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el perfil de usuario: ", ex.ToString());
            }

        }


        public void eliminarPerfiles(TextBox idPerfil)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "DELETE FROM perfiles WHERE idPerfil='" + idPerfil.Text + "' LIMIT 1;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se eliminó el perfil de usuario.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el perfil de usuario: ", ex.ToString());
            }

        }
    }
}
