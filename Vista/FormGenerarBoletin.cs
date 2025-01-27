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
    public partial class FormGenerarBoletin : Form
    {
        Alumno alumno;
        CicloAcademico ciclo;
        public FormGenerarBoletin(Alumno alumno1, CicloAcademico ciclo1)
        {
            InitializeComponent();
            alumno = alumno1;
            ciclo = ciclo1;
            CargarCmb();
        }

        public void CargarCmb()
        {
            var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumno.CicloAcademicoId);
            cmbNumTrimestre.DataSource = ControladoraTrimestres.Instancia.ObtenerTrimestres(cicloAcademico);
            cmbNumTrimestre.DisplayMember = "NumTrimestre";
        }

        private bool ValidarDatos()
        {
            if (cmbNumTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el número de trimestre.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Trimestre trimestreSeleccionado = (Trimestre)cmbNumTrimestre.SelectedItem;
                var mensaje = ControladoraBoletines.Instancia.GenerarBoletin(alumno, ciclo.Año, trimestreSeleccionado.NumTrimestre);
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
