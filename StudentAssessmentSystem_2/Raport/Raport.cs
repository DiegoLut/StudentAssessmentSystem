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

namespace Raport
{
    public partial class Raport : Form
    {
        StudentSerwis serwisStudent = new StudentSerwis();

        GradesCalculator gradesCalculator = new GradesCalculator();
        public Raport()
        {
            InitializeComponent();
        }

        private void buttonSubStudentGrades_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string albumNr =  textBoxAlbumNrSub.Text;
            string subject = comboBoxSubjectAlbumNr.Text;
            int parsedAlbumNr = 0;

            try
            {
                parsedAlbumNr = int.Parse(albumNr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Album input value has to be a number!");
                return;
            }

            bool foundGrade = false;

            foreach (Student student in serwisStudent.DownloadAllStudents())
            {
                if (parsedAlbumNr == student.AlbumNumber)
                {
                    foreach (Grades grade in student.GradesList)
                    {
                        if (subject == grade.SubjectName)
                        {
                            listBox1.Items.Add(grade);
                            foundGrade =true;
                        }
                    }
                }
            }
            if (!foundGrade)
            {
                listBox1.Items.Add($"No grades found for the {subject} in Grade List of selected student");
            }
        }

        private void buttonAllStudentGrades_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string albumNr = textBoxAlbumNr.Text;
            int parsedAlbumNr = 0;

            try
            {
                parsedAlbumNr = int.Parse(albumNr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Album input value has to be a number!");
                return;
            }

            foreach (Student student in serwisStudent.DownloadAllStudents())
            {
                if (parsedAlbumNr == student.AlbumNumber)
                {
                    foreach (Grades grade in student.GradesList)
                    {
                        listBox1.Items.Add(grade);
                    }
                }
            }
        }
        private void buttonByHighestSubject_Click(object sender, EventArgs e)
        {
            List<Student> students = serwisStudent.DownloadAllStudents();

            Dictionary<Student, double> studentAverages;
            string subject = comboBoxSubject.Text;

            gradesCalculator.CalculateStudentsSubjectAverages(students, subject, out studentAverages);

            var sortedStudents = studentAverages.OrderByDescending(x => x.Value);
            if (string.IsNullOrEmpty(comboBoxSubject.Text))
            {
                MessageBox.Show("You have to pick a subject");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Average students grades of {subject}:");
                foreach (var item in sortedStudents)
                {
                    Student student = item.Key;
                    double average = item.Value;
                    string averageFormatted = average.ToString("0.00");
                    if (average > 0)
                    {
                        listBox1.Items.Add($"Student: {student.FirstName} {student.LastName}    Average: {averageFormatted}");
                    }
                }
            }
        }

        private void buttonByHighestTotal_Click(object sender, EventArgs e)
        {

            List<Student> students = serwisStudent.DownloadAllStudents();
            Dictionary<Student, double> studentAverages;

            gradesCalculator.CalculateStudentsAverages(students, out studentAverages);

            var sortedStudents = studentAverages.OrderByDescending(x => x.Value);

            listBox1.Items.Clear();

            foreach (var item in sortedStudents)
            {
                Student student = item.Key;
                double average = item.Value;
                string averageFormatted = average.ToString("0.00");
                if (average > 0)
                {
                    listBox1.Items.Add($"Student: {student.FirstName} {student.LastName}    Average: {averageFormatted}");
                }
            }
        }
    }
}
