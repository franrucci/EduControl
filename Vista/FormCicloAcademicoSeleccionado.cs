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
    public partial class FormCicloAcademicoSeleccionado : Form
    {
        CicloAcademico cicloAcademico;
        int idRol;
        public FormCicloAcademicoSeleccionado(CicloAcademico cicloAcademico1, int idRol)
        {
            cicloAcademico = cicloAcademico1;
            InitializeComponent();
            ConfigurarDatos();
            this.idRol = idRol;
            this.FormClosed += FormCicloAcademicoSeleccionado_FormClosed;
        }

        private void ConfigurarDatos()
        {
            txtCicloAcademicoSeleccionado.Text = $"{cicloAcademico.Año}";
        }
        private void FormCicloAcademicoSeleccionado_Load(object sender, EventArgs e)
        {
            ConsultarRol(this, idRol);
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (cicloAcademico != null)
            {
                FormAgregarNuevoAlumno formAgregarNuevoAlumno = new FormAgregarNuevoAlumno(cicloAcademico);

                // Asegura que el formulario sea hijo del formulario actual
                AddOwnedForm(formAgregarNuevoAlumno);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formAgregarNuevoAlumno.FormBorderStyle = FormBorderStyle.None;
                formAgregarNuevoAlumno.TopLevel = false;
                formAgregarNuevoAlumno.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formAgregarNuevoAlumno);
                this.Tag = formAgregarNuevoAlumno;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formAgregarNuevoAlumno.BringToFront();
                formAgregarNuevoAlumno.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo académico.");
            }
        }
        private void btnAgregarTrimestre_Click(object sender, EventArgs e)
        {
            if (cicloAcademico != null)
            {
                FormAgregarTrimestre formAgregarTrimestre = new FormAgregarTrimestre(cicloAcademico);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formAgregarTrimestre);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formAgregarTrimestre.FormBorderStyle = FormBorderStyle.None;
                formAgregarTrimestre.TopLevel = false;
                formAgregarTrimestre.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formAgregarTrimestre);
                this.Tag = formAgregarTrimestre;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formAgregarTrimestre.BringToFront();
                formAgregarTrimestre.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo académico.");
            }
        }
        private void btnGradosAcademicos_Click(object sender, EventArgs e)
        {
            if (cicloAcademico != null)
            {
                FormGrados formGrados = new FormGrados(cicloAcademico, idRol);

                // Asegura que el formulario sea hijo del formulario actual
                AddOwnedForm(formGrados);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formGrados.FormBorderStyle = FormBorderStyle.None;
                formGrados.TopLevel = false;
                formGrados.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formGrados);
                this.Tag = formGrados;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formGrados.BringToFront();
                formGrados.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo académico.");
            }
        }
        private void FormCicloAcademicoSeleccionado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCuotasMensuales_Click(object sender, EventArgs e)
        {
            if (cicloAcademico != null)
            {
                FormCuotasMensuales formCuotasMensuales = new FormCuotasMensuales(cicloAcademico);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formCuotasMensuales);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formCuotasMensuales.FormBorderStyle = FormBorderStyle.None;
                formCuotasMensuales.TopLevel = false;
                formCuotasMensuales.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formCuotasMensuales);
                this.Tag = formCuotasMensuales;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formCuotasMensuales.BringToFront();
                formCuotasMensuales.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo académico.");
            }
        }
        // Este método recorre todos los botones del formulario y los habilita o deshabilita según el permiso
        public void ConsultarRol(Form pForm, int pIdRol)
        {
            // Obtener la lista de permisos para el rol actual
            var LstOp = ControladoraPermisos.Instancia.SelectOpcion(pIdRol);

            // Recorrer todos los controles del formulario
            foreach (Control c in pForm.Controls)
            {
                if (c is Button) // Si el control es un botón
                {
                    // Buscar el permiso asociado al botón usando el Tag
                    foreach (Permiso opc in LstOp)
                    {
                        // Comparar el OpcionId con el Tag del botón
                        if (opc.OpcionId == Convert.ToInt32(c.Tag))
                        {
                            // Si el permiso no está permitido, deshabilitar el botón
                            if (!opc.Permitido)
                            {
                                c.Enabled = false;
                            }
                            else
                            {
                                c.Enabled = true;
                            }
                        }
                    }
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
