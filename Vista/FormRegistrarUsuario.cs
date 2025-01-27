using Controladora;
using Entidades;
using Modelo;
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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }
        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario.");
                return false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar el E-mail.");
                return false;
            }
            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el rol.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Usuario usuarioEnt = new Usuario();
                usuarioEnt.Usuario1 = txtNombreUsuario.Text;
                usuarioEnt.Password = txtContraseña.Text;
                usuarioEnt.Email = txtEmail.Text;
                usuarioEnt.RolId = (int)cmbRol.SelectedValue;
                var mensaje = ControladoraUsuarios.Instancia.GuardarUsuario(usuarioEnt);
                MessageBox.Show(mensaje);

                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            cmbRol.SelectedIndex = 0; // Esto deselecciona cualquier selección previa en el ComboBox
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras (mayúsculas y minúsculas), números y teclas de control como Backspace
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

    }
}
