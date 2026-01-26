namespace formularz;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private async void alert(object sender, EventArgs e)
    {
        var thumbnai = sender as Image;

        if (thumbnai != null)
        {
            await DisplayAlert(
                "Miniatura",
                "Kliknieto w miniature w galerii",
                "OK");
        }
    }
}