using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLibrosDeAsistencias
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraLibrosDeAsistencias instancia;

        public static ControladoraLibrosDeAsistencias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraLibrosDeAsistencias();
                }
                return instancia;
            }
        }

        ControladoraLibrosDeAsistencias()
        {
            sistemaColegio = new SistemaColegio();
        }

        public LibroDeAsistencias RecuperarLibroAlumno(Boletin boletin)
        {
            try
            {
                var libroDeAsistenciasEncontrado = sistemaColegio.LibrosDeAsistencias.FirstOrDefault(x => x.BoletinId == boletin.BoletinId);
                return libroDeAsistenciasEncontrado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
