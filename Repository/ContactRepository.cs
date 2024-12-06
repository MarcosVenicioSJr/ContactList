using ContactList.Context;
using ContactList.Entities;
using ContactList.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactListContext _context;

        public ContactRepository(ContactListContext context)
        {
            _context = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts.ToListAsync();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
