namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool btnCreado = false;

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funcion que hace referencia a cuando se pulsa el boton 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void btn2Clicked(object sender, EventArgs args)
        {
            if (!btnCreado)
            {
                btnCreado = true;
                Button button = new Button
                {
                    Text = "Boton 3",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    MaximumHeightRequest = 70,
                    MaximumWidthRequest = 200,
                    FontFamily = "Verdana",
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold,
                    BorderColor = Colors.Yellow,
                    Margin = 30,
                    BackgroundColor = Colors.Blue
                };

                button.Clicked += (sender, args) =>
                {
                    VerticalStack.Children.Remove(btnBoton1);
                    btnBoton2.Text = "Crear controles en tiempo de ejecución mola";
                    btnBoton2.Clicked -= (sender, args) => { };
                    btnBoton2.MaximumHeightRequest = 200;
                    btnBoton2.MaximumWidthRequest = 500;

                };

                VerticalStack.Children.Add(button);
            }
        }
    }
}

