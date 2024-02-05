﻿namespace ExamSystem_Project.Forms
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
            label_filedsReq = new Label();
            button_Test = new Button();
            panel1 = new Panel();
            comboBox_minutes_totalTime = new ComboBox();
            comboBox_hours_totalTime = new ComboBox();
            comboBox_minutes_StartTime = new ComboBox();
            comboBox_hours_StartTime = new ComboBox();
            checkBox_QuestionOrder = new CheckBox();
            label5 = new Label();
            dateTimePicker_examDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            textBox_examTitle = new TextBox();
            label9 = new Label();
            textBox_date = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBox_teacherName = new TextBox();
            label4 = new Label();
            label_teaStu = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox_Course_Select = new ComboBox();
            tabPage_step2 = new TabPage();
            button_ShowQuestions = new Button();
            button_testQuestions = new Button();
            button_AddQuestion = new Button();
            panel_questionList = new Panel();
            label12 = new Label();
            label10 = new Label();
            listBox_opstionAns = new ListBox();
            listBox_Questions = new ListBox();
            panel_questions = new Panel();
            button_SaveQuestion = new Button();
            checkBox_OptionOrder = new CheckBox();
            button_addOption = new Button();
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
            panel_questionList.SuspendLayout();
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
            tabPage_step1.Controls.Add(label_filedsReq);
            tabPage_step1.Controls.Add(button_Test);
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
            // label_filedsReq
            // 
            label_filedsReq.AutoSize = true;
            label_filedsReq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_filedsReq.ForeColor = Color.Red;
            label_filedsReq.Location = new Point(1209, 22);
            label_filedsReq.Name = "label_filedsReq";
            label_filedsReq.Size = new Size(256, 32);
            label_filedsReq.TabIndex = 32;
            label_filedsReq.Text = "* all fields are required";
            // 
            // button_Test
            // 
            button_Test.Location = new Point(1209, 112);
            button_Test.Margin = new Padding(4, 2, 4, 2);
            button_Test.Name = "button_Test";
            button_Test.Size = new Size(118, 38);
            button_Test.TabIndex = 31;
            button_Test.Text = "Test";
            button_Test.UseVisualStyleBackColor = true;
            button_Test.Click += button_Test_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(comboBox_minutes_totalTime);
            panel1.Controls.Add(comboBox_hours_totalTime);
            panel1.Controls.Add(comboBox_minutes_StartTime);
            panel1.Controls.Add(comboBox_hours_StartTime);
            panel1.Controls.Add(checkBox_QuestionOrder);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker_examDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_examTitle);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox_date);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_teacherName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label_teaStu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox_Course_Select);
            panel1.Location = new Point(26, 22);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 762);
            panel1.TabIndex = 30;
            // 
            // comboBox_minutes_totalTime
            // 
            comboBox_minutes_totalTime.DropDownHeight = 100;
            comboBox_minutes_totalTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_minutes_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_minutes_totalTime.FormattingEnabled = true;
            comboBox_minutes_totalTime.IntegralHeight = false;
            comboBox_minutes_totalTime.ItemHeight = 30;
            comboBox_minutes_totalTime.Location = new Point(395, 448);
            comboBox_minutes_totalTime.Name = "comboBox_minutes_totalTime";
            comboBox_minutes_totalTime.Size = new Size(100, 38);
            comboBox_minutes_totalTime.TabIndex = 33;
            comboBox_minutes_totalTime.SelectedIndexChanged += comboBox_minutes_totalTime_SelectedIndexChanged;
            // 
            // comboBox_hours_totalTime
            // 
            comboBox_hours_totalTime.BackColor = SystemColors.Window;
            comboBox_hours_totalTime.DropDownHeight = 100;
            comboBox_hours_totalTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_hours_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_hours_totalTime.FormattingEnabled = true;
            comboBox_hours_totalTime.IntegralHeight = false;
            comboBox_hours_totalTime.ItemHeight = 30;
            comboBox_hours_totalTime.Location = new Point(266, 448);
            comboBox_hours_totalTime.Name = "comboBox_hours_totalTime";
            comboBox_hours_totalTime.Size = new Size(100, 38);
            comboBox_hours_totalTime.TabIndex = 32;
            comboBox_hours_totalTime.SelectedIndexChanged += comboBox_hours_totalTime_SelectedIndexChanged;
            // 
            // comboBox_minutes_StartTime
            // 
            comboBox_minutes_StartTime.DropDownHeight = 100;
            comboBox_minutes_StartTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_minutes_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_minutes_StartTime.FormattingEnabled = true;
            comboBox_minutes_StartTime.IntegralHeight = false;
            comboBox_minutes_StartTime.ItemHeight = 30;
            comboBox_minutes_StartTime.Location = new Point(329, 338);
            comboBox_minutes_StartTime.Name = "comboBox_minutes_StartTime";
            comboBox_minutes_StartTime.Size = new Size(100, 38);
            comboBox_minutes_StartTime.TabIndex = 31;
            comboBox_minutes_StartTime.SelectedIndexChanged += comboBox_minutes_StartTime_SelectedIndexChanged;
            // 
            // comboBox_hours_StartTime
            // 
            comboBox_hours_StartTime.BackColor = SystemColors.Window;
            comboBox_hours_StartTime.DropDownHeight = 100;
            comboBox_hours_StartTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_hours_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_hours_StartTime.FormattingEnabled = true;
            comboBox_hours_StartTime.IntegralHeight = false;
            comboBox_hours_StartTime.ItemHeight = 30;
            comboBox_hours_StartTime.Location = new Point(200, 338);
            comboBox_hours_StartTime.Name = "comboBox_hours_StartTime";
            comboBox_hours_StartTime.Size = new Size(100, 38);
            comboBox_hours_StartTime.TabIndex = 30;
            comboBox_hours_StartTime.SelectedIndexChanged += comboBox_hours_StartTime_SelectedIndexChanged;
            // 
            // checkBox_QuestionOrder
            // 
            checkBox_QuestionOrder.AutoSize = true;
            checkBox_QuestionOrder.CheckAlign = ContentAlignment.MiddleRight;
            checkBox_QuestionOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_QuestionOrder.ForeColor = Color.FromArgb(0, 135, 209);
            checkBox_QuestionOrder.Location = new Point(54, 648);
            checkBox_QuestionOrder.Margin = new Padding(4, 2, 4, 2);
            checkBox_QuestionOrder.Name = "checkBox_QuestionOrder";
            checkBox_QuestionOrder.Size = new Size(303, 34);
            checkBox_QuestionOrder.TabIndex = 29;
            checkBox_QuestionOrder.Text = "Random Question Order :";
            checkBox_QuestionOrder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 135, 209);
            label5.Location = new Point(51, 58);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 11;
            label5.Text = "Exam Title :";
            // 
            // dateTimePicker_examDate
            // 
            dateTimePicker_examDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_examDate.Location = new Point(216, 248);
            dateTimePicker_examDate.Margin = new Padding(2);
            dateTimePicker_examDate.Name = "dateTimePicker_examDate";
            dateTimePicker_examDate.Size = new Size(332, 37);
            dateTimePicker_examDate.TabIndex = 19;
            dateTimePicker_examDate.ValueChanged += dateTimePicker_examDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(392, 492);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 28;
            label8.Text = "Minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 135, 209);
            label7.Location = new Point(54, 248);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 30);
            label7.TabIndex = 20;
            label7.Text = "Exam Date :";
            // 
            // textBox_examTitle
            // 
            textBox_examTitle.BorderStyle = BorderStyle.FixedSingle;
            textBox_examTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_examTitle.Location = new Point(200, 55);
            textBox_examTitle.Margin = new Padding(2);
            textBox_examTitle.Name = "textBox_examTitle";
            textBox_examTitle.Size = new Size(292, 37);
            textBox_examTitle.TabIndex = 0;
            textBox_examTitle.TextChanged += textBox_examTitle_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(266, 492);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 27;
            label9.Text = "Hours";
            // 
            // textBox_date
            // 
            textBox_date.BorderStyle = BorderStyle.FixedSingle;
            textBox_date.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_date.Location = new Point(584, 248);
            textBox_date.Margin = new Padding(2);
            textBox_date.Name = "textBox_date";
            textBox_date.ReadOnly = true;
            textBox_date.Size = new Size(188, 37);
            textBox_date.TabIndex = 21;
            textBox_date.TextChanged += textBox_date_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 135, 209);
            label6.Location = new Point(51, 448);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(201, 30);
            label6.TabIndex = 16;
            label6.Text = "Total Exam Time : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(329, 385);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 26;
            label2.Text = "Minutes";
            // 
            // textBox_teacherName
            // 
            textBox_teacherName.BorderStyle = BorderStyle.FixedSingle;
            textBox_teacherName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_teacherName.Location = new Point(240, 150);
            textBox_teacherName.Margin = new Padding(2);
            textBox_teacherName.Name = "textBox_teacherName";
            textBox_teacherName.Size = new Size(253, 37);
            textBox_teacherName.TabIndex = 3;
            textBox_teacherName.TextChanged += textBox_teacherName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 135, 209);
            label4.Location = new Point(51, 558);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 15;
            label4.Text = "Course :";
            // 
            // label_teaStu
            // 
            label_teaStu.AutoSize = true;
            label_teaStu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_teaStu.ForeColor = SystemColors.GrayText;
            label_teaStu.Location = new Point(200, 385);
            label_teaStu.Margin = new Padding(2, 0, 2, 0);
            label_teaStu.Name = "label_teaStu";
            label_teaStu.Size = new Size(63, 25);
            label_teaStu.TabIndex = 25;
            label_teaStu.Text = "Hours";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 135, 209);
            label1.Location = new Point(54, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 12;
            label1.Text = "Teacher Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 135, 209);
            label3.Location = new Point(54, 338);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 14;
            label3.Text = "Start Time :";
            // 
            // comboBox_Course_Select
            // 
            comboBox_Course_Select.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Course_Select.FormattingEnabled = true;
            comboBox_Course_Select.Location = new Point(166, 558);
            comboBox_Course_Select.Margin = new Padding(2);
            comboBox_Course_Select.Name = "comboBox_Course_Select";
            comboBox_Course_Select.Size = new Size(246, 38);
            comboBox_Course_Select.TabIndex = 24;
            comboBox_Course_Select.SelectedIndexChanged += comboBox_Course_Select_SelectedIndexChanged;
            // 
            // tabPage_step2
            // 
            tabPage_step2.Controls.Add(button_ShowQuestions);
            tabPage_step2.Controls.Add(button_testQuestions);
            tabPage_step2.Controls.Add(button_AddQuestion);
            tabPage_step2.Controls.Add(panel_questions);
            tabPage_step2.Controls.Add(panel_questionList);
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
            // button_ShowQuestions
            // 
            button_ShowQuestions.BackColor = Color.FromArgb(0, 135, 209);
            button_ShowQuestions.FlatStyle = FlatStyle.Flat;
            button_ShowQuestions.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_ShowQuestions.ForeColor = Color.White;
            button_ShowQuestions.Location = new Point(1276, 121);
            button_ShowQuestions.Margin = new Padding(2);
            button_ShowQuestions.Name = "button_ShowQuestions";
            button_ShowQuestions.Size = new Size(201, 52);
            button_ShowQuestions.TabIndex = 33;
            button_ShowQuestions.Text = "Show Questions";
            button_ShowQuestions.UseVisualStyleBackColor = false;
            button_ShowQuestions.Click += button_ShowQuestions_Click;
            // 
            // button_testQuestions
            // 
            button_testQuestions.Location = new Point(1331, 444);
            button_testQuestions.Margin = new Padding(4, 2, 4, 2);
            button_testQuestions.Name = "button_testQuestions";
            button_testQuestions.Size = new Size(139, 48);
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
            button_AddQuestion.Location = new Point(1276, 46);
            button_AddQuestion.Margin = new Padding(2);
            button_AddQuestion.Name = "button_AddQuestion";
            button_AddQuestion.Size = new Size(201, 52);
            button_AddQuestion.TabIndex = 4;
            button_AddQuestion.Text = "Add Question";
            button_AddQuestion.UseVisualStyleBackColor = false;
            button_AddQuestion.Click += button_AddQuestion_Click;
            // 
            // panel_questionList
            // 
            panel_questionList.BackColor = SystemColors.InactiveBorder;
            panel_questionList.Controls.Add(label12);
            panel_questionList.Controls.Add(label10);
            panel_questionList.Controls.Add(listBox_opstionAns);
            panel_questionList.Controls.Add(listBox_Questions);
            panel_questionList.Location = new Point(6, 6);
            panel_questionList.Margin = new Padding(2);
            panel_questionList.Name = "panel_questionList";
            panel_questionList.Size = new Size(1255, 794);
            panel_questionList.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 135, 209);
            label12.Location = new Point(645, 154);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(113, 30);
            label12.TabIndex = 13;
            label12.Text = "Options : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 135, 209);
            label10.Location = new Point(36, 154);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(134, 30);
            label10.TabIndex = 12;
            label10.Text = "Questions : ";
            // 
            // listBox_opstionAns
            // 
            listBox_opstionAns.FormattingEnabled = true;
            listBox_opstionAns.ItemHeight = 25;
            listBox_opstionAns.Location = new Point(645, 196);
            listBox_opstionAns.Margin = new Padding(4);
            listBox_opstionAns.Name = "listBox_opstionAns";
            listBox_opstionAns.Size = new Size(570, 404);
            listBox_opstionAns.TabIndex = 1;
            listBox_opstionAns.SelectedIndexChanged += listBox_opstionAns_SelectedIndexChanged;
            // 
            // listBox_Questions
            // 
            listBox_Questions.FormattingEnabled = true;
            listBox_Questions.ItemHeight = 25;
            listBox_Questions.Location = new Point(36, 196);
            listBox_Questions.Margin = new Padding(4);
            listBox_Questions.Name = "listBox_Questions";
            listBox_Questions.Size = new Size(544, 404);
            listBox_Questions.TabIndex = 0;
            listBox_Questions.SelectedIndexChanged += listBox_Questions_SelectedIndexChanged;
            // 
            // panel_questions
            // 
            panel_questions.BackColor = SystemColors.InactiveBorder;
            panel_questions.Controls.Add(button_SaveQuestion);
            panel_questions.Controls.Add(checkBox_OptionOrder);
            panel_questions.Controls.Add(button_addOption);
            panel_questions.Controls.Add(textBox_QuetionContent);
            panel_questions.Controls.Add(label_question);
            panel_questions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_questions.Location = new Point(8, 6);
            panel_questions.Margin = new Padding(4, 2, 4, 2);
            panel_questions.Name = "panel_questions";
            panel_questions.Size = new Size(1255, 794);
            panel_questions.TabIndex = 1;
            // 
            // button_SaveQuestion
            // 
            button_SaveQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_SaveQuestion.FlatStyle = FlatStyle.Flat;
            button_SaveQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SaveQuestion.ForeColor = Color.White;
            button_SaveQuestion.Location = new Point(1056, 730);
            button_SaveQuestion.Margin = new Padding(2);
            button_SaveQuestion.Name = "button_SaveQuestion";
            button_SaveQuestion.Size = new Size(182, 52);
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
            checkBox_OptionOrder.Location = new Point(875, 100);
            checkBox_OptionOrder.Margin = new Padding(4, 2, 4, 2);
            checkBox_OptionOrder.Name = "checkBox_OptionOrder";
            checkBox_OptionOrder.Size = new Size(188, 34);
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
            button_addOption.Location = new Point(875, 38);
            button_addOption.Margin = new Padding(2);
            button_addOption.Name = "button_addOption";
            button_addOption.Size = new Size(156, 52);
            button_addOption.TabIndex = 5;
            button_addOption.Text = "Add Option";
            button_addOption.UseVisualStyleBackColor = false;
            button_addOption.Click += button_addOption_Click;
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
            textBox_QuetionContent.TextChanged += textBox_QuetionContent_TextChanged;
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
            button_SaveExamBuilder.Location = new Point(668, 18);
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
            label11.Size = new Size(256, 60);
            label11.TabIndex = 7;
            label11.Text = "Build Exam";
            // 
            // BuildExamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1524, 1055);
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "BuildExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuildExamForm";
            tabControl1.ResumeLayout(false);
            tabPage_step1.ResumeLayout(false);
            tabPage_step1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage_step2.ResumeLayout(false);
            panel_questionList.ResumeLayout(false);
            panel_questionList.PerformLayout();
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

        private TabControl tabControl1;
        private TabPage tabPage_step1;
        private TabPage tabPage_step2;
        private TabPage tabPage_step3;
        private TextBox textBox_teacherName;
        private TextBox textBox_examTitle;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker_examDate;
        private TextBox textBox_date;
        private Label label7;
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
        private Panel panel_questionList;
        private Button button_ShowQuestions;
        private ListBox listBox_Questions;
        private BindingSource questionBindingSource1;
        private ListBox listBox_opstionAns;
        private Label label12;
        private Label label10;
        private ComboBox comboBox_hours_StartTime;
        private ComboBox comboBox_minutes_StartTime;
        private Label label_filedsReq;
        private ComboBox comboBox_minutes_totalTime;
        private ComboBox comboBox_hours_totalTime;
    }
}