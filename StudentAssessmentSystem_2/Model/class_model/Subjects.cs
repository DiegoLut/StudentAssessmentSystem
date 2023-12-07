using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    [Serializable]
    public class Subjects
    {
        public string Teacher { get; set; }
        public string Subject { get; set; }
        public int ECTS { get; set; }
        public string Classroom { get; set; }
        public int StudentClassCount { get; set; }
        public SubPassType ExameType { get; set; }
        public ClassForm StudyForm { get; set; }
        public int CreditHours { get; set; }
        public Subjects() { }

        public Subjects(string teacher, string subject, int eCTS, string classroom)
        {
            Teacher = teacher;
            Subject = subject;
            ECTS = eCTS;
            Classroom = classroom;
        }

        public Subjects(string teacher, string subject, int eCTS, string classroom, int studentClassCount, SubPassType exameType, ClassForm studyForm, int creditHours)
        {
            Teacher = teacher;
            Subject = subject;
            ECTS = eCTS;
            Classroom = classroom;
            StudentClassCount = studentClassCount;
            ExameType = exameType;
            StudyForm = studyForm;
            CreditHours = creditHours;
        }
    }
}
