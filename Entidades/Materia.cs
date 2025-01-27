using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        public GradoAcademico GradoAcademico { get; set; }
        public string NombreMateria {  get; set; }
        public string CodigoMateria { get; set; }
        public List<Examen> Examenes { get; set; }
        //----------------------------------------
        public int MateriaId { get; set; }
        public int GradoAcademicoId { get; set; }
        //----------------------------------------
    }
}
