using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria.Clases
{
    internal class ClaseLogin
    {

        public void iniciarSesion(TextBox username, TextBox contrasena)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(contrasena.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            try
            {

                ConexionBase conexion = new ConexionBase();
                {
                    string consulta = "SELECT username, contrasena FROM usuarios WHERE username = @username AND contrasena = @contrasena LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.realizarConexion()))
                    {
                        // Uso de parámetros para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena.Text);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                MenuPrincipal objetoMenu = new MenuPrincipal();
                                objetoMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Usuario y contraseña incorrectos, por favor intente nuevamente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario de login: " + ex.ToString());
            }
        }

    }
}
