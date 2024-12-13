using BL;
using Modelos;
using NoBuscaMinasUI.ViewModel.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBuscaMinasUI.ViewModel
{
    public class MinasVM: Notify
    {
        #region atributos
        private ObservableCollection<clsCelda> listaCeldas;
        private clsCelda celdaSeleccionada;
        private int dificultad = 1;
        private int aciertos = 0;
        private int fallos = 0;
        private int numIntentos = 0;
        #endregion

        #region propiedades
        public ObservableCollection<clsCelda> ListaCeldas { get { return listaCeldas; } set { listaCeldas = value; } }
        public clsCelda CeldaSeleccionada 
        { 
            get { return celdaSeleccionada; } 
            set 
            { 
                celdaSeleccionada = value;   
                comprobarIntento();
            } 
        }
        public int Aciertos { get { return aciertos; } }
        public int Fallos { get { return fallos; } }
        public int NumIntentos { get { return numIntentos; } }
        #endregion

        public MinasVM()
        {
            listaCeldas = new ObservableCollection<clsCelda>(clsListadoBL.listadoDeCeldas(dificultad));
        }

        /// <summary>
        /// Funcion que se encarga de comprobar si la carta elegida por el jugador es correcta o no. Ademas de cambiar la imagen de la carat a la correspondiente
        /// </summary>
        private void comprobarIntento()
        {
            if (celdaSeleccionada != null && celdaSeleccionada.EsRevelado == false)
            {
                celdaSeleccionada.EsRevelado = true;

                if (celdaSeleccionada.EsBomba)
                {
                    celdaSeleccionada.Imagen = "bomb_card.png";
                    fallos++;
                    NotifyPropertyChanged("Fallos");
                }
                else
                {
                    celdaSeleccionada.Imagen = "blank_card.png";
                    aciertos++;
                    NotifyPropertyChanged("Aciertos");
                }
                numIntentos++;
            }
        }
    }
}
