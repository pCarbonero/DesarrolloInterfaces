using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03UI.ViewModels
{
    internal class NombreVM
    {
        private ClsPersona p = new ClsPersona();

        public NombreVM() { }
        public NombreVM(ClsPersona p) { this.p = p; }
    }
}
