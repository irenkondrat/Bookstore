using System.ComponentModel.DataAnnotations;

namespace Bookstore.POCO
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string JobTitle { get; set; }
        public bool IsUser { get; set; }
        public string PhoneLocal { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
