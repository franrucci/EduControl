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
    public partial class FormRegistrarAsistencia : Form
    {
        Alumno alumno;
        public FormRegistrarAsistencia(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            CargarCmb();
        }

        public void CargarCmb()
        {
            var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
            cmbTrimestre.DataSource = ControladoraTrimestres.Instancia.ObtenerTrimestres(cicloAcademico);
            cmbTrimestre.DisplayMember = "NumTrimestre";

            cmbTipoDeAsistencia.DataSource = ControladoraTipoDeAsistencia.Instancia.RetornarTiposDeAsistencia();
            cmbTipoDeAsistencia.DisplayMember = "Nombre";
        }

        private bool ValidarDatos()
        {
            if (cmbTipoDeAsistencia.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de de asistencia.");
                return false;
            }
            if (cmbTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el numero de trimestre.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Asistencia asistencia = new Asistencia();

                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
                var boletinAlumno = ControladoraBoletines.Instancia.RecuperarBoletinAlumno(alumno, cicloAcademico.Año);
                var libroDeAsistencia = ControladoraLibrosDeAsistencias.Instancia.RecuperarLibroAlumno(boletinAlumno);

                asistencia.LibroDeAsistencias = libroDeAsistencia;
                asistencia.LibroDeAsistenciasId = libroDeAsistencia.LibroDeAsistenciasId;
                asistencia.Fecha = dtpFecha.Value;

                Trimestre trimestreSeleccionado = (Trimestre)cmbTrimestre.SelectedItem;
                asistencia.NumTrimestre = trimestreSeleccionado.NumTrimestre;

                var tipoDeAsistencia = (TipoDeAsistencia)cmbTipoDeAsistencia.SelectedItem;
                asistencia.TipoDeAsistencia = tipoDeAsistencia;
                asistencia.TipoDeAsistenciaId = tipoDeAsistencia.TipoDeAsistenciaId;

                var mensaje = ControladoraBoletines.Instancia.RegistrarAsistencia(alumno, asistencia);
                MessageBox.Show(mensaje);

                cmbTrimestre.SelectedIndex = 0; 
                cmbTipoDeAsistencia.SelectedIndex = 0; 
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
