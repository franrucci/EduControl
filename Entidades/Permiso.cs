using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class Permiso
    {
        public int PermisoId { get; set; }
        public int RolUsuarioId { get; set; }
        public int OpcionId { get; set; }
        public bool Permitido { get; set; }

        public virtual Opcion Opcion { get; set; }
        public virtual RolUsuario RolUsuario { get; set; }
    }
}
