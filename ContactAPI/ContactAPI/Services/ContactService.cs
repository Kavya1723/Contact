using ContactAPI.Models;
using ContactAPI.Repositories;

namespace ContactAPI.Services
{
    public class ContactService: IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Contact>> GetAllContactsAsync() => _repository.GetAllAsync();

        public Task<Contact> GetContactByIdAsync(int id) => _repository.GetByIdAsync(id);

        public Task AddContactAsync(Contact contact) => _repository.AddAsync(contact);

        public Task UpdateContactAsync(Contact contact) => _repository.UpdateAsync(contact);

        //public Task DeleteContactAsync(int id) => _repository.DeleteAsync(id);
    }
}
