namespace Raport
{
    partial class Raport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAlbumNrSub = new System.Windows.Forms.TextBox();
            this.textBoxAlbumNr = new System.Windows.Forms.TextBox();
            this.comboBoxSubjectAlbumNr = new System.Windows.Forms.ComboBox();
            this.buttonSubStudentGrades = new System.Windows.Forms.Button();
            this.buttonAllStudentGrades = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.buttonByHighestSubject = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonByHighestTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students Raports";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Student album number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Subject:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Student album number:";
            // 
            // textBoxAlbumNrSub
            // 
            this.textBoxAlbumNrSub.Location = new System.Drawing.Point(134, 100);
            this.textBoxAlbumNrSub.MaxLength = 5;
            this.textBoxAlbumNrSub.Name = "textBoxAlbumNrSub";
            this.textBoxAlbumNrSub.Size = new System.Drawing.Size(82, 20);
            this.textBoxAlbumNrSub.TabIndex = 22;
            // 
            // textBoxAlbumNr
            // 
            this.textBoxAlbumNr.Location = new System.Drawing.Point(187, 153);
            this.textBoxAlbumNr.MaxLength = 5;
            this.textBoxAlbumNr.Name = "textBoxAlbumNr";
            this.textBoxAlbumNr.Size = new System.Drawing.Size(82, 20);
            this.textBoxAlbumNr.TabIndex = 23;
            // 
            // comboBoxSubjectAlbumNr
            // 
            this.comboBoxSubjectAlbumNr.FormattingEnabled = true;
            this.comboBoxSubjectAlbumNr.Items.AddRange(new object[] {
            "Maths",
            "Mechanics",
            "Biologi",
            "Economics",
            "Finances",
            "Micro economics",
            "Macro economics",
            "English",
            "Germany",
            "Robotics",
            "WF",
            "History of Germany",
            "Algorythms"});
            this.comboBoxSubjectAlbumNr.Location = new System.Drawing.Point(275, 99);
            this.comboBoxSubjectAlbumNr.Name = "comboBoxSubjectAlbumNr";
            this.comboBoxSubjectAlbumNr.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSubjectAlbumNr.TabIndex = 24;
            // 
            // buttonSubStudentGrades
            // 
            this.buttonSubStudentGrades.Location = new System.Drawing.Point(377, 92);
            this.buttonSubStudentGrades.Name = "buttonSubStudentGrades";
            this.buttonSubStudentGrades.Size = new System.Drawing.Size(149, 35);
            this.buttonSubStudentGrades.TabIndex = 25;
            this.buttonSubStudentGrades.Text = "Show subject grades off the student";
            this.buttonSubStudentGrades.UseVisualStyleBackColor = true;
            this.buttonSubStudentGrades.Click += new System.EventHandler(this.buttonSubStudentGrades_Click);
            // 
            // buttonAllStudentGrades
            // 
            this.buttonAllStudentGrades.Location = new System.Drawing.Point(377, 145);
            this.buttonAllStudentGrades.Name = "buttonAllStudentGrades";
            this.buttonAllStudentGrades.Size = new System.Drawing.Size(149, 35);
            this.buttonAllStudentGrades.TabIndex = 26;
            this.buttonAllStudentGrades.Text = "Show all grades off the student";
            this.buttonAllStudentGrades.UseVisualStyleBackColor = true;
            this.buttonAllStudentGrades.Click += new System.EventHandler(this.buttonAllStudentGrades_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Subject:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "Maths",
            "Mechanics",
            "Biologi",
            "Economics",
            "Finances",
            "Micro economics",
            "Macro economics",
            "English",
            "Germany",
            "Robotics",
            "WF",
            "History of Germany",
            "Algorythms"});
            this.comboBoxSubject.Location = new System.Drawing.Point(187, 204);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSubject.TabIndex = 28;
            // 
            // buttonByHighestSubject
            // 
            this.buttonByHighestSubject.Location = new System.Drawing.Point(377, 196);
            this.buttonByHighestSubject.Name = "buttonByHighestSubject";
            this.buttonByHighestSubject.Size = new System.Drawing.Size(149, 35);
            this.buttonByHighestSubject.TabIndex = 29;
            this.buttonByHighestSubject.Text = "Show students by highest average subject grade\r\n";
            this.buttonByHighestSubject.UseVisualStyleBackColor = true;
            this.buttonByHighestSubject.Click += new System.EventHandler(this.buttonByHighestSubject_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 324);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 251);
            this.listBox1.TabIndex = 30;
            // 
            // buttonByHighestTotal
            // 
            this.buttonByHighestTotal.Location = new System.Drawing.Point(377, 250);
            this.buttonByHighestTotal.Name = "buttonByHighestTotal";
            this.buttonByHighestTotal.Size = new System.Drawing.Size(149, 35);
            this.buttonByHighestTotal.TabIndex = 31;
            this.buttonByHighestTotal.Text = "Show students by highest average total grade";
            this.buttonByHighestTotal.UseVisualStyleBackColor = true;
            this.buttonByHighestTotal.Click += new System.EventHandler(this.buttonByHighestTotal_Click);
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 634);
            this.Controls.Add(this.buttonByHighestTotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonByHighestSubject);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonAllStudentGrades);
            this.Controls.Add(this.buttonSubStudentGrades);
            this.Controls.Add(this.comboBoxSubjectAlbumNr);
            this.Controls.Add(this.textBoxAlbumNr);
            this.Controls.Add(this.textBoxAlbumNrSub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Raport";
            this.Text = "Raport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAlbumNrSub;
        private System.Windows.Forms.TextBox textBoxAlbumNr;
        private System.Windows.Forms.ComboBox comboBoxSubjectAlbumNr;
        private System.Windows.Forms.Button buttonSubStudentGrades;
        private System.Windows.Forms.Button buttonAllStudentGrades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button buttonByHighestSubject;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonByHighestTotal;
    }
}

