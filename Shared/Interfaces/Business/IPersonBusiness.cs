using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces.Business
{
    public interface IPersonBusiness
    {
        List<Person> GetAllContacts();
        bool InsertContact(Person person);
        bool UpdateContact(Person person);
        bool DeleteContact(int id);
    }
}
