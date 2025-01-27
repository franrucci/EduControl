using Controladora;
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
    public partial class FormModificarRol : Form
    {
        public FormModificarRol()
        {
            InitializeComponent();
        }

        private void FormModificarRol_Load(object sender, EventArgs e)
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

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var rolId = (int)cmbRol.SelectedValue;
                FormRolesUsuarios formRolesUsuarios = new FormRolesUsuarios(rolId);

                // Asegura que el formulario sea hijo del formulario actual
                AddOwnedForm(formRolesUsuarios);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formRolesUsuarios.FormBorderStyle = FormBorderStyle.None;
                formRolesUsuarios.TopLevel = false;
                formRolesUsuarios.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formRolesUsuarios);
                this.Tag = formRolesUsuarios;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formRolesUsuarios.BringToFront();
                formRolesUsuarios.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
