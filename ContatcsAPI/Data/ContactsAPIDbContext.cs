using ContatcsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatcsAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options) {


        }

        public DbSet<Contact>Contacts{get; set;}
          


    }
}
