using PlacasSolaresUI.ViewModels;
using PlacasSolaresUI.Views;

namespace PlacasSolaresUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
