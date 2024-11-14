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

        #endregion

        #region propiedades
        public ObservableCollection<clsPersona> ListaCompleta { get;}
        public ObservableCollection<clsPersona> ListaFiltrada { get; set; }


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
            set { listaPersonas = value; notifyPropertyChanged("ListaPersonas"); }
        }
        #endregion

        #region constructores
        public BorrarPersonaVM()
        {
            try
            {
                ListaCompleta = new ObservableCollection<clsPersona>(clsListados.listadoPersonas());
                ListaPersonas = ListaCompleta;
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

        public void ExecuteEliminar()
        {
           ListaPersonas.Remove(PersonaSeleccionada);
        }

        private bool CanExecuteBuscar()
        {
            bool sePuede = true;
            if (String.IsNullOrEmpty(nombrePersona))
            {
                sePuede = false;
                ListaPersonas = ListaCompleta;
            }
            return sePuede;
        }

        public void ExecuteBuscar()
        {
            ListaFiltrada = new ObservableCollection<clsPersona>(clsListados.listadoFiltrado(NombrePersona));
            ListaPersonas = ListaFiltrada;
        }
        #endregion
    }
}
