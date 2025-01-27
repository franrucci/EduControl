using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Patron_Strategy
{
    public class AgregarAlumnoExistenteStrategy : IAlumnoStrategy
    {
        private SistemaColegio sistemaColegio;
        public AgregarAlumnoExistenteStrategy()
        {
            sistemaColegio = new SistemaColegio();
        }

        public string AgregarAlumno(Alumno alumno, CicloAcademico cicloAcademico, GradoAcademico grado)
        {
            try
            {
                // Valida si el alumno tiene boletines anteriores.
                var boletinesAnteriores = sistemaColegio.Boletines
                    .Include(b => b.EstadoFinal)
                    .Where(b => b.Alumno.PersonaId == alumno.PersonaId)
                    .ToList();

                // Permite inscripción solo si el grado fue reprobado
                var gradoReprobado = boletinesAnteriores
                    .FirstOrDefault(b => b.numGrado == grado.NumGrado &&
                                         b.EstadoFinal != null &&
                                         b.EstadoFinal.EstadoFinalId == 2);

                if (gradoReprobado != null && gradoReprobado.Año < cicloAcademico.Año)
                {
                    // Se permite la inscripción al mismo grado reprobado
                    if (grado.NumGrado != gradoReprobado.numGrado)
                    {
                        return $"Error: El alumno debe repetir el grado {gradoReprobado.numGrado}, no inscribirse a un grado diferente.";
                    }

                    var alumnoExistente = sistemaColegio.Alumnos
                        .FirstOrDefault(a => a.PersonaId == alumno.PersonaId);

                    if (alumnoExistente == null)
                    {
                        return "Error: El alumno no existe en la base de datos.";
                    }

                    // Verificar si el último boletín está activo
                    var ultimoBoletin = boletinesAnteriores.OrderByDescending(b => b.Año).FirstOrDefault();

                    if (ultimoBoletin != null && ultimoBoletin.Activo)
                    {
                        return "Error: El último boletín del alumno está activo, no se puede inscribir hasta que esté inactivo.";
                    }

                    // Si el alumno ya existe, actualiza su ciclo académico y grado
                    alumnoExistente.CicloAcademico = cicloAcademico;
                    alumnoExistente.GradoAcademico = grado;

                    // Actualiza el ciclo académico y grado académico
                    alumnoExistente.CicloAcademicoId = cicloAcademico.CicloAcademicoId;
                    alumnoExistente.GradoAcademicoId = grado.GradoAcademicoId;

                    // Crea un nuevo boletín para el alumno en el nuevo ciclo académico
                    var nuevoBoletin = new Boletin
                    {
                        Año = cicloAcademico.Año,
                        numGrado = grado.NumGrado,
                        Activo = true,
                        Alumno = alumnoExistente,
                        EstadoFinal = sistemaColegio.EstadosFinales.FirstOrDefault(x => x.EstadoFinalId == 1),
                        PromedioTrimestre1 = 0,
                        PromedioTrimestre2 = 0,
                        PromedioTrimestre3 = 0,
                        ObservacionTrimestre1 = "",
                        ObservacionTrimestre2 = "",
                        ObservacionTrimestre3 = ""
                    };

                    var libroDeNotas = new LibroDeNotas();
                    var libroDeAsistencias = new LibroDeAsistencias();

                    nuevoBoletin.LibroDeNotas = libroDeNotas;
                    nuevoBoletin.LibroDeAsistencias = libroDeAsistencias;


                    sistemaColegio.Boletines.Add(nuevoBoletin);
                    sistemaColegio.SaveChanges();

                    // Ahora que los IDs están generados, actualiza los IDs de los libros en el boletín
                    nuevoBoletin.LibroDeNotasId = libroDeNotas.LibroDeNotasId;
                    nuevoBoletin.LibroDeAsistenciasId = libroDeAsistencias.LibroDeAsistenciasId;

                    sistemaColegio.SaveChanges();
                    sistemaColegio.ChangeTracker.Clear();

                    return "Alumno agregado exitosamente en el nuevo ciclo académico y grado.";
                }
                else
                {
                    // Código para cuando el alumno fue promovido en el ciclo anterior o no tiene boletín
                    var boletinAnterior = boletinesAnteriores
                        .FirstOrDefault(b => b.Año == cicloAcademico.Año - 1); // Obtener el boletín del ciclo académico anterior

                    if (boletinAnterior != null && boletinAnterior.EstadoFinal != null && boletinAnterior.EstadoFinal.EstadoFinalId != 1)
                    {
                        return $"Error: El alumno no puede ser inscrito en el ciclo académico {cicloAcademico.Año} porque no fue promovido en el ciclo anterior.";
                    }

                    // Verifica si el alumno ya está registrado en el ciclo académico
                    var alumnoEnCiclo = sistemaColegio.Boletines
                        .Include(b => b.Alumno)
                        .FirstOrDefault(b => b.Alumno.PersonaId == alumno.PersonaId && b.Año == cicloAcademico.Año);

                    if (alumnoEnCiclo != null)
                    {
                        return $"Error: El alumno ya fue registrado en el ciclo académico {cicloAcademico.Año}.";
                    }

                    // Validación: No permitir inscripción a un grado ya aprobado
                    var gradoAprobado = boletinesAnteriores
                        .FirstOrDefault(b => b.numGrado == grado.NumGrado &&
                                             b.EstadoFinal != null &&
                                             b.EstadoFinal.EstadoFinalId == 1); // 1 = Aprobado

                    if (gradoAprobado != null && gradoAprobado.Año < cicloAcademico.Año)
                    {
                        return $"Error: El alumno ya aprobó el grado {grado.NumGrado} en el ciclo académico {gradoAprobado.Año}.";
                    }

                    // Último boletín debe estar inactivo para inscribir al alumno
                    var ultimoBoletin = boletinesAnteriores.OrderByDescending(b => b.Año).FirstOrDefault();

                    if (ultimoBoletin != null && ultimoBoletin.Activo)
                    {
                        return "Error: El último boletín del alumno está activo, no se puede inscribir hasta que esté inactivo.";
                    }

                    // Sigue con la inscripción normal
                    var alumnoExistente = sistemaColegio.Alumnos
                        .FirstOrDefault(a => a.PersonaId == alumno.PersonaId);

                    if (alumnoExistente == null)
                    {
                        return "Error: El alumno no existe en la base de datos.";
                    }

                    // Si el alumno ya existe, actualiza su ciclo académico y grado
                    alumnoExistente.CicloAcademico = cicloAcademico;
                    alumnoExistente.GradoAcademico = grado;

                    // Actualiza el ciclo académico y grado académico
                    alumnoExistente.CicloAcademicoId = cicloAcademico.CicloAcademicoId;
                    alumnoExistente.GradoAcademicoId = grado.GradoAcademicoId;

                    // Crea un nuevo boletín para el alumno en el nuevo ciclo académico
                    var nuevoBoletin = new Boletin
                    {
                        Año = cicloAcademico.Año,
                        numGrado = grado.NumGrado,
                        Activo = true,
                        Alumno = alumnoExistente,
                        EstadoFinal = sistemaColegio.EstadosFinales.FirstOrDefault(x => x.EstadoFinalId == 1),
                        PromedioTrimestre1 = 0,
                        PromedioTrimestre2 = 0,
                        PromedioTrimestre3 = 0,
                        ObservacionTrimestre1 = "",
                        ObservacionTrimestre2 = "",
                        ObservacionTrimestre3 = ""
                    };

                    var libroDeNotas = new LibroDeNotas();
                    var libroDeAsistencias = new LibroDeAsistencias();

                    // Asocia los libros al boletín
                    nuevoBoletin.LibroDeNotas = libroDeNotas;
                    nuevoBoletin.LibroDeAsistencias = libroDeAsistencias;

                    // Guarda los cambios para que se generen los IDs de los libros
                    sistemaColegio.Boletines.Add(nuevoBoletin);
                    sistemaColegio.SaveChanges();

                    // Ahora que los IDs están generados, actualiza los IDs de los libros en el boletín
                    nuevoBoletin.LibroDeNotasId = libroDeNotas.LibroDeNotasId;
                    nuevoBoletin.LibroDeAsistenciasId = libroDeAsistencias.LibroDeAsistenciasId;

                    sistemaColegio.SaveChanges();

                    return "Alumno agregado exitosamente en el nuevo ciclo académico y grado.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al registrar al alumno: {ex.Message}";
            }
        }
    }
}
