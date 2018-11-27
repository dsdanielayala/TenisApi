using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tienda.Dominio;

namespace TenisApi.Models
{
    public class ProductoContext : DbContext
    {
        public ProductoContext() : base("prueb26a")
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Talla> Tallas { get; set; }
    }
}