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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView_StudentExam = new DataGridView();
            studentExamBindingSource = new BindingSource(components);
            studentExamIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isFinishedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            StartExam = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(266, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 106);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 1;
            label1.Text = "Search for exam in DB :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(386, 32);
            label2.Name = "label2";
            label2.Size = new Size(296, 50);
            label2.TabIndex = 3;
            label2.Text = "Student Window";
            // 
            // dataGridView_StudentExam
            // 
            dataGridView_StudentExam.AutoGenerateColumns = false;
            dataGridView_StudentExam.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_StudentExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_StudentExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_StudentExam.Columns.AddRange(new DataGridViewColumn[] { studentExamIdDataGridViewTextBoxColumn, examIdDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, examTitleDataGridViewTextBoxColumn, examDateDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, totalTimeDataGridViewTextBoxColumn, courseTypeDataGridViewTextBoxColumn, gradeDataGridViewTextBoxColumn, isFinishedDataGridViewCheckBoxColumn, StartExam });
            dataGridView_StudentExam.DataSource = studentExamBindingSource;
            dataGridView_StudentExam.EnableHeadersVisualStyles = false;
            dataGridView_StudentExam.Location = new Point(49, 155);
            dataGridView_StudentExam.Name = "dataGridView_StudentExam";
            dataGridView_StudentExam.RowHeadersWidth = 51;
            dataGridView_StudentExam.RowTemplate.Height = 29;
            dataGridView_StudentExam.ScrollBars = ScrollBars.Vertical;
            dataGridView_StudentExam.Size = new Size(986, 359);
            dataGridView_StudentExam.TabIndex = 4;
            dataGridView_StudentExam.CellClick += dataGridView_StudentExam_CellClick;
            // 
            // studentExamBindingSource
            // 
            studentExamBindingSource.DataSource = typeof(Models.StudentExam);
            // 
            // studentExamIdDataGridViewTextBoxColumn
            // 
            studentExamIdDataGridViewTextBoxColumn.DataPropertyName = "StudentExamId";
            studentExamIdDataGridViewTextBoxColumn.HeaderText = "StudentExamId";
            studentExamIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentExamIdDataGridViewTextBoxColumn.Name = "studentExamIdDataGridViewTextBoxColumn";
            studentExamIdDataGridViewTextBoxColumn.Visible = false;
            studentExamIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // examIdDataGridViewTextBoxColumn
            // 
            examIdDataGridViewTextBoxColumn.DataPropertyName = "ExamId";
            examIdDataGridViewTextBoxColumn.HeaderText = "Exam Id";
            examIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            examIdDataGridViewTextBoxColumn.Name = "examIdDataGridViewTextBoxColumn";
            examIdDataGridViewTextBoxColumn.Visible = false;
            examIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "User Id";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Visible = false;
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // examTitleDataGridViewTextBoxColumn
            // 
            examTitleDataGridViewTextBoxColumn.DataPropertyName = "ExamTitle";
            examTitleDataGridViewTextBoxColumn.HeaderText = "Exam Title";
            examTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            examTitleDataGridViewTextBoxColumn.Name = "examTitleDataGridViewTextBoxColumn";
            examTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // examDateDataGridViewTextBoxColumn
            // 
            examDateDataGridViewTextBoxColumn.DataPropertyName = "ExamDate";
            examDateDataGridViewTextBoxColumn.HeaderText = "Exam Date";
            examDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            examDateDataGridViewTextBoxColumn.Name = "examDateDataGridViewTextBoxColumn";
            examDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            startTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            totalTimeDataGridViewTextBoxColumn.HeaderText = "Total Time";
            totalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            totalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            courseTypeDataGridViewTextBoxColumn.HeaderText = "Course Type";
            courseTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            courseTypeDataGridViewTextBoxColumn.Visible = false;
            courseTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isFinishedDataGridViewCheckBoxColumn
            // 
            isFinishedDataGridViewCheckBoxColumn.DataPropertyName = "isFinished";
            isFinishedDataGridViewCheckBoxColumn.HeaderText = "Is Finished";
            isFinishedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isFinishedDataGridViewCheckBoxColumn.Name = "isFinishedDataGridViewCheckBoxColumn";
            isFinishedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // StartExam
            // 
            StartExam.HeaderText = "Start Exam";
            StartExam.MinimumWidth = 6;
            StartExam.Name = "StartExam";
            StartExam.Text = "Start Exam";
            StartExam.UseColumnTextForButtonValue = true;
            StartExam.Width = 125;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 701);
            Controls.Add(dataGridView_StudentExam);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView_StudentExam;
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
        private DataGridViewButtonColumn StartExam;
    }
}