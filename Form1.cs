using System.Data;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;
using SistemaCafeteria.Clases;

namespace SistemaCafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.ClaseUsuario objetoUsuario = new ClaseUsuario();
            objetoUsuario.listarUsuarios(dtgvListaUsuarios);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.ConexionBase objetoConexion = new Clases.ConexionBase();
            objetoConexion.realizarConexion();
        }

        private void dtgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.ClaseUsuario objetoUsuario = new ClaseUsuario();
            objetoUsuario.guardarUsuarios(txtUsername, txtNombres, txtApellidos, txtContrasena);
            objetoUsuario.listarUsuarios(dtgvListaUsuarios);
        }

        private void dtgvListaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseUsuario objetoUsuario = new ClaseUsuario();
            objetoUsuario.seleccionarUsuario(dtgvListaUsuarios, txtIdUsuario, txtUsername, txtNombres, txtApellidos, txtContrasena);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.ClaseUsuario objetoUsuario = new ClaseUsuario();
            objetoUsuario.editarUsuarios(txtIdUsuario, txtUsername, txtNombres, txtApellidos, txtContrasena);
            objetoUsuario.listarUsuarios(dtgvListaUsuarios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClaseUsuario objetoUsuario = new ClaseUsuario();
            objetoUsuario.eliminarUsuarios(txtIdUsuario);
            objetoUsuario.listarUsuarios(dtgvListaUsuarios);
        }
    }
}
