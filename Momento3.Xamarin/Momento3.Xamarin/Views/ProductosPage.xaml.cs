using Momento3.Xamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Momento3.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductosPage : ContentPage
	{
		public ProductosPage ()
		{
			InitializeComponent ();
            CargarProductos();
        }
        private async void CargarProductos()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var request = await client.GetAsync("/api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Producto>>(responseJson);
                listProducto.ItemsSource = listado;
            }
            else
            {
                await DisplayAlert("Lo sentimos!", "Ha ocurrido un error de comunicacion", "OK");
            }
        }

        private async void Producto_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = (Producto)e.SelectedItem;
            await Navigation.PushAsync(new ProductoDetallesPage(producto));
        }
    }
}