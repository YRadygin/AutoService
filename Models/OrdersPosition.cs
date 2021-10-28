using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class OrdersPosition
    {
        public int Id { get; set; }
        public int Id_Order { get; set; }
        public string Product { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
        public string Total { get; set; }

        public virtual Orders IdOrderNavigation { get; set; }
    }
}
