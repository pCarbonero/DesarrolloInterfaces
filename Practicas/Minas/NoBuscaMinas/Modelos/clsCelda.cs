using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Modelos
{
    public class clsCelda: INotifyPropertyChanged
    {
        private string imagen;
        #region Propiedades
        public bool EsBomba {  get; set; }
        public bool EsRevelado { get; set; }
        public string Imagen 
        {
            get { return imagen; } 
            set 
            { 
                imagen = value;
                NotifyPropertyChanged();
            } 
        }
        #endregion

        #region Constructores
        public clsCelda()
        {
            EsBomba = false;
            EsRevelado = false;
            Imagen = "no_revelado.png";
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
