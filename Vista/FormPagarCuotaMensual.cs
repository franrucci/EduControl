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
    public partial class FormPagarCuotaMensual : Form
    {
        Alumno alumno;
        Cuota cuotaSeleccionada;
        public FormPagarCuotaMensual(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            var cuotasImpagas = ControladoraCuotasMensuales.Instancia.ObtenerCuotasImpagas(alumno);

            // Proyectamos los datos para incluir el año del CicloAcademico
            var cuotasConAño = cuotasImpagas.Select(c => new
            {
                c.CuotaId,
                c.Mes,
                Año = c.CicloAcademico.Año, // Incluimos el año del CicloAcademico
                Precio = c.Precio
            }).ToList();

            dgvCuotasImpagas.DataSource = null;
            dgvCuotasImpagas.DataSource = cuotasConAño;

            dgvCuotasImpagas.Columns["CuotaId"].Visible = false;
            dgvCuotasImpagas.Columns["Mes"].HeaderText = "Mes N°";
            dgvCuotasImpagas.Columns["Año"].HeaderText = "Año";
            dgvCuotasImpagas.Columns["Precio"].HeaderText = "Precio";

        }

        private void dgvCuotasImpagas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCuotasImpagas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCuotasImpagas.SelectedRows[0];

                // Extraer valores directamente desde las celdas de la fila seleccionada
                int cuotaId = Convert.ToInt32(row.Cells["CuotaId"].Value);

                // Recargar los datos de la cuota desde la base de datos
                cuotaSeleccionada = ControladoraCuotasMensuales.Instancia.ObtenerCuotaPorId(cuotaId);

                if (cuotaSeleccionada == null)
                {
                    MessageBox.Show("Error: No se pudo cargar la información de la cuota.");
                }
            }
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            if (cuotaSeleccionada != null)
            {
                // Crea una instancia del formulario de FormPagarCuotas.
                FormPagarCuota formPagarCuota = new FormPagarCuota(cuotaSeleccionada, alumno);

                // Asegura que el formulario FormPagarCuotas sea hijo del formulario principal
                AddOwnedForm(formPagarCuota);

                // Configura el formulario para que no tenga borde y se ajuste al contenedor principal
                formPagarCuota.FormBorderStyle = FormBorderStyle.None;
                formPagarCuota.TopLevel = false;
                formPagarCuota.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formPagarCuota);
                this.Tag = formPagarCuota;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formPagarCuota.BringToFront();
                formPagarCuota.Show();
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
