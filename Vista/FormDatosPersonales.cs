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
    public partial class FormDatosPersonales : Form
    {
        Alumno alumno;
        public FormDatosPersonales(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            CargarDatos();
        }

        public void CargarDatos()
        {
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtDni.Text = alumno.Dni;
            txtFechaDeNacimiento.Text = alumno.FechaDeNacimiento.ToString("dd/MM/yyyy");
            txtDomicilio.Text = alumno.Domicilio;
            txtLocalidad.Text = alumno.Localidad;
            txtCodigoPostal.Text = alumno.CodigoPostal.ToString();
            txtProvincia.Text = alumno.Provincia;
            txtPais.Text = alumno.Pais;
            txtEmail.Text = alumno.Email;
            txtSexo.Text = ControladoraSexos.Instancia.BuscarSexo(alumno.SexoId);

            var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumno.GradoAcademicoId);
            txtGrado.Text = gradoAcademico.NumGrado.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
