using Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.FileMenagment
{
    public interface IFileService
    {
        List<Student> ReadData(string path);
        List<Teacher> ReadTeacherData(string path);
        void SaveData(string path, List<Student> students);
    }
}
