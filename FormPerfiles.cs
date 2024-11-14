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
    public partial class FormPerfiles : Form
    {
        public FormPerfiles()
        {
            InitializeComponent();
            Clases.ClasePerfiles objetoPerfil = new ClasePerfiles();
            objetoPerfil.listarPerfiles(dtgvListaPerfiles);
        }

        private void FormPerfiles_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.ConexionBase objetoConexion = new Clases.ConexionBase();
            objetoConexion.realizarConexion();
        }

        private void dtgvListaPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClasePerfiles objetoPerfil = new ClasePerfiles();
            objetoPerfil.seleccionarPerfiles(dtgvListaPerfiles, txtIdPerfil, txtTipoPerfil, txtDescripcion, txtFechaRegistro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.ClasePerfiles objetoPerfil = new ClasePerfiles();
            objetoPerfil.guardarPerfiles(txtTipoPerfil, txtDescripcion);
            objetoPerfil.listarPerfiles(dtgvListaPerfiles);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.ClasePerfiles objetoPerfil = new ClasePerfiles();
            objetoPerfil.editarPerfiles(txtIdPerfil, txtTipoPerfil, txtDescripcion);
            objetoPerfil.listarPerfiles(dtgvListaPerfiles);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClasePerfiles objetoPerfil = new ClasePerfiles();
            objetoPerfil.eliminarPerfiles(txtIdPerfil);
            objetoPerfil.listarPerfiles(dtgvListaPerfiles);
        }
    }
}
