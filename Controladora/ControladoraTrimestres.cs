using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTrimestres
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraTrimestres instancia;

        public static ControladoraTrimestres Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTrimestres();
                }
                return instancia;
            }
        }

        ControladoraTrimestres()
        {
            sistemaColegio = new SistemaColegio();
        }

        public string AgregarNuevoTrimestre(Trimestre trimestre)
        {
            try
            {
                // Obtiene el ciclo académico del trimestre
                var cicloAcademico = sistemaColegio.CiclosAcademicos
                    .FirstOrDefault(c => c.CicloAcademicoId == trimestre.CicloAcademico.CicloAcademicoId);

                if (cicloAcademico == null)
                {
                    return "Error: El ciclo académico especificado no existe.";
                }

                // Verifica si ya existe un trimestre con el mismo número en el ciclo académico
                var trimestreExistente = sistemaColegio.Trimestres
                    .FirstOrDefault(t => t.NumTrimestre == trimestre.NumTrimestre
                                        && t.CicloAcademico.CicloAcademicoId == cicloAcademico.CicloAcademicoId);

                if (trimestreExistente != null)
                {
                    return $"Error: Ya existe un trimestre con el número {trimestre.NumTrimestre} en el ciclo académico {cicloAcademico.Año}.";
                }

                // Valida que el número de trimestre sea 1, 2 o 3
                if (trimestre.NumTrimestre < 1 || trimestre.NumTrimestre > 3)
                {
                    return "Error: El número de trimestre debe ser 1, 2 o 3.";
                }

                // Valida que los días totales hábiles sean menor o igual a 63
                if (trimestre.DiasTotalesHabiles > 63)
                {
                    return "Error: El máximo de días hábiles permitidos es 63.";
                }

                // Verifica que los trimestres anteriores esten registrados.
                switch (trimestre.NumTrimestre)
                {
                    case 1: // En el primer trimestre no hace falta validar nada.
                        break;

                    case 2:
                        if (!sistemaColegio.Trimestres.Any(t => t.NumTrimestre == 1 && t.CicloAcademico.CicloAcademicoId == cicloAcademico.CicloAcademicoId))
                        {
                            return "Error: Antes de ingresar el trimestre 2, debe existir el trimestre 1.";
                        }
                        break;

                    case 3:
                        if (!sistemaColegio.Trimestres.Any(t => t.NumTrimestre == 2 && t.CicloAcademico.CicloAcademicoId == cicloAcademico.CicloAcademicoId))
                        {
                            return "Error: Antes de ingresar el trimestre 3, debe existir el trimestre 2.";
                        }
                        break;
                }

                trimestre.CicloAcademico = cicloAcademico;

                sistemaColegio.Trimestres.Add(trimestre);
                sistemaColegio.SaveChanges();

                return "Trimestre agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el trimestre: {ex.Message}";
            }
        }

        public List<Trimestre> ObtenerTrimestres(CicloAcademico cicloAcademico)
        {
            try
            {
                var listaTrimestres = sistemaColegio.Trimestres.Where(x => x.CicloAcademicoId == cicloAcademico.CicloAcademicoId).ToList();
                return listaTrimestres;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
