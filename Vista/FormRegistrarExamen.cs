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
    public partial class FormRegistrarExamen : Form
    {
        Alumno alumno;
        public FormRegistrarExamen(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            CargarCmb();
        }

        public void CargarCmb()
        {
            cmbMateria.DataSource = ControladoraMaterias.Instancia.RetornarMaterias(alumno.GradoAcademicoId);
            cmbMateria.DisplayMember = "NombreMateria";

            cmbTipoDeExamen.DataSource = ControladoraTipoDeExamen.Instancia.RetornarTiposDeExamen();
            cmbTipoDeExamen.DisplayMember = "Nombre";

            var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
            cmbTrimestre.DataSource = ControladoraTrimestres.Instancia.ObtenerTrimestres(cicloAcademico);
            cmbTrimestre.DisplayMember = "NumTrimestre";
        }

        private bool ValidarDatos()
        {
            if (cmbTipoDeExamen.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de examen.");
                return false;
            }
            if (cmbTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el numero de trimestre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Ingrese la nota.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Examen examen = new Examen();

                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
                var boletinAlumno = ControladoraBoletines.Instancia.RecuperarBoletinAlumno(alumno, cicloAcademico.Año);
                var libroDeNotas = ControladoraLibrosDeNotas.Instancia.RecuperarLibroAlumno(boletinAlumno);

                examen.LibroDeNotas = libroDeNotas;
                examen.LibroDeNotasId = libroDeNotas.LibroDeNotasId;

                var materia = (Materia)cmbMateria.SelectedItem;
                examen.Materia = materia;
                examen.MateriaId = materia.MateriaId;

                var tipoDeExamen = (TipoDeExamen)cmbTipoDeExamen.SelectedItem;
                examen.TipoDeExamen = tipoDeExamen;
                examen.TipoDeExamenId = tipoDeExamen.TipoDeExamenId;

                Trimestre trimestreSeleccionado = (Trimestre)cmbTrimestre.SelectedItem;
                examen.NumTrimestre = trimestreSeleccionado.NumTrimestre;

                examen.Nota = Convert.ToDecimal(txtNota.Text);

                var mensaje = ControladoraBoletines.Instancia.RegistrarNotaDeExamen(alumno, examen);
                MessageBox.Show(mensaje);

                cmbMateria.SelectedIndex = 0; 
                cmbTipoDeExamen.SelectedIndex = 0;
                cmbTrimestre.SelectedIndex = 0;

                txtNota.Clear();
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (dígitos) y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }
    }
}
