using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.POCO;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Repository
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddress { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderToBook> OrderToBook { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().ToTable("Autor");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<DeliveryAddress>().ToTable("DeliveryAddress");
            modelBuilder.Entity<BookGenre>().ToTable("BookGenre");
            modelBuilder.Entity<Order> ().ToTable("Order");
            modelBuilder.Entity<DeliveryAddress>().ToTable("DeliveryAddress");
            modelBuilder.Entity<OrderToBook>().ToTable("OrderToBook");
            modelBuilder.Entity<OrderStatus>().ToTable("OrderStatus");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
