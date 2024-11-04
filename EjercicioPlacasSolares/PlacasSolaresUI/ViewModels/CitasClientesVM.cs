using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolaresUI.ViewModels
{
    class CitasClientesVM
    {
        public List<ClsCita> ListaCitas { get; }
        public ClsCita CitaSelected { get; set; }

        public CitasClientesVM() 
        {
            ListaCitas = ClsListas.listaCitas();
        }
       
    }
}
