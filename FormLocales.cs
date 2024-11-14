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
    public partial class FormLocales : Form
    {
        public FormLocales()
        {
            InitializeComponent();
            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.listarLocales(dtgvListaLocales);
        }

        private void FormLocales_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clases.ConexionBase objetoConexion = new Clases.ConexionBase();
            objetoConexion.realizarConexion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.editarLocales(txtIdLocal, txtNombreLocal, txtUbicacion, txtHorarioApertura, txtHorarioCierre, txtTelefono);
            objetoLocal.listarLocales(dtgvListaLocales);
        }

        private void dtgvListaLocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.seleccionarLocales(dtgvListaLocales, txtIdLocal, txtNombreLocal, txtUbicacion, txtHorarioApertura, txtHorarioCierre, txtTelefono, txtFechaRegistro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.guardarLocales(txtNombreLocal, txtUbicacion, horarioApertura, txtHorarioCierre, txtTelefono);
            objetoLocal.listarLocales(dtgvListaLocales);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClaseLocales objetoLocal = new ClaseLocales();
            objetoLocal.eliminarLocales(txtIdLocal);
            objetoLocal.listarLocales(dtgvListaLocales);
        }
    }
}
