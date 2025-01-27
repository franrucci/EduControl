using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDeExamen
    {
        public string Codigo {  get; set; }
        public string Nombre {  get; set; }
        public List<Examen> Examenes { get; set; }
        //----------------------------------------
        public int TipoDeExamenId { get; set; }
        //----------------------------------------
    }
}
