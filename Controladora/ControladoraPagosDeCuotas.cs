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
    public class ControladoraPagosDeCuotas
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraPagosDeCuotas instancia;

        public static ControladoraPagosDeCuotas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPagosDeCuotas();
                }
                return instancia;
            }
        }

        ControladoraPagosDeCuotas()
        {
            sistemaColegio = new SistemaColegio();
        }

        public decimal CalcularNuevoMonto(Cuota cuota, DateTime fecha)
        {
            try
            {
                // Verifica si la fecha de pago corresponde al mismo mes o un mes posterior al mes de la cuota
                if ((fecha.Year > cuota.CicloAcademico.Año) ||
                    (fecha.Year == cuota.CicloAcademico.Año && fecha.Month >= cuota.Mes))
                {
                    // Si el día es mayor a 10 y la cuota pertenece al mes correspondiente o posterior
                    if (fecha.Day > 10)
                    {
                        // Aplicamos un 10% de aumento al precio de la cuota
                        return cuota.Precio * 1.10m;
                    }
                }

                // Si no se aplica aumento, retornamos el precio original
                return cuota.Precio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string PagarCuota(PagoDeCuota pagoDeCuota)
        {
            try
            {
                using (var context = new SistemaColegio())
                {
                    // Valida que la cuota exista en la base de datos
                    var cuotaExistente = context.Cuotas
                        .Include(c => c.CicloAcademico)
                        .FirstOrDefault(c => c.CuotaId == pagoDeCuota.Cuota.CuotaId);

                    if (cuotaExistente == null)
                    {
                        return "Error: La cuota especificada no existe.";
                    }

                    pagoDeCuota.Cuota = cuotaExistente;

                    // Valida que no existan cuotas anteriores impagas
                    var cuotasAnteriores = context.Cuotas
                        .Where(c => c.CicloAcademico.Año < cuotaExistente.CicloAcademico.Año ||
                                    (c.CicloAcademico.Año == cuotaExistente.CicloAcademico.Año && c.Mes < cuotaExistente.Mes))
                        .Select(c => c.CuotaId)
                        .ToList();

                    var cuotasImpagas = context.Cuotas
                        .Where(c => cuotasAnteriores.Contains(c.CuotaId) &&
                                    !context.PagosDeCuota.Any(pd => pd.Cuota.CuotaId == c.CuotaId))
                        .ToList();

                    if (cuotasImpagas.Any())
                    {
                        return "Error: Existen cuotas anteriores sin pagar. Primero debe abonar las cuotas anteriores.";
                    }

                    var alumnoExistente = context.Alumnos
                        .FirstOrDefault(a => a.PersonaId == pagoDeCuota.Alumno.PersonaId);

                    if (alumnoExistente == null)
                    {
                        return "Error: El alumno especificado no existe.";
                    }

                    pagoDeCuota.Alumno = alumnoExistente;

                    context.PagosDeCuota.Add(pagoDeCuota);
                    context.SaveChanges();

                    return "El pago se registró exitosamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al registrar el pago: {ex.Message}";
            }
        }
    }
}
