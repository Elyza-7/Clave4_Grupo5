using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria.Clases
{
    internal class ClaseUsuario
    {
        public void listarUsuarios(DataGridView TablaUsuarios) {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "SELECT * FROM usuarios";
                TablaUsuarios.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion.realizarConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                TablaUsuarios.DataSource = dt;
                conexion.cerrarConexion();

            }
            catch (Exception ex) {

                MessageBox.Show("Error al cargar la lista de usuarios registrados en el servidor: ", ex.ToString());
            }
        
        }


        public void guardarUsuarios(TextBox username, TextBox nombres, TextBox apellidos, TextBox contrasena)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "INSERT INTO usuarios (username, nombres, apellidos, contrasena) values" + "('"+username.Text+"','"+nombres.Text+"','"+apellidos.Text+"','"+contrasena.Text+"');";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se guardo el usuario.");


                while (reader.Read()) { 
                
                    
                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar  el usuario: ", ex.ToString());
            }

        }


        public void seleccionarUsuario(DataGridView tablaUsuarios,TextBox id_usuario, TextBox username, TextBox nombres, TextBox apellidos, TextBox contrasena)
        {

            try
            {
                id_usuario.Text = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                username.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                nombres.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                apellidos.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                contrasena.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al seleccionar el usuario: ", ex.ToString());
            }

        }



        public void editarUsuarios(TextBox id_usuario,TextBox username, TextBox nombres, TextBox apellidos, TextBox contrasena)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "UPDATE usuarios SET username ='" + username.Text + "', nombres ='" + nombres.Text + "',apellidos='" + apellidos.Text + "', contrasena= '" + contrasena.Text +"' WHERE id_usuario='" + id_usuario.Text + "' LIMIT 1";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se actualizó el usuario.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el usuario: ", ex.ToString());
            }

        }


        public void eliminarUsuarios(TextBox id_usuario)
        {

            try
            {
                ConexionBase conexion = new ConexionBase();

                String consulta = "DELETE FROM usuarios WHERE id_usuario='" + id_usuario.Text + "' LIMIT 1;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.realizarConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Se eliminó el usuario.");


                while (reader.Read())
                {


                }



                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el usuario: ", ex.ToString());
            }

        }

    }
}
