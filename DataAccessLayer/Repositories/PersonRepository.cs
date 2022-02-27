using System.Collections.Generic;
using System.Data.SqlClient;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace DataAccessLayer.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public List<Person> GetAllContacts()
        {
            List<Person> listToReturn = new List<Person>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Persons");

            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    Person temp = new Person();

                    temp.Id = sqlDataReader.GetInt32(0);
                    temp.FirstName = sqlDataReader.GetString(1);
                    temp.LastName = sqlDataReader.GetString(2);
                    temp.Phone = sqlDataReader.GetString(3);
                    temp.Address = sqlDataReader.GetString(4);
                    temp.Email = sqlDataReader.GetString(5);

                    listToReturn.Add(temp);
                }
            }

            DBConnection.CloseConnection();

            return listToReturn;
        }

        public int InsertContact(Person person)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Persons VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                person.FirstName, person.LastName, person.Phone, person.Address, person.Email));

            DBConnection.CloseConnection();
            return result;
        }

        public int UpdateContact(Person person)
        {
            int result = DBConnection.EditData(string.Format(
                "UPDATE Persons SET firstName = '{0}', lastName = '{1}', phone = '{2}', address = '{3}', email = '{4}'" +
                "WHERE id = '" + person.Id + "'", person.FirstName, person.LastName, person.Phone, person.Address, person.Email));

            DBConnection.CloseConnection();
            return result;
        }

        public int DeleteContact(int id)
        {
            int result = DBConnection.EditData("DELETE FROM Persons WHERE id =" + id);

            DBConnection.CloseConnection();
            return result;
        }
    }
}
