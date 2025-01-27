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
    public class ControladoraLibrosDeNotas
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraLibrosDeNotas instancia;

        public static ControladoraLibrosDeNotas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraLibrosDeNotas();
                }
                return instancia;
            }
        }

        ControladoraLibrosDeNotas()
        {
            sistemaColegio = new SistemaColegio();
        }

        public LibroDeNotas RecuperarLibroAlumno(Boletin boletin)
        {
            try
            {
                var libroDeNotasEncontrado = sistemaColegio.LibrosDeNotas.Include(l => l.Examenes).FirstOrDefault(x => x.BoletinId == boletin.BoletinId);
                return libroDeNotasEncontrado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
