using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal interface ITeacherSerwis
    {
        bool LoginTeacher(string email, string password);
        void AddGrade(Student student, string subject, decimal weight, int value);
        void RemoveGrade(Student student, int index);
    }
}
