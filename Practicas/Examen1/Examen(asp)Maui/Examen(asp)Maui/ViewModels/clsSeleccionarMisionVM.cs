using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;
using BL;
using Entidades;
using Examen_asp_Maui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen_asp_Maui.ViewModels
{
    public class clsSeleccionarMisionVM: INotifyPropertyChanged
    {
        #region atributos
        private ObservableCollection<clsCandidatoEdad> listaCandidatosEdad;
        private List<clsCandidato> listaCandidatos;
        private List<clsMision> listadoMisiones;

        private clsMision misionSeleccionada;
        private clsCandidatoEdad candidatoSeleccionado;

        private DelegateCommand detallesCommand;

        #endregion

        #region Propiedades
        public ObservableCollection<clsCandidatoEdad> ListaCandidatosEdad 
        {
            get { return listaCandidatosEdad; } 
            set 
            {
                listaCandidatosEdad = value;
            }
        }
        public List<clsMision> ListadoMisiones { get { return listadoMisiones; } }

        public clsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set 
            { 
                misionSeleccionada = value;
                rellenarListaCandidatos();
            }
        }

        public clsCandidatoEdad CandidatoSeleccionado
        {
            get { return candidatoSeleccionado; }
            set { value = candidatoSeleccionado; }
        }

        public DelegateCommand DetallesCommand
        {
            get { return detallesCommand; }
        }
        #endregion

        #region constructores
        public clsSeleccionarMisionVM()
        {
            listaCandidatosEdad = new ObservableCollection<clsCandidatoEdad>();
            listadoMisiones = clsListadosBL.listadoCompletoMisionesBL();
            detallesCommand = new DelegateCommand(detallesExecute, detallesCanExecute);
        }
        #endregion

        #region Command
        /// <summary>
        /// Funcion que se encarga de ejecutar las instrucciones del comando
        /// </summary>
        public async void detallesExecute()
        {

        }

        /// <summary>
        /// Metodo que comprueba si el comando verCandidatos se puede ejecutar
        /// </summary>
        /// <returns></returns>
        public bool detallesCanExecute()
        {
            bool canExecute = false;
            if (misionSeleccionada != null)
            {
                canExecute = true;
            }
            return canExecute;
        }

        #endregion

        #region metodos
        private async void rellenarListaCandidatos()
        {
            try
            {
                listaCandidatos = clsListadosBL.listadoCandidatosParaMision(misionSeleccionada.Dificultad);
                listaCandidatosEdad.Clear();
                foreach (clsCandidato candidato in listaCandidatos)
                {
                    listaCandidatosEdad.Add(new clsCandidatoEdad(candidato));
                }
                NotifyPropertyChanged("ListaCandidatosEdad");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
            }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
