using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boletin
    {
        public Alumno Alumno { get; set; }
        public LibroDeNotas LibroDeNotas { get; set; }
        public LibroDeAsistencias LibroDeAsistencias { get; set; }
        public decimal PromedioAsistenciaTrimestre1 {  get; set; }
        public decimal PromedioAsistenciaTrimestre2 { get; set; }
        public decimal PromedioAsistenciaTrimestre3 { get; set; }
        public decimal PromedioTotalAsistencia {  get; set; }
        public decimal PromedioTrimestre1 {  get; set; }
        public decimal PromedioTrimestre2 { get; set; }
        public decimal PromedioTrimestre3 { get; set; }
        public decimal PromedioTotalExamenes {  get; set; }
        public string ObservacionTrimestre1 { get; set; }
        public string ObservacionTrimestre2 { get; set; }
        public string ObservacionTrimestre3 { get; set; }
        public EstadoFinal EstadoFinal { get; set; }
        public int Año {  get; set; }
        public int numGrado {  get; set; }
        public bool Activo {  get; set; }
        public bool BoletinCerrado1 {  get; set; }
        public bool BoletinCerrado2 { get; set; }
        public bool BoletinCerrado3 { get; set; }

        //----------------------------------------
        public int BoletinId {  get; set; }
        public int PersonaId {  get; set; }
        public int LibroDeNotasId {  get; set; }
        public int LibroDeAsistenciasId {  get; set; }
        public int EstadoFinalId {  get; set; }
        //----------------------------------------
    }
}
