using Logic.FileMenagment;
using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TeacherSerwis : ITeacherSerwis
    {
        IFileService fileService = new XmlFileService();
        List<Teacher> teacherList = new List<Teacher>();
        public bool LoginTeacher(string email, string password)
        {
            foreach (Teacher teacher in teacherList)
            {
                if (teacher.AdressEmail == email && teacher.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddGrade(Student student, string subject, decimal weight, int value)
        {
            Grades addedGrade = new Grades(subject, weight, value);
            student.GradesList.Add(addedGrade);
        }

        public void RemoveGrade(Student student, int index)
        {
            student.GradesList.RemoveAt(index);
        }
        public List<Teacher> DownloadAllTeachers()
        {
            if (teacherList.Count == 0)
            {
                List<Teacher> fileTeachers = fileService.ReadTeacherData(ConfigData.TEACHER_FILE_PATH);
                foreach (Teacher teacher in fileTeachers)
                {
                    teacherList.Add(teacher);
                }
            }
            return teacherList;
        }
    }
}
