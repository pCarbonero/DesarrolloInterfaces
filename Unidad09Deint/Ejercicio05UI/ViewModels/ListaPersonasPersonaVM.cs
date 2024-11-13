using DAL05;
using Entidades05;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05UI.ViewModels
{
    internal class ListaPersonasPersonaVM: INotifyPropertyChanged
    {
        #region atributos
        private clsPersona personaSeleccionada;
        #endregion
        #region propiedades
        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value; notifyPropertyChanged(); }
        }
        public ObservableCollection<clsPersona> ListaPersonas { get; }
        #endregion
        #region constructores
        public ListaPersonasPersonaVM()
        {
            try
            {
                ListaPersonas = new ObservableCollection<clsPersona>(clsListados.listadoPersonas());
            }
            catch (Exception ex)
            {
                // TODO: mostrar mensaje de ERROU $%&LAVICBIDNIINMLAVICBIDNIINM$%&
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
