using Model.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic.FileMenagment
{
    public class XmlFileService : IFileService
    {
        public List<Student> ReadData(string path)
        {
            List<Student> students = new List<Student>();
            if (File.Exists(path))
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    students = (List<Student>)serializer.Deserialize(stream);
                }
            }
            else
            {
                FileNotFoundException exception = new FileNotFoundException("File doesn't exist");
                throw exception;
            }
            return students;
        }

        public List<Teacher> ReadTeacherData(string path)
        {
            List<Teacher> teachers = new List<Teacher>();
            if (File.Exists(path))
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Teacher>));
                    teachers = (List<Teacher>)serializer.Deserialize(stream);
                }
            }
            else
            {
                FileNotFoundException exception = new FileNotFoundException("File doesn't exist");
                throw exception;
            }
            return teachers;
        }

        public void SaveData(string path, List<Student> students)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream stream = File.Create(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                xmlSerializer.Serialize(stream, students);
            }
        }
    }
}
