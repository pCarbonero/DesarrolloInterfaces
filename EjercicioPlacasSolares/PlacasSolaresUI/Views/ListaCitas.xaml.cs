namespace PlacasSolaresUI.Views;

public partial class ListaCitas : ContentPage
{
	public ListaCitas()
	{
		InitializeComponent();
	}

	public void onItemSelected(object sender, SelectedItemChangedEventArgs args)
	{
        Navigation.PushAsync(new CitaDetalle());
    }
}