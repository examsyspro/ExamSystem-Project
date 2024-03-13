namespace ExamSystem_Project.Forms
{
    partial class StatisticsForm
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
            panel4 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label11 = new Label();
            label15 = new Label();
            listBox_studentsList = new ListBox();
            listBox_errorsList = new ListBox();
            label_errorList = new Label();
            label1 = new Label();
            label_idStudent = new Label();
            label_selectedAnswer = new Label();
            label19 = new Label();
            label17 = new Label();
            label_studentName = new Label();
            label_gradeStudent = new Label();
            label18 = new Label();
            label_currectAnswer = new Label();
            label14 = new Label();
            label2 = new Label();
            label_examName = new Label();
            label3 = new Label();
            label_studentsAver = new Label();
            panel2 = new Panel();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 135, 209);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1185, 71);
            panel4.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 135, 209);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 71);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(450, 7);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(281, 50);
            label4.TabIndex = 7;
            label4.Text = "Statistics Panel";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(450, 7);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(281, 50);
            label11.TabIndex = 7;
            label11.Text = "Statistics Panel";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 135, 209);
            label15.Location = new Point(86, 149);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 25);
            label15.TabIndex = 42;
            label15.Text = "Students List";
            // 
            // listBox_studentsList
            // 
            listBox_studentsList.FormattingEnabled = true;
            listBox_studentsList.ItemHeight = 20;
            listBox_studentsList.Location = new Point(86, 183);
            listBox_studentsList.Name = "listBox_studentsList";
            listBox_studentsList.Size = new Size(174, 544);
            listBox_studentsList.TabIndex = 43;
            listBox_studentsList.SelectedIndexChanged += listBox_studentsList_SelectedIndexChanged;
            // 
            // listBox_errorsList
            // 
            listBox_errorsList.FormattingEnabled = true;
            listBox_errorsList.ItemHeight = 20;
            listBox_errorsList.Location = new Point(769, 183);
            listBox_errorsList.Name = "listBox_errorsList";
            listBox_errorsList.Size = new Size(339, 544);
            listBox_errorsList.TabIndex = 45;
            listBox_errorsList.SelectedIndexChanged += listBox_errorsList_SelectedIndexChanged;
            // 
            // label_errorList
            // 
            label_errorList.AutoSize = true;
            label_errorList.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_errorList.ForeColor = Color.FromArgb(0, 135, 209);
            label_errorList.Location = new Point(769, 149);
            label_errorList.Margin = new Padding(2, 0, 2, 0);
            label_errorList.Name = "label_errorList";
            label_errorList.Size = new Size(101, 25);
            label_errorList.TabIndex = 44;
            label_errorList.Text = "Erorrs List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 135, 209);
            label1.Location = new Point(307, 223);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 53;
            label1.Text = "Student : ";
            // 
            // label_idStudent
            // 
            label_idStudent.AutoSize = true;
            label_idStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_idStudent.ForeColor = SystemColors.GrayText;
            label_idStudent.Location = new Point(353, 322);
            label_idStudent.Margin = new Padding(2, 0, 2, 0);
            label_idStudent.Name = "label_idStudent";
            label_idStudent.Size = new Size(100, 25);
            label_idStudent.TabIndex = 49;
            label_idStudent.Text = "idStudent";
            // 
            // label_selectedAnswer
            // 
            label_selectedAnswer.AutoSize = true;
            label_selectedAnswer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_selectedAnswer.ForeColor = Color.Red;
            label_selectedAnswer.Location = new Point(475, 524);
            label_selectedAnswer.Margin = new Padding(2, 0, 2, 0);
            label_selectedAnswer.Name = "label_selectedAnswer";
            label_selectedAnswer.Size = new Size(149, 25);
            label_selectedAnswer.TabIndex = 50;
            label_selectedAnswer.Text = "selectedAnswer";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(0, 135, 209);
            label19.Location = new Point(307, 322);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(42, 25);
            label19.TabIndex = 54;
            label19.Text = "ID :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 135, 209);
            label17.Location = new Point(307, 419);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(76, 25);
            label17.TabIndex = 56;
            label17.Text = "Grade :";
            // 
            // label_studentName
            // 
            label_studentName.AutoSize = true;
            label_studentName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_studentName.ForeColor = SystemColors.GrayText;
            label_studentName.Location = new Point(401, 223);
            label_studentName.Margin = new Padding(2, 0, 2, 0);
            label_studentName.Name = "label_studentName";
            label_studentName.Size = new Size(132, 25);
            label_studentName.TabIndex = 48;
            label_studentName.Text = "studentName";
            // 
            // label_gradeStudent
            // 
            label_gradeStudent.AutoSize = true;
            label_gradeStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_gradeStudent.ForeColor = SystemColors.GrayText;
            label_gradeStudent.Location = new Point(381, 419);
            label_gradeStudent.Margin = new Padding(2, 0, 2, 0);
            label_gradeStudent.Name = "label_gradeStudent";
            label_gradeStudent.Size = new Size(134, 25);
            label_gradeStudent.TabIndex = 51;
            label_gradeStudent.Text = "studentGrade";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(0, 135, 209);
            label18.Location = new Point(307, 524);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(172, 25);
            label18.TabIndex = 55;
            label18.Text = "Selected Answer : ";
            // 
            // label_currectAnswer
            // 
            label_currectAnswer.AutoSize = true;
            label_currectAnswer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_currectAnswer.ForeColor = Color.ForestGreen;
            label_currectAnswer.Location = new Point(475, 634);
            label_currectAnswer.Margin = new Padding(2, 0, 2, 0);
            label_currectAnswer.Name = "label_currectAnswer";
            label_currectAnswer.Size = new Size(141, 25);
            label_currectAnswer.TabIndex = 52;
            label_currectAnswer.Text = "currectAnswer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 135, 209);
            label14.Location = new Point(307, 634);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(164, 25);
            label14.TabIndex = 57;
            label14.Text = "Currect Answer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 135, 209);
            label2.Location = new Point(274, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 59;
            label2.Text = "Exam Name : ";
            // 
            // label_examName
            // 
            label_examName.AutoSize = true;
            label_examName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_examName.ForeColor = SystemColors.ControlDarkDark;
            label_examName.Location = new Point(400, 15);
            label_examName.Margin = new Padding(2, 0, 2, 0);
            label_examName.Name = "label_examName";
            label_examName.Size = new Size(112, 25);
            label_examName.TabIndex = 58;
            label_examName.Text = "examName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 135, 209);
            label3.Location = new Point(540, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 61;
            label3.Text = "Students Average :";
            // 
            // label_studentsAver
            // 
            label_studentsAver.AutoSize = true;
            label_studentsAver.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_studentsAver.ForeColor = SystemColors.ControlDarkDark;
            label_studentsAver.Location = new Point(719, 15);
            label_studentsAver.Margin = new Padding(2, 0, 2, 0);
            label_studentsAver.Name = "label_studentsAver";
            label_studentsAver.Size = new Size(164, 25);
            label_studentsAver.TabIndex = 60;
            label_studentsAver.Text = "StudentsAverage";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label_examName);
            panel2.Controls.Add(label_studentsAver);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 53);
            panel2.TabIndex = 62;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 763);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(label_idStudent);
            Controls.Add(label_currectAnswer);
            Controls.Add(label_selectedAnswer);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label_studentName);
            Controls.Add(label_gradeStudent);
            Controls.Add(label18);
            Controls.Add(listBox_errorsList);
            Controls.Add(label_errorList);
            Controls.Add(listBox_studentsList);
            Controls.Add(label15);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticForm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label label11;
        private Label label15;
        private ListBox listBox_studentsList;
        private ListBox listBox_errorsList;
        private Label label_errorList;
        private Label label1;
        public Label label_idStudent;
        public Label label_selectedAnswer;
        private Label label19;
        private Label label17;
        public Label label_studentName;
        public Label label_gradeStudent;
        private Label label18;
        public Label label_currectAnswer;
        private Label label14;
        private Label label2;
        public Label label_examName;
        private Label label3;
        public Label label_studentsAver;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
    }
}