using System;

namespace Shared.Models
{
    public class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
