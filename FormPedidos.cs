using SistemaCafeteria.Clases;
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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            Clases.ClasePedidos objetoPedido = new ClasePedidos();
            Clases.ClaseLocales objetoLocales = new ClaseLocales();
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoLocales.listarLocales(dtgvLocales);
            objetoPedido.listarPedidos(dtgvPedidos);
            objetoProducto.listarProductos(dtgvProductos);
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoProducto.seleccionarProducto(dtgvProductos, txtProducto, numPrecioUnitario);
        }

        private void dtgvLocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.seleccionarLocal(dtgvLocales, txtLocales);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.ClasePedidos objetoPedido = new ClasePedidos();
            objetoPedido.guardarPedidos(txtProducto, numPrecioUnitario, txtNombreCliente, numCantidadProducto, txtLocales);
            objetoPedido.listarPedidos(dtgvPedidos);
        }
    }
}
