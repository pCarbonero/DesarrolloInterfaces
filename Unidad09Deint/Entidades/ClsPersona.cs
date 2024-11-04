using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class ClsPersona
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
