using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class RolUsuario
    {
        public RolUsuario()
        {
            this.Permiso = new HashSet<Permiso>();
            this.Usuario = new HashSet<Usuario>();
        }

        public int RolUsuarioId { get; set; }
        public string RolNombre { get; set; }

        public virtual ICollection<Permiso> Permiso { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
