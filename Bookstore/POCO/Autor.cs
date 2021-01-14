using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.POCO
{
    public class Autor 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public ICollection<Book> Books { get; set; }
        public Autor()
        {
            Books = new List<Book>();
        }
    }
}
