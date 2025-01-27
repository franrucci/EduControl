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
    public partial class FormRegistrarAlumnoExistente : Form
    {
        CicloAcademico cicloAcademico;
        Alumno alumnoSeleccionado;
        public FormRegistrarAlumnoExistente(CicloAcademico cicloAcademico1)
        {
            InitializeComponent();
            ActualizarGrilla();
            IncicializarCmb();
            cicloAcademico = cicloAcademico1;
        }

        private void IncicializarCmb()
        {
            cmbGradoAcademico.DataSource = ControladoraGradosAcademicos.Instancia.ListarGrados();
            cmbGradoAcademico.DisplayMember = "NumGrado"; // Propiedad a mostrar en el ComboBox
        }

        public void ActualizarGrilla()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = ControladoraAlumnos.Instancia.ListarAlumnos();

            dgvAlumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvAlumnos.Columns["Apellido"].HeaderText = "Apellido";
            dgvAlumnos.Columns["Dni"].HeaderText = "Dni";

            //Columnas que no se muestran.
            dgvAlumnos.Columns["PersonaId"].Visible = false;
            dgvAlumnos.Columns["FechaDeNacimiento"].Visible = false;
            dgvAlumnos.Columns["Domicilio"].Visible = false;
            dgvAlumnos.Columns["Localidad"].Visible = false;
            dgvAlumnos.Columns["CodigoPostal"].Visible = false;
            dgvAlumnos.Columns["Provincia"].Visible = false;
            dgvAlumnos.Columns["Pais"].Visible = false;
            dgvAlumnos.Columns["Email"].Visible = false;
            dgvAlumnos.Columns["Sexo"].Visible = false;
            dgvAlumnos.Columns["SexoId"].Visible = false;
            dgvAlumnos.Columns["CicloAcademico"].Visible = false;
            dgvAlumnos.Columns["CicloAcademicoId"].Visible = false;
            dgvAlumnos.Columns["GradoAcademico"].Visible = false;
            dgvAlumnos.Columns["GradoAcademicoId"].Visible = false;
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAlumnos.SelectedRows[0];
                alumnoSeleccionado = (Alumno)row.DataBoundItem;
            }
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                GradoAcademico nuevoGrado = new GradoAcademico();
                if (cmbGradoAcademico.SelectedItem != null)
                {
                    nuevoGrado = (GradoAcademico)cmbGradoAcademico.SelectedItem;

                    // Cambiar estrategia a AgregarAlumnoExistenteStrategy
                    ControladoraAlumnos.Instancia.CambiarEstrategia(new AgregarAlumnoExistenteStrategy());

                    string respuesta = ControladoraAlumnos.Instancia.Agregar(alumnoSeleccionado, cicloAcademico, nuevoGrado);

                    //var respuesta = ControladoraAlumnos.Instancia.AgregarAlumnoExistente(alumnoSeleccionado, cicloAcademico, nuevoGrado);
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("Error: No hay ningun grado academico seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
