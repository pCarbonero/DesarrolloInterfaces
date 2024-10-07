using ClasesMauiHM;

namespace MauiHolaMundo
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcion asociada al click del boton saludar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonClicked(object sender, EventArgs e)
        {
            ClsPersona pers = new ClsPersona(); 
            pers.Nombre = entryN.Text;
            pers.Apellidos = await DisplayPromptAsync("Apelidos", "Introduce tus apellidos");

            if (!String.IsNullOrEmpty(pers.Nombre) && !String.IsNullOrEmpty(pers.Apellidos))
            {
                saludo.Text = $"Hola {pers.Nombre} {pers.Apellidos}";
                saludo.TextColor = Colors.Black;
            }
            else
            {
                saludo.Text = $"Nombre o apellido mal introducido ";
                saludo.TextColor = Colors.Red;
            }
        }
    }

}
