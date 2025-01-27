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
    public partial class FormCiclosAcademicos : Form, IFormularioConRol
    {
        CicloAcademico cicloSeleccionado;
        int idRol;
        public FormCiclosAcademicos()
        {
            InitializeComponent();
            ActualizarGrilla();
            ConfigurarColumnas();
            this.FormClosed += FormCiclosAcademicos_FormClosed;
        }

        // Implementación de la interfaz para recibir el idRol
        public void SetIdRol(int idRol)
        {
            this.idRol = idRol;
            ActualizarGrilla();
            ConfigurarColumnas();
            this.FormClosed += FormCiclosAcademicos_FormClosed;
        }
        private void btnAgregarNuevoCiclo_Click(object sender, EventArgs e)
        {
            FormAgregarNuevoCicloAcademico formAgregarNuevoCicloAcademico = new FormAgregarNuevoCicloAcademico();

            // Asegura que el formulario sea hijo del formulario actual
            AddOwnedForm(formAgregarNuevoCicloAcademico);

            // Configura el formulario para que se ajuste al panel y no tenga borde
            formAgregarNuevoCicloAcademico.FormBorderStyle = FormBorderStyle.None;
            formAgregarNuevoCicloAcademico.TopLevel = false;
            formAgregarNuevoCicloAcademico.Dock = DockStyle.Fill;

            // Agrega el formulario al panel o contenedor principal
            this.Controls.Add(formAgregarNuevoCicloAcademico);
            this.Tag = formAgregarNuevoCicloAcademico;

            // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
            formAgregarNuevoCicloAcademico.BringToFront();
            formAgregarNuevoCicloAcademico.Show();
        }

        public void ActualizarGrilla()
        {
            dgvCiclosAcademicos.DataSource = null;
            dgvCiclosAcademicos.DataSource = ControladoraCiclosAcademicos.Instancia.ListarCiclosAcademicos();
        }

        private void ConfigurarColumnas()
        {
            // Columnas que no se muestran.
            dgvCiclosAcademicos.Columns["CicloAcademicoId"].Visible = false;
        }

        private void dgvCiclosAcademicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCiclosAcademicos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCiclosAcademicos.SelectedRows[0];
                cicloSeleccionado = (CicloAcademico)row.DataBoundItem;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cicloSeleccionado != null)
            {
                FormCicloAcademicoSeleccionado formCicloAcademicoSeleccionado = new FormCicloAcademicoSeleccionado(cicloSeleccionado, idRol);
                AddOwnedForm(formCicloAcademicoSeleccionado);
                formCicloAcademicoSeleccionado.FormBorderStyle = FormBorderStyle.None;
                formCicloAcademicoSeleccionado.TopLevel = false;
                formCicloAcademicoSeleccionado.Dock = DockStyle.Fill;
                this.Controls.Add(formCicloAcademicoSeleccionado);
                this.Tag = formCicloAcademicoSeleccionado;
                formCicloAcademicoSeleccionado.BringToFront();
                formCicloAcademicoSeleccionado.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un ciclo academico.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCiclosAcademicos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormCiclosAcademicos_Load(object sender, EventArgs e)
        {
            ConsultarRol(this, idRol);
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



    }
}
