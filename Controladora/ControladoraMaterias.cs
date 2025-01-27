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
    public class ControladoraMaterias
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraMaterias instancia;

        public static ControladoraMaterias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraMaterias();
                }
                return instancia;
            }
        }

        ControladoraMaterias()
        {
            sistemaColegio = new SistemaColegio();
        }

        public List<Materia> RetornarMaterias(int gradoId)
        {
            try
            {
                var listaDeMaterias = sistemaColegio.Materias.Where(m => m.GradoAcademicoId == gradoId).ToList();
                return listaDeMaterias;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
