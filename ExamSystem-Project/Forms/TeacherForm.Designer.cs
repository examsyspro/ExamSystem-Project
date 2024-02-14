namespace ExamSystem_Project.Forms
{
    partial class TeacherForm
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
            button_createExam = new Button();
            button_getAllExams = new Button();
            dataGridView_teacherExams = new DataGridView();
            examIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examStrIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            examDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teacherFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalMinutesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            randomQuestionOrderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            courseTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ShowExam = new DataGridViewButtonColumn();
            examBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_teacherExams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button_createExam
            // 
            button_createExam.Location = new Point(72, 158);
            button_createExam.Margin = new Padding(4);
            button_createExam.Name = "button_createExam";
            button_createExam.Size = new Size(240, 85);
            button_createExam.TabIndex = 0;
            button_createExam.Text = "Create Exam";
            button_createExam.UseVisualStyleBackColor = true;
            button_createExam.Click += button_createExam_Click;
            // 
            // button_getAllExams
            // 
            button_getAllExams.Location = new Point(594, 158);
            button_getAllExams.Margin = new Padding(4);
            button_getAllExams.Name = "button_getAllExams";
            button_getAllExams.Size = new Size(205, 85);
            button_getAllExams.TabIndex = 2;
            button_getAllExams.Text = "getallexams";
            button_getAllExams.UseVisualStyleBackColor = true;
            button_getAllExams.Click += button_getAllExams_Click;
            // 
            // dataGridView_teacherExams
            // 
            dataGridView_teacherExams.AutoGenerateColumns = false;
            dataGridView_teacherExams.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_teacherExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_teacherExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_teacherExams.Columns.AddRange(new DataGridViewColumn[] { examIdDataGridViewTextBoxColumn, examStrIdDataGridViewTextBoxColumn, examTitleDataGridViewTextBoxColumn, examDateTimeDataGridViewTextBoxColumn, teacherFullNameDataGridViewTextBoxColumn, totalHoursDataGridViewTextBoxColumn, totalMinutesDataGridViewTextBoxColumn, randomQuestionOrderDataGridViewCheckBoxColumn, courseTypeDataGridViewTextBoxColumn, ShowExam });
            dataGridView_teacherExams.DataSource = examBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_teacherExams.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_teacherExams.EnableHeadersVisualStyles = false;
            dataGridView_teacherExams.Location = new Point(42, 478);
            dataGridView_teacherExams.Margin = new Padding(4, 3, 4, 3);
            dataGridView_teacherExams.Name = "dataGridView_teacherExams";
            dataGridView_teacherExams.RowHeadersWidth = 51;
            dataGridView_teacherExams.RowTemplate.Height = 29;
            dataGridView_teacherExams.ScrollBars = ScrollBars.Vertical;
            dataGridView_teacherExams.Size = new Size(1566, 559);
            dataGridView_teacherExams.TabIndex = 5;
            dataGridView_teacherExams.CellClick += dataGridView_teacherExams_CellClick;
            // 
            // examIdDataGridViewTextBoxColumn
            // 
            examIdDataGridViewTextBoxColumn.DataPropertyName = "ExamId";
            examIdDataGridViewTextBoxColumn.HeaderText = "ExamId";
            examIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            examIdDataGridViewTextBoxColumn.Name = "examIdDataGridViewTextBoxColumn";
            examIdDataGridViewTextBoxColumn.Visible = false;
            examIdDataGridViewTextBoxColumn.Width = 150;
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
            // examTitleDataGridViewTextBoxColumn
            // 
            examTitleDataGridViewTextBoxColumn.DataPropertyName = "ExamTitle";
            examTitleDataGridViewTextBoxColumn.HeaderText = "Exam Title";
            examTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            examTitleDataGridViewTextBoxColumn.Name = "examTitleDataGridViewTextBoxColumn";
            examTitleDataGridViewTextBoxColumn.Width = 200;
            // 
            // examDateTimeDataGridViewTextBoxColumn
            // 
            examDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ExamDateTime";
            examDateTimeDataGridViewTextBoxColumn.HeaderText = "Exam Date";
            examDateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            examDateTimeDataGridViewTextBoxColumn.Name = "examDateTimeDataGridViewTextBoxColumn";
            examDateTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // teacherFullNameDataGridViewTextBoxColumn
            // 
            teacherFullNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherFullName";
            teacherFullNameDataGridViewTextBoxColumn.HeaderText = "Teacher Name";
            teacherFullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            teacherFullNameDataGridViewTextBoxColumn.Name = "teacherFullNameDataGridViewTextBoxColumn";
            teacherFullNameDataGridViewTextBoxColumn.Width = 200;
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
            totalMinutesDataGridViewTextBoxColumn.Width = 180;
            // 
            // randomQuestionOrderDataGridViewCheckBoxColumn
            // 
            randomQuestionOrderDataGridViewCheckBoxColumn.DataPropertyName = "RandomQuestionOrder";
            randomQuestionOrderDataGridViewCheckBoxColumn.HeaderText = "Random Question Order";
            randomQuestionOrderDataGridViewCheckBoxColumn.MinimumWidth = 8;
            randomQuestionOrderDataGridViewCheckBoxColumn.Name = "randomQuestionOrderDataGridViewCheckBoxColumn";
            randomQuestionOrderDataGridViewCheckBoxColumn.Width = 280;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            courseTypeDataGridViewTextBoxColumn.HeaderText = "CourseType";
            courseTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            courseTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ShowExam
            // 
            ShowExam.HeaderText = "Show Exam";
            ShowExam.MinimumWidth = 8;
            ShowExam.Name = "ShowExam";
            ShowExam.Text = "Open";
            ShowExam.UseColumnTextForButtonValue = true;
            ShowExam.Width = 150;
            // 
            // examBindingSource
            // 
            examBindingSource.DataSource = typeof(Models.Exam);
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 1099);
            Controls.Add(dataGridView_teacherExams);
            Controls.Add(button_getAllExams);
            Controls.Add(button_createExam);
            Margin = new Padding(4);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_teacherExams).EndInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_createExam;
        private Button button_getAllExams;
        private BindingSource examBindingSource;
        private DataGridViewTextBoxColumn examIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examStrIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teacherFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMinutesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn randomQuestionOrderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn ShowExam;
        public DataGridView dataGridView_teacherExams;
    }
}