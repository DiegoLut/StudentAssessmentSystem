using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal interface IStudentSerwis <T> where T : Person
    {
        bool LoginStudent(string email, string password);
        T SearchStudent(int albumNr);
        T GetLoggedStudent(string email);
        List<T> DownloadAllStudents();
    }
}
