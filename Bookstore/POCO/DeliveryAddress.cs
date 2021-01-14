using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.POCO
{
    public class DeliveryAddress
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string UserFullName { get; set; }
        public string UserPhone { get; set; }
        public ICollection<Order> Orders { get; set; }
        public DeliveryAddress()
        {
            Orders = new List<Order>();
        }

    }
}
