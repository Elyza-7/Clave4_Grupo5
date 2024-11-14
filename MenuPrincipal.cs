using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCafeteria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionarUsuario_Click(object sender, EventArgs e)
        {
            Form1 formUsuarios = new Form1();


            formUsuarios.ShowDialog();
        }

        private void btnGestionarLocales_Click(object sender, EventArgs e)
        {
            FormLocales formularioLocales = new FormLocales();
            formularioLocales.ShowDialog();
        }

        private void btnGestionarPerfiles_Click(object sender, EventArgs e)
        {
            FormPerfiles formularioPerfiles = new FormPerfiles();
            formularioPerfiles.ShowDialog();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            FormProductos formularioProductos = new FormProductos();
            formularioProductos.ShowDialog();
        }

        private void btnGestionarPedido_Click(object sender, EventArgs e)
        {
            FormPedidos formularioPedidos = new FormPedidos();
            formularioPedidos.ShowDialog();
        }
    }
}
