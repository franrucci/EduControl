using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        public List<Boletin> Boletines = new List<Boletin>();
        public CicloAcademico CicloAcademico { get; set; }
        public GradoAcademico GradoAcademico { get; set; }
        public List<PagoDeCuota> CuotasPagas = new List<PagoDeCuota>();

        //----------------------------------------
        public int CicloAcademicoId {  get; set; }
        public int GradoAcademicoId { get; set; }
        //----------------------------------------
    }
}
