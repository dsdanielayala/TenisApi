using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TenisApi.Models;
using Tienda.Dominio;

namespace TenisApi.Controllers
{
    public class ProductoController : ApiController
    {
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            using (var context = new ProductoContext())
            {
                return context.Productos.Include("Talla").ToList();
            }
        }
    }
}
