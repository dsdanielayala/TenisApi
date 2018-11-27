using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int  Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Precio { get; set; }
        
        public string Descuento { get; set; }
        [Required]
        public string Imagen { get; set; }

        public List<Talla> Talla { get; set; }

    }
}
