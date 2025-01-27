using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormRegistrarNuevaCuotaMensual : Form
    {
        CicloAcademico ciclo;
        public FormRegistrarNuevaCuotaMensual(CicloAcademico cicloAcademico)
        {
            InitializeComponent();
            ciclo = cicloAcademico;
            InicializarTxtCicloAcademico();
            InicializarComboBox();
        }

        private void InicializarTxtCicloAcademico()
        {
            txtCicloAcademico.Text = $"{ciclo.Año}";
        }

        private void InicializarComboBox()
        {
            cmbMes.Items.Add(1);
            cmbMes.Items.Add(2);
            cmbMes.Items.Add(3);
            cmbMes.Items.Add(4);
            cmbMes.Items.Add(5);
            cmbMes.Items.Add(6);
            cmbMes.Items.Add(7);
            cmbMes.Items.Add(8);
            cmbMes.Items.Add(9);
            cmbMes.Items.Add(10);
            cmbMes.Items.Add(11);
            cmbMes.Items.Add(12);
        }

        private bool ValidarDatos()
        {
            if (cmbMes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un mes.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese el precio de la cuota.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cuota cuota = new Cuota();

                cuota.CicloAcademico = ciclo;
                cuota.Mes = Convert.ToInt32(cmbMes.SelectedItem);
                cuota.Precio = Convert.ToDecimal(txtPrecio.Text);

                var mensaje = ControladoraCuotasMensuales.Instancia.RegistrarCuota(cuota);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es válido
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true; // Cancela el evento si ya hay un punto decimal en el texto
            }
        }

    }
}
