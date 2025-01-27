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
    public partial class FormEliminarRol : Form
    {
        public FormEliminarRol()
        {
            InitializeComponent();
        }

        private void FormEliminarRol_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void CargarCombo()
        {
            try
            {
                var Lst = ControladoraRoles.Instancia.ComboRol();
                cmbRol.DataSource = Lst;
                cmbRol.DisplayMember = "RolNombre";
                cmbRol.ValueMember = "RolUsuarioId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarDatos()
        {
            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el rol.");
                return false;
            }
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var rolId = (int)cmbRol.SelectedValue;
                bool usuariosConRol = ControladoraUsuarios.Instancia.VerUsuariosConRol(rolId);

                if (usuariosConRol)
                {
                    MessageBox.Show("Error: No se puede eliminar el rol porque existen usuarios con ese rol asignado.");
                }
                else
                {
                    // Mostrar mensaje de confirmación
                    var resultado = MessageBox.Show(
                        "¿Está seguro de que desea eliminar este rol?", // Mensaje
                        "Confirmar Eliminación", // Título del cuadro de mensaje
                        MessageBoxButtons.YesNo, // Opciones de botones
                        MessageBoxIcon.Question // Icono de pregunta
                    );

                    // Si el usuario hace clic en "Sí", proceder con la eliminación
                    if (resultado == DialogResult.Yes)
                    {
                        var mensaje = ControladoraRoles.Instancia.EliminarRol(rolId);
                        MessageBox.Show(mensaje);
                        CargarCombo(); // Recargar el combo de roles
                    }
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
