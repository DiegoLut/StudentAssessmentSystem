namespace GUI
{
    partial class TeacherView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSanAddGrade = new System.Windows.Forms.TextBox();
            this.comboBoxSubjectAddGrade = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOpenRaport = new System.Windows.Forms.Button();
            this.numericUpDownAddWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddValue = new System.Windows.Forms.NumericUpDown();
            this.buttonStudentGradesDisplay = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFiltrStudents = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddStudentView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teacher view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student album number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Grade weight:";
            // 
            // textBoxSanAddGrade
            // 
            this.textBoxSanAddGrade.Location = new System.Drawing.Point(270, 117);
            this.textBoxSanAddGrade.MaxLength = 5;
            this.textBoxSanAddGrade.Name = "textBoxSanAddGrade";
            this.textBoxSanAddGrade.Size = new System.Drawing.Size(85, 20);
            this.textBoxSanAddGrade.TabIndex = 8;
            // 
            // comboBoxSubjectAddGrade
            // 
            this.comboBoxSubjectAddGrade.FormattingEnabled = true;
            this.comboBoxSubjectAddGrade.Items.AddRange(new object[] {
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
            this.comboBoxSubjectAddGrade.Location = new System.Drawing.Point(439, 117);
            this.comboBoxSubjectAddGrade.Name = "comboBoxSubjectAddGrade";
            this.comboBoxSubjectAddGrade.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSubjectAddGrade.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(541, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add grade";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 238);
            this.listBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(305, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adding new grade:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(635, 516);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 32);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Delete grade";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOpenRaport
            // 
            this.buttonOpenRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonOpenRaport.Location = new System.Drawing.Point(299, 603);
            this.buttonOpenRaport.Name = "buttonOpenRaport";
            this.buttonOpenRaport.Size = new System.Drawing.Size(159, 60);
            this.buttonOpenRaport.TabIndex = 46;
            this.buttonOpenRaport.Text = "Open raports window";
            this.buttonOpenRaport.UseVisualStyleBackColor = true;
            this.buttonOpenRaport.Click += new System.EventHandler(this.buttonOpenRaport_Click);
            // 
            // numericUpDownAddWeight
            // 
            this.numericUpDownAddWeight.Location = new System.Drawing.Point(270, 149);
            this.numericUpDownAddWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAddWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddWeight.Name = "numericUpDownAddWeight";
            this.numericUpDownAddWeight.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownAddWeight.TabIndex = 47;
            this.numericUpDownAddWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAddValue
            // 
            this.numericUpDownAddValue.DecimalPlaces = 1;
            this.numericUpDownAddValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownAddValue.Location = new System.Drawing.Point(439, 149);
            this.numericUpDownAddValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAddValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAddValue.Name = "numericUpDownAddValue";
            this.numericUpDownAddValue.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownAddValue.TabIndex = 48;
            this.numericUpDownAddValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonStudentGradesDisplay
            // 
            this.buttonStudentGradesDisplay.Location = new System.Drawing.Point(172, 516);
            this.buttonStudentGradesDisplay.Name = "buttonStudentGradesDisplay";
            this.buttonStudentGradesDisplay.Size = new System.Drawing.Size(183, 32);
            this.buttonStudentGradesDisplay.TabIndex = 53;
            this.buttonStudentGradesDisplay.Text = "Display grades of selected student ";
            this.buttonStudentGradesDisplay.UseVisualStyleBackColor = true;
            this.buttonStudentGradesDisplay.Click += new System.EventHandler(this.buttonStudentGradesDisplay_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(395, 272);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(321, 238);
            this.listBox2.TabIndex = 54;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonSaveChanges.Location = new System.Drawing.Point(308, 554);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(140, 43);
            this.buttonSaveChanges.TabIndex = 55;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(397, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Selected Student Grade List:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Student List:";
            // 
            // textBoxFiltrStudents
            // 
            this.textBoxFiltrStudents.Location = new System.Drawing.Point(252, 233);
            this.textBoxFiltrStudents.Name = "textBoxFiltrStudents";
            this.textBoxFiltrStudents.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltrStudents.TabIndex = 59;
            this.textBoxFiltrStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltrStudents_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Search:";
            // 
            // buttonAddStudentView
            // 
            this.buttonAddStudentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonAddStudentView.Location = new System.Drawing.Point(287, 669);
            this.buttonAddStudentView.Name = "buttonAddStudentView";
            this.buttonAddStudentView.Size = new System.Drawing.Size(182, 42);
            this.buttonAddStudentView.TabIndex = 61;
            this.buttonAddStudentView.Text = "Create new student";
            this.buttonAddStudentView.UseVisualStyleBackColor = true;
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 722);
            this.Controls.Add(this.buttonAddStudentView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFiltrStudents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonStudentGradesDisplay);
            this.Controls.Add(this.numericUpDownAddValue);
            this.Controls.Add(this.numericUpDownAddWeight);
            this.Controls.Add(this.buttonOpenRaport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSubjectAddGrade);
            this.Controls.Add(this.textBoxSanAddGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherView";
            this.Text = "TeacherView";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSanAddGrade;
        private System.Windows.Forms.ComboBox comboBoxSubjectAddGrade;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOpenRaport;
        private System.Windows.Forms.NumericUpDown numericUpDownAddWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownAddValue;
        private System.Windows.Forms.Button buttonStudentGradesDisplay;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFiltrStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddStudentView;
    }
}