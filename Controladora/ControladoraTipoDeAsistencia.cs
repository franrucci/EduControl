using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTipoDeAsistencia
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraTipoDeAsistencia instancia;

        public static ControladoraTipoDeAsistencia Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTipoDeAsistencia();
                }
                return instancia;
            }
        }

        ControladoraTipoDeAsistencia()
        {
            sistemaColegio = new SistemaColegio();
        }

        public List<TipoDeAsistencia> RetornarTiposDeAsistencia()
        {
            try
            {
                var listaDeTiposDeAsistencia = sistemaColegio.TiposDeAsistencias.ToList();
                return listaDeTiposDeAsistencia;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
