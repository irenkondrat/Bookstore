using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.POCO
{
    public class Photo
    {
        public Photo()
        {
           
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }

    }
}
