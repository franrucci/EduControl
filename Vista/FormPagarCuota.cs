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
    public partial class FormPagarCuota : Form
    {
        Cuota cuota;
        Alumno alumno;
        public FormPagarCuota(Cuota cuota1, Alumno alumno1)
        {
            InitializeComponent();
            cuota = cuota1;
            alumno = alumno1;
            CargarDatos();
        }

        public void CargarDatos()
        {
            txtAlumno.Text = $"{alumno.Nombre} {alumno.Apellido}";
            txtCuotaMes.Text = cuota.Mes.ToString();
            txtCicloAcademicoAño.Text = cuota.CicloAcademico.Año.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Obtener el mes y año de la cuota
            int cuotaMes = cuota.Mes;  // El mes de la cuota
            int cuotaAño = cuota.CicloAcademico.Año;  // El año de la cuota

            DateTime fechaSeleccionada = dtpFecha.Value;  // Fecha seleccionada en el DateTimePicker

            // Verificar si el día de la fecha seleccionada es mayor a 20
            // Y si el mes de la fecha seleccionada es mayor o igual al mes de la cuota
            // Y si el año de la fecha seleccionada es mayor o igual al año de la cuota
            if ((fechaSeleccionada.Day > 20 && fechaSeleccionada.Month >= cuotaMes && fechaSeleccionada.Year >= cuotaAño) || (fechaSeleccionada.Month > cuotaMes && fechaSeleccionada.Year > cuotaAño))
            {
                // Crea una instancia del formulario para registrar una nueva cuota mensual
                FormDatosDePagoDeCuota formDatosDePagoDeCuota = new FormDatosDePagoDeCuota(cuota, alumno, fechaSeleccionada, 2);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formDatosDePagoDeCuota);

                // Configura el formulario para que no tenga borde y se ajuste al contenedor principal
                formDatosDePagoDeCuota.FormBorderStyle = FormBorderStyle.None;
                formDatosDePagoDeCuota.TopLevel = false;
                formDatosDePagoDeCuota.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formDatosDePagoDeCuota);
                this.Tag = formDatosDePagoDeCuota;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formDatosDePagoDeCuota.BringToFront();
                formDatosDePagoDeCuota.Show();
            }
            else
            {
                // Crea una instancia del formulario para registrar una nueva cuota mensual
                FormDatosDePagoDeCuota formDatosDePagoDeCuota = new FormDatosDePagoDeCuota(cuota, alumno, fechaSeleccionada, 1);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formDatosDePagoDeCuota);

                // Configura el formulario para que no tenga borde y se ajuste al contenedor principal
                formDatosDePagoDeCuota.FormBorderStyle = FormBorderStyle.None;
                formDatosDePagoDeCuota.TopLevel = false;
                formDatosDePagoDeCuota.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formDatosDePagoDeCuota);
                this.Tag = formDatosDePagoDeCuota;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formDatosDePagoDeCuota.BringToFront();
                formDatosDePagoDeCuota.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
