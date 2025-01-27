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
    public partial class FormCambiarContraseña : Form
    {
        Usuario usuario;
        public FormCambiarContraseña(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            CargarTxt();
        }

        private void CargarTxt()
        {
            txtNombreUsuario.Text = usuario.Usuario1;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la nueva contraseña.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                usuario.Password = txtContraseña.Text; // Nueva contraseña que el usuario ha ingresado
                // Llamar al método ModificarUsuario en la controladora
                var mensaje = ControladoraUsuarios.Instancia.ModificarContraseña(usuario);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
