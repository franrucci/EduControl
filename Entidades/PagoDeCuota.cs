using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PagoDeCuota
    {
        public string Codigo {  get; set; }
        public Cuota Cuota { get; set; }
        public DateTime Fecha { get; set; }
        public Alumno Alumno { get; set; }
        public EstadoCuota EstadoCuota { get; set; }
        public Pago Pago { get; set; }
        public decimal MontoFinal {  get; set; }

        //----------------------------------------
        public int PagoDeCuotaId {  get; set; }
        public int CuotaId {  get; set; }
        public int AlumnoId {  get; set; }
        public int EstadoCuotaId { get;set; }
        public int PagoId {  get; set; }
        //----------------------------------------
    }
}
