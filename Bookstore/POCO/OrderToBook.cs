using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.POCO
{
    public class OrderToBook
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
        public int? BookId { get; set; }
        public Double Price { get; set; }
        public int Count { get; set; }

    }
}
