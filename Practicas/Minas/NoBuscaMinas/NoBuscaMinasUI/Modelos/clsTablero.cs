using BL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBuscaMinasUI.Modelos
{
    public class clsTablero
    {
        private ObservableCollection<clsCelda> listaCeldas;
        private int dificultad;
        private int numCeldas;
        private int numBombas;
        private int numCorrectas;
        

        public ObservableCollection<clsCelda> ListaCeldas { get { return listaCeldas; } set { listaCeldas = value; } }

        public clsTablero(int dificultad)
        {
            this.dificultad = dificultad;
            listaCeldas = new ObservableCollection<clsCelda>(clsListadoBL.listadoDeCeldas(dificultad));
        }
    }
}
