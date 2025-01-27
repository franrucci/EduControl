using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Patron_Strategy;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladora
{
    public class ControladoraAlumnos
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraAlumnos instancia;
        private IAlumnoStrategy estrategia;

        public static ControladoraAlumnos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAlumnos();
                }
                return instancia;
            }
        }

        ControladoraAlumnos()
        {
            sistemaColegio = new SistemaColegio();
        }

        public Alumno ObtenerAlumnoPorId(int personaId)
        {
            try
            {
                return sistemaColegio.Alumnos
                              .Include(a => a.CicloAcademico)
                              .Include(a => a.GradoAcademico)
                              .FirstOrDefault(a => a.PersonaId == personaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CambiarEstrategia(IAlumnoStrategy nuevaEstrategia)
        {
            this.estrategia = nuevaEstrategia;
        }

        public ReadOnlyCollection<Alumno> ListarAlumnos()
        {
            try
            {
                return sistemaColegio.Alumnos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string Agregar(Alumno alumno, CicloAcademico cicloAcademico, GradoAcademico grado)
        {
            try
            {
                return estrategia.AgregarAlumno(alumno, cicloAcademico, grado);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Alumno> ObtenerAlumnosPorGrado(GradoAcademico grado, CicloAcademico ciclo)
        {
            var alumnos = sistemaColegio.Alumnos
                .Where(a => a.GradoAcademicoId == grado.GradoAcademicoId && a.CicloAcademicoId == ciclo.CicloAcademicoId)
                .ToList();

            return alumnos;
        }

        public List<Alumno> ObtenerTodosLosAlumnos()
        {
            var alumnos = sistemaColegio.Alumnos.ToList();
            return alumnos;
        }

        public string EliminarAlumno(Alumno alumno)
        {
            try
            {
                // Busca y elimina todos los boletines relacionados con el alumno
                var boletinesRelacionados = sistemaColegio.Boletines
                    .Where(b => b.PersonaId == alumno.PersonaId)
                    .ToList();

                sistemaColegio.Boletines.RemoveRange(boletinesRelacionados);
                sistemaColegio.SaveChanges();

                // Busca y elimina todos los pagos de cuota relacionados con el alumno
                var pagosRelacionados = sistemaColegio.PagosDeCuota
                    .Where(p => p.AlumnoId == alumno.PersonaId)
                    .ToList();

                sistemaColegio.PagosDeCuota.RemoveRange(pagosRelacionados);
                sistemaColegio.SaveChanges();

                // Elimina al alumno de la tabla personas
                var alumnoAEliminar = sistemaColegio.Personas
                    .OfType<Alumno>()
                    .FirstOrDefault(a => a.PersonaId == alumno.PersonaId);

                if (alumnoAEliminar != null)
                {
                    sistemaColegio.Personas.Remove(alumnoAEliminar);
                    sistemaColegio.SaveChanges();

                    return "Alumno eliminado correctamente.";
                }
                else
                {
                    return "No se encontró el alumno especificado.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al intentar eliminar al alumno: {ex.Message}";
            }
        }

        public string ModificarAlumno(Alumno alumno)
        {
            try
            {
                var alumnoExistente = sistemaColegio.Personas.FirstOrDefault(a => a.PersonaId == alumno.PersonaId);

                if (alumnoExistente == null)
                {
                    return "El alumno no fue encontrado en el sistema.";
                }

                // Actualiza los datos personales que pueden cambiar
                alumnoExistente.Nombre = alumno.Nombre;
                alumnoExistente.Apellido = alumno.Apellido;
                alumnoExistente.Dni = alumno.Dni;
                alumnoExistente.FechaDeNacimiento = alumno.FechaDeNacimiento;
                alumnoExistente.Domicilio = alumno.Domicilio;
                alumnoExistente.Localidad = alumno.Localidad;
                alumnoExistente.CodigoPostal = alumno.CodigoPostal;
                alumnoExistente.Provincia = alumno.Provincia;
                alumnoExistente.Pais = alumno.Pais;
                alumnoExistente.Email = alumno.Email;
                alumnoExistente.Sexo = alumno.Sexo;

                sistemaColegio.SaveChanges();

                return "El alumno se modificó correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al intentar modificar al alumno: {ex.Message}";
            }
        }
    }
}