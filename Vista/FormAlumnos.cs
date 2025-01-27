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
    public partial class FormAlumnos : Form
    {
        GradoAcademico grado;
        CicloAcademico ciclo;
        Alumno alumnoSeleccionado;
        int idRol;
        private List<Alumno> listaAlumnos;
        public FormAlumnos(GradoAcademico grado1, CicloAcademico ciclo1, int idRol)
        {
            InitializeComponent();
            grado = grado1;
            ciclo = ciclo1;
            ActualizarGrilla();
            this.idRol = idRol;
        }
        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            ConsultarRol(this, idRol);
        }

        public void ActualizarGrilla()
        {

            dgvAlumnos.DataSource = null;
            listaAlumnos = ControladoraAlumnos.Instancia.ObtenerAlumnosPorGrado(grado, ciclo);
            dgvAlumnos.DataSource = listaAlumnos;

            dgvAlumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvAlumnos.Columns["Apellido"].HeaderText = "Apellido";

            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            //Columnas que no se muestran.
            dgvAlumnos.Columns["PersonaId"].Visible = false;
            dgvAlumnos.Columns["FechaDeNacimiento"].Visible = false;
            dgvAlumnos.Columns["Domicilio"].Visible = false;
            dgvAlumnos.Columns["Localidad"].Visible = false;
            dgvAlumnos.Columns["CodigoPostal"].Visible = false;
            dgvAlumnos.Columns["Provincia"].Visible = false;
            dgvAlumnos.Columns["Pais"].Visible = false;
            dgvAlumnos.Columns["Email"].Visible = false;
            dgvAlumnos.Columns["Sexo"].Visible = false;
            dgvAlumnos.Columns["SexoId"].Visible = false;
            dgvAlumnos.Columns["CicloAcademico"].Visible = false;
            dgvAlumnos.Columns["CicloAcademicoId"].Visible = false;
            dgvAlumnos.Columns["GradoAcademico"].Visible = false;
            dgvAlumnos.Columns["GradoAcademicoId"].Visible = false;
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAlumnos.SelectedRows[0];
                var alumnoDesdeGrilla = (Alumno)row.DataBoundItem;

                // Recargar los datos del alumno desde la base de datos
                alumnoSeleccionado = ControladoraAlumnos.Instancia.ObtenerAlumnoPorId(alumnoDesdeGrilla.PersonaId);

                if (alumnoSeleccionado == null)
                {
                    MessageBox.Show("Error: No se pudo cargar la información del alumno.");
                }
            }
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                // Crea una instancia del formulario de datos personales
                FormDatosPersonales formDatosPersonales = new FormDatosPersonales(alumnoSeleccionado);

                // Asegura que el formulario de datos personales sea hijo del formulario principal
                AddOwnedForm(formDatosPersonales);

                // Configura el formulario para que no tenga borde y se ajuste al contenedor principal
                formDatosPersonales.FormBorderStyle = FormBorderStyle.None;
                formDatosPersonales.TopLevel = false;
                formDatosPersonales.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formDatosPersonales);
                this.Tag = formDatosPersonales;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formDatosPersonales.BringToFront();
                formDatosPersonales.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnRegistrarExamen_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumnoSeleccionado.CicloAcademicoId);
                var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumnoSeleccionado.GradoAcademicoId);

                bool boletinActivo = ControladoraBoletines.Instancia.VerificarBoletinActivo(alumnoSeleccionado.PersonaId, cicloAcademico.Año, gradoAcademico.NumGrado);

                if (!boletinActivo)
                {
                    MessageBox.Show($"Error: El boletín del alumno para el año {cicloAcademico.Año} y grado especificado ya se ha cerrado y no está activo.");
                    return;
                }
                else
                {
                    // Crea una instancia del formulario con el alumno seleccionado
                    FormRegistrarExamen formRegistrarExamen = new FormRegistrarExamen(alumnoSeleccionado);

                    // Asegura que el formulario sea hijo del formulario principal
                    AddOwnedForm(formRegistrarExamen);

                    // Configura el formulario para que se ajuste al panel y no tenga borde
                    formRegistrarExamen.FormBorderStyle = FormBorderStyle.None;
                    formRegistrarExamen.TopLevel = false;
                    formRegistrarExamen.Dock = DockStyle.Fill;

                    // Agrega el formulario al panel o contenedor principal
                    this.Controls.Add(formRegistrarExamen);
                    this.Tag = formRegistrarExamen;

                    // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                    formRegistrarExamen.BringToFront();
                    formRegistrarExamen.Show();
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumnoSeleccionado.CicloAcademicoId);
                var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumnoSeleccionado.GradoAcademicoId);

                bool boletinActivo = ControladoraBoletines.Instancia.VerificarBoletinActivo(alumnoSeleccionado.PersonaId, cicloAcademico.Año, gradoAcademico.NumGrado);

                if (!boletinActivo)
                {
                    MessageBox.Show($"Error: El boletín del alumno para el año {cicloAcademico.Año} y grado especificado ya se ha cerrado y no está activo.");
                    return;
                }
                else
                {
                    // Crea una instancia del formulario con el alumno seleccionado
                    FormRegistrarAsistencia formRegistrarAsistencia = new FormRegistrarAsistencia(alumnoSeleccionado);

                    // Asegura que el formulario sea hijo del formulario principal
                    AddOwnedForm(formRegistrarAsistencia);

                    // Configura el formulario para que se ajuste al panel y no tenga borde
                    formRegistrarAsistencia.FormBorderStyle = FormBorderStyle.None;
                    formRegistrarAsistencia.TopLevel = false;
                    formRegistrarAsistencia.Dock = DockStyle.Fill;

                    // Agrega el formulario al panel o contenedor principal
                    this.Controls.Add(formRegistrarAsistencia);
                    this.Tag = formRegistrarAsistencia;

                    // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                    formRegistrarAsistencia.BringToFront();
                    formRegistrarAsistencia.Show();
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnRegistarObservacion_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumnoSeleccionado.CicloAcademicoId);
                var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumnoSeleccionado.GradoAcademicoId);

                bool boletinActivo = ControladoraBoletines.Instancia.VerificarBoletinActivo(alumnoSeleccionado.PersonaId, cicloAcademico.Año, gradoAcademico.NumGrado);

                if (!boletinActivo)
                {
                    MessageBox.Show($"Error: El boletín del alumno para el año {cicloAcademico.Año} y grado especificado ya se ha cerrado y no está activo.");
                    return;
                }
                else
                {
                    // Crea una instancia del formulario con el alumno seleccionado
                    FormRegistrarObservacion formRegistrarObservacion = new FormRegistrarObservacion(alumnoSeleccionado);

                    // Asegura que el formulario sea hijo del formulario principal
                    AddOwnedForm(formRegistrarObservacion);

                    // Configura el formulario para que se ajuste al panel y no tenga borde
                    formRegistrarObservacion.FormBorderStyle = FormBorderStyle.None;
                    formRegistrarObservacion.TopLevel = false;
                    formRegistrarObservacion.Dock = DockStyle.Fill;

                    // Agrega el formulario al panel o contenedor principal
                    this.Controls.Add(formRegistrarObservacion);
                    this.Tag = formRegistrarObservacion;

                    // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                    formRegistrarObservacion.BringToFront();
                    formRegistrarObservacion.Show();
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnGenerarBoletin_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumnoSeleccionado.CicloAcademicoId);
                var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumnoSeleccionado.GradoAcademicoId);

                bool boletinActivo = ControladoraBoletines.Instancia.VerificarBoletinActivo(alumnoSeleccionado.PersonaId, cicloAcademico.Año, gradoAcademico.NumGrado);

                if (!boletinActivo)
                {
                    MessageBox.Show($"Error: El boletín del alumno para el año {cicloAcademico.Año} y grado especificado ya se ha cerrado y no está activo.");
                    return;
                }
                else
                {
                    // Crea una instancia del formulario con el alumno seleccionado y el ciclo
                    FormGenerarBoletin formGenerarBoletin = new FormGenerarBoletin(alumnoSeleccionado, ciclo);

                    // Asegura que el formulario sea hijo del formulario principal
                    AddOwnedForm(formGenerarBoletin);

                    // Configura el formulario para que se ajuste al panel y no tenga borde
                    formGenerarBoletin.FormBorderStyle = FormBorderStyle.None;
                    formGenerarBoletin.TopLevel = false;
                    formGenerarBoletin.Dock = DockStyle.Fill;

                    // Agrega el formulario al panel o contenedor principal
                    this.Controls.Add(formGenerarBoletin);
                    this.Tag = formGenerarBoletin;

                    // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                    formGenerarBoletin.BringToFront();
                    formGenerarBoletin.Show();
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnInformacionAcademica_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                // Crea una instancia del formulario con el alumno seleccionado
                FormInformacionAcademica formInformacionAcademica = new FormInformacionAcademica(alumnoSeleccionado);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formInformacionAcademica);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formInformacionAcademica.FormBorderStyle = FormBorderStyle.None;
                formInformacionAcademica.TopLevel = false;
                formInformacionAcademica.Dock = DockStyle.Fill;

                // Agrega el formulario al contenedor principal
                this.Controls.Add(formInformacionAcademica);
                this.Tag = formInformacionAcademica;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formInformacionAcademica.BringToFront();
                formInformacionAcademica.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                // Crea una instancia del formulario con el alumno seleccionado
                FormEnviarEmail formEnviarEmail = new FormEnviarEmail(alumnoSeleccionado);

                // Asegura que el formulario sea hijo del formulario principal
                AddOwnedForm(formEnviarEmail);

                // Configura el formulario para que se ajuste al panel y no tenga borde
                formEnviarEmail.FormBorderStyle = FormBorderStyle.None;
                formEnviarEmail.TopLevel = false;
                formEnviarEmail.Dock = DockStyle.Fill;

                // Agrega el formulario al panel o contenedor principal
                this.Controls.Add(formEnviarEmail);
                this.Tag = formEnviarEmail;

                // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                formEnviarEmail.BringToFront();
                formEnviarEmail.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }


        private void btnRendimientoAnual_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                var cicloAcademico = ControladoraCiclosAcademicos.Instancia.ObtenerCicloAcademico(alumnoSeleccionado.CicloAcademicoId);
                var gradoAcademico = ControladoraGradosAcademicos.Instancia.BuscarGrado(alumnoSeleccionado.GradoAcademicoId);

                bool boletinActivo = ControladoraBoletines.Instancia.VerificarBoletinActivo(alumnoSeleccionado.PersonaId, cicloAcademico.Año, gradoAcademico.NumGrado);

                if (!boletinActivo)
                {
                    // Crea una instancia del formulario de rendimiento anual
                    FormRendimientoAnual formRendimientoAnual = new FormRendimientoAnual(alumnoSeleccionado);

                    // Asegura que el formulario sea hijo del formulario principal
                    AddOwnedForm(formRendimientoAnual);

                    // Configura el formulario para que se ajuste al panel y no tenga borde
                    formRendimientoAnual.FormBorderStyle = FormBorderStyle.None;
                    formRendimientoAnual.TopLevel = false;
                    formRendimientoAnual.Dock = DockStyle.Fill;

                    // Agrega el formulario al contenedor principal
                    this.Controls.Add(formRendimientoAnual);
                    this.Tag = formRendimientoAnual;

                    // Muestra el formulario, lo pone al frente y asegura que se vea correctamente
                    formRendimientoAnual.BringToFront();
                    formRendimientoAnual.Show();
                }
                else
                {
                    MessageBox.Show($"Error: No es posible visualizar el rendimiento anual porque el boletín del alumno para el año {cicloAcademico.Año} todavía no se ha cerrado.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        // Este método recorre todos los botones del formulario y los habilita o deshabilita según el permiso
        public void ConsultarRol(Form pForm, int pIdRol)
        {
            // Obtener la lista de permisos para el rol actual
            var LstOp = ControladoraPermisos.Instancia.SelectOpcion(pIdRol);

            // Recorre todos los controles del formulario, incluyendo los controles dentro de contenedores
            RecorrerControles(pForm.Controls, LstOp);
        }
        private void RecorrerControles(Control.ControlCollection controles, List<Permiso> LstOp)
        {
            foreach (Control c in controles)
            {
                // Si el control es un botón, procesarlo
                if (c is Button)
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

                // Si el control es un contenedor, como GroupBox o Panel, recorrer sus controles también
                if (c.HasChildren)
                {
                    RecorrerControles(c.Controls, LstOp);  // Llamada recursiva para recorrer los controles hijos
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Alumno> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 1)
            {
                // Filtrar por DNI, ignorando mayúsculas/minúsculas
                listaFiltrada = listaAlumnos.FindAll(x => x.Dni.Contains(filtro));
            }
            else
            {
                // Si el filtro tiene menos de 3 caracteres, mostrar toda la lista
                listaFiltrada = listaAlumnos;
            }

            // Actualizar el DataGridView con la lista filtrada
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaFiltrada;

            dgvAlumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvAlumnos.Columns["Apellido"].HeaderText = "Apellido";
            dgvAlumnos.Columns["Dni"].HeaderText = "DNI";
            OcultarColumnas();
        }
    }
}
