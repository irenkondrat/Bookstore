using System;
using System.Collections.Generic;

namespace Bookstore.POCO
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public int YearOfPublishing { get; set; }
        public string PublishingHouse { get; set; }
        public string Language { get; set; }
        public  ICollection<BookGenre> BookGenres { get; set; }
        public  ICollection<Autor> Autors { get; set; }
        public  ICollection<OrderToBook> OrderToBooks { get; set; }
        public  ICollection<Photo> Photos { get; set; }
        public Book()
        {
            BookGenres = new List<BookGenre>();
            Autors = new List<Autor>();
            OrderToBooks = new List<OrderToBook>();
            Photos = new List<Photo>();
        }


    }
}
