namespace formularz;

public partial class NewPage2 : ContentPage
{
    private int imageCount;
    public NewPage2()
	{
		InitializeComponent();
        int imageCount = photosWrap.Children.OfType<Grid>().SelectMany(g => g.Children.OfType<Image>()).Count();
        photoCountLabel.Text = $"Obecna iloœæ zdjêæ: {imageCount}";
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