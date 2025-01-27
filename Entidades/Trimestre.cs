using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trimestre
    {
        public int NumTrimestre {  get; set; }
        public int DiasTotalesHabiles {  get; set; }
        public CicloAcademico CicloAcademico { get; set; }
        //----------------------------------------
        public int TrimestreId {  get; set; }
        public int CicloAcademicoId {  get; set; }
        //----------------------------------------
    }
}
