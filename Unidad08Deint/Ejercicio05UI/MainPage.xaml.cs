using Ejercicio05DAL;
using Ejercicio05ENT;
using System.Collections.ObjectModel;

namespace Ejercicio05UI
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<ClsPersona> lista = new ObservableCollection<ClsPersona>();

            lista = ClsListaPersonas.listaPersonas();

            listaView.ItemsSource = lista;
        }
    }

}
