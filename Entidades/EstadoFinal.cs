﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoFinal
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public List<Boletin> Boletines { get; set; }

        //----------------------------------------
        public int EstadoFinalId {  get; set; }
        //----------------------------------------
    }
}
