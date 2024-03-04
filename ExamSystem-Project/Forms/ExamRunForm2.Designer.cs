namespace ExamSystem_Project.Forms
{
    partial class ExamRunForm2
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
            tabControl1 = new TabControl();
            tabPage_step1 = new TabPage();
            panel1 = new Panel();
            button_start = new Button();
            label15 = new Label();
            label14 = new Label();
            label_TeacherName_S = new Label();
            label_pointQuestion_S = new Label();
            label_course_S = new Label();
            label19 = new Label();
            label17 = new Label();
            label_examTitle_S = new Label();
            label_totalExamTime_S = new Label();
            label18 = new Label();
            tabPage_step2 = new TabPage();
            panel_questions = new Panel();
            textBox_QuetionContent = new TextBox();
            label_question = new Label();
            tabPage_step3 = new TabPage();
            questionBindingSource1 = new BindingSource(components);
            questionBindingSource = new BindingSource(components);
            button_SaveExamBuilder = new Button();
            button_next = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            button_Previous = new Button();
            panel4 = new Panel();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage_step1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage_step2.SuspendLayout();
            panel_questions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_step1);
            tabControl1.Controls.Add(tabPage_step2);
            tabControl1.Controls.Add(tabPage_step3);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(11, 102);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1498, 858);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_step1
            // 
            tabPage_step1.BackColor = SystemColors.Window;
            tabPage_step1.Controls.Add(panel1);
            tabPage_step1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step1.Location = new Point(4, 47);
            tabPage_step1.Margin = new Padding(2);
            tabPage_step1.Name = "tabPage_step1";
            tabPage_step1.Padding = new Padding(2);
            tabPage_step1.Size = new Size(1490, 807);
            tabPage_step1.TabIndex = 0;
            tabPage_step1.Text = "Exam details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button_start);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label_TeacherName_S);
            panel1.Controls.Add(label_pointQuestion_S);
            panel1.Controls.Add(label_course_S);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label_examTitle_S);
            panel1.Controls.Add(label_totalExamTime_S);
            panel1.Controls.Add(label18);
            panel1.Location = new Point(26, 22);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 762);
            panel1.TabIndex = 30;
            // 
            // button_start
            // 
            button_start.BackColor = Color.FromArgb(0, 135, 209);
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_start.ForeColor = Color.White;
            button_start.Location = new Point(56, 448);
            button_start.Margin = new Padding(2);
            button_start.Name = "button_start";
            button_start.Size = new Size(141, 58);
            button_start.TabIndex = 48;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 135, 209);
            label15.Location = new Point(56, 48);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(133, 30);
            label15.TabIndex = 41;
            label15.Text = "Exam Title :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 135, 209);
            label14.Location = new Point(56, 362);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(226, 30);
            label14.TabIndex = 47;
            label14.Text = "Points per question :";
            // 
            // label_TeacherName_S
            // 
            label_TeacherName_S.AutoSize = true;
            label_TeacherName_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_TeacherName_S.ForeColor = Color.Black;
            label_TeacherName_S.Location = new Point(232, 118);
            label_TeacherName_S.Margin = new Padding(2, 0, 2, 0);
            label_TeacherName_S.Name = "label_TeacherName_S";
            label_TeacherName_S.Size = new Size(152, 30);
            label_TeacherName_S.TabIndex = 31;
            label_TeacherName_S.Text = "Teacher Name";
            // 
            // label_pointQuestion_S
            // 
            label_pointQuestion_S.AutoSize = true;
            label_pointQuestion_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_pointQuestion_S.ForeColor = Color.Black;
            label_pointQuestion_S.Location = new Point(305, 362);
            label_pointQuestion_S.Margin = new Padding(2, 0, 2, 0);
            label_pointQuestion_S.Name = "label_pointQuestion_S";
            label_pointQuestion_S.Size = new Size(198, 30);
            label_pointQuestion_S.TabIndex = 39;
            label_pointQuestion_S.Text = "Points per question";
            // 
            // label_course_S
            // 
            label_course_S.AutoSize = true;
            label_course_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_course_S.ForeColor = Color.Black;
            label_course_S.Location = new Point(156, 285);
            label_course_S.Margin = new Padding(2, 0, 2, 0);
            label_course_S.Name = "label_course_S";
            label_course_S.Size = new Size(81, 30);
            label_course_S.TabIndex = 33;
            label_course_S.Text = "Course";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(0, 135, 209);
            label19.Location = new Point(56, 118);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(172, 30);
            label19.TabIndex = 42;
            label19.Text = "Teacher Name :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 135, 209);
            label17.Location = new Point(56, 202);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(201, 30);
            label17.TabIndex = 45;
            label17.Text = "Total Exam Time : ";
            // 
            // label_examTitle_S
            // 
            label_examTitle_S.AutoSize = true;
            label_examTitle_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_examTitle_S.ForeColor = Color.Black;
            label_examTitle_S.Location = new Point(192, 48);
            label_examTitle_S.Margin = new Padding(2, 0, 2, 0);
            label_examTitle_S.Name = "label_examTitle_S";
            label_examTitle_S.Size = new Size(111, 30);
            label_examTitle_S.TabIndex = 30;
            label_examTitle_S.Text = "Exam Title";
            // 
            // label_totalExamTime_S
            // 
            label_totalExamTime_S.AutoSize = true;
            label_totalExamTime_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_totalExamTime_S.ForeColor = Color.Black;
            label_totalExamTime_S.Location = new Point(275, 202);
            label_totalExamTime_S.Margin = new Padding(2, 0, 2, 0);
            label_totalExamTime_S.Name = "label_totalExamTime_S";
            label_totalExamTime_S.Size = new Size(170, 30);
            label_totalExamTime_S.TabIndex = 34;
            label_totalExamTime_S.Text = "Total Exam Time";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(0, 135, 209);
            label18.Location = new Point(56, 285);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(96, 30);
            label18.TabIndex = 44;
            label18.Text = "Course :";
            // 
            // tabPage_step2
            // 
            tabPage_step2.Controls.Add(panel_questions);
            tabPage_step2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step2.Location = new Point(4, 47);
            tabPage_step2.Margin = new Padding(2);
            tabPage_step2.Name = "tabPage_step2";
            tabPage_step2.Padding = new Padding(2);
            tabPage_step2.Size = new Size(1490, 807);
            tabPage_step2.TabIndex = 1;
            tabPage_step2.Text = "Add questions";
            tabPage_step2.UseVisualStyleBackColor = true;
            // 
            // panel_questions
            // 
            panel_questions.BackColor = SystemColors.InactiveBorder;
            panel_questions.Controls.Add(textBox_QuetionContent);
            panel_questions.Controls.Add(label_question);
            panel_questions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_questions.Location = new Point(8, 6);
            panel_questions.Margin = new Padding(4, 2, 4, 2);
            panel_questions.Name = "panel_questions";
            panel_questions.Size = new Size(1255, 794);
            panel_questions.TabIndex = 1;
            // 
            // textBox_QuetionContent
            // 
            textBox_QuetionContent.BorderStyle = BorderStyle.FixedSingle;
            textBox_QuetionContent.Location = new Point(258, 38);
            textBox_QuetionContent.Margin = new Padding(4, 2, 4, 2);
            textBox_QuetionContent.Multiline = true;
            textBox_QuetionContent.Name = "textBox_QuetionContent";
            textBox_QuetionContent.Size = new Size(600, 100);
            textBox_QuetionContent.TabIndex = 1;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_question.ForeColor = Color.FromArgb(0, 135, 209);
            label_question.Location = new Point(25, 40);
            label_question.Margin = new Padding(4, 0, 4, 0);
            label_question.Name = "label_question";
            label_question.Size = new Size(207, 30);
            label_question.TabIndex = 0;
            label_question.Text = "Question Content :";
            // 
            // tabPage_step3
            // 
            tabPage_step3.Location = new Point(4, 47);
            tabPage_step3.Margin = new Padding(4, 5, 4, 5);
            tabPage_step3.Name = "tabPage_step3";
            tabPage_step3.Padding = new Padding(4, 5, 4, 5);
            tabPage_step3.Size = new Size(1490, 807);
            tabPage_step3.TabIndex = 2;
            tabPage_step3.Text = "Summary";
            tabPage_step3.UseVisualStyleBackColor = true;
            // 
            // questionBindingSource1
            // 
            questionBindingSource1.DataSource = typeof(Models.Question);
            // 
            // questionBindingSource
            // 
            questionBindingSource.DataSource = typeof(Models.Question);
            // 
            // button_SaveExamBuilder
            // 
            button_SaveExamBuilder.BackColor = Color.FromArgb(0, 135, 209);
            button_SaveExamBuilder.FlatStyle = FlatStyle.Flat;
            button_SaveExamBuilder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SaveExamBuilder.ForeColor = Color.White;
            button_SaveExamBuilder.Location = new Point(1299, 18);
            button_SaveExamBuilder.Margin = new Padding(2);
            button_SaveExamBuilder.Name = "button_SaveExamBuilder";
            button_SaveExamBuilder.Size = new Size(181, 52);
            button_SaveExamBuilder.TabIndex = 2;
            button_SaveExamBuilder.Text = "Save Exam";
            button_SaveExamBuilder.UseVisualStyleBackColor = false;
            button_SaveExamBuilder.Click += button_SaveExamBuilder_Click;
            // 
            // button_next
            // 
            button_next.BackColor = Color.FromArgb(0, 135, 209);
            button_next.FlatStyle = FlatStyle.Flat;
            button_next.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_next.ForeColor = Color.White;
            button_next.Location = new Point(1319, 18);
            button_next.Margin = new Padding(2);
            button_next.Name = "button_next";
            button_next.Size = new Size(134, 52);
            button_next.TabIndex = 3;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += button_next_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1524, 1055);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_next);
            panel5.Controls.Add(button_Previous);
            panel5.Controls.Add(button_SaveExamBuilder);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 963);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1524, 92);
            panel5.TabIndex = 2;
            // 
            // button_Previous
            // 
            button_Previous.BackColor = Color.FromArgb(0, 135, 209);
            button_Previous.FlatStyle = FlatStyle.Flat;
            button_Previous.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Previous.ForeColor = Color.White;
            button_Previous.Location = new Point(56, 18);
            button_Previous.Margin = new Padding(2);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(148, 52);
            button_Previous.TabIndex = 4;
            button_Previous.Text = "Previous";
            button_Previous.UseVisualStyleBackColor = false;
            button_Previous.Click += button_Previous_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 135, 209);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1524, 88);
            panel4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(610, 8);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(231, 60);
            label11.TabIndex = 7;
            label11.Text = "Run Exam";
            // 
            // ExamRunForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1524, 1055);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ExamRunForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuildExamForm";
            tabControl1.ResumeLayout(false);
            tabPage_step1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage_step2.ResumeLayout(false);
            panel_questions.ResumeLayout(false);
            panel_questions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel4;
        private Label label11;
        private Panel panel5;
        private Button button_Previous;
        private BindingSource questionBindingSource;
        private BindingSource questionBindingSource1;
        public Label label_question;
        public TextBox textBox_QuetionContent;
        public Panel panel_questions;
        public Button button_SaveExamBuilder;
        public Button button_next;
        public Panel panel1;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        public Label label_pointQuestion_S;
        public Label label_examTitle_S;
        public Label label_totalExamTime_S;
        public Label label_course_S;
        public Label label_TeacherName_S;
        private Button button_start;
        public TabControl tabControl1;
        public TabPage tabPage_step1;
        public TabPage tabPage_step2;
        public TabPage tabPage_step3;
    }
}