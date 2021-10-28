using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Product
    {
        public string Kod { get; set; }
        public string Manufacturer { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductGroup { get; set; }
       
    }
}
