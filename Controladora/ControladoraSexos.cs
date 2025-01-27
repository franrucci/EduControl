using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSexos
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraSexos instancia;

        public static ControladoraSexos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraSexos();
                }
                return instancia;
            }
        }

        ControladoraSexos()
        {
            sistemaColegio = new SistemaColegio();
        }

        public ReadOnlyCollection<Sexo> ListarSexos()
        {
            try
            {
                return sistemaColegio.Sexos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string BuscarSexo(int sexoId)
        {
            try
            {
                var sexoEncontrado = sistemaColegio.Sexos.FirstOrDefault(x => x.SexoId == sexoId);
                return sexoEncontrado.Nombre;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
