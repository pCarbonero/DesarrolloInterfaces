﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClsCita
    {
        #region Propiedades
        public DateTime Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        public bool EsApta { get; set; }
        public string Observaciones { get; set; }
        public ClsCliente Cliente { get; set; }
        #endregion

        #region Constructores
        public ClsCita() { }
        public ClsCita(DateTime fecha, TimeOnly hora, bool esApta, string observaciones, ClsCliente cliente)
        {
            Fecha = fecha;
            Hora = hora;
            EsApta = esApta;
            Observaciones = observaciones;
            Cliente = cliente;
        }

        #endregion
    }
}
