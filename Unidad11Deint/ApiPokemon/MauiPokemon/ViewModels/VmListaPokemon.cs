﻿using MauiPokemon.ViewModels.Utilidades;
using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudMaui.ViewModels.Utilities;
using System.ComponentModel;

namespace MauiPokemon.ViewModels
{
    public class VmListaPokemon: Notify
    {
        #region atributos
        private clsRespuesta respuesta;
        private ObservableCollection<clsPokemon> listaPokemon;
        private DelegateCommand rellenarLista;
        private DelegateCommand avanzar;
        private DelegateCommand regresar;
        #endregion

        #region propiedades
        public ObservableCollection<clsPokemon> ListaPokemon
        {
            get { return listaPokemon; }
            set { listaPokemon = value; }
        }

        public DelegateCommand RellenarLista
        {
            get { return rellenarLista; }
        }
        public DelegateCommand Avanzar
        {
            get { return avanzar; }
        }
        public DelegateCommand Regresar
        {
            get { return regresar; }
        }
        #endregion

        #region constructor
        public VmListaPokemon()
        {
            rellenarLista = new DelegateCommand(rellenarListaExecute);
            avanzar = new DelegateCommand(avanzarExecute);
            regresar = new DelegateCommand(regresarExecute);
        }

        public int Limit { get; set; }
        public int Offset { get; set; }
        #endregion

        #region metodos
        public async void rellenarListaExecute()
        {
            try
            {
                if (Offset > 0)
                {
                    Offset = Offset - 1;
                }
                respuesta = await clsServices.getListaPokemon(Limit, Offset);
                listaPokemon = new ObservableCollection<clsPokemon>(respuesta.results);
                NotifyPropertyChanged("ListaPokemon");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Intentalo más tarde.", "OK");
            }
            
        }

        public async void avanzarExecute()
        {

        }

        public async void regresarExecute()
        {

        }
        #endregion
    }
}
