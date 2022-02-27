using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System.Collections.Generic;

namespace BusinessLayer.Businesses
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _personRepository;

        public PersonBusiness(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAllContacts()
        {
            return this._personRepository.GetAllContacts();
        }

        public bool InsertContact(Person person)
        {
            return this._personRepository.InsertContact(person) > 0;
        }

        public bool UpdateContact(Person person)
        {
            return this._personRepository.UpdateContact(person) > 0;
        }

        public bool DeleteContact(int id)
        {
            return this._personRepository.DeleteContact(id) > 0;
        }
    }
 }
