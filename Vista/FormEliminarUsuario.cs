using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormEliminarUsuario : Form
    {
        Usuario usuarioSeleccionado;
        public FormEliminarUsuario()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ControladoraUsuarios.Instancia.ListarUsuarios();

            dgvUsuarios.Columns["Usuario1"].HeaderText = "Nombre de usuario";

            //Columnas que no se muestran.
            dgvUsuarios.Columns["UsuarioId"].Visible = false;
            dgvUsuarios.Columns["Password"].Visible = false;
            dgvUsuarios.Columns["RolId"].Visible = false;
            dgvUsuarios.Columns["RolUsuario"].Visible = false;
            dgvUsuarios.Columns["Salt"].Visible = false;
            dgvUsuarios.Columns["Token"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                var usuarioDesdeGrilla = (Usuario)row.DataBoundItem;

                // Recargar los datos del alumno desde la base de datos
                usuarioSeleccionado = ControladoraUsuarios.Instancia.RetornarUsuario(usuarioDesdeGrilla.UsuarioId);//ControladoraAlumnos.Instancia.ObtenerAlumnoPorId(alumnoDesdeGrilla.PersonaId);

                if (usuarioSeleccionado == null)
                {
                    MessageBox.Show("Error: No se pudo cargar la información del alumno.");
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                // Mostrar el mensaje de confirmación
                var resultado = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Si el usuario confirma, proceder con la eliminación
                    var mensaje = ControladoraUsuarios.Instancia.EliminarUsuario(usuarioSeleccionado);
                    MessageBox.Show(mensaje);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un usuario.");
            }
        }
    }
}
