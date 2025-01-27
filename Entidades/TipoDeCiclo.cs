using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDeCiclo
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public List<GradoAcademico> GradosAcademicos = new List<GradoAcademico>();
        //----------------------------------------
        public int TipoDeCicloId {  get; set; }
        //----------------------------------------
    }
}
