using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Orders
    {
        public Orders()
        {
            OrdersPosition = new HashSet<OrdersPosition>();
        }

        public int Id { get; set; }
        public int Id_client { get; set; }
        public DateTime CreateOrder { get; set; }
        public DateTime CloseOrder { get; set; }
        public string IdWorker { get; set; }
        public string Discription { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TypeOrder { get; set; }
        public string StateOrder { get; set; }

        public virtual Clients Client { get; set; }
        public virtual ICollection<OrdersPosition> OrdersPosition { get; set; }
    }
}
