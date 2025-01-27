using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class Opcion
    {
        public Opcion()
        {
            this.Permiso = new HashSet<Permiso>();
        }

        public int OpcionId { get; set; }
        public string OpcionNombre { get; set; }
        public int ModuloId { get; set; }

        public virtual ICollection<Permiso> Permiso { get; set; }
    }
}
