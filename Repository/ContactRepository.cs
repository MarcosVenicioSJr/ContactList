using ContactList.Entities;
using ContactList.Interfaces;

namespace ContactList.Repository
{
    public class ContactRepository : IContactRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
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
