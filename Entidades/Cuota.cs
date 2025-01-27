using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuota
    {
        public CicloAcademico CicloAcademico { get; set; }
        public int Mes {  get; set; }
        public List<PagoDeCuota> PagosDeCuotas = new List<PagoDeCuota>();
        public decimal Precio {  get; set; }

        //----------------------------------------
        public int CuotaId { get; set; }
        public int CicloAcademicoId {  get; set; }
        //----------------------------------------
    }
}
