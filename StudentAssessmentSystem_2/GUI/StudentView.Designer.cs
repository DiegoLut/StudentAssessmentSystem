namespace GUI
{
    partial class StudentView
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubjectSearch = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student view";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject you want to peep:";
            // 
            // buttonSubjectSearch
            // 
            this.buttonSubjectSearch.Location = new System.Drawing.Point(170, 111);
            this.buttonSubjectSearch.Name = "buttonSubjectSearch";
            this.buttonSubjectSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSubjectSearch.TabIndex = 3;
            this.buttonSubjectSearch.Text = "Search";
            this.buttonSubjectSearch.UseVisualStyleBackColor = true;
            this.buttonSubjectSearch.Click += new System.EventHandler(this.buttonSubjectSearch_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Items.AddRange(new object[] {
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
            this.comboBoxSubjects.Location = new System.Drawing.Point(29, 111);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubjects.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of your subjects with \r\naverage grades:";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(85, 209);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 225);
            this.listBox1.TabIndex = 7;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(400, 121);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(142, 53);
            this.buttonDisplay.TabIndex = 9;
            this.buttonDisplay.Text = "Dsiplay personal data and \r\nacademic subject list\r\n";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 495);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.buttonSubjectSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSubjectSearch;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDisplay;
    }
}