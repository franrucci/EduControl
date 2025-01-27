using Controladora;
using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using Modelo;
using Org.BouncyCastle.Crypto;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        int IdRol, IdUsu;
        public FormPrincipal(string pUser, int pIdRol, int pIdUsu)
        {
            InitializeComponent();
            IdRol = pIdRol;
            IdUsu = pIdUsu;
            CargarTxt();
        }

        private void CargarTxt()
        {
            var usuario = ControladoraUsuarios.Instancia.RetornarUsuario(IdUsu);
            lblUser.Text = "Usuario: " + usuario.Usuario1;

            var rol = ControladoraRoles.Instancia.RetornarRol(usuario.RolId);
            lblRol.Text = "Rol: " + rol.RolNombre;
        }


        #region Funcionalidades del formulario.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;


        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        */
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCiclosAcademicos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormCiclosAcademicos>(IdRol);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlumnosTotal>(IdRol);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAdministrarUsuarios>(IdRol);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar sesión?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnMiUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMiUsuario>(IdUsu);
        }
        #endregion


        // METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void AbrirFormulario<MiForm>(int idRol) where MiForm : Form, new()
        {
            // Cerrar formularios abiertos, excepto "FormPrincipal" y "FormLogin"
            Form[] OpenForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in OpenForms)
            {
                if (thisForm.Name != "FormPrincipal" && thisForm.Name != "FormLogin")
                    thisForm.Close();
            }

            // Buscar el formulario en la colección de controles
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // Busca el formulario en la colección

            if (formulario == null) // Si el formulario no está abierto
            {
                formulario = new MiForm(); // Crear una nueva instancia del formulario
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                // Pasar el idRol al formulario
                if (formulario is IFormularioConRol rolForm)
                {
                    rolForm.SetIdRol(idRol); // Aquí asumimos que el formulario implementa IFormularioConRol
                }

                panelFormularios.Controls.Add(formulario); // Añadir el formulario al panel
                panelFormularios.Tag = formulario; // Asociar el formulario al panel
                formulario.Show(); // Mostrar el formulario
                formulario.BringToFront(); // Traerlo al frente
            }
            else // Si el formulario ya está abierto
            {
                formulario.BringToFront(); // Solo lo traemos al frente
            }
        }

        /*
        public void AbrirFormulario2<MiForm>(Usuario usuario) where MiForm : Form, new()
        {
            // Cerrar formularios abiertos, excepto "FormPrincipal" y "FormLogin"
            Form[] OpenForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in OpenForms)
            {
                if (thisForm.Name != "FormPrincipal" && thisForm.Name != "FormLogin")
                    thisForm.Close();
            }

            // Buscar el formulario en la colección de controles
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // Busca el formulario en la colección

            if (formulario == null) // Si el formulario no está abierto
            {
                formulario = new MiForm(); // Crear una nueva instancia del formulario
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                // Pasar la variable Usuario al formulario, si tiene una propiedad o método pública para recibirla
                var propiedadUsuario = formulario.GetType().GetProperty("Usuario");
                if (propiedadUsuario != null && propiedadUsuario.PropertyType == typeof(Usuario))
                {
                    propiedadUsuario.SetValue(formulario, usuario); // Asignar la variable usuario
                }

                panelFormularios.Controls.Add(formulario); // Añadir el formulario al panel
                panelFormularios.Tag = formulario; // Asociar el formulario al panel
                formulario.Show(); // Mostrar el formulario
                formulario.BringToFront(); // Traerlo al frente
            }
            else // Si el formulario ya está abierto
            {
                formulario.BringToFront(); // Solo lo traemos al frente
            }
        }
        */


    }
}