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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoProducto.listarProductos(dtgvListaProductos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoProducto.guardarProductos(txtNombre, txtDescripcion, numPrecio, numDisponible, cbxTipoProducto, dtHorario, numCantidadMaxima);
            objetoProducto.listarProductos(dtgvListaProductos);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoProducto.editarProductos(txtIdProductos, txtNombre, txtDescripcion, numPrecio, numDisponible, cbxTipoProducto, dtHorario, numCantidadMaxima);
            objetoProducto.listarProductos(dtgvListaProductos);
        }

        private void dtgvListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseProductos objetoProductos = new ClaseProductos();
            objetoProductos.seleccionarProductos(dtgvListaProductos, txtIdProductos, txtNombre, txtDescripcion, numPrecio, numDisponible, cbxTipoProducto, dtHorario, numCantidadMaxima);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClaseProductos objetoProducto = new ClaseProductos();
            objetoProducto.eliminarProductos(txtIdProductos);
            objetoProducto.listarProductos(dtgvListaProductos);
        }
    }
}
