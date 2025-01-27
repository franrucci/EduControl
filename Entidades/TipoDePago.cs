using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDePago
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public List<Pago> Pagos { get; set; }
        //----------------------------------------
        public int TipoDePagoId {  get; set; }
        //----------------------------------------
    }
}
