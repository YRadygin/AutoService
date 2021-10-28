using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Groupprod
    {
        public Groupprod()
        {
            Product = new HashSet<Product>();
            Service = new HashSet<Service>();
        }

        public int IdGroup { get; set; }
        public string NameGroup { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
