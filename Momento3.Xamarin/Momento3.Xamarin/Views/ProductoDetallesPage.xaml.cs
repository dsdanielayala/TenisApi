using Momento3.Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Momento3.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductoDetallesPage : ContentPage
	{
        private Producto producto;

        public ProductoDetallesPage (Producto producto)
		{
			InitializeComponent ();
            this.producto = producto;
            BindingContext = producto;
        }

        private async void detalle_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            string cantidad = CantidadBoletas.Text;
            if (string.IsNullOrEmpty(cantidad))
            {
                await DisplayAlert("Validación", "Debe ingresar la cantidad de boletas", "OK");
                return;
            }

            int cant = Convert.ToInt32(cantidad);
            var tallas = (Talla)e.SelectedItem;

            await Navigation.PushAsync(new FinPage(producto, tallas, cant));
        }
    }
}