using PlacasSolaresUI.ViewModels;
using PlacasSolaresUI.Views;

namespace PlacasSolaresUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        public void onClick(object sender, EventArgs e)
        {
            if (BindingContext is ClsLoginVM vm)
            {
                if (vm.correctLogIn())
                {
                    Navigation.PushAsync(new ListaCitas());
                    textError.IsVisible = false;
                }
                else
                {
                    textError.IsVisible = true;
                }
            }
        }
    }

}
