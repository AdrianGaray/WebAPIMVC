using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMVC.Models
{
    public class Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
    }
}