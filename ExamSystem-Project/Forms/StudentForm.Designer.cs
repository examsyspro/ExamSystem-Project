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
            dataGridView_StudentExam = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            StartExam = new DataGridViewButtonColumn();
            studentExamBindingSource1 = new BindingSource(components);
            studentExamBindingSource = new BindingSource(components);
            panel4 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(333, 152);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 1;
            label1.Text = "Search for exam in DB :";
            // 
            // dataGridView_StudentExam
            // 
            dataGridView_StudentExam.AutoGenerateColumns = false;
            dataGridView_StudentExam.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 135, 209);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_StudentExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_StudentExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_StudentExam.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewCheckBoxColumn1, StartExam });
            dataGridView_StudentExam.DataSource = studentExamBindingSource1;
            dataGridView_StudentExam.EnableHeadersVisualStyles = false;
            dataGridView_StudentExam.Location = new Point(61, 221);
            dataGridView_StudentExam.Margin = new Padding(4, 3, 4, 3);
            dataGridView_StudentExam.Name = "dataGridView_StudentExam";
            dataGridView_StudentExam.RowHeadersWidth = 51;
            dataGridView_StudentExam.RowTemplate.Height = 29;
            dataGridView_StudentExam.ScrollBars = ScrollBars.Vertical;
            dataGridView_StudentExam.Size = new Size(1033, 559);
            dataGridView_StudentExam.TabIndex = 4;
            dataGridView_StudentExam.CellClick += dataGridView_StudentExam_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "StudentExamId";
            dataGridViewTextBoxColumn1.HeaderText = "StudentExamId";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ExamId";
            dataGridViewTextBoxColumn2.HeaderText = "ExamId";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "UserId";
            dataGridViewTextBoxColumn3.HeaderText = "UserId";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Visible = false;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ExamTitle";
            dataGridViewTextBoxColumn4.HeaderText = "Exam Title";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ExamDate";
            dataGridViewTextBoxColumn5.HeaderText = "Exam Date";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "StartTime";
            dataGridViewTextBoxColumn6.HeaderText = "Start Time";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "TotalTime";
            dataGridViewTextBoxColumn7.HeaderText = "Total Time";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "CourseType";
            dataGridViewTextBoxColumn8.HeaderText = "Course Type";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Visible = false;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Grade";
            dataGridViewTextBoxColumn9.HeaderText = "Grade";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "isFinished";
            dataGridViewCheckBoxColumn1.HeaderText = "Is Finished";
            dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // StartExam
            // 
            StartExam.HeaderText = "Start Exam";
            StartExam.MinimumWidth = 6;
            StartExam.Name = "StartExam";
            StartExam.Text = "Start Exam";
            StartExam.UseColumnTextForButtonValue = true;
            StartExam.Width = 150;
            // 
            // studentExamBindingSource1
            // 
            studentExamBindingSource1.DataSource = typeof(Models.StudentExam);
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 135, 209);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1508, 89);
            panel4.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(610, 9);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(314, 60);
            label11.TabIndex = 7;
            label11.Text = "Student Panel";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 1015);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1508, 91);
            panel5.TabIndex = 6;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1508, 1106);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(dataGridView_StudentExam);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentExamBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
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
    }
}