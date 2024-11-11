using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.ViewModels
{
    public class NombreApellidoTrollVM: INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get { return nombre; }
            set 
            {
                nombre = value;
                
                if (nombre.Contains("n"))
                {
                    apellido = "";
                }
                notifyPropertyChanged("Apellido");
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set 
            {
                apellido = value;
                
                if (apellido.Contains("n"))
                {
                    nombre = "";
                }
                notifyPropertyChanged("Nombre");
            }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void notifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
