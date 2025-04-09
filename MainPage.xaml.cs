using MauiApp6.pages;
namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ljekoviClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductListPage());
        }

        private async void cartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage());
        }
    }
}

