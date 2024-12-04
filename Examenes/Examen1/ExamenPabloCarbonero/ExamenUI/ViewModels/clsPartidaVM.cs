using BL;
using DAL;
using Entidades;
using ExamenUI.Models;
using ExamenUI.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUI.ViewModels
{
    public class clsPartidaVM: Notify
    {
        #region atributos
        private Random numAleatorio = new Random();
        private int partidasJugadas = 0;
        private List<clsCandidato> listaCandidatos;
        private List<clsCandidatoConFoto> listaOpcionesCorrectas;
        private ObservableCollection<clsCandidato> listaOpciones;
        private clsCandidatoConFoto candidatoCorrecto;
        private clsCandidato candidatoElegido;
        private int aciertos = 0;
        private int fallos = 0;
        private bool fin = false;
        private string mensajeAcierto;
        private DelegateCommand reiniciarCommand;
        #endregion

        #region propiedades
        public ObservableCollection<clsCandidato> ListaOpciones { get { return listaOpciones; } }
        public clsCandidatoConFoto CandidatoCorrecto { get { return candidatoCorrecto; } }
        public clsCandidato CandidatoElegido 
        {
            get {  return candidatoElegido; }
            set 
            { 
                candidatoElegido = value;
                //NotifyPropertyChanged("CandidatoElegido");
                comprobarResultado(); 
            }
        }
        public int Aciertos { get { return aciertos; } }
        public int Fallos { get { return fallos; } }
        public bool Fin { get { return fin; } }
        public string MensajeAcierto
        {
            get { return mensajeAcierto; }
        }

        public DelegateCommand ReiniciarCommand { get { return reiniciarCommand; } } 
        #endregion

        #region Constructor
        public clsPartidaVM()
        {
            cargarNuevaPartida();
        }
        #endregion

        #region Command
        /// <summary>
        /// He intentado que el boton cargue la partida de nuevo llamando a la funcion cargarNuevaPartida la cual carga todo de 0
        /// </summary>
        public void reiniciarExecute()
        {
            cargarNuevaPartida();
        }
        #endregion


        #region Metodos

        /// <summary>
        /// Metodo que se encarga de cargar todas las listas y datos para el comienzo de una partida
        /// </summary>
        private async void cargarNuevaPartida()
        {
            try
            {
                fin = false;
                listaCandidatos = clsListadosBL.listadoCompletoCandidatosBL();
                listaOpcionesCorrectas = new List<clsCandidatoConFoto>();
                listaOpciones = new ObservableCollection<clsCandidato>();
                reiniciarCommand = new DelegateCommand(reiniciarExecute);

                foreach (clsCandidato candidato in listaCandidatos)
                {
                    listaOpcionesCorrectas.Add(new clsCandidatoConFoto(candidato));
                }
                aciertos = 0;
                fallos = 0;
                partidasJugadas = 0;
                NotifyPropertyChanged("Fallos");
                NotifyPropertyChanged("Aciertos");
                generarCandidatoCorrecto();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", "Error inesperado. Intentalo más tarde", "OK");
            }
        }

        /// <summary>
        /// Metodo privado que se encarga de elegir una nueva opcion correcta y la elimina de la lista
        /// </summary>
        private void generarCandidatoCorrecto()
        {
            int num = numAleatorio.Next(1, listaOpcionesCorrectas.Count);

            candidatoCorrecto = listaOpcionesCorrectas[num];

            listaOpcionesCorrectas.Remove(candidatoCorrecto);

            NotifyPropertyChanged("CandidatoCorrecto");

            generarListaOpciones();
        }

        /// <summary>
        /// Metodo estatico que se encarga de rellenar la lista con una opcion correcta y 3 incorrectas 
        /// </summary>
        private void generarListaOpciones()
        {
            // intente que la opcion correcta estuviera en una posicion aleatoria y que no pudiera repetirse ningua opcion pero no me dio tiempo

            listaOpciones.Clear();
            listaOpciones.Add(candidatoCorrecto);

            for (int i = 0; i < 3; i++)
            {
                listaOpciones.Add(listaCandidatos[numAleatorio.Next(1,listaCandidatos.Count)]);
            }

            NotifyPropertyChanged("ListaOpciones");
        }

        /// <summary>
        /// Metodo que se encarga de comprobar si la respuesta de tony es correcta
        /// </summary>
        private void comprobarResultado()
        {

            if (candidatoElegido != null)
            {
                if (candidatoElegido.Id == candidatoCorrecto.Id)
                {
                    aciertos++;
                    NotifyPropertyChanged("Aciertos");
                    mensajeAcierto = "Has acertado";
                }
                else
                {
                    fallos++;
                    NotifyPropertyChanged("Fallos");
                    mensajeAcierto = "Has fallado";                 
                }
                NotifyPropertyChanged("MensajeAcierto");
                partidasJugadas++;
                generarCandidatoCorrecto();
                comprobarFin();
            }
        }

        /// <summary>
        /// Funcion que comprueba si se debe terminar la partida
        /// </summary>
        private void comprobarFin()
        {
            if(partidasJugadas == 5)
            {
                listaOpciones.Clear();
                NotifyPropertyChanged("ListaOpciones");
                fin = true;
                NotifyPropertyChanged("Fin");
            }
        }

        #endregion
    }
}
