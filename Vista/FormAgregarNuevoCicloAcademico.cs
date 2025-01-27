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
    public partial class FormAgregarNuevoCicloAcademico : Form
    {
        public FormAgregarNuevoCicloAcademico()
        {
            InitializeComponent();
            //this.FormClosed += FormAgregarNuevoCicloAcademico_FormClosed;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("Error: Ingrese el año del nuevo ciclo academico.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CicloAcademico cicloAcademico = new CicloAcademico();
                cicloAcademico.Año = Convert.ToInt32(txtAño.Text);

                var mensaje = ControladoraCiclosAcademicos.Instancia.AgregarCicloAcademico(cicloAcademico);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }
        }

    }
}
