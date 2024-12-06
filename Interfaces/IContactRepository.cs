using ContactList.Entities;

namespace ContactList.Interfaces
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAll();
        Contact GetById(int id);
        Task Update(Contact contact);
        Task Delete(int id);
    }
}
