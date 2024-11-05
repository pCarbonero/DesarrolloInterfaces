using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolaresUI.ViewModels
{
    public class CitaDetalleVM
    {
        public ClsCita Cita { set; get; }
        public CitaDetalleVM() 
        {
            Cita = new ClsCita(DateTime.Today,
            new TimeOnly(9, 30), false, "", "Pablo Carbonero", "C/ Hiro-no-miya Naruhito nº126");
        }
    }
}
