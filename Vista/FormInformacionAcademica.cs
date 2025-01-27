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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Controladora;
using Modelo;

namespace Vista
{
    public partial class FormInformacionAcademica : Form
    {
        Alumno alumno;
        Boletin boletinSeleccionado;
        public FormInformacionAcademica(Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;
            ActualizarGrilla();
            ConfigurarColumnas();
        }

        public void ActualizarGrilla()
        {
            dgvBoletines.DataSource = null;
            dgvBoletines.DataSource = ControladoraBoletines.Instancia.ObtenerBoletines(alumno.PersonaId);
        }

        private void ConfigurarColumnas()
        {
            dgvBoletines.Columns["Año"].HeaderText = "Año";
            dgvBoletines.Columns["numGrado"].HeaderText = "N° de grado";
            dgvBoletines.Columns["BoletinCerrado1"].HeaderText = "Boletin N°1";
            dgvBoletines.Columns["BoletinCerrado2"].HeaderText = "Boletin N°2";
            dgvBoletines.Columns["BoletinCerrado3"].HeaderText = "Boletin N°3";

            // Columnas que no se muestran.
            dgvBoletines.Columns["Alumno"].Visible = false;
            dgvBoletines.Columns["LibroDeNotas"].Visible = false;
            dgvBoletines.Columns["LibroDeAsistencias"].Visible = false;
            dgvBoletines.Columns["PromedioAsistenciaTrimestre1"].Visible = false;
            dgvBoletines.Columns["PromedioAsistenciaTrimestre2"].Visible = false;
            dgvBoletines.Columns["PromedioAsistenciaTrimestre3"].Visible = false;
            dgvBoletines.Columns["PromedioTotalAsistencia"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre1"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre2"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre3"].Visible = false;
            dgvBoletines.Columns["PromedioTotalExamenes"].Visible = false;
            dgvBoletines.Columns["ObservacionTrimestre1"].Visible = false;
            dgvBoletines.Columns["ObservacionTrimestre2"].Visible = false;
            dgvBoletines.Columns["ObservacionTrimestre3"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre2"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre3"].Visible = false;
            dgvBoletines.Columns["EstadoFinal"].Visible = false;
            dgvBoletines.Columns["Activo"].Visible = false;
            dgvBoletines.Columns["BoletinId"].Visible = false;
            dgvBoletines.Columns["PromedioTrimestre1"].Visible = false;
            dgvBoletines.Columns["PersonaId"].Visible = false;
            dgvBoletines.Columns["LibroDeNotasId"].Visible = false;
            dgvBoletines.Columns["LibroDeAsistenciasId"].Visible = false;
            dgvBoletines.Columns["EstadoFinalId"].Visible = false;
        }

        private void dgvBoletines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBoletines.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBoletines.SelectedRows[0];
                boletinSeleccionado = (Boletin)row.DataBoundItem;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (boletinSeleccionado != null)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Templates\plantilla.html");
                string paginahtml_texto = File.ReadAllText(ruta);

                // Rellenar información del alumno y ciclo académico
                paginahtml_texto = paginahtml_texto.Replace("@ALUMNO", alumno.Nombre + " " + alumno.Apellido);
                paginahtml_texto = paginahtml_texto.Replace("@GRADO", boletinSeleccionado.numGrado.ToString());
                paginahtml_texto = paginahtml_texto.Replace("@CICLO_ACADEMICO", boletinSeleccionado.Año.ToString());

                var listaDeMaterias = ControladoraMaterias.Instancia.RetornarMaterias(alumno.GradoAcademicoId);
                string filasCalificacionesHtml = "";

                foreach (var materia in listaDeMaterias)
                {
                    string notaTrimestre1 = boletinSeleccionado.PromedioTrimestre1 > 0
                        ? ObtenerNotaFinalTrimestre(materia, boletinSeleccionado, 1)
                        : "No disponible";
                    string notaTrimestre2 = boletinSeleccionado.PromedioTrimestre2 > 0
                        ? ObtenerNotaFinalTrimestre(materia, boletinSeleccionado, 2)
                        : "No disponible";
                    string notaTrimestre3 = boletinSeleccionado.PromedioTrimestre3 > 0
                        ? ObtenerNotaFinalTrimestre(materia, boletinSeleccionado, 3)
                        : "No disponible";

                    // Calcular el promedio individual de la materia en base a las notas disponibles
                    var notas = new List<decimal>();
                    if (decimal.TryParse(notaTrimestre1, out var n1)) notas.Add(n1);
                    if (decimal.TryParse(notaTrimestre2, out var n2)) notas.Add(n2);
                    if (decimal.TryParse(notaTrimestre3, out var n3)) notas.Add(n3);

                    // Verificar que se tengan las 3 notas para calcular el promedio
                    string promedioMateria = (notas.Count == 3)
                        ? (notas.Average()).ToString("F2")
                        : "No disponible";

                    if (notaTrimestre1 != "No disponible" || notaTrimestre2 != "No disponible" || notaTrimestre3 != "No disponible")
                    {
                        filasCalificacionesHtml += $"<tr><td>{materia.NombreMateria}</td><td>{notaTrimestre1}</td><td>{notaTrimestre2}</td><td>{notaTrimestre3}</td><td>{promedioMateria}</td></tr>";
                    }
                }

                paginahtml_texto = paginahtml_texto.Replace("@FILAS_CALIFICACIONES", filasCalificacionesHtml);

                // Promedios trimestrales y anual
                paginahtml_texto = paginahtml_texto.Replace("@PROMEDIO_TRIMESTRE1", boletinSeleccionado.PromedioTrimestre1 > 0 ? boletinSeleccionado.PromedioTrimestre1.ToString("F2") : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@PROMEDIO_TRIMESTRE2", boletinSeleccionado.PromedioTrimestre2 > 0 ? boletinSeleccionado.PromedioTrimestre2.ToString("F2") : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@PROMEDIO_TRIMESTRE3", boletinSeleccionado.PromedioTrimestre3 > 0 ? boletinSeleccionado.PromedioTrimestre3.ToString("F2") : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@PROMEDIO_FINAL_ANUAL", boletinSeleccionado.PromedioTotalExamenes > 0 ? boletinSeleccionado.PromedioTotalExamenes.ToString("F2") : "No disponible");

                // Estado final y observaciones por trimestre
                if (boletinSeleccionado.PromedioTrimestre1 == 0 ||
                    boletinSeleccionado.PromedioTrimestre2 == 0 ||
                    boletinSeleccionado.PromedioTrimestre3 == 0)
                {
                    paginahtml_texto = paginahtml_texto.Replace("@ESTADO_FINAL", "En Curso");
                }
                else
                {
                    var boletinCompleto = ControladoraBoletines.Instancia.RecuperarBoletinCompleto(boletinSeleccionado);

                    paginahtml_texto = paginahtml_texto.Replace("@ESTADO_FINAL", boletinCompleto.EstadoFinal.Nombre.ToString());
                }

                paginahtml_texto = paginahtml_texto.Replace("@OBSERVACIONES_TRIMESTRE1", boletinSeleccionado.PromedioTrimestre1 > 0 ? boletinSeleccionado.ObservacionTrimestre1 : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@OBSERVACIONES_TRIMESTRE2", boletinSeleccionado.PromedioTrimestre2 > 0 ? boletinSeleccionado.ObservacionTrimestre2 : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@OBSERVACIONES_TRIMESTRE3", boletinSeleccionado.PromedioTrimestre3 > 0 ? boletinSeleccionado.ObservacionTrimestre3 : "No disponible");

                // Asistencias
                paginahtml_texto = paginahtml_texto.Replace("@ASISTENCIA_TRIMESTRE1", boletinSeleccionado.PromedioTrimestre1 > 0 ? boletinSeleccionado.PromedioAsistenciaTrimestre1.ToString() : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@ASISTENCIA_TRIMESTRE2", boletinSeleccionado.PromedioTrimestre2 > 0 ? boletinSeleccionado.PromedioAsistenciaTrimestre2.ToString() : "No disponible");
                paginahtml_texto = paginahtml_texto.Replace("@ASISTENCIA_TRIMESTRE3", boletinSeleccionado.PromedioTrimestre3 > 0 ? boletinSeleccionado.PromedioAsistenciaTrimestre3.ToString() : "No disponible");

                // Guardar el archivo PDF
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(paginahtml_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        // Método auxiliar para obtener la nota final de una materia en un trimestre
        private string ObtenerNotaFinalTrimestre(Materia materia, Boletin boletin, int trimestre)
        {
            // Recupera el Libro de Notas utilizando la Controladora
            var libroDeNotas = ControladoraLibrosDeNotas.Instancia.RecuperarLibroAlumno(boletin);

            // Verifica si el libro de notas es nulo
            if (libroDeNotas == null || libroDeNotas.Examenes == null || !libroDeNotas.Examenes.Any())
            {
                return "Sin Nota";
            }

            // Filtrar los exámenes para el trimestre y materia especificados
            var examenes = libroDeNotas.Examenes
                .Where(e => e.NumTrimestre == trimestre && e.MateriaId == materia.MateriaId)
                .ToList();

            // Verificamos si hay examen de recuperatorio y parcial
            var detalleRecuperatorio = examenes.FirstOrDefault(e => e.TipoDeExamenId == 2);
            var detalleParcial = examenes.FirstOrDefault(e => e.TipoDeExamenId == 1);

            // Retornar la nota adecuada o "Sin Nota" si no hay exámenes
            if (detalleRecuperatorio != null)
            {
                return detalleRecuperatorio.Nota.ToString("F2");
            }
            else if (detalleParcial != null)
            {
                return detalleParcial.Nota.ToString("F2");
            }
            else
            {
                return "Sin Nota";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
