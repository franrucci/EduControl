using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GradoAcademico
    {
        public int NumGrado {  get; set; }
        public int CantDeMaterias {  get; set; }
        public TipoDeCiclo TipoDeCiclo { get; set; }
        public List<Materia> Materias = new List<Materia>();
        public List<Alumno> Alumnos = new List<Alumno>();
        //----------------------------------------
        public int GradoAcademicoId {  get; set; }
        public int TipoDeCicloId {  get; set; }
        //----------------------------------------
    }
}
