using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Models.Entidades
{
    internal class ClsPersona: INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; notifyPropertyChanged("Nombre"); }
        }
        #endregion


        #region notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void notifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
