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

        private void ButtonClicked(object sender, EventArgs e)
        {
           ClsPersona pers = new ClsPersona();
           pers.Nombre = entry.Text;
          // string result = await DisplayPromptAsync("Apellidos", "¿Cual es su apellido?");

            /* count++;

             if (count == 1)
                 CounterBtn.Text = $"Clicked {count} time";
             else
                 CounterBtn.Text = $"Clicked {count} times";

             SemanticScreenReader.Announce(CounterBtn.Text);*/
        }
    }

}
