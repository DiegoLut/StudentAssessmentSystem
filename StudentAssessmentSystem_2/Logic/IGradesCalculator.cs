using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal interface IGradesCalculator
    {
        void CalculateSubjectGrades(List<Grades> gradesList, out Dictionary<string, List<double>> subjectGrades, out Dictionary<string, double> subjectTotalWeights);
        void CalculateStudentsSubjectAverages(List<Student> students, string subject, out Dictionary<Student, double> studentAverages);
        void CalculateStudentsAverages(List<Student> students, out Dictionary<Student, double> studentAverages);
    }
}
