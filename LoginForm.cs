using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCafeteria.Clases;
using MySql.Data.MySqlClient;

namespace SistemaCafeteria
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //ClaseLogin objetoLogin = new ClaseLogin();
            
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Clases.ClaseLogin objetoLogin = new ClaseLogin();

            objetoLogin.iniciarSesion(txtUsuario, txtContrasena);
            
        }
    }
}
