using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public string Salt { get; set; }
        public virtual RolUsuario RolUsuario { get; set; }
        public string Email { get; set; }
        public string? Token { get; set; }

    }
}
