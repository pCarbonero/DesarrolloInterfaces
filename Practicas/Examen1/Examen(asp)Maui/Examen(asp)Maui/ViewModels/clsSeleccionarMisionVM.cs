using BL;
using Entidades;
using Examen_asp_Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_asp_Maui.ViewModels
{
    public class clsSeleccionarMisionVM
    {
        #region atributos
        private List<clsCandidatoEdad> listaCandidatosEdad;
        private List<clsCandidato> listaCandidatos;
        private List<clsMision> listadoMisiones;

        clsMision misionSeleccionada;
        clsCandidatoEdad candidatoSeleccionado;

        #endregion

        #region Propiedades
        public List<clsCandidatoEdad> ListaCandidatosEdad { get { return listaCandidatosEdad; } }
        public List<clsMision> ListadoMisiones { get { return listadoMisiones; } }

        public clsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set { misionSeleccionada = value; }
        }

        public clsCandidatoEdad CandidatoSeleccionado
        {
            get { return candidatoSeleccionado; }
            set { value = candidatoSeleccionado; }
        }

        #endregion

        public clsSeleccionarMisionVM()
        {
            listaCandidatosEdad = new List<clsCandidatoEdad>();
            listadoMisiones = clsListadosBL.listadoCompletoMisionesBL();
        }
    }
}
