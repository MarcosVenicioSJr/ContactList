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

        public void Create(Contact contact)
        {
            if (contact.Id != null)
                contact.Id = null;

            _contactRepository.Create(contact);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Contact Get(int id)
        {
            return _contactRepository.GetById(id).Result;
        }

        public List<Contact> GetAll()
        {
            return _contactRepository.GetAll().Result;
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
