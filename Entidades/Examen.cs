using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        public LibroDeNotas LibroDeNotas { get; set; }
        public Materia Materia { get; set; }
        public TipoDeExamen TipoDeExamen { get; set; }
        public int NumTrimestre { get; set; }
        public decimal Nota {  get; set; }

        //----------------------------------------
        public int ExamenId {  get; set; }
        public int LibroDeNotasId {  get; set; }
        public int MateriaId { get; set; }
        public int TipoDeExamenId { get; set; }
        //----------------------------------------
    }
}
