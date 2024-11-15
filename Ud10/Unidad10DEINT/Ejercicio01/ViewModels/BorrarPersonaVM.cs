using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DelegateCommand = _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades.DelegateCommand;

namespace Ejercicio01.ViewModels
{
    internal class BorrarPersonaVM : INotifyPropertyChanged
    {
        #region atributos
        private String nombrePersona = "";
        private clsPersona personaSeleccionada;
        private DelegateCommand eliminar;
        private DelegateCommand buscar;
        private ObservableCollection<clsPersona> listaPersonas;
        private ObservableCollection<clsPersona> listaCompleta;
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

        public string NombrePersona
        {
            get { return nombrePersona; }
            set 
            { 
                nombrePersona = value; 
                notifyPropertyChanged("NombrePersona");
                buscar.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand Eliminar
        {
            get { return eliminar; }
        }

        public DelegateCommand Buscar
        { 
            get { return buscar; }
        }

        public ObservableCollection<clsPersona> ListaPersonas 
        { 
            get { return listaPersonas; } 
        }
        #endregion

        #region constructores
        public BorrarPersonaVM()
        {
            try
            {
                listaCompleta = new ObservableCollection<clsPersona>(clsListados.listadoPersonas());
                listaPersonas = listaCompleta;
                eliminar = new DelegateCommand(ExecuteEliminar, CanExecuteEliminar);
                buscar = new DelegateCommand(ExecuteBuscar, CanExecuteBuscar);
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
        private bool CanExecuteEliminar()
        {
            bool sePuede = true;
            if (personaSeleccionada == null)
            {
                sePuede = false;
            }
            return sePuede;
        }

        public async void ExecuteEliminar()
        {
            bool acepta = await Application.Current.MainPage.DisplayAlert("Borrar persona", "¿Estas seguro de que quieres borrar esta persona?", "Sí", "No");
            ListaPersonas.Remove(PersonaSeleccionada);
        }

        private bool CanExecuteBuscar()
        {
            bool sePuede = true;
            if (String.IsNullOrEmpty(nombrePersona))
            {
                sePuede = false;
                listaPersonas = listaCompleta;
                notifyPropertyChanged("ListaPersonas");
            }
            return sePuede;
        }

        public void ExecuteBuscar()
        {
            listaPersonas = new ObservableCollection<clsPersona>(clsListados.listadoFiltrado(NombrePersona));
            notifyPropertyChanged("ListaPersonas");
        }
        #endregion
    }
}
