using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraBoletines
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraBoletines instancia;

        public static ControladoraBoletines Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraBoletines();
                }
                return instancia;
            }
        }

        ControladoraBoletines()
        {
            sistemaColegio = new SistemaColegio();
        }

        // Verifica si existe un boletín activo para el alumno, año y grado especificado
        public bool VerificarBoletinActivo(int personaId, int año, int numGrado)
        {
            var boletinActivo = sistemaColegio.Boletines
                .FirstOrDefault(b => b.Alumno.PersonaId == personaId
                                     && b.Año == año
                                     && b.Alumno.GradoAcademicoId == numGrado
                                     && b.Activo);

            return boletinActivo != null;
        }
        
        public List<Boletin> ObtenerBoletines(int alumnoId)
        {
            var boletinesAlumno = sistemaColegio.Boletines
                .Where(b => b.PersonaId == alumnoId)
                .ToList();

            return boletinesAlumno;
        }

        public Boletin RecuperarBoletinAlumno(Alumno alumno, int año)
        {
            var boletinEncontrado = sistemaColegio.Boletines.FirstOrDefault(x => x.PersonaId == alumno.PersonaId && x.Año == año);
            return boletinEncontrado;
        }

        public Boletin RecuperarBoletinCompleto(Boletin boletin)
        {
            var boletinSeleccionado = sistemaColegio.Boletines
                .Include(b => b.EstadoFinal)
                .FirstOrDefault(b => b.BoletinId == boletin.BoletinId);

            return boletinSeleccionado;
        }

        public string RegistrarNotaDeExamen(Alumno alumno, Examen examen)
        {
            try
            {
                if (examen.Nota < 1 || examen.Nota > 10)
                {
                    return "Error: La nota ingresada no es válida.";
                }

                // Valida que el boletín del alumno esté activo.
                var boletinActivo = sistemaColegio.Boletines
                    .FirstOrDefault(b => b.PersonaId == alumno.PersonaId && b.Activo);

                if (boletinActivo == null)
                {
                    return $"Error: Ya se ha cerrado el boletín del alumno {alumno.Nombre}.";
                }

                // Busca el LibroDeNotas asociado al boletín activo.
                var libroDeNotas = sistemaColegio.LibrosDeNotas
                    .Include(l => l.Examenes)
                    .FirstOrDefault(l => l.BoletinId == boletinActivo.BoletinId);

                if (libroDeNotas == null)
                {
                    return "Error: No se encontró el libro de notas asociado al boletín del alumno.";
                }

                // Verifica si la entidad Materia ya está siendo rastreada.
                var materiaExistente = sistemaColegio.Materias
                    .Local
                    .FirstOrDefault(m => m.MateriaId == examen.MateriaId);

                if (materiaExistente != null)
                {
                    // Usa la instancia existente en lugar de la nueva.
                    examen.Materia = materiaExistente;
                }
                else
                {
                    // Adjunta la nueva instancia.
                    sistemaColegio.Materias.Attach(examen.Materia);
                }

                // Valida si ya existe un examen para la misma materia en el mismo trimestre y con el mismo tipo de examen.
                var examenExistente = sistemaColegio.Examenes
                    .FirstOrDefault(e => e.LibroDeNotasId == examen.LibroDeNotasId
                                         && e.MateriaId == examen.MateriaId
                                         && e.TipoDeExamenId == examen.TipoDeExamenId
                                         && e.NumTrimestre == examen.NumTrimestre);

                if (examenExistente != null)
                {
                    return $"Error: Ya existe un examen {examen.TipoDeExamen.Nombre} de la materia {examen.Materia.NombreMateria} en el trimestre {examen.NumTrimestre}.";
                }

                // Valida que todas las materias del trimestre anterior tengan un examen parcial antes de permitir registrar uno en el trimestre actual.
                if (examen.NumTrimestre > 1)
                {
                    var trimestreAnterior = examen.NumTrimestre - 1;

                    // Obtiene todas las materias del grado del alumno.
                    var materiasDelGrado = sistemaColegio.Materias
                        .Where(m => m.GradoAcademicoId == alumno.GradoAcademicoId)
                        .ToList();

                    // Verifica si todas las materias tienen al menos un examen parcial en el trimestre anterior.
                    foreach (var materia in materiasDelGrado)
                    {
                        var examenParcialTrimestreAnterior = libroDeNotas.Examenes
                            .Any(e => e.MateriaId == materia.MateriaId
                                      && e.NumTrimestre == trimestreAnterior
                                      && e.TipoDeExamenId == 1); // Parcial

                        if (!examenParcialTrimestreAnterior)
                        {
                            return $"Error: No se puede cargar un examen del trimestre {examen.NumTrimestre} sin haber cargado al menos un examen parcial en el trimestre {trimestreAnterior} para todas las materias del grado.";
                        }
                    }
                }

                // Valida que se haya registrado un examen parcial en el trimestre actual antes de registrar un recuperatorio.
                if (examen.TipoDeExamen.Codigo == "A02") // Recuperatorio
                {
                    // Verifica si el boletín para el trimestre está cerrado.
                    bool boletinCerrado = false;

                    if (examen.NumTrimestre == 1)
                    {
                        boletinCerrado = boletinActivo.BoletinCerrado1;
                    }
                    else if (examen.NumTrimestre == 2)
                    {
                        boletinCerrado = boletinActivo.BoletinCerrado2;
                    }
                    else if (examen.NumTrimestre == 3)
                    {
                        boletinCerrado = boletinActivo.BoletinCerrado3;
                    }

                    if (boletinCerrado)
                    {
                        return $"Error: El boletín del trimestre {examen.NumTrimestre} está cerrado, no se pueden registrar exámenes recuperatorios.";
                    }

                    var examenParcial = libroDeNotas.Examenes
                        .FirstOrDefault(e => e.MateriaId == examen.MateriaId
                                             && e.NumTrimestre == examen.NumTrimestre
                                             && e.TipoDeExamenId == 1); // Parcial

                    if (examenParcial == null)
                    {
                        return $"Error: No se puede cargar un examen recuperatorio sin haber cargado un examen parcial previo en el mismo trimestre y para la misma materia.";
                    }
                }

                // Si todas las validaciones pasan, agrega el examen al libro de notas.
                libroDeNotas.Examenes.Add(examen);
                sistemaColegio.SaveChanges();

                return "Nota registrada correctamente.";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error desconocido al registrar la nota.";
            }
        }

        public string RegistrarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            try
            {
                // Valida que el boletín del alumno esté activo.
                var boletinActivo = sistemaColegio.Boletines
                    .FirstOrDefault(b => b.PersonaId == alumno.PersonaId && b.Activo);

                if (boletinActivo == null)
                {
                    return $"Error: El boletín del alumno {alumno.Nombre} está cerrado.";
                }

                // Busca el LibroDeAsistencias asociado al boletín activo.
                var libroDeAsistencias = sistemaColegio.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .FirstOrDefault(l => l.BoletinId == boletinActivo.BoletinId);

                if (libroDeAsistencias == null)
                {
                    return "Error: No se encontró el libro de asistencias asociado al boletín del alumno.";
                }

                // Valida que la fecha no esté registrada en ningún trimestre.
                var asistenciaExistenteEnOtroTrimestre = libroDeAsistencias.Asistencias
                    .FirstOrDefault(a => a.Fecha.Date == asistencia.Fecha.Date);

                if (asistenciaExistenteEnOtroTrimestre != null)
                {
                    return $"Error: Ya existe una asistencia registrada para el día {asistencia.Fecha.ToShortDateString()} en el trimestre {asistenciaExistenteEnOtroTrimestre.NumTrimestre}.";
                }

                // Verifica que las asistencias del trimestre anterior estén completas.
                if (asistencia.NumTrimestre > 1)
                {
                    int trimestreAnterior = asistencia.NumTrimestre - 1;

                    // Obtiene los días hábiles del trimestre anterior.
                    var trimestrePrevio = sistemaColegio.Trimestres.FirstOrDefault(t => t.NumTrimestre == trimestreAnterior);

                    int diasHabilesPrevios = trimestrePrevio.DiasTotalesHabiles;

                    // Cuenta las asistencias cargadas del trimestre anterior.
                    int diasAsistidosPrevios = libroDeAsistencias.Asistencias
                        .Count(a => a.NumTrimestre == trimestreAnterior);

                    if (diasAsistidosPrevios < diasHabilesPrevios)
                    {
                        return $"Error: No se pueden registrar asistencias en el trimestre {asistencia.NumTrimestre} porque faltan asistencias del trimestre anterior ({trimestreAnterior}).";
                    }
                }

                // Valida si ya existe una asistencia registrada para el mismo día en el mismo trimestre.
                var asistenciaExistente = libroDeAsistencias.Asistencias
                    .FirstOrDefault(a => a.Fecha.Date == asistencia.Fecha.Date && a.NumTrimestre == asistencia.NumTrimestre);

                if (asistenciaExistente != null)
                {
                    return $"Error: Ya existe una asistencia registrada en el trimestre {asistencia.NumTrimestre} para el día {asistencia.Fecha.ToShortDateString()}.";
                }

                // Verifica el límite de días hábiles para el trimestre actual.
                var trimestre = sistemaColegio.Trimestres.FirstOrDefault(t => t.NumTrimestre == asistencia.NumTrimestre);

                int diasHabiles = trimestre.DiasTotalesHabiles;
                int diasAsistidosCargados = libroDeAsistencias.Asistencias
                    .Count(a => a.NumTrimestre == asistencia.NumTrimestre);

                if (diasAsistidosCargados + 1 > diasHabiles)
                {
                    return $"Error: Ya se alcanzó el máximo de días permitidos para el trimestre {asistencia.NumTrimestre}.";
                }

                // Agrega la asistencia al libro de asistencias.
                libroDeAsistencias.Asistencias.Add(asistencia);
                sistemaColegio.SaveChanges();

                return "Asistencia registrada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error desconocido al registrar la asistencia: {ex.Message}";
            }
        }

        public string RegistrarObservacion(Alumno alumno, int numTrimestre, string observacion)
        {
            try
            {
                // Busca el boletín activo del alumno.
                var boletinActivo = sistemaColegio.Boletines
                    .FirstOrDefault(b => b.PersonaId == alumno.PersonaId && b.Activo);

                if (boletinActivo == null)
                {
                    return $"Error: El boletín del alumno {alumno.Nombre} está cerrado.";
                }

                // Valida el número de trimestre.
                if (numTrimestre < 1 || numTrimestre > 3)
                {
                    return "Error: El número de trimestre no es válido. Debe ser 1, 2 o 3.";
                }

                // Valida las observaciones previas para el trimestre 2 y 3
                if (numTrimestre == 2 && string.IsNullOrEmpty(boletinActivo.ObservacionTrimestre1))
                {
                    return "Error: Debes registrar una observación en el Trimestre 1 antes de registrar una en el Trimestre 2.";
                }

                if (numTrimestre == 3 && string.IsNullOrEmpty(boletinActivo.ObservacionTrimestre2))
                {
                    return "Error: Debes registrar una observación en el Trimestre 2 antes de registrar una en el Trimestre 3.";
                }

                // Dependiendo del número de trimestre, verifica si ya hay una observación registrada.
                switch (numTrimestre)
                {
                    case 1:
                        if (!string.IsNullOrEmpty(boletinActivo.ObservacionTrimestre1) && boletinActivo.ObservacionTrimestre1.Length > 1)
                        {
                            return "Error: Ya existe una observación registrada para el Trimestre 1.";
                        }
                        boletinActivo.ObservacionTrimestre1 = observacion;
                        break;

                    case 2:
                        if (!string.IsNullOrEmpty(boletinActivo.ObservacionTrimestre2) && boletinActivo.ObservacionTrimestre2.Length > 1)
                        {
                            return "Error: Ya existe una observación registrada para el Trimestre 2.";
                        }
                        boletinActivo.ObservacionTrimestre2 = observacion;
                        break;

                    case 3:
                        if (!string.IsNullOrEmpty(boletinActivo.ObservacionTrimestre3) && boletinActivo.ObservacionTrimestre3.Length > 1)
                        {
                            return "Error: Ya existe una observación registrada para el Trimestre 3.";
                        }
                        boletinActivo.ObservacionTrimestre3 = observacion;
                        break;

                    default:
                        return "Error: El número de trimestre es inválido.";
                }

                sistemaColegio.SaveChanges();

                return $"Observación para el Trimestre {numTrimestre} registrada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error al registrar la observación: {ex.Message}";
            }
        }

        public string GenerarBoletin(Alumno alumno, int año, int numTrimestre)
        {
            try
            {
                // Busca el boletín del alumno que coincida con el año del ciclo académico.
                var boletin = sistemaColegio.Boletines
                    .Include(b => b.LibroDeNotas)
                    .ThenInclude(l => l.Examenes)
                    .ThenInclude(e => e.Materia)
                    .Include(b => b.LibroDeAsistencias)
                    .ThenInclude(l => l.Asistencias)
                    .FirstOrDefault(b => b.Alumno.PersonaId == alumno.PersonaId && b.Año == año);
                /*
                if (boletin == null)
                {
                    return "Boletín no encontrado para el año especificado.";
                }
                */
                //Valida que el boletín para el trimestre ya no haya sido generado.
                switch (numTrimestre)
                {
                    case 1:
                        if (boletin.PromedioTrimestre1 > 0)
                        {
                            return $"Error: El boletín para el trimestre {numTrimestre} ya fue generado y no es posible generarlo nuevamente.";
                        }
                        break;
                    case 2:
                        if (boletin.PromedioTrimestre2 > 0)
                        {
                            return $"Error: El boletín para el trimestre {numTrimestre} ya fue generado y no es posible generarlo nuevamente.";
                        }
                        break;
                    case 3:
                        if (boletin.PromedioTrimestre3 > 0)
                        {
                            return $"Error: El boletín para el trimestre {numTrimestre} ya fue generado y no es posible generarlo nuevamente.";
                        }
                        break;
                }

                // Valida que el trimestre anterior haya sido generado si no es el 1er trimestre.
                if (numTrimestre == 2 && boletin.PromedioTrimestre1 == 0)
                {
                    return "El boletín del trimestre 1 debe ser generado antes de generar el trimestre 2.";
                }
                if (numTrimestre == 3 && (boletin.PromedioTrimestre1 == 0 || boletin.PromedioTrimestre2 == 0))
                {
                    return "Los boletines de los trimestres 1 y 2 deben ser generados antes de generar el trimestre 3.";
                }

                // Obtiene las materias del grado del alumno.
                var listaDeMaterias = ControladoraMaterias.Instancia.RetornarMaterias(alumno.GradoAcademicoId);

                // Obtiene todas las calificaciones para el trimestre específico.
                var detallesCalificaciones = boletin.LibroDeNotas.Examenes
                    .Where(e => e.NumTrimestre == numTrimestre)
                    .ToList();

                // Verifica que cada materia tenga al menos un examen en el trimestre.
                var materiasConDetalles = listaDeMaterias
                    .All(materia => detallesCalificaciones.Any(detalle => detalle.Materia != null && detalle.Materia.MateriaId == materia.MateriaId));

                if (!materiasConDetalles)
                {
                    return $"No se ha registrado ningún examen para todas las materias en el trimestre {numTrimestre}.";
                }

                // Filtra exámenes dependiendo si son parciales y recuperatorios
                var parcialesTrimestre = detallesCalificaciones
                    .Where(detalle => detalle.TipoDeExamenId == 1)
                    .ToList();

                var recuperatoriosTrimestre = detallesCalificaciones
                    .Where(detalle => detalle.TipoDeExamenId == 2)
                    .ToList();

                // Calcula el promedio de notas del trimestre.
                decimal sumaNotas = 0;
                var detallesFinales = new List<Examen>();

                foreach (var materia in listaDeMaterias)
                {
                    var detalleParcial = parcialesTrimestre
                        .FirstOrDefault(detalle => detalle.Materia != null && detalle.Materia.MateriaId == materia.MateriaId);

                    var detalleRecuperatorio = recuperatoriosTrimestre
                        .FirstOrDefault(detalle => detalle.Materia != null && detalle.Materia.MateriaId == materia.MateriaId);

                    if (detalleRecuperatorio != null)
                    {
                        detallesFinales.Add(detalleRecuperatorio);
                        sumaNotas += detalleRecuperatorio.Nota;
                    }
                    else if (detalleParcial != null)
                    {
                        detallesFinales.Add(detalleParcial);
                        sumaNotas += detalleParcial.Nota;
                    }
                }

                decimal promedioTrimestre = detallesFinales.Count > 0 ? sumaNotas / listaDeMaterias.Count : 0;

                // Asigna el promedio al trimestre correspondiente y cierra el boletín para el trimestre.
                switch (numTrimestre)
                {
                    case 1:
                        boletin.PromedioTrimestre1 = promedioTrimestre;
                        boletin.BoletinCerrado1 = true;
                        break;
                    case 2:
                        boletin.PromedioTrimestre2 = promedioTrimestre;
                        boletin.BoletinCerrado2 = true;
                        break;
                    case 3:
                        boletin.PromedioTrimestre3 = promedioTrimestre;
                        boletin.BoletinCerrado3 = true;
                        break;
                }

                // Valida las asistencias del alumno.
                var asistenciasTrimestre = boletin.LibroDeAsistencias.Asistencias
                    .Where(a => a.NumTrimestre == numTrimestre)
                    .ToList();

                var diasHabiles = sistemaColegio.Trimestres
                    .FirstOrDefault(t => t.NumTrimestre == numTrimestre)?.DiasTotalesHabiles;

                if (diasHabiles == null || asistenciasTrimestre.Count == 0)
                {
                    return $"Las asistencias no coinciden con los días hábiles registrados para el trimestre {numTrimestre}.";
                }

                // Calcula el porcentaje de asistencia del trimestre.
                decimal porcentajeAsistencia = (asistenciasTrimestre
                    .Sum(a => ObtenerPorcentajeAsistencia(a.TipoDeAsistenciaId))) / diasHabiles.Value * 100;

                // Asigna el promedio de asistencia al trimestre correspondiente.
                switch (numTrimestre)
                {
                    case 1:
                        boletin.PromedioAsistenciaTrimestre1 = porcentajeAsistencia;
                        break;
                    case 2:
                        boletin.PromedioAsistenciaTrimestre2 = porcentajeAsistencia;
                        break;
                    case 3:
                        boletin.PromedioAsistenciaTrimestre3 = porcentajeAsistencia;
                        break;
                }

                // Si es el 3er trimestre, calcula el promedio anual y el total de asistencia.
                if (numTrimestre == 3)
                {
                    var promedioAnual = (boletin.PromedioTrimestre1 + boletin.PromedioTrimestre2 + boletin.PromedioTrimestre3) / 3;
                    boletin.PromedioTotalExamenes = promedioAnual;

                    var promedioTotalAsistencia = (boletin.PromedioAsistenciaTrimestre1 + boletin.PromedioAsistenciaTrimestre2 + boletin.PromedioAsistenciaTrimestre3) / 3;
                    boletin.PromedioTotalAsistencia = promedioTotalAsistencia;

                    // Determina las materias adeudadas.
                    var materiasAdeudadas = ObtenerMateriasAdeudadas(boletin, listaDeMaterias);
                    bool tieneMateriasAdeudadas = materiasAdeudadas.Any();
                    bool tieneBuenaAsistencia = promedioTotalAsistencia >= 75;

                    // Asigna el estado final
                    if (!tieneBuenaAsistencia || materiasAdeudadas.Count > 3) // Si NO tiene buena asiastencia o mas de 3 materias adeudadas es REPROBADO.
                    {
                        boletin.EstadoFinalId = 2; // Reprobado
                    }
                    else if (tieneBuenaAsistencia && materiasAdeudadas.Count <= 3 && materiasAdeudadas.Count != 0)
                    {
                        boletin.EstadoFinalId = 3; // Mes de recuperación
                    }
                    else if (tieneBuenaAsistencia && !tieneMateriasAdeudadas)
                    {
                        boletin.EstadoFinalId = 1; // Aprobado
                    }

                    // Desactiva el boletín.
                    boletin.Activo = false;
                }

                sistemaColegio.SaveChanges();

                return $"Boletín generado correctamente para el trimestre {numTrimestre}.";
            }
            catch (Exception ex)
            {
                return $"Error al generar el boletín: {ex.Message}";
            }
        }


        // Método para obtener el porcentaje de asistencia basado en el tipo de asistencia.
        private decimal ObtenerPorcentajeAsistencia(int tipoDeAsistenciaId)
        {
            return tipoDeAsistenciaId switch
            {
                1 => 1m,    // Presente
                2 => 0m,    // Ausente
                3 => 1m,    // Falta justificada
                4 => 0.5m,  // Retiro
            };
        }

        public List<Materia> ObtenerMateriasAdeudadas(Boletin boletin, List<Materia> listaDeMaterias)
        {
            try
            {
                var materiasAdeudadas = new List<Materia>();

                if (boletin == null || listaDeMaterias == null)
                {
                    throw new ArgumentNullException("El boletín o la lista de materias no pueden ser nulos.");
                }

                // Calcula el promedio por materia
                foreach (var materia in listaDeMaterias)
                {
                    var sumaNotas = 0m;
                    var cantidadExamenes = 0;

                    // Filtra los detalles de calificaciones para la materia específica
                    var detallesMateria = boletin.LibroDeNotas.Examenes
                        .Where(detalle => detalle.Materia != null && detalle.Materia.MateriaId == materia.MateriaId)
                        .ToList();

                    // Suma las notas de los exámenes de la materia
                    foreach (var detalle in detallesMateria)
                    {
                        sumaNotas += detalle.Nota;
                        cantidadExamenes++;
                    }

                    // Calcula el promedio anual de la materia
                    var promedioAnual = cantidadExamenes > 0 ? sumaNotas / cantidadExamenes : 0;

                    // Verifica si la materia está adeudada
                    if (promedioAnual < 7)
                    {
                        materiasAdeudadas.Add(materia);
                    }
                }

                return materiasAdeudadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las materias adeudadas", ex);
            }
        }
    }
}