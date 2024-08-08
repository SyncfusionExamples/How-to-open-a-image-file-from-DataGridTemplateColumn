using Syncfusion.Maui.DataGrid;
using System.Collections;
using System.Reflection;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var imageButton = sender as ImageButton;
            var rowData = (imageButton.BindingContext as Employee);

            if (rowData != null)
            {
                // Assuming you have a method to show the image
                ShowPartImage(rowData.URL);
            }
        }

        private async Task ShowPartImage(string imageUrl)
        {
            // Implement your logic to display the image
            // For example, you can open a new page or a popup with the image
            await Navigation.PushAsync(new PartImage(imageUrl));
        }
    }
}
