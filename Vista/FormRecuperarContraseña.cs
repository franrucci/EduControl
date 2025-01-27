using Controladora;
using Controladora.EmailService;
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
    public partial class FormRecuperarContraseña : Form
    {
        private readonly EmailService emailService;
        public FormRecuperarContraseña()
        {
            InitializeComponent();
            emailService = new EmailService(); // Instancia del servicio
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // Buscar el usuario por su correo electrónico
            Usuario usuario = ControladoraUsuarios.Instancia.BuscarUsuarioPorEmail(email);

            if (usuario == null)
            {
                // Si no se encuentra el usuario, mostrar un mensaje
                MessageBox.Show("Error: El correo electrónico no está registrado.");
                return;
            }

            // Si el usuario existe, generar un token
            string token = ControladoraUsuarios.Instancia.GenerarToken();

            // Encriptar el token usando el mismo Salt del usuario
            string tokenEncriptado = ControladoraUsuarios.Instancia.EncriptarToken(token, usuario.Salt);

            // Asignar el token encriptado al usuario (puede guardarse en la base de datos)
            usuario.Token = tokenEncriptado;
            ControladoraUsuarios.Instancia.ActualizarUsuario(usuario);

            // Enviar el token por correo electrónico
            string asunto = "Recuperación de Contraseña";
            string mensaje = $"Hola {usuario.Usuario1},\n\nTu token de recuperación es: {token}\n\nUtiliza este token para ingresar al sistema y cambiar tu contraseña.";

            string error;
            emailService.EnviarCorreo(new StringBuilder(mensaje), DateTime.Now, "AcaPonerElMail@ejemplo.com", usuario.Email, asunto, out error); //Poner el mail correcto

            // Mostrar mensaje de éxito
            if (error == "Mensaje enviado correctamente.")
            {
                MessageBox.Show("Se ha enviado un correo electrónico con el token de recuperación.");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Error al enviar el correo: {error}");
            }
        }

    }
}
