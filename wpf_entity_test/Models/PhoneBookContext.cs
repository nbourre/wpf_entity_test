using Microsoft.EntityFrameworkCore;

namespace wpf_entity_test
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=phonebook.db");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
