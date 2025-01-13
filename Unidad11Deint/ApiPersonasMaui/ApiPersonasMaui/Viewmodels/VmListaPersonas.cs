using ApiPersonasMaui.Viewmodels.Utils;
using DAL;
using Entidades;
using MauiPokemon.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPersonasMaui.Viewmodels
{
    public class VmListaPersonas: Notify
    {
        #region atributos
        private ObservableCollection<clsPersona> listaPersonas;
        private DelegateCommand getPersonas;
        private DelegateCommand deletePersona;
        private clsPersona personaSeleccionada;
        #endregion

        #region propiedades
        public ObservableCollection<clsPersona> ListaPersonas
        {
            get { return listaPersonas; }
        }

        public DelegateCommand GetPersonas
        {
            get { return getPersonas; }
        }

        public DelegateCommand DeletePersonas
        {
            get { return deletePersona; }
        }

        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set 
            { 
                personaSeleccionada = value;
                deletePersona.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region constructores
        public VmListaPersonas() 
        {
            getPersonas = new DelegateCommand(cargarLista);
            deletePersona = new DelegateCommand(deletePersonaExecute, deletePersonaCanExecute);
        }

        #endregion

        #region metodos
        /// <summary>
        /// Funcion que se encarga de cargar la lsita de personas
        /// </summary>
        private async void cargarLista()
        {
            try
            {
                listaPersonas = new ObservableCollection<clsPersona>(await Services.getListaPersonas());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Intentalo más tarde.", "OK");
            }
            finally
            {
                NotifyPropertyChanged("ListaPersonas");
            }
        }

        private async void deletePersonaExecute()
        {
            bool borrar = await Application.Current.MainPage.DisplayAlert("Borrar?", "QUIERES BORRAR ESA PERSONA?", "ASIES", "NO");

            if (borrar)
            {
                try
                {
                    await Services.deletePersona(personaSeleccionada);
                    cargarLista();
                    personaSeleccionada = null;
                }
                catch (Exception e)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Intentalo más tarde.", "OK");
                }
            }
        }

        private bool deletePersonaCanExecute()
        {
            bool canExecute = false;

            if (PersonaSeleccionada != null)
            {
                canExecute = true;
            }
            return canExecute;
        }

        #endregion
    }
}
