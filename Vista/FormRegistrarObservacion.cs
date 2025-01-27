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
    public partial class FormRegistrarObservacion : Form
    {
        Alumno alumno;
        public FormRegistrarObservacion(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            CargarCmb();
        }

        private void CargarCmb()
        {
            var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
            cmbTrimestre.DataSource = ControladoraTrimestres.Instancia.ObtenerTrimestres(cicloAcademico);
            cmbTrimestre.DisplayMember = "NumTrimestre";
        }

        private bool ValidarDatos()
        {
            if (cmbTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el numero de trimestre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                MessageBox.Show("Ingrese la observacion.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Trimestre trimestreSeleccionado = (Trimestre)cmbTrimestre.SelectedItem;
                int numTrimestre = trimestreSeleccionado.NumTrimestre;

                string observacion = txtObservacion.Text;

                var mensaje = ControladoraBoletines.Instancia.RegistrarObservacion(alumno, numTrimestre, observacion);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
