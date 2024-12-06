using ContactList.Entities;

namespace ContactList.Interfaces
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAll();
        Task<Contact> GetById(int id);
        Task Update(Contact contact);
        Task Delete(int id);
        Task Create(Contact contact);
    }
}
