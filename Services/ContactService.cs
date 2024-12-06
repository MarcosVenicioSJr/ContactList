using ContactList.Entities;
using ContactList.Interfaces;

namespace ContactList.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Contact Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            return _contactRepository.GetAll().Result;
        }

        public Task Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
