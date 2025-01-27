using Controladora;
using Entidades;
using Org.BouncyCastle.Crypto;
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
    public partial class FormMiUsuario : Form, IFormularioConRol
    {
        Usuario usuario;

        public FormMiUsuario()
        {
            InitializeComponent();
        }

        public void SetIdRol(int idUsu)
        {
            Usuario usuarioEncontrado = ControladoraUsuarios.Instancia.RetornarUsuario(idUsu);
            usuario = usuarioEncontrado;
        }

        private void CargarDatosUsuario()
        {
            if (usuario != null)
            {
                txtNombreUsuario.Text = usuario.Usuario1; // Asigna el nombre del usuario al control del formulario
                var rolEncontrado = ControladoraRoles.Instancia.RetornarRol(usuario.RolId);
                txtRol.Text = rolEncontrado.RolNombre;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMiUsuario_Load_1(object sender, EventArgs e)
        {
            CargarDatosUsuario(); // Llamar al método que carga los datos del usuario
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            FormCambiarContraseña formCambiarContraseña = new FormCambiarContraseña(usuario);

            // Asegura que el formulario sea hijo del formulario actual
            AddOwnedForm(formCambiarContraseña);

            // Configura el formulario para que se ajuste al panel y no tenga borde
            formCambiarContraseña.FormBorderStyle = FormBorderStyle.None;
            formCambiarContraseña.TopLevel = false;
            formCambiarContraseña.Dock = DockStyle.Fill;

            // Agrega el formulario al panel o contenedor principal
            this.Controls.Add(formCambiarContraseña);
            this.Tag = formCambiarContraseña;

            // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
            formCambiarContraseña.BringToFront();
            formCambiarContraseña.Show();
        }
    }
}
