using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dominio
{   [Table("Talla")]
    public class Talla
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Tallas { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Sexo { get; set; }

    }
}
