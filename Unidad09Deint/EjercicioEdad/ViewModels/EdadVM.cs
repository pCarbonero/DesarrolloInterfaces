using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEdad.ViewModels
{
    public class EdadVM : INotifyPropertyChanged
    {
        #region Atributos
        private DateTime fechaNac;
        private int edad;
        #endregion

        #region Propiedades
        public DateTime FechaNac { 
            get { return fechaNac; } 
            set { fechaNac = value; NotifyPropertyChanged("Edad"); }       
        }
        public int Edad { 
            get 
            {
                edad = calculaEdad();
                return edad;       
            }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Método que calcula la edad dependiendo de la fecha de nacimiento
        /// </summary>
        /// <returns></returns>
        private int calculaEdad()
        {
            if (FechaNac.DayOfYear < DateTime.Now.DayOfYear)
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }
            else
            {
                edad = (DateTime.Now.Year-1) - FechaNac.Year;
            }

            return edad;
        }
        #endregion
    }
}
