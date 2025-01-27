using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeNotas
    {
        public Boletin Boletin { get; set; }
        public List<Examen> Examenes { get; set; }
        //----------------------------------------
        public int LibroDeNotasId {  get; set; }
        public int BoletinId {  get; set; }
        //----------------------------------------
    }
}
