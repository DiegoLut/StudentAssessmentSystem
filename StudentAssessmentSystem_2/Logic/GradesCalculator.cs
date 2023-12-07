using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GradesCalculator : IGradesCalculator
    {
        public void CalculateSubjectGrades(List<Grades> gradesList, out Dictionary<string, List<double>> subjectGrades, out Dictionary<string, double> subjectTotalWeights)
        {
            subjectGrades = new Dictionary<string, List<double>>();
            subjectTotalWeights = new Dictionary<string, double>();

            foreach (Grades grade in gradesList)
            {
                string subjectName = grade.SubjectName;
                double gradeValue = (double)grade.GradeValue;
                double gradeWeight = grade.GradeWeight;

                if (subjectGrades.ContainsKey(subjectName))
                {
                    subjectGrades[subjectName].Add(gradeValue * gradeWeight);
                    subjectTotalWeights[subjectName] += gradeWeight;
                }
                else
                {
                    List<double> sGradesList = new List<double>();
                    sGradesList.Add(gradeValue * gradeWeight);
                    subjectGrades.Add(subjectName, sGradesList);
                    subjectTotalWeights.Add(subjectName, gradeWeight);
                }
            }
        }
        public void CalculateStudentsSubjectAverages(List<Student> students, string subject, out Dictionary<Student, double> studentAverages)
        {
            studentAverages = new Dictionary<Student, double>();

            foreach (Student student in students)
            {
                double sum = 0;
                int count = 0;

                foreach (Grades grade in student.GradesList)
                {
                    if (subject == grade.SubjectName)
                    {
                        sum += (double)grade.GradeValue * grade.GradeWeight;
                        count += grade.GradeWeight;
                    }
                }

                double average = count > 0 ? sum / count : 0;
                studentAverages.Add(student, average);
            }
        }
        public void CalculateStudentsAverages(List<Student> students, out Dictionary<Student, double> studentAverages)
        {
            studentAverages = new Dictionary<Student, double>();

            foreach (Student student in students)
            {
                double sum = 0;
                int count = 0;

                foreach (Grades grade in student.GradesList)
                { 
                    sum += (double)grade.GradeValue * grade.GradeWeight;
                    count += grade.GradeWeight;  
                }

                double average = count > 0 ? sum / count : 0;
                studentAverages.Add(student, average);
            }
        }
    }
}
