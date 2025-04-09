using MauiApp6.Models;
using System.Text.Json;

namespace MauiApp6.pages;


    public partial class CartPage : ContentPage
{
    private List<Product> cartItems;

    public CartPage()
    {
        InitializeComponent();
        LoadCartItems();
    }

    private void LoadCartItems()
    {
        var cartItemsJson = Preferences.Get("CartItems", null);
        if (cartItemsJson != null)
        {
            cartItems = JsonSerializer.Deserialize<List<Product>>(cartItemsJson);
        }
        else
        {
            cartItems = new List<Product>();
        }

        cartItemsCollectionView.ItemsSource = cartItems;
    }

    private void OnRemoveFromCartClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var product = button?.BindingContext as Product;

        if (product != null)
        {
            cartItems.Remove(product);

            var updatedCartJson = JsonSerializer.Serialize(cartItems);
            Preferences.Set("CartItems", updatedCartJson);

            cartItemsCollectionView.ItemsSource = null;
            cartItemsCollectionView.ItemsSource = cartItems;
        }
    }

    private async void OnCheckoutClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Kupovina", "Kupovina je dovršena!", "OK");
    }
}

