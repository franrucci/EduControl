using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Patron_Strategy
{
    public class AgregarAlumnoNuevoStrategy : IAlumnoStrategy
    {
        private SistemaColegio sistemaColegio;
        public AgregarAlumnoNuevoStrategy()
        {
            sistemaColegio = new SistemaColegio();
        }

        public string AgregarAlumno(Alumno alumno, CicloAcademico cicloAcademico, GradoAcademico grado)
        {
            try
            {
                // Valida si el alumno con el mismo DNI ya está registrado en el ciclo académico especificado.
                var alumnoEnCiclo = sistemaColegio.Alumnos
                    .Include(a => a.CicloAcademico)
                    .FirstOrDefault(a => a.Dni == alumno.Dni && a.CicloAcademico.CicloAcademicoId == cicloAcademico.CicloAcademicoId);

                if (alumnoEnCiclo != null)
                {
                    return $"Error: El alumno ya se encuentra registrado en el ciclo académico {cicloAcademico.Año}.";
                }

                // Valida si el alumno con el mismo DNI ya existe en la base de datos.
                var alumnoExistente = sistemaColegio.Alumnos.FirstOrDefault(a => a.Dni == alumno.Dni);

                if (alumnoExistente != null)
                {
                    return "El alumno ya está registrado en el sistema. Debe cargarlo mediante el botón de 'REGISTRAR ALUMNO EXISTENTE'.";
                }
                else
                {
                    var gradoAcademico = sistemaColegio.GradosAcademicos.FirstOrDefault(g => g.GradoAcademicoId == grado.GradoAcademicoId);
                    var sexo = sistemaColegio.Sexos.FirstOrDefault(s => s.SexoId == alumno.Sexo.SexoId);
                    var ciclo = sistemaColegio.CiclosAcademicos.FirstOrDefault(c => c.CicloAcademicoId == cicloAcademico.CicloAcademicoId);

                    if (gradoAcademico != null && sexo != null && ciclo != null)
                    {
                        alumno.GradoAcademico = gradoAcademico;
                        alumno.Sexo = sexo;
                        alumno.CicloAcademico = ciclo;

                        var nuevoBoletin = new Boletin();

                        var libroDeNotas = new LibroDeNotas();
                        var libroDeAsistencias = new LibroDeAsistencias();

                        nuevoBoletin.LibroDeNotas = libroDeNotas;
                        nuevoBoletin.LibroDeAsistencias = libroDeAsistencias;
                        nuevoBoletin.Alumno = alumno;
                        nuevoBoletin.EstadoFinal = sistemaColegio.EstadosFinales.FirstOrDefault(x => x.EstadoFinalId == 1);
                        nuevoBoletin.Año = alumno.CicloAcademico.Año;
                        nuevoBoletin.numGrado = alumno.GradoAcademico.NumGrado;
                        nuevoBoletin.Activo = true;
                        nuevoBoletin.PromedioTrimestre1 = 0;
                        nuevoBoletin.PromedioTrimestre2 = 0;
                        nuevoBoletin.PromedioTrimestre3 = 0;
                        nuevoBoletin.ObservacionTrimestre1 = "";
                        nuevoBoletin.ObservacionTrimestre2 = "";
                        nuevoBoletin.ObservacionTrimestre3 = "";

                        alumno.Boletines = new List<Boletin> { nuevoBoletin };

                        sistemaColegio.Boletines.Add(nuevoBoletin);
                        sistemaColegio.Alumnos.Add(alumno);

                        sistemaColegio.SaveChanges();

                        // Se asocian los IDs de los libros al boletín.
                        nuevoBoletin.LibroDeNotasId = libroDeNotas.LibroDeNotasId;
                        nuevoBoletin.LibroDeAsistenciasId = libroDeAsistencias.LibroDeAsistenciasId;

                        // Ahora que se asignaron los IDs, se guardan los cambios de nuevo.
                        sistemaColegio.SaveChanges();

                        return "Alumno registrado exitosamente.";
                    }
                    else
                    {
                        return "Error: Datos relacionados con el grado académico, sexo o ciclo académico son inválidos o no existen en la base de datos.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al registrar el alumno: {ex.Message}";
            }
        }
    }
}
