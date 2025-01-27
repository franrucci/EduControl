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
    public partial class FormAgregarTrimestre : Form
    {
        CicloAcademico cicloAcademico;
        public FormAgregarTrimestre(CicloAcademico cicloAcademico1)
        {
            InitializeComponent();
            cicloAcademico = cicloAcademico1;
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            cmbNumeroDeTrimestre.Items.Add(1);
            cmbNumeroDeTrimestre.Items.Add(2);
            cmbNumeroDeTrimestre.Items.Add(3);
        }

        private bool ValidarDatos()
        {
            if (cmbNumeroDeTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un número de trimestre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDiasTotalesHabiles.Text))
            {
                MessageBox.Show("Ingrese los dias totales habiles.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Trimestre trimestre = new Trimestre();

                trimestre.NumTrimestre = Convert.ToInt32(cmbNumeroDeTrimestre.SelectedItem);
                trimestre.DiasTotalesHabiles = Convert.ToInt32(txtDiasTotalesHabiles.Text);
                trimestre.CicloAcademico = cicloAcademico;

                var mensaje = ControladoraTrimestres.Instancia.AgregarNuevoTrimestre(trimestre);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiasTotalesHabiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (dígitos) y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

    }
}
