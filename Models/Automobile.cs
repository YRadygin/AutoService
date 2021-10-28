using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Automobile
    {
        public Automobile()
        {
            OrdersAutoService = new HashSet<Orders>();
        }

        public int Id_client { get; set; }
        public string Trade_mark { get; set; }
        public int Year { get; set; }
        public string Gosn { get; set; }
        public int Odometr { get; set; }
        public string Vin{ get; set; }
        public string Fuel { get; set; }

        public virtual ICollection<Orders> OrdersAutoService { get; set; }
    }
}

