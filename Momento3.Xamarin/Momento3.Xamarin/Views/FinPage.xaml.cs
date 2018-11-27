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
	public partial class FinPage : ContentPage
	{
		public FinPage (Producto producto, Talla talla, int cantidad)
		{
			InitializeComponent ();
            gridPelicula.BindingContext = producto;
            gridFuncion.BindingContext = talla;
            Cantidad.Text = cantidad.ToString();
            TotalPagar.Text = (cantidad * producto.Precio).ToString();
        }

        private async void Finalizar_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Felicitaciones!", "La reserva se ha realizado correctamente", "OK");
        }
    }
}