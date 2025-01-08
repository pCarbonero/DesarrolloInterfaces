using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPokemon.ViewModels
{
    public class VmListaPokemon
    {
        private ObservableCollection<clsPokemon> listaPokemon;

        public ObservableCollection<clsPokemon> ListaPokemon;


        public VmListaPokemon()
        {
            //listaPokemon = new ObservableCollection<clsPokemon>(clsServices.getListaPokemon());
        }
    }
}
