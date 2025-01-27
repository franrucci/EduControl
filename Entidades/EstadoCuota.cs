using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoCuota
    {
        public string Codigo { get; set; }
        public string Nombre {  get; set; }
        public List<PagoDeCuota> PagosDeCuota { get; set; }
        //----------------------------------------
        public int EstadoCuotaId { get; set; }
        //----------------------------------------
    }
}
