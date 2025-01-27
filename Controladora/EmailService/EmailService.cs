using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.EmailService
{
    public class EmailService
    {
        private const string usuario = "Debe ir el correo electronico"; //Poner el email correcto
        private const string contraseña = "Su contraseña"; //Poner la contraseña correcta

        public string EnviarCorreo(StringBuilder mensaje, DateTime fechaEnvio, string de, string para, string asunto, out string error)
        {
            error = "";
            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("\n\n\n ---------- Este correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH:mm:ss} hs. ----------", fechaEnvio));
                mensaje.Append(Environment.NewLine);
                MailMessage email = new MailMessage();
                email.From = new MailAddress(de); // De quien se envia el mensaje.
                email.To.Add(para); // A quien se le envia el mensaje.
                email.Subject = asunto;
                email.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, contraseña);
                smtp.EnableSsl = true;
                smtp.Send(email);
                error = "Mensaje enviado correctamente.";
                return error;
            }
            catch (Exception ex)
            {
                error = "Error: " + ex.Message;
                return error;
            }
        }
    }
}
