namespace Ejercicio02.Views;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}

    private void onClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pagina2());
    }
}