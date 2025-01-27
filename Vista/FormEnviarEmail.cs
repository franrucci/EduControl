using Controladora.EmailService;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormEnviarEmail : Form
    {
        Alumno alumno;
        private readonly EmailService emailService;

        public FormEnviarEmail(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            emailService = new EmailService(); // Instancia del servicio
            CargarCampos();
        }

        public void CargarCampos()
        {
            txtDe.Text = "Aca debe ir el email"; //Poner el email correcto.
            txtPara.Text = alumno.Email;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string error = "";
            StringBuilder mensajeBuilder = new StringBuilder();
            mensajeBuilder.Append(txtMensaje.Text.Trim());
            var mensaje = emailService.EnviarCorreo(mensajeBuilder, DateTime.Now, txtDe.Text.Trim(), txtPara.Text.Trim(), txtAsunto.Text.Trim(), out error);
            MessageBox.Show(mensaje);

            txtAsunto.Text = string.Empty;
            txtMensaje.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
