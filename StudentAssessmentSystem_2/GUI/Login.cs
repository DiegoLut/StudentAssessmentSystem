using Logic;
using Model.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        StudentSerwis serwisStudent = new StudentSerwis();
        TeacherSerwis serwisTeacher = new TeacherSerwis();

        StudentView studentView = new StudentView();
        TeacherView teacherView = new TeacherView();
        public Login()
        {
            InitializeComponent();
            //serwisStudent.GenereteStudents();
            //serwisTeacher.GenereteTeachers();
            serwisStudent.DownloadAllStudents();
            serwisTeacher.DownloadAllTeachers();
        }

        private void buttonLogInStudent_Click(object sender, EventArgs e)
        {
            string email = this.textBoxStudentEmail.Text;
            string password = this.textBoxStudentPassword.Text;

            if(serwisStudent.LoginStudent(email, password))
            {
                MessageBox.Show("you have been logged in succesfull!");
                StudentView studentView = new StudentView(serwisStudent.GetLoggedStudent(email));
                studentView.Show();
            }
            else
            {
                MessageBox.Show("Incorrect input\nPlease try again");
            }
             
        }
        private void buttonLogInTeacher_Click(object sender, EventArgs e)
        {
            string email = this.textBoxTeacherEmail.Text;
            string password = this.textBoxTeacherPassword.Text;

            if (serwisTeacher.LoginTeacher(email, password))
            {
                MessageBox.Show("you have been logged in succesfull!");
                teacherView.Show();
            }
            else
            {
                MessageBox.Show("Incorrect input\nPlease try again");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
