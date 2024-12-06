using ContactList.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Context
{
    public class ContactListContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactListContext(DbContextOptions<ContactListContext> options) : base(options)
        {
        }
    }
}
