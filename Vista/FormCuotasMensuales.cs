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
    public partial class FormCuotasMensuales : Form
    {
        CicloAcademico ciclo;
        Cuota cuotaSeleccionada;
        public FormCuotasMensuales(CicloAcademico cicloAcademico)
        {
            InitializeComponent();
            ciclo = cicloAcademico;
            ActualizarGrilla();
            ConfigurarColumnas();
        }

        public void ActualizarGrilla()
        {
            dgvCuotasMensuales.DataSource = null;
            dgvCuotasMensuales.DataSource = ControladoraCuotasMensuales.Instancia.ListarCuotasPorAño(ciclo);
        }

        private void ConfigurarColumnas()
        {
            // Columnas que no se muestran.
            dgvCuotasMensuales.Columns["CicloAcademico"].Visible = false;
            dgvCuotasMensuales.Columns["CuotaId"].Visible = false;
            dgvCuotasMensuales.Columns["CicloAcademicoId"].Visible = false;

            dgvCuotasMensuales.Columns["Mes"].HeaderText = "Mes N°";
        }

        private void dgvCiclosAcademicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCuotasMensuales.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCuotasMensuales.SelectedRows[0];
                cuotaSeleccionada = (Cuota)row.DataBoundItem;
            }
        }

        private void btnRegistrarNuevaCuota_Click(object sender, EventArgs e)
        {
            if (ciclo != null)
            {
                // Crea una instancia del formulario para registrar una nueva cuota mensual
                FormRegistrarNuevaCuotaMensual formRegistrarNuevaCuotaMensual = new FormRegistrarNuevaCuotaMensual(ciclo);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formRegistrarNuevaCuotaMensual);

                // Configura el formulario para que no tenga borde y se ajuste al contenedor principal
                formRegistrarNuevaCuotaMensual.FormBorderStyle = FormBorderStyle.None;
                formRegistrarNuevaCuotaMensual.TopLevel = false;
                formRegistrarNuevaCuotaMensual.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formRegistrarNuevaCuotaMensual);
                this.Tag = formRegistrarNuevaCuotaMensual;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formRegistrarNuevaCuotaMensual.BringToFront();
                formRegistrarNuevaCuotaMensual.Show();

                // Actualiza la grilla y configura las columnas luego de mostrar el formulario
                ActualizarGrilla();
                ConfigurarColumnas();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo académico.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
