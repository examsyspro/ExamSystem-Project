namespace ExamSystem_Project.Forms
{
    partial class BuildExamForm
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
            button_Test = new Button();
            panel1 = new Panel();
            checkBox_QuestionOrder = new CheckBox();
            label5 = new Label();
            dateTimePicker_examDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            textBox_examTitle = new TextBox();
            textBox_minutes_StartTime = new TextBox();
            label9 = new Label();
            textBox_date = new TextBox();
            textBox_hours_StartTime = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBox_hours_totalTime = new TextBox();
            textBox_teacherName = new TextBox();
            label4 = new Label();
            label_teaStu = new Label();
            textBox_minutes_totalTime = new TextBox();
            label1 = new Label();
            label3 = new Label();
            comboBox_Course_Select = new ComboBox();
            tabPage_step2 = new TabPage();
            panel_questions = new Panel();
            button_testQuestions = new Button();
            button_AddQuestion = new Button();
            button_SaveQuestion = new Button();
            checkBox_OptionOrder = new CheckBox();
            button_addOption = new Button();
            textBox_QuetionContent = new TextBox();
            label_question = new Label();
            tabPage_step3 = new TabPage();
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
            tabControl1.Location = new Point(8, 62);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 514);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_step1
            // 
            tabPage_step1.BackColor = SystemColors.Window;
            tabPage_step1.Controls.Add(button_Test);
            tabPage_step1.Controls.Add(panel1);
            tabPage_step1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step1.Location = new Point(4, 34);
            tabPage_step1.Margin = new Padding(2);
            tabPage_step1.Name = "tabPage_step1";
            tabPage_step1.Padding = new Padding(2);
            tabPage_step1.Size = new Size(1032, 476);
            tabPage_step1.TabIndex = 0;
            tabPage_step1.Text = "Exam details";
            // 
            // button_Test
            // 
            button_Test.Location = new Point(846, 68);
            button_Test.Margin = new Padding(3, 2, 3, 2);
            button_Test.Name = "button_Test";
            button_Test.Size = new Size(82, 22);
            button_Test.TabIndex = 31;
            button_Test.Text = "Test";
            button_Test.UseVisualStyleBackColor = true;
            button_Test.Click += button_Test_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(checkBox_QuestionOrder);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker_examDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_examTitle);
            panel1.Controls.Add(textBox_minutes_StartTime);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox_date);
            panel1.Controls.Add(textBox_hours_StartTime);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_hours_totalTime);
            panel1.Controls.Add(textBox_teacherName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label_teaStu);
            panel1.Controls.Add(textBox_minutes_totalTime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox_Course_Select);
            panel1.Location = new Point(18, 14);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 458);
            panel1.TabIndex = 30;
            // 
            // checkBox_QuestionOrder
            // 
            checkBox_QuestionOrder.AutoSize = true;
            checkBox_QuestionOrder.CheckAlign = ContentAlignment.MiddleRight;
            checkBox_QuestionOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_QuestionOrder.ForeColor = Color.FromArgb(0, 135, 209);
            checkBox_QuestionOrder.Location = new Point(38, 389);
            checkBox_QuestionOrder.Margin = new Padding(3, 2, 3, 2);
            checkBox_QuestionOrder.Name = "checkBox_QuestionOrder";
            checkBox_QuestionOrder.Size = new Size(206, 24);
            checkBox_QuestionOrder.TabIndex = 29;
            checkBox_QuestionOrder.Text = "Random Question Order :";
            checkBox_QuestionOrder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 135, 209);
            label5.Location = new Point(36, 34);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 11;
            label5.Text = "Exam Title :";
            // 
            // dateTimePicker_examDate
            // 
            dateTimePicker_examDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_examDate.Location = new Point(151, 149);
            dateTimePicker_examDate.Margin = new Padding(2);
            dateTimePicker_examDate.Name = "dateTimePicker_examDate";
            dateTimePicker_examDate.Size = new Size(233, 27);
            dateTimePicker_examDate.TabIndex = 19;
            dateTimePicker_examDate.ValueChanged += dateTimePicker_examDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(276, 291);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 28;
            label8.Text = "Minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 135, 209);
            label7.Location = new Point(38, 149);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 20;
            label7.Text = "Exam Date :";
            // 
            // textBox_examTitle
            // 
            textBox_examTitle.BorderStyle = BorderStyle.FixedSingle;
            textBox_examTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_examTitle.Location = new Point(140, 33);
            textBox_examTitle.Margin = new Padding(2);
            textBox_examTitle.Name = "textBox_examTitle";
            textBox_examTitle.Size = new Size(205, 27);
            textBox_examTitle.TabIndex = 0;
            // 
            // textBox_minutes_StartTime
            // 
            textBox_minutes_StartTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_minutes_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_minutes_StartTime.Location = new Point(230, 202);
            textBox_minutes_StartTime.Margin = new Padding(2);
            textBox_minutes_StartTime.Name = "textBox_minutes_StartTime";
            textBox_minutes_StartTime.Size = new Size(70, 27);
            textBox_minutes_StartTime.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(186, 291);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 27;
            label9.Text = "Hours";
            // 
            // textBox_date
            // 
            textBox_date.BorderStyle = BorderStyle.FixedSingle;
            textBox_date.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_date.Location = new Point(409, 149);
            textBox_date.Margin = new Padding(2);
            textBox_date.Name = "textBox_date";
            textBox_date.ReadOnly = true;
            textBox_date.Size = new Size(132, 27);
            textBox_date.TabIndex = 21;
            // 
            // textBox_hours_StartTime
            // 
            textBox_hours_StartTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_hours_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_hours_StartTime.Location = new Point(140, 202);
            textBox_hours_StartTime.Margin = new Padding(2);
            textBox_hours_StartTime.Name = "textBox_hours_StartTime";
            textBox_hours_StartTime.Size = new Size(70, 27);
            textBox_hours_StartTime.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 135, 209);
            label6.Location = new Point(36, 268);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 16;
            label6.Text = "Total Exam Time : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(232, 228);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 26;
            label2.Text = "Minutes";
            // 
            // textBox_hours_totalTime
            // 
            textBox_hours_totalTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_hours_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_hours_totalTime.Location = new Point(186, 267);
            textBox_hours_totalTime.Margin = new Padding(2);
            textBox_hours_totalTime.Name = "textBox_hours_totalTime";
            textBox_hours_totalTime.Size = new Size(70, 27);
            textBox_hours_totalTime.TabIndex = 22;
            // 
            // textBox_teacherName
            // 
            textBox_teacherName.BorderStyle = BorderStyle.FixedSingle;
            textBox_teacherName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_teacherName.Location = new Point(168, 90);
            textBox_teacherName.Margin = new Padding(2);
            textBox_teacherName.Name = "textBox_teacherName";
            textBox_teacherName.Size = new Size(178, 27);
            textBox_teacherName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 135, 209);
            label4.Location = new Point(36, 335);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 15;
            label4.Text = "Course :";
            // 
            // label_teaStu
            // 
            label_teaStu.AutoSize = true;
            label_teaStu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_teaStu.ForeColor = SystemColors.GrayText;
            label_teaStu.Location = new Point(140, 228);
            label_teaStu.Margin = new Padding(2, 0, 2, 0);
            label_teaStu.Name = "label_teaStu";
            label_teaStu.Size = new Size(40, 15);
            label_teaStu.TabIndex = 25;
            label_teaStu.Text = "Hours";
            // 
            // textBox_minutes_totalTime
            // 
            textBox_minutes_totalTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_minutes_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_minutes_totalTime.Location = new Point(275, 267);
            textBox_minutes_totalTime.Margin = new Padding(2);
            textBox_minutes_totalTime.Name = "textBox_minutes_totalTime";
            textBox_minutes_totalTime.Size = new Size(70, 27);
            textBox_minutes_totalTime.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 135, 209);
            label1.Location = new Point(38, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 12;
            label1.Text = "Teacher Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 135, 209);
            label3.Location = new Point(38, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 14;
            label3.Text = "Start Time :";
            // 
            // comboBox_Course_Select
            // 
            comboBox_Course_Select.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Course_Select.FormattingEnabled = true;
            comboBox_Course_Select.Location = new Point(116, 335);
            comboBox_Course_Select.Margin = new Padding(2);
            comboBox_Course_Select.Name = "comboBox_Course_Select";
            comboBox_Course_Select.Size = new Size(174, 28);
            comboBox_Course_Select.TabIndex = 24;
            // 
            // tabPage_step2
            // 
            tabPage_step2.Controls.Add(panel_questions);
            tabPage_step2.Location = new Point(4, 34);
            tabPage_step2.Margin = new Padding(2);
            tabPage_step2.Name = "tabPage_step2";
            tabPage_step2.Padding = new Padding(2);
            tabPage_step2.Size = new Size(1040, 476);
            tabPage_step2.TabIndex = 1;
            tabPage_step2.Text = "Add questions";
            tabPage_step2.UseVisualStyleBackColor = true;
            // 
            // panel_questions
            // 
            panel_questions.Controls.Add(button_testQuestions);
            panel_questions.Controls.Add(button_AddQuestion);
            panel_questions.Controls.Add(button_SaveQuestion);
            panel_questions.Controls.Add(checkBox_OptionOrder);
            panel_questions.Controls.Add(button_addOption);
            panel_questions.Controls.Add(textBox_QuetionContent);
            panel_questions.Controls.Add(label_question);
            panel_questions.Dock = DockStyle.Fill;
            panel_questions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_questions.Location = new Point(2, 2);
            panel_questions.Margin = new Padding(3, 2, 3, 2);
            panel_questions.Name = "panel_questions";
            panel_questions.Size = new Size(1036, 472);
            panel_questions.TabIndex = 1;
            // 
            // button_testQuestions
            // 
            button_testQuestions.Location = new Point(913, 75);
            button_testQuestions.Margin = new Padding(3, 2, 3, 2);
            button_testQuestions.Name = "button_testQuestions";
            button_testQuestions.Size = new Size(82, 22);
            button_testQuestions.TabIndex = 32;
            button_testQuestions.Text = "Test";
            button_testQuestions.UseVisualStyleBackColor = true;
            button_testQuestions.Click += button_testQuestions_Click;
            // 
            // button_AddQuestion
            // 
            button_AddQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_AddQuestion.FlatStyle = FlatStyle.Flat;
            button_AddQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_AddQuestion.ForeColor = Color.White;
            button_AddQuestion.Location = new Point(863, 24);
            button_AddQuestion.Margin = new Padding(2);
            button_AddQuestion.Name = "button_AddQuestion";
            button_AddQuestion.Size = new Size(132, 30);
            button_AddQuestion.TabIndex = 4;
            button_AddQuestion.Text = "Add Question";
            button_AddQuestion.UseVisualStyleBackColor = false;
            button_AddQuestion.Click += button_AddQuestion_Click;
            // 
            // button_SaveQuestion
            // 
            button_SaveQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_SaveQuestion.FlatStyle = FlatStyle.Flat;
            button_SaveQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SaveQuestion.ForeColor = Color.White;
            button_SaveQuestion.Location = new Point(732, 24);
            button_SaveQuestion.Margin = new Padding(2);
            button_SaveQuestion.Name = "button_SaveQuestion";
            button_SaveQuestion.Size = new Size(128, 30);
            button_SaveQuestion.TabIndex = 3;
            button_SaveQuestion.Text = "Save Question";
            button_SaveQuestion.UseVisualStyleBackColor = false;
            button_SaveQuestion.Click += button_SaveQuestion_Click;
            // 
            // checkBox_OptionOrder
            // 
            checkBox_OptionOrder.AutoSize = true;
            checkBox_OptionOrder.CheckAlign = ContentAlignment.MiddleRight;
            checkBox_OptionOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_OptionOrder.ForeColor = Color.FromArgb(0, 135, 209);
            checkBox_OptionOrder.Location = new Point(619, 62);
            checkBox_OptionOrder.Margin = new Padding(3, 2, 3, 2);
            checkBox_OptionOrder.Name = "checkBox_OptionOrder";
            checkBox_OptionOrder.Size = new Size(127, 24);
            checkBox_OptionOrder.TabIndex = 2;
            checkBox_OptionOrder.Text = "Options Order";
            checkBox_OptionOrder.UseVisualStyleBackColor = true;
            // 
            // button_addOption
            // 
            button_addOption.BackColor = Color.FromArgb(0, 135, 209);
            button_addOption.FlatStyle = FlatStyle.Flat;
            button_addOption.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_addOption.ForeColor = Color.White;
            button_addOption.Location = new Point(619, 24);
            button_addOption.Margin = new Padding(2);
            button_addOption.Name = "button_addOption";
            button_addOption.Size = new Size(109, 31);
            button_addOption.TabIndex = 5;
            button_addOption.Text = "Add Option";
            button_addOption.UseVisualStyleBackColor = false;
            button_addOption.Click += button_addOption_Click;
            // 
            // textBox_QuetionContent
            // 
            textBox_QuetionContent.BorderStyle = BorderStyle.FixedSingle;
            textBox_QuetionContent.Location = new Point(186, 24);
            textBox_QuetionContent.Margin = new Padding(3, 2, 3, 2);
            textBox_QuetionContent.Multiline = true;
            textBox_QuetionContent.Name = "textBox_QuetionContent";
            textBox_QuetionContent.Size = new Size(420, 60);
            textBox_QuetionContent.TabIndex = 1;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_question.ForeColor = Color.FromArgb(0, 135, 209);
            label_question.Location = new Point(24, 26);
            label_question.Name = "label_question";
            label_question.Size = new Size(140, 20);
            label_question.TabIndex = 0;
            label_question.Text = "Question Content :";
            // 
            // tabPage_step3
            // 
            tabPage_step3.Location = new Point(4, 34);
            tabPage_step3.Name = "tabPage_step3";
            tabPage_step3.Padding = new Padding(3);
            tabPage_step3.Size = new Size(1032, 476);
            tabPage_step3.TabIndex = 2;
            tabPage_step3.Text = "Summary";
            tabPage_step3.UseVisualStyleBackColor = true;
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
            button_SaveExamBuilder.Location = new Point(467, 10);
            button_SaveExamBuilder.Margin = new Padding(2);
            button_SaveExamBuilder.Name = "button_SaveExamBuilder";
            button_SaveExamBuilder.Size = new Size(127, 32);
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
            button_next.Location = new Point(923, 10);
            button_next.Margin = new Padding(2);
            button_next.Name = "button_next";
            button_next.Size = new Size(94, 32);
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
            panel3.Size = new Size(1067, 633);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_next);
            panel5.Controls.Add(button_Previous);
            panel5.Controls.Add(button_SaveExamBuilder);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 578);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1067, 55);
            panel5.TabIndex = 2;
            // 
            // button_Previous
            // 
            button_Previous.BackColor = Color.FromArgb(0, 135, 209);
            button_Previous.FlatStyle = FlatStyle.Flat;
            button_Previous.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Previous.ForeColor = Color.White;
            button_Previous.Location = new Point(39, 10);
            button_Previous.Margin = new Padding(2);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(103, 32);
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
            panel4.Size = new Size(1067, 53);
            panel4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(427, 5);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(176, 41);
            label11.TabIndex = 7;
            label11.Text = "Build Exam";
            // 
            // BuildExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1067, 633);
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "BuildExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuildExamForm";
            tabControl1.ResumeLayout(false);
            tabPage_step1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage_step2.ResumeLayout(false);
            panel_questions.ResumeLayout(false);
            panel_questions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_step1;
        private TabPage tabPage_step2;
        private TabPage tabPage_step3;
        private TextBox textBox_teacherName;
        private TextBox textBox_hours_StartTime;
        private TextBox textBox_examTitle;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox textBox_minutes_StartTime;
        private DateTimePicker dateTimePicker_examDate;
        private TextBox textBox_date;
        private Label label7;
        private TextBox textBox_minutes_totalTime;
        private TextBox textBox_hours_totalTime;
        private ComboBox comboBox_Course_Select;
        private Label label_teaStu;
        private Label label2;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label11;
        private Button button_SaveExamBuilder;
        private Button button_next;
        private Panel panel5;
        private Button button_Previous;
        private Label label_question;
        private Panel panel_questions;
        private CheckBox checkBox_OptionOrder;
        private Button button_AddQuestion;
        private Button button_SaveQuestion;
        private CheckBox checkBox_QuestionOrder;
        private Button button_addOption;
        private TextBox textBox_QuetionContent;
        private BindingSource questionBindingSource;
        private Button button_Test;
        private Button button_testQuestions;
    }
}