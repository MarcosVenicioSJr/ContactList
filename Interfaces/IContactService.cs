using ContactList.Entities;

namespace ContactList.Interfaces
{
    public interface IContactService
    {
        List<Contact> GetAll();
        Contact Get(int id);
        void Delete(int id);
        void Update(Contact contact);
        void Create(Contact contact);
    }
}
