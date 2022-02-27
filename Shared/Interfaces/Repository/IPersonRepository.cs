using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAllContacts();
        int InsertContact(Person person);
        int UpdateContact(Person person);
        int DeleteContact(int id);
    }
}
