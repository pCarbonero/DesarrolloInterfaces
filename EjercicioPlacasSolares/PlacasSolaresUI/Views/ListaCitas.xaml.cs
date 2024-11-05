namespace PlacasSolaresUI.Views;

public partial class ListaCitas : ContentPage
{
	public ListaCitas()
	{
		InitializeComponent();
	}

	public void onClickLogOut(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());
    }

	public void onItemSelected(object sender, SelectedItemChangedEventArgs args)
	{
        Navigation.PushAsync(new CitaDetalle());
    }
}