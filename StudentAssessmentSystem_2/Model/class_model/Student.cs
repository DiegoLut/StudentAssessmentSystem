using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    [Serializable]
    public class Student : Person
    {
        public int AlbumNumber { get; set; }
        public int StudyYear { get; set; }
        public List<Subjects> SubjectsList { get; set; }
        public List<Grades> GradesList { get; set;}

        public Student() { }

        public Student(int albumNumber, int studyYear, List<Subjects> subjectsList, List<Grades> gradesList, string firstName, 
            string lastName, string adressEmail, string password, GenderType gender, DateTime dateOfBirth) 
            :base(firstName, lastName, adressEmail, password, gender, dateOfBirth) 
        {
            this.AlbumNumber = albumNumber;
            this.StudyYear = studyYear;
            this.SubjectsList = subjectsList;
            this.GradesList = gradesList;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdressEmail = adressEmail;
            this.Password = password;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            string studentInfo = string.Format("{0}: {1} {2}", this.AlbumNumber, this.FirstName, this.LastName);
            return studentInfo;
        }
    }
}
