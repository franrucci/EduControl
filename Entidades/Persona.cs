using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Domicilio {  get; set; }
        public string Localidad {  get; set; }
        public int CodigoPostal {  get; set; }
        public string Provincia {  get; set; }
        public string Pais {  get; set; }
        public string Email {  get; set; }
        public Sexo Sexo { get; set; }

        //----------------------------------------
        public int PersonaId {  get; set; }
        public int SexoId { get; set; }
        //----------------------------------------
    }
}
