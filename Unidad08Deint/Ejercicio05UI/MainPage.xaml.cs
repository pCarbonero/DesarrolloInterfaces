using Ejercicio05DAL;
using Ejercicio05ENT;
using System.Collections.ObjectModel;

namespace Ejercicio05UI
{
    public partial class MainPage : ContentPage
    {
        public List<ClsPersona> lista;
        public MainPage()
        {
            InitializeComponent();

            lista = ClsListaPersonas.listaPersonas();

            listaView.ItemsSource = lista;
        }
    }

}
