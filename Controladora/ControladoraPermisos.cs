using Modelo.Patron_Strategy;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraPermisos
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraPermisos instancia;

        public static ControladoraPermisos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPermisos();
                }
                return instancia;
            }
        }

        ControladoraPermisos()
        {
            sistemaColegio = new SistemaColegio();
        }

        // Este metodo devuelve una lista de permisos con el id de rol que recibe.
        public List<Permiso> SelectOpcion(int pId)
        {
            using (SistemaColegio db = new SistemaColegio())
            {
                return db.Permisos.Where(i => i.RolUsuarioId == pId).ToList();
            }
        }

        public void GuardarPermiso(Permiso pPermiso)
        {
            try
            {
                sistemaColegio.Permisos.Add(pPermiso);
                sistemaColegio.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el permiso: {ex.Message}");
            }
        }

        public List<Permiso> ObtenerPermisosPorRol(int rolId)
        {
            try
            {
                return sistemaColegio.Permisos.Where(p => p.RolUsuarioId == rolId).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermisosPorRol(int rolId)
        {
            try
            {
                var permisos = sistemaColegio.Permisos.Where(p => p.RolUsuarioId == rolId).ToList();
                sistemaColegio.Permisos.RemoveRange(permisos);
                sistemaColegio.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
