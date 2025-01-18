using B4TestePratico.Models;
using Microsoft.EntityFrameworkCore;

namespace B4TestePratico.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=client.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
