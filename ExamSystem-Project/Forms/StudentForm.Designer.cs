namespace ExamSystem_Project.Forms
{
    partial class StudentForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            label1 = new Label();
            studentExamBindingSource1 = new BindingSource(components);
            studentExamBindingSource = new BindingSource(components);
            panel4 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            dataGridView_StudentExam = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            examStrIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            examDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teacherFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalMinutesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            randomQuestionOrderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            ShowExam = new DataGridViewButtonColumn();
            examBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(278, 127);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 127);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 1;
            label1.Text = "Search for exam in DB :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 135, 209);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1257, 74);
            panel4.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(508, 8);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(262, 50);
            label11.TabIndex = 7;
            label11.Text = "Student Panel";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 846);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1257, 76);
            panel5.TabIndex = 6;
            // 
            // dataGridView_StudentExam
            // 
            dataGridView_StudentExam.AutoGenerateColumns = false;
            dataGridView_StudentExam.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_StudentExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_StudentExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_StudentExam.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, examStrIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn11, examDateTimeDataGridViewTextBoxColumn, teacherFullNameDataGridViewTextBoxColumn, totalHoursDataGridViewTextBoxColumn, totalMinutesDataGridViewTextBoxColumn, randomQuestionOrderDataGridViewCheckBoxColumn, dataGridViewTextBoxColumn12, ShowExam });
            dataGridView_StudentExam.DataSource = examBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_StudentExam.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_StudentExam.EnableHeadersVisualStyles = false;
            dataGridView_StudentExam.Location = new Point(51, 232);
            dataGridView_StudentExam.Margin = new Padding(3, 2, 3, 2);
            dataGridView_StudentExam.Name = "dataGridView_StudentExam";
            dataGridView_StudentExam.RowHeadersWidth = 51;
            dataGridView_StudentExam.RowTemplate.Height = 29;
            dataGridView_StudentExam.ScrollBars = ScrollBars.Vertical;
            dataGridView_StudentExam.Size = new Size(931, 466);
            dataGridView_StudentExam.TabIndex = 7;
            dataGridView_StudentExam.CellClick += dataGridView_StudentExam_CellClick;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "ExamId";
            dataGridViewTextBoxColumn10.HeaderText = "ExamId";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // examStrIdDataGridViewTextBoxColumn
            // 
            examStrIdDataGridViewTextBoxColumn.DataPropertyName = "ExamStrId";
            examStrIdDataGridViewTextBoxColumn.HeaderText = "ExamStrId";
            examStrIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            examStrIdDataGridViewTextBoxColumn.Name = "examStrIdDataGridViewTextBoxColumn";
            examStrIdDataGridViewTextBoxColumn.Visible = false;
            examStrIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "ExamTitle";
            dataGridViewTextBoxColumn11.HeaderText = "Exam Title";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // examDateTimeDataGridViewTextBoxColumn
            // 
            examDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ExamDateTime";
            examDateTimeDataGridViewTextBoxColumn.HeaderText = "Exam Date";
            examDateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            examDateTimeDataGridViewTextBoxColumn.Name = "examDateTimeDataGridViewTextBoxColumn";
            examDateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // teacherFullNameDataGridViewTextBoxColumn
            // 
            teacherFullNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherFullName";
            teacherFullNameDataGridViewTextBoxColumn.HeaderText = "TeacherFullName";
            teacherFullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            teacherFullNameDataGridViewTextBoxColumn.Name = "teacherFullNameDataGridViewTextBoxColumn";
            teacherFullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalHoursDataGridViewTextBoxColumn
            // 
            totalHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalHours";
            totalHoursDataGridViewTextBoxColumn.HeaderText = "Total Hours";
            totalHoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalHoursDataGridViewTextBoxColumn.Name = "totalHoursDataGridViewTextBoxColumn";
            totalHoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalMinutesDataGridViewTextBoxColumn
            // 
            totalMinutesDataGridViewTextBoxColumn.DataPropertyName = "TotalMinutes";
            totalMinutesDataGridViewTextBoxColumn.HeaderText = "Total Minutes";
            totalMinutesDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalMinutesDataGridViewTextBoxColumn.Name = "totalMinutesDataGridViewTextBoxColumn";
            totalMinutesDataGridViewTextBoxColumn.Width = 150;
            // 
            // randomQuestionOrderDataGridViewCheckBoxColumn
            // 
            randomQuestionOrderDataGridViewCheckBoxColumn.DataPropertyName = "RandomQuestionOrder";
            randomQuestionOrderDataGridViewCheckBoxColumn.HeaderText = "RandomQuestionOrder";
            randomQuestionOrderDataGridViewCheckBoxColumn.MinimumWidth = 8;
            randomQuestionOrderDataGridViewCheckBoxColumn.Name = "randomQuestionOrderDataGridViewCheckBoxColumn";
            randomQuestionOrderDataGridViewCheckBoxColumn.Visible = false;
            randomQuestionOrderDataGridViewCheckBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "CourseType";
            dataGridViewTextBoxColumn12.HeaderText = "CourseType";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Visible = false;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // ShowExam
            // 
            ShowExam.HeaderText = "Start Exam";
            ShowExam.MinimumWidth = 8;
            ShowExam.Name = "ShowExam";
            ShowExam.Text = "Open";
            ShowExam.UseColumnTextForButtonValue = true;
            ShowExam.Width = 140;
            // 
            // examBindingSource
            // 
            examBindingSource.DataSource = typeof(Models.Exam);
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1257, 922);
            Controls.Add(dataGridView_StudentExam);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";

            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private BindingSource studentExamBindingSource;
        private DataGridViewTextBoxColumn studentExamIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isFinishedDataGridViewCheckBoxColumn;
        private BindingSource studentExamBindingSource1;
        private Panel panel4;
        private Label label11;
        private Panel panel5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewButtonColumn StartExam;
        public DataGridView dataGridView_teacherExams;
        private BindingSource examBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn examStrIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn examDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teacherFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMinutesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn randomQuestionOrderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewButtonColumn ShowExam;
        public DataGridView dataGridView_StudentExam;
    }
}