using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolaresUI.ViewModels
{
    internal class ClsLoginVM
    {
        #region atributes
        private string username;
        private string password;
        #endregion

        #region propiedades
        public string Username
        {
            get { return username; }
            set { username = value; NotifyPropertyChanged("Username"); }
        }
        public string Password
        {

            get { return password; }
            set { password = value; NotifyPropertyChanged("Password"); }

        }
        #endregion  

        #region metodos
        /// <summary>
        /// Metodo privado que devuelve si es posible o no logearse
        /// </summary>
        /// <returns>boolean si se puede o no</returns>
        public bool correctLogIn()
        {
            bool isCorrect = false;

            if (!String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(Password))
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        #endregion       

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
