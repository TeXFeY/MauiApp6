using MauiApp6.Models;
using System.Text.Json;
using Microsoft.Maui.Storage;

namespace MauiApp6.pages;
    public partial class ProductDetailPage : ContentPage
{
    private Product product;

    public ProductDetailPage(Product selectedProduct)
    {
        InitializeComponent();
        product = selectedProduct;
        BindingContext = product;
    }

    private void cartClicked(object sender, EventArgs e)
    {
        var cartItemsJson = Preferences.Get("CartItems", null);
        var cartItems = string.IsNullOrEmpty(cartItemsJson)
                        ? new List<Product>()
                        : JsonSerializer.Deserialize<List<Product>>(cartItemsJson);

        cartItems.Add(product);

        var updatedCartJson = JsonSerializer.Serialize(cartItems);
        Preferences.Set("CartItems", updatedCartJson);

        DisplayAlert("Košarica", $"{product.Name} je dodan u košaricu!", "OK");
    }
}

