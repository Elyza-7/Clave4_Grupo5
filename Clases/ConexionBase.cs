using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria.Clases
{
    internal class ConexionBase
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost"; 
        static string userbd = "root"; 
        static string contra = "root26"; 
        static string puertoServidor = "3306";
        static string basedeDatos = "cafeteria";

        static string cadenaConexion = "server=" + servidor+ ";port="+puertoServidor+";user id ="+userbd+";password="+contra+";database="+basedeDatos+";";


        public MySqlConnection realizarConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("SE conecto a la base de datos");
            }
            catch (Exception ex) { 
                MessageBox.Show("No se pudo conectar a la base de datos: "+ex.ToString());
            }

            return conexion;

        }


        public void cerrarConexion()
        {
            conexion.Close();
        }



    }
}
