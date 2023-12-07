using Logic.FileMenagment;
using Model.model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class StudentSerwis : IStudentSerwis <Student>
    {
        IFileService fileService = new XmlFileService();
        List<Student> studentsList = new List<Student>();

        public bool LoginStudent(string email, string password)
        {
            foreach (Student student in studentsList)
            {
                if (student.AdressEmail == email && student.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public Student SearchStudent(int albumNr)
        {
            foreach (Student student in DownloadAllStudents())
            {
                if (student.AlbumNumber == albumNr)
                {
                    return student;
                }
            }
            return null;
        }

        public Student GetLoggedStudent(string email) 
        {
            foreach (Student student in DownloadAllStudents())
            {
                if (student.AdressEmail == email)
                {
                    return student;
                }
            }
            return null;
        }

        public static double CalculateAverage(List<Grades> gradesList)
        {
            double sum = 0;
            double totalWeight = 0;

            foreach (Grades grade in gradesList)
            {
                double gradeValue = (double)grade.GradeValue;
                double gradeWeight = grade.GradeWeight;

                sum += gradeValue * gradeWeight;
                totalWeight += gradeWeight;
            }

            return totalWeight > 0 ? sum / totalWeight : 0;
        }
        public List<Student> DownloadAllStudents()
        {
            if (studentsList.Count == 0)
            {
                List<Student> fileStudents = fileService.ReadData(ConfigData.STUDENT_FILE_PATH);
                foreach (Student student in fileStudents)
                {
                    studentsList.Add(student);
                }
            }
            return studentsList;
        }
        public void SaveChanges()
        {
            List<Student> fileStudents = new List<Student>();
            foreach (Student s in studentsList)
            {
                fileStudents.Add(s);
            }
            fileService.SaveData(ConfigData.STUDENT_FILE_PATH , fileStudents);
        }
    }
}
