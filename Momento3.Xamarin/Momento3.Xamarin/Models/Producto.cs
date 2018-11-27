using System;
using System.Collections.Generic;
using System.Text;

namespace Momento3.Xamarin.Models
{
    public class Producto
    {
        
        public int Id { get; set; }

      
        public string Nombre { get; set; }
       
        public string Marca { get; set; }
      
        public string Descripcion { get; set; }
        
        public int Precio { get; set; }

        public string Descuento { get; set; }
        
        public string Imagen { get; set; }

        public List<Talla> Talla { get; set; }
    }
}
