using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIMVC.Models;

namespace WebAPIMVC.Controllers
{
    public class ProductosController : ApiController
    {
        Productos[] productos = new Productos[]
        {
            new Productos{ ID=1, Nombre = "Producto 1", Categoria="Categoria 1", Precio =34 },
            new Productos{ ID=2, Nombre = "Producto 2", Categoria="Categoria 2", Precio =35},
            new Productos{ ID=3, Nombre = "Producto 3", Categoria="Categoria 3", Precio =36 }
        };

        public IEnumerable<Productos> GetTodosLosProductos()
        {
            return productos;

        }

        public IHttpActionResult GetProductos(int id)
        {
            var producto = productos.FirstOrDefault((p) => p.ID == id);

            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
    }
}
