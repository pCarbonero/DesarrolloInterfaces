using DAL;
using Entidades;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio01.ViewModels
{
    internal class BorrarPersonaVM: INotifyPropertyChanged
    {
        #region atributos
        private clsPersona personaSeleccionada;
        private DelegateCommand eliminar;
        #endregion

        #region propiedades
        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }

            set 
            { 
                personaSeleccionada = value;
                notifyPropertyChanged("PersonaSeleccionada");
                eliminar.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand Eliminar
        {
            get { return eliminar; }
        }
        public ObservableCollection<clsPersona> ListaPersonas { get; }
        #endregion

        #region constructores
        public BorrarPersonaVM()
        {
            try
            {
                ListaPersonas = new ObservableCollection<clsPersona>(clsListados.listadoPersonas());
                eliminar = new DelegateCommand(Execute, CanExecute);
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

        #region Eventos
        public event EventHandler? CanExecuteChanged;
        private bool CanExecute()
        {
            bool sePuede = true;
            if (personaSeleccionada == null)
            {
                sePuede = false;
            }
            return sePuede;
        }

        public void Execute()
        {
           ListaPersonas.Remove(PersonaSeleccionada);
        }
        #endregion
    }
}
