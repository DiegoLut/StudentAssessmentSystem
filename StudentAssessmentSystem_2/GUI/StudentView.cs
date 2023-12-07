using Logic;
using Model.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentView : Form
    {
        StudentSerwis studentSerwis = new StudentSerwis();

        GradesCalculator gradeCalculator = new GradesCalculator();

        private Student loggedStudent;

        public StudentView()
        {
        }

        public StudentView(Student student)
        {
            InitializeComponent();
            loggedStudent = student;

            DisplayLoggedStudentInfo();
        }

        private void DisplayLoggedStudentInfo()
        {
            listBox1.Items.Add("Welcome " + loggedStudent.FirstName + " " + loggedStudent.LastName + "!");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("Student Information:");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("First Name: \t" + loggedStudent.FirstName);
            listBox1.Items.Add("Last Name: \t" + loggedStudent.LastName);
            listBox1.Items.Add("Email: \t\t" + loggedStudent.AdressEmail);
            listBox1.Items.Add("Album Number: \t" + loggedStudent.AlbumNumber);
            listBox1.Items.Add("Study Year: \t" + loggedStudent.StudyYear);
            listBox1.Items.Add("Gender: \t" + loggedStudent.Gender);

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Your Subject list for current academic year:");

            foreach (Subjects subject in loggedStudent.SubjectsList)
            {
                listBox1.Items.Add(" ");
                listBox1.Items.Add("Subject: \t\t" + subject.Subject);
                listBox1.Items.Add("Teacher: \t" + subject.Teacher);
                listBox1.Items.Add("Class number: \t" + subject.Classroom);
                listBox1.Items.Add("ECTS: \t\t" + subject.ECTS);
            }

        }

        private void buttonSubjectSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string selectedSubject = comboBoxSubjects.SelectedItem.ToString();

            bool foundSubject = false;

            listBox1.Items.Add($"{selectedSubject} list of grades:");

            foreach (Grades grade in loggedStudent.GradesList) 
            {
                if (selectedSubject == grade.SubjectName)
                {
                    foundSubject = true; 
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add($"Grade value: {grade.GradeValue}");
                    listBox1.Items.Add($"Grade weight: {grade.GradeWeight}");
                }
            }
            if (!foundSubject)
                {
                listBox1.Items.Clear();
                listBox1.Items.Add($"No grades found for the subject: {selectedSubject}");
                }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("List of your subjects with avergage grades:");

            Dictionary<string, List<double>> subjectGrades;
            Dictionary<string, double> subjectTotalWeights;

            gradeCalculator.CalculateSubjectGrades(loggedStudent.GradesList, out subjectGrades, out subjectTotalWeights);

            foreach (string subjectName in subjectGrades.Keys)
            {
                List<double> gradesList = subjectGrades[subjectName];
                double sum = gradesList.Sum();
                double totalWeight = subjectTotalWeights[subjectName];
                double average = sum / totalWeight;
                string average00 = average.ToString("0.00");

                listBox1.Items.Add(" ");
                listBox1.Items.Add($"Subject: {subjectName}     Average: {average00}");
            }
        }
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayLoggedStudentInfo();
        }
    }
}
