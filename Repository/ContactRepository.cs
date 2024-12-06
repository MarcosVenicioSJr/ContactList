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

        public async Task Create(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact> GetById(int id)
        {
            return await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
