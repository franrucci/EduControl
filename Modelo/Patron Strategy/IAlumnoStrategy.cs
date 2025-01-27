using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Patron_Strategy
{
    // Interfaz que define el contrato para todas las estrategias concretas de registro de alumnos.
    // Declara el método AgregarAlumno, que deberá ser implementado por cada estrategia concreta
    public interface IAlumnoStrategy
    {
        string AgregarAlumno(Alumno alumno, CicloAcademico cicloAcademico, GradoAcademico grado);
    }
}