using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        public string NombrePagador { get; set; }
        public string ApellidoPagador { get; set; }
        public string DniPagador { get; set; }
        public TipoDePago TipoDePago {  get; set; }
        public string CodigoDeComprobante {  get; set; }

        //----------------------------------------
        public int PagoId {  get; set; }
        public int TipoDePagoId {  get; set; }
        //----------------------------------------
    }
}
