using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public LibroDeAsistencias LibroDeAsistencias {  get; set; }
        public DateTime Fecha { get; set; }
        public int NumTrimestre {  get; set; }
        public TipoDeAsistencia TipoDeAsistencia { get; set; }
        //----------------------------------------
        public int AsistenciaId {  get; set; }
        public int LibroDeAsistenciasId {  get; set; }
        public int TipoDeAsistenciaId { get; set; }
        //----------------------------------------
    }
}
