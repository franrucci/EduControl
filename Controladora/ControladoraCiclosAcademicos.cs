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
    public class ControladoraCiclosAcademicos
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraCiclosAcademicos instancia;

        public static ControladoraCiclosAcademicos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCiclosAcademicos();
                }
                return instancia;
            }
        }

        ControladoraCiclosAcademicos()
        {
            sistemaColegio = new SistemaColegio();
        }

        public string AgregarCicloAcademico(CicloAcademico cicloAcademico)
        {
            try
            {
                int añoActual = cicloAcademico.Año;

                // Verifica si ya existe un ciclo académico con el mismo año
                var cicloExistente = sistemaColegio.CiclosAcademicos.FirstOrDefault(x => x.Año == añoActual);
                if (cicloExistente != null)
                {
                    return $"No se puede agregar el ciclo académico {añoActual} porque ya existe un ciclo académico con ese año.";
                }

                // Verifica si existe un ciclo académico con el año anterior
                int añoAnterior = añoActual - 1;
                var cicloAnterior = sistemaColegio.CiclosAcademicos.FirstOrDefault(x => x.Año == añoAnterior);
                if (cicloAnterior == null)
                {
                    return $"No se puede agregar el ciclo académico {añoActual} porque no existe el ciclo académico con año {añoAnterior}. Debes agregar los ciclos académicos en orden consecutivo.";
                }

                // Verifica si existe un ciclo académico con el año posterior
                int añoPosterior = añoActual + 1;
                var cicloPosterior = sistemaColegio.CiclosAcademicos.FirstOrDefault(x => x.Año == añoPosterior);
                if (cicloPosterior != null)
                {
                    return $"No se puede agregar el ciclo académico {añoActual} porque ya existe un ciclo académico con año {añoPosterior}. Debes agregar los ciclos académicos en orden consecutivo.";
                }

                // Agrega el ciclo académico
                sistemaColegio.CiclosAcademicos.Add(cicloAcademico);
                sistemaColegio.SaveChanges();
                return "Ciclo académico agregado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el ciclo académico: {ex.Message}";
            }
        }

        public ReadOnlyCollection<CicloAcademico> ListarCiclosAcademicos()
        {
            try
            {
                return sistemaColegio.CiclosAcademicos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public CicloAcademico? ObtenerCicloAcademico(int cicloAcademicoId)
        {
            try
            {
                var cicloAcademicoEncontrado = sistemaColegio.CiclosAcademicos.FirstOrDefault(x => x.CicloAcademicoId == cicloAcademicoId);
                return cicloAcademicoEncontrado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
