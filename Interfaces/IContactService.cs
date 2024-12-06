using ContactList.Entities;

namespace ContactList.Interfaces
{
    public interface IContactService
    {
        List<Contact> GetAll();
        Contact Get(int id);
        Task Delete(int id);
        Task Update(Contact contact);
    }
}
