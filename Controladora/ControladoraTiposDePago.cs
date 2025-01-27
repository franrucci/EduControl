using Modelo.Patron_Strategy;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Collections.ObjectModel;

namespace Controladora
{
    public class ControladoraTiposDePago
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraTiposDePago instancia;

        public static ControladoraTiposDePago Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTiposDePago();
                }
                return instancia;
            }
        }

        ControladoraTiposDePago()
        {
            sistemaColegio = new SistemaColegio();
        }

        
        public ReadOnlyCollection<TipoDePago> ListarTiposDePago()
        {
            try
            {
                return sistemaColegio.TiposDePagos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
