using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    [Serializable]
    public class Grades
    {
        public string SubjectName { get; set; }
        public decimal GradeValue { get; set; }
        public int GradeWeight { get; set; }
        

        public Grades() { }

        public Grades(string SubjectName, decimal GradeValue, int GradeWeight)
        {
            this.SubjectName = SubjectName;
            this.GradeValue = GradeValue;
            this.GradeWeight = GradeWeight;
        }

        public override string ToString()
        {
            string studentGradeInfo = string.Format("{0}: Value: {1} Weight: {2}", this.SubjectName, this.GradeValue, this.GradeWeight);
            return studentGradeInfo;
        }
    }
}
