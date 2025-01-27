using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraGradosAcademicos
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraGradosAcademicos instancia;

        public static ControladoraGradosAcademicos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraGradosAcademicos();
                }
                return instancia;
            }
        }

        ControladoraGradosAcademicos()
        {
            sistemaColegio = new SistemaColegio();
        }

        public ReadOnlyCollection<GradoAcademico> ListarGrados()
        {
            try
            {
                return sistemaColegio.GradosAcademicos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GradoAcademico BuscarGrado(int gradoId)
        {
            try
            {
                var gradoEncontrado = sistemaColegio.GradosAcademicos.FirstOrDefault(x => x.GradoAcademicoId == gradoId);
                return gradoEncontrado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
