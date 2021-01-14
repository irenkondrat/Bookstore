using Bookstore.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
    public static class DbInitializer
    {
        public static void Initialize(BookstoreContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.User.Any())
            {
                return;
            }
            var admin = new User { Email = "admin", Password = "admin" };
            context.User.Add(admin);

            context.SaveChanges();

        }
    }
}
