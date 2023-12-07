using Logic;
using Logic.Exceptions;
using Model.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TeacherView : Form
    {
        StudentSerwis serwisStudent = new StudentSerwis();
        TeacherSerwis serwisTeacher = new TeacherSerwis();
        
        Raport.Raport raport = new Raport.Raport();
        public TeacherView()
        {
            InitializeComponent();
            //serwisStudent.GenereteStudents();
            //serwisTeacher.GenereteTeachers();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                students = serwisStudent.DownloadAllStudents();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Nieodnaleziono pliku " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieznany błąd " + ex.Message);
            }

            listBox1.Items.Clear();

            for (int i = 0; i < students.Count; i++)
            {
                listBox1.Items.Add(students[i]);
            }
            /*listBox1.Items.Clear();

            foreach (Student student in serwisStudent.DisplayAllStudents())
            {
                //string studentInfo = string.Format("{0}: {1} {2}", student.AlbumNumber, student.FirstName, student.LastName);
                listBox1.Items.Add(student);
            }*/


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string albumNr = textBoxSanAddGrade.Text;
            string subject = comboBoxSubjectAddGrade.Text;
            int gradeWeight = (int)numericUpDownAddWeight.Value;
            decimal gradeValue = numericUpDownAddValue.Value;
            int parsedAlbumNr = 0;
            //exception ocena z poza zakresu 
            try
            {
                parsedAlbumNr = int.Parse(albumNr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Album input value has to be a number!");
                return;
            }

            Student student = serwisStudent.SearchStudent(parsedAlbumNr);
            if (student != null)
            {
                serwisTeacher.AddGrade(student, subject, gradeValue, gradeWeight);
                MessageBox.Show("Grade have been added sucessfully!");
                RefreshListBox2();
            }
            else
            {
                //MessageBox.Show("Student of this album number does not exist!\nCheck if album number is correct.");
                throw new ContainException("List of students doesn't contain student with selected index");
            }
        }

        private Student selectedStudent;
        private void buttonStudentGradesDisplay_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                selectedStudent = (Student)listBox1.SelectedItem;
                listBox2.Items.Clear();
                foreach (Grades grade in selectedStudent.GradesList)
                {
                    listBox2.Items.Add(grade);
                }
            }
            else
            {
                //MessageBox.Show("Student from listBox have not been chosen.");
                throw new SelectException("Student from listBox has to be selected");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;

            if (index >= 0)
            {
                if (selectedStudent != null && index < selectedStudent.GradesList.Count)
                {
                    selectedStudent.GradesList.RemoveAt(index);
                    RefreshListBox2();
                }
                else
                {
                    throw new SelectException("index has to be selected");
                }
            }
            else
            {
                throw new SelectException("valid index", "index has to be greater than 0");
            }
        }

        private void RefreshListBox2()
        {
            listBox2.Items.Clear();

            //List<Student> students = serwisStudent.DisplayAllStudents();
            List<Student> students = serwisStudent.DownloadAllStudents();


            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < students.Count)
            {
                Student pickedStudent = students[listBox1.SelectedIndex];
                foreach (Grades grade in pickedStudent.GradesList)
                {
                    listBox2.Items.Add(grade);
                }
            }
            else
            {
                MessageBox.Show("Make sure you selected student from listBox.");
            }
        }
        private void textBoxFiltrStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filtr = textBoxFiltrStudents.Text.ToLower();
            listBox1.DataSource = null;
            //listBox1.DataSource = serwisStudent.DisplayAllStudents().Where(x => x.AlbumNumber.ToString().Contains(filtr) || x.FirstName.ToLower().Contains(filtr) || x.LastName.ToLower().Contains(filtr)).ToList();
            listBox1.DataSource = serwisStudent.DownloadAllStudents().Where(x => x.AlbumNumber.ToString().Contains(filtr) || x.FirstName.ToLower().Contains(filtr) || x.LastName.ToLower().Contains(filtr)).ToList();

        }

        private void buttonOpenRaport_Click(object sender, EventArgs e)
        {
            Raport.Raport raport = new Raport.Raport();
            raport.Show();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            serwisStudent.SaveChanges();
            MessageBox.Show("New data has been saved to file");
        }
    }
}
