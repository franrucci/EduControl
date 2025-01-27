using Modelo.Patron_Strategy;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraRoles
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraRoles instancia;

        public static ControladoraRoles Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraRoles();
                }
                return instancia;
            }
        }

        ControladoraRoles()
        {
            sistemaColegio = new SistemaColegio();
        }

        public List<RolUsuario> ComboRol()
        {
            try
            {
                return sistemaColegio.Roles.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener la lista de roles: {ex.Message}", ex);
            }
        }

        public int GuardarRol(string nombreRol)
        {
            try
            {
                nombreRol = nombreRol.ToUpper();

                RolUsuario rolNuevo = new RolUsuario
                {
                    RolNombre = nombreRol
                };

                sistemaColegio.Roles.Add(rolNuevo);
                sistemaColegio.SaveChanges();

                return rolNuevo.RolUsuarioId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el rol: {ex.Message}");
            }
        }

        /*
        public int UltimoRegistro()
        {
            try
            {
                // Obtener el último registro de la tabla Roles
                var ultimo = (from c in sistemaColegio.Roles
                              orderby c.RolUsuarioId descending
                              select c.RolUsuarioId).FirstOrDefault();
                return ultimo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el último registro: {ex.Message}");
            }
        }
        */

        public RolUsuario RetornarRol(int idUsu)
        {
            try
            {
                return sistemaColegio.Roles.FirstOrDefault(x => x.RolUsuarioId == idUsu);
            }
            catch (Exception ex)
            {
                // Lanza la excepción para que sea manejada en la capa de presentación
                throw new Exception($"Error al buscar usuario: {ex.Message}", ex);
            }
        }

        public string EliminarRol(int rolId)
        {
            try
            {
                var rol = sistemaColegio.Roles.FirstOrDefault(x => x.RolUsuarioId == rolId);

                sistemaColegio.Roles.Remove(rol);
                sistemaColegio.SaveChanges();

                return "El rol se eliminó correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al intentar eliminar el rol: {ex.Message}";
            }
        }

        public bool ValidarNombre(string nombreRol, int? rolId = null)
        {
            try
            {
                // Normalizamos el nombre del rol en el cliente
                var nombreRolNormalizado = nombreRol
                    .Normalize(System.Text.NormalizationForm.FormD)  // Normalización de la cadena
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)  // Elimina los acentos
                    .Aggregate(string.Empty, (current, c) => current + c)  // Reconstruye la cadena sin los acentos
                    .ToUpper();

                // Recuperamos los roles de la base de datos
                var roles = sistemaColegio.Roles.ToList();

                // Si rolId tiene valor, lo ignoramos en la validación (es decir, no validamos el rol que estamos modificando)
                return roles.Any(r => r.RolNombre
                    .Normalize(System.Text.NormalizationForm.FormD)
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    .Aggregate(string.Empty, (current, c) => current + c)
                    .ToUpper() == nombreRolNormalizado && (rolId == null || r.RolUsuarioId != rolId));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al validar el nombre del rol: {ex.Message}", ex);
            }
        }

        public RolUsuario ObtenerRolPorId(int rolId)
        {
            try
            {
                return sistemaColegio.Roles.FirstOrDefault(r => r.RolUsuarioId == rolId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ObtenerIdPorNombre(string nombre)
        {
            try
            {
                var rol = sistemaColegio.Roles.FirstOrDefault(r => r.RolNombre == nombre);
                return rol?.RolUsuarioId ?? 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarRol(int rolId, string nuevoNombreRol)
        {
            try
            {
                var rolExistente = sistemaColegio.Roles.FirstOrDefault(r => r.RolUsuarioId == rolId);

                if (rolExistente != null)
                {
                    rolExistente.RolNombre = nuevoNombreRol;
                    sistemaColegio.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el rol: {ex.Message}", ex);
            }
        }
    }
}
