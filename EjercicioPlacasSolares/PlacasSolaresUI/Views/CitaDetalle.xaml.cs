namespace PlacasSolaresUI.Views;

public partial class CitaDetalle : ContentPage
{
	public CitaDetalle()
	{
		InitializeComponent();
	}

	public void onClickLocation(object sender, EventArgs e)
	{
        var location = new Location(47.645160, -122.1306032);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };
        try
        {
            Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void onClickImages(object sender, EventArgs e)
    {
        MediaPicker.PickPhotoAsync();
    }
}