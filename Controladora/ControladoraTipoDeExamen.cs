using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTipoDeExamen
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraTipoDeExamen instancia;

        public static ControladoraTipoDeExamen Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTipoDeExamen();
                }
                return instancia;
            }
        }

        ControladoraTipoDeExamen()
        {
            sistemaColegio = new SistemaColegio();
        }

        public List<TipoDeExamen> RetornarTiposDeExamen()
        {
            try
            {
                var listaDeTiposDeExamen = sistemaColegio.TiposDeExamenes.ToList();
                return listaDeTiposDeExamen;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
