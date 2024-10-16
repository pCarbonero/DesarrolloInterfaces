using Ejercicio02.Views;
namespace Ejercicio02
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());
        }
    }

}
