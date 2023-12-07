using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    [Serializable]
    public class Teacher : Person
    {
        public DegreeType Degree { get; set; }
        public List<Subjects> TaughtSubjects { get; set; }

        public Teacher() { }

        public Teacher(DegreeType degree, List<Subjects> taughtSubjects, string firstName,string lastName, 
            string adressEmail, string password, GenderType gender, DateTime dateOfBirth)
            : base(firstName, lastName, adressEmail, password, gender, dateOfBirth) 
        {
            this.Degree = degree;
            this.TaughtSubjects = taughtSubjects;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdressEmail = adressEmail;
            this.Password = password;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
