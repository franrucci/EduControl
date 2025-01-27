using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeAsistencias
    {
        public Boletin Boletin { get; set; }
        public List<Asistencia> Asistencias = new List<Asistencia>();

        //----------------------------------------
        public int LibroDeAsistenciasId {  get; set; }
        public int BoletinId {  get; set; }
        //----------------------------------------
    }
}
