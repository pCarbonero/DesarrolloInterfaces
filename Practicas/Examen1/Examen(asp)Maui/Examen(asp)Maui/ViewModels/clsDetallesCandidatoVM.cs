using Examen_asp_Maui.Models;
using Examen_asp_Maui.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_asp_Maui.ViewModels
{
    [QueryProperty(nameof(Candidato), "Candidato")]
    public class clsDetallesCandidatoVM: Notify
    {
        private clsCandidatoEdad candidato;

        public clsCandidatoEdad Candidato 
        { 
            get {  return candidato; } 
            set { candidato = value; NotifyPropertyChanged("Candidato"); }
        }
        public clsDetallesCandidatoVM() { }
    }
}
