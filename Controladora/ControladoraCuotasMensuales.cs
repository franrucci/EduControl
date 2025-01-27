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
    public class ControladoraCuotasMensuales
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraCuotasMensuales instancia;

        public static ControladoraCuotasMensuales Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCuotasMensuales();
                }
                return instancia;
            }
        }

        ControladoraCuotasMensuales()
        {
            sistemaColegio = new SistemaColegio();
        }

        public ReadOnlyCollection<Cuota> ListarCuotasPorAño(CicloAcademico ciclo)
        {
            try
            {
                return sistemaColegio.Cuotas
                    .Where(c => c.CicloAcademicoId == ciclo.CicloAcademicoId)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string RegistrarCuota(Cuota cuota)
        {
            try
            {
                // Valida si ya existe una cuota en el mismo año del ciclo académico y mes
                var ciclo = sistemaColegio.CiclosAcademicos
                    .FirstOrDefault(c => c.CicloAcademicoId == cuota.CicloAcademico.CicloAcademicoId);

                if (ciclo == null)
                {
                    return $"Error: No se encontró el ciclo académico con ID {cuota.CicloAcademicoId}.";
                }

                var cuotaExistente = sistemaColegio.Cuotas
                    .FirstOrDefault(c => c.CicloAcademicoId == cuota.CicloAcademico.CicloAcademicoId && c.Mes == cuota.Mes);

                if (cuotaExistente != null)
                {
                    return $"Error: Ya existe una cuota registrada para el ciclo académico {ciclo.Año} en el mes {cuota.Mes}.";
                }

                // Valida si el mes anterior existe para el mismo ciclo académico
                if (cuota.Mes > 1)
                {
                    var cuotaMesAnterior = sistemaColegio.Cuotas
                        .FirstOrDefault(c => c.CicloAcademicoId == cuota.CicloAcademico.CicloAcademicoId && c.Mes == cuota.Mes - 1);

                    if (cuotaMesAnterior == null)
                    {
                        return $"Error: No se puede registrar la cuota para el mes {cuota.Mes} del ciclo académico {ciclo.Año} porque falta registrar la cuota del mes {cuota.Mes - 1}.";
                    }
                }

                cuota.CicloAcademico = ciclo;

                sistemaColegio.Cuotas.Add(cuota);
                sistemaColegio.SaveChanges();

                return "Cuota registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error al intentar registrar la cuota: {ex.Message}";
            }
        }

        public List<Cuota> ObtenerCuotasImpagas(Alumno alumno)
        {
            try
            {
                // Obtiene los años de los boletines del alumno
                var añosBoletines = sistemaColegio.Boletines
                    .Where(b => b.PersonaId == alumno.PersonaId)
                    .Select(b => b.Año)
                    .Distinct()
                    .ToList();

                // Busca todas las cuotas correspondientes a esos años
                var cuotas = sistemaColegio.Cuotas
                    .Include(c => c.CicloAcademico)
                    .Where(c => añosBoletines.Contains(c.CicloAcademico.Año))
                    .ToList();

                // Filtra las cuotas que no han sido pagadas
                var cuotasImpagas = cuotas.Where(c =>
                    !sistemaColegio.PagosDeCuota
                    .Any(pc => pc.CuotaId == c.CuotaId && pc.AlumnoId == alumno.PersonaId))
                    .ToList();

                return cuotasImpagas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener las cuotas impagas: {ex.Message}");
                return new List<Cuota>();
            }
        }

        public Cuota ObtenerCuotaPorId(int cuotaId)
        {
            try
            {
                    // Busca la cuota por ID
                    return sistemaColegio.Cuotas.Include(c => c.CicloAcademico).FirstOrDefault(c => c.CuotaId == cuotaId);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al obtener la cuota: {ex.Message}");
                return null;
            }
        }
    }
}
