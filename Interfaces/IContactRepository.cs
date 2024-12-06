using ContactList.Entities;

namespace ContactList.Interfaces
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        Contact GetById(int id);
        Task Update(Contact contact);
        Task Delete(int id);
    }
}
