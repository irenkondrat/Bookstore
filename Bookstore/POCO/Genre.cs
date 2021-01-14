using System.Collections.Generic;

namespace Bookstore.POCO
{
    public class BookGenre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
        public BookGenre()
        {
            Books = new List<Book>();
        }
    }
}
