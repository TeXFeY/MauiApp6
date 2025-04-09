using MauiApp6.Models;
using System.Text.Json;
using Microsoft.Maui.Storage;
using Microsoft.Maui.Controls;
namespace MauiApp6.pages;

    public partial class ProductListPage : ContentPage
{
    private List<Product> products;

    public ProductListPage()
    {
        InitializeComponent();
        LoadProducts();
    }

    private void LoadProducts()
    {
        products = new List<Product>
            {
                new Product {
    Name = "Aspirin",
    Price = 1.5,
    ImageUrl = "aspirin.jpeg",
    Description = "Aspirin je poznat lijek koji se koristi za ublažavanje boli, snižavanje temperature i smanjenje upala. Dostupan je u obliku tableta i djeluje brzo na ublažavanje blagih do umjerenih bolova."
},
new Product {
    Name = "Paracetamol",
    Price = 1.0,
    ImageUrl = "paracetamol.jpeg",
    Description = "Paracetamol je blag analgetik i antipiretik koji pomaže u smanjenju temperature i ublažavanju bolova. Koristi se za liječenje blagih bolova poput glavobolje, bolova u mišićima i prehlade."
},
new Product {
    Name = "Ibuprofen",
    Price = 2.5,
    ImageUrl = "ibuprofen.jpeg",
    Description = "Ibuprofen je nesteroidni protuupalni lijek (NSAID) koji se koristi za smanjenje upala, bolova i groznice. Koristi se za liječenje bolova u zglobovima, mišićima, glavobolje i menstrualnih bolova."
},
new Product {
    Name = "Antibiotik",
    Price = 2.0,
    ImageUrl = "antibiotik.jpeg",
    Description = "Antibiotici su lijekovi koji se koriste za liječenje bakterijskih infekcija. Djeluju tako da ubijaju bakterije ili usporavaju njihov rast, pomažući tijelu u borbi protiv infekcija."
},
new Product {
    Name = "Vitamina C",
    Price = 2.0,
    ImageUrl = "vitamina_c.jpeg",
    Description = "Vitamin C je esencijalni nutrijent koji jača imunološki sustav i pomaže u borbi protiv infekcija. Također je važan za zdravlje kože, kostiju i krvnih žila, te djeluje kao antioksidans."
},
new Product {
    Name = "Antialergik",
    Price = 1.3,
    ImageUrl = "antialergik.jpeg",
    Description = "Antialergici su lijekovi koji se koriste za ublažavanje simptoma alergija, kao što su kihanje, svrbež i suzenje očiju. Djeluju tako da blokiraju učinke histamina u tijelu."
},
new Product {
    Name = "Laksativ",
    Price = 3.0,
    ImageUrl = "laksativ.jpeg",
    Description = "Laksativi su lijekovi koji se koriste za olakšavanje prolaska stolice i liječenje zatvora. Pomažu u stimulaciji crijeva i olakšavaju redovito pražnjenje crijeva."
}
            };

        productCollectionView.ItemsSource = products;
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var product = button?.CommandParameter as Product;

        if (product != null)
        {
            await Navigation.PushAsync(new ProductDetailPage(product));
        }
    }
}
