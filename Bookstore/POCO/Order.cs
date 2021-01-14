using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.POCO
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime DateConfirmedUser { get; set; }
        public DateTime DateTakenForProcessing{ get; set; }
        public DateTime DateHandedOverCourier { get; set; }
        public string StatusId { get; set; }
        public ICollection<OrderToBook> OrderToBooks { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public int? DeliveryAddressId { get; set; }
        public Order()
        {
            OrderToBooks = new List<OrderToBook>();
        }
    }
}
