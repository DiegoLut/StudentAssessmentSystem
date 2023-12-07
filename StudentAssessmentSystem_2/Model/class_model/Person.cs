using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdressEmail { get; set; }
        public string Password { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string adressEmail, string password, GenderType gender, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            AdressEmail = adressEmail;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}
