using Controladora;
using Entidades;
using Modelo.Patron_Strategy;
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
    public partial class FormModificarAlumno : Form
    {
        Alumno alumno;
        public FormModificarAlumno(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            InicializarCmb();
            CargarDatos();
        }

        private void InicializarCmb()
        {
            // Cargar el ComboBox con los sexos disponibles
            cmbSexo.DataSource = ControladoraSexos.Instancia.ListarSexos();
            cmbSexo.DisplayMember = "Nombre"; // Mostrar la propiedad "Nombre" de la clase Sexo

            // Cargar el ComboBox con los grados disponibles
            cmbGradoAcademico.DataSource = ControladoraGradosAcademicos.Instancia.ListarGrados();
            cmbGradoAcademico.DisplayMember = "NumGrado"; // Propiedad a mostrar en el ComboBox
        }

        private void ConfigurarCmb(Alumno alumno)
        {
            // Buscar y seleccionar el sexo correspondiente al alumno
            foreach (var item in cmbSexo.Items)
            {
                if (((Sexo)item).SexoId == alumno.SexoId) // Comparar por Id o cualquier propiedad única
                {
                    cmbSexo.SelectedItem = item;
                    break;
                }
            }

            // Buscar y seleccionar el grado correspondiente al alumno
            foreach (var item in cmbGradoAcademico.Items)
            {
                if (((GradoAcademico)item).GradoAcademicoId == alumno.GradoAcademicoId) // Comparar por Id o cualquier propiedad única
                {
                    cmbGradoAcademico.SelectedItem = item;
                    break;
                }
            }
        }

        private void CargarDatos()
        {
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtDni.Text = alumno.Dni;
            dtpFechaDeNacimiento.Value = alumno.FechaDeNacimiento;
            txtDomicilio.Text = alumno.Domicilio;
            txtLocalidad.Text = alumno.Localidad;
            txtCodigoPostal.Text = alumno.CodigoPostal.ToString();
            txtProvincia.Text = alumno.Provincia;
            txtPais.Text = alumno.Pais;
            txtEmail.Text = alumno.Email;
            ConfigurarCmb(alumno);
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido");
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar el DNI.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                MessageBox.Show("Debe ingresar el domicilio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                MessageBox.Show("Debe ingresar la localidad.");
                return false;
            }
            if (string.IsNullOrEmpty(txtCodigoPostal.Text))
            {
                MessageBox.Show("Debe ingresar el codigo postal.");
                return false;
            }
            if (string.IsNullOrEmpty(txtProvincia.Text))
            {
                MessageBox.Show("Debe ingresar la provincia.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show("Debe ingresar el pais.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar el Email.");
                return false;
            }
            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el sexo.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.Dni = txtDni.Text;
                alumno.FechaDeNacimiento = dtpFechaDeNacimiento.Value;
                alumno.Domicilio = txtDomicilio.Text;
                alumno.Localidad = txtLocalidad.Text;
                alumno.CodigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
                alumno.Provincia = txtProvincia.Text;
                alumno.Pais = txtPais.Text;
                alumno.Email = txtEmail.Text;
                alumno.Sexo = (Sexo)cmbSexo.SelectedItem;
                alumno.GradoAcademico = (GradoAcademico)cmbGradoAcademico.SelectedItem;

                var mensaje = ControladoraAlumnos.Instancia.ModificarAlumno(alumno);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras (tanto mayúsculas como minúsculas), espacios y teclas de control como Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Si el carácter no es válido, se cancela el evento
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras (tanto mayúsculas como minúsculas), espacios y teclas de control como Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Si el carácter no es válido, se cancela el evento
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos (0-9) y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, espacios y teclas de control como Backspace
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, espacios y teclas de control como Backspace
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, espacios y teclas de control como Backspace
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras (mayúsculas y minúsculas), espacios y teclas de control como Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras (mayúsculas y minúsculas), espacios y teclas de control como Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, puntos, guiones, guiones bajos, arroba y teclas de control
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '@')
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }
    }
}
