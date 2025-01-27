using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CicloAcademico
    {
        public int Año {  get; set; }
        public List<Alumno> Alumnos = new List<Alumno>();
        public List<Trimestre> Trimestres = new List<Trimestre>();
        //----------------------------------------
        public int CicloAcademicoId {  get; set; }
        //----------------------------------------
    }
}
