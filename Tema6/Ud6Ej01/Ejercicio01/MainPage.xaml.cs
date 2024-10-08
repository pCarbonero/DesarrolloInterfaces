namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Button button;

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
            if (button == null)
            {
                button = new Button
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
                    mainStack.Children.Remove(btnBoton1);
                    btnBoton2.Text = "Crear controles en tiempo de ejecución mola";
                    btnBoton2.Clicked -= (sender, args) => { };

                };

                mainStack.Children.Add(button);
            }
           
        }
    }
}

