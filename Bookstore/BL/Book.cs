using Bookstore.POCO;
using Bookstore.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.BL
{
     
    public class BookBL
    {
         private readonly BookstoreContext _context;

        public BookBL(BookstoreContext context)
        {
            _context = context;
        }
        public List<Book> GetAllBooks ()
        {
            var photo = _context.Photo.FirstOrDefault().Book;
            var f = _context.Book.Include(a => a.Photos).AsNoTracking();
            return f.ToList();
        }
    }
}
