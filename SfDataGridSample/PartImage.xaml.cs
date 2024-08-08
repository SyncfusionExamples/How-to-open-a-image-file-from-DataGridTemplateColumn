namespace SfDataGridSample;

public partial class PartImage : ContentPage
{
	public PartImage(string imageUrl)
	{
		InitializeComponent();
		imageView.Source = imageUrl;
	}
}