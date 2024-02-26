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
            button_Test = new Button();
            panel1 = new Panel();
            tabPage_step2 = new TabPage();
            button_ShowQuestions = new Button();
            button_testQuestions = new Button();
            button_AddQuestion = new Button();
            panel_questions = new Panel();
            button_SaveQuestion = new Button();
            textBox_QuetionContent = new TextBox();
            label_question = new Label();
            panel_questionList = new Panel();
            button_removeQuestion = new Button();
            button_updateQuestion = new Button();
            label12 = new Label();
            label10 = new Label();
            listBox_opstionAns = new ListBox();
            listBox_Questions = new ListBox();
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
            label_TeacherName_S = new Label();
            label_course_S = new Label();
            label_totalExamTime_S = new Label();
            label_examTitle_S = new Label();
            label_pointQuestion_S = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label15 = new Label();
            label14 = new Label();
            button_addOption = new Button();
            checkBox_OptionOrder = new CheckBox();
            button_start = new Button();
            tabControl1.SuspendLayout();
            tabPage_step1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage_step2.SuspendLayout();
            panel_questions.SuspendLayout();
            panel_questionList.SuspendLayout();
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
            tabControl1.Location = new Point(9, 82);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1198, 686);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_step1
            // 
            tabPage_step1.BackColor = SystemColors.Window;
            tabPage_step1.Controls.Add(button_Test);
            tabPage_step1.Controls.Add(panel1);
            tabPage_step1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step1.Location = new Point(4, 40);
            tabPage_step1.Margin = new Padding(2);
            tabPage_step1.Name = "tabPage_step1";
            tabPage_step1.Padding = new Padding(2);
            tabPage_step1.Size = new Size(1190, 642);
            tabPage_step1.TabIndex = 0;
            tabPage_step1.Text = "Exam details";
            // 
            // button_Test
            // 
            button_Test.Location = new Point(967, 90);
            button_Test.Margin = new Padding(3, 2, 3, 2);
            button_Test.Name = "button_Test";
            button_Test.Size = new Size(94, 30);
            button_Test.TabIndex = 31;
            button_Test.Text = "Test";
            button_Test.UseVisualStyleBackColor = true;
            button_Test.Click += button_Test_Click;
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
            panel1.Location = new Point(21, 18);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 610);
            panel1.TabIndex = 30;
            // 
            // tabPage_step2
            // 
            tabPage_step2.Controls.Add(button_ShowQuestions);
            tabPage_step2.Controls.Add(button_testQuestions);
            tabPage_step2.Controls.Add(button_AddQuestion);
            tabPage_step2.Controls.Add(panel_questions);
            tabPage_step2.Controls.Add(panel_questionList);
            tabPage_step2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step2.Location = new Point(4, 40);
            tabPage_step2.Margin = new Padding(2);
            tabPage_step2.Name = "tabPage_step2";
            tabPage_step2.Padding = new Padding(2);
            tabPage_step2.Size = new Size(1190, 642);
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
            button_ShowQuestions.Location = new Point(1021, 97);
            button_ShowQuestions.Margin = new Padding(2);
            button_ShowQuestions.Name = "button_ShowQuestions";
            button_ShowQuestions.Size = new Size(161, 42);
            button_ShowQuestions.TabIndex = 33;
            button_ShowQuestions.Text = "Show Questions";
            button_ShowQuestions.UseVisualStyleBackColor = false;
            button_ShowQuestions.Click += button_ShowQuestions_Click;
            // 
            // button_testQuestions
            // 
            button_testQuestions.Location = new Point(1065, 355);
            button_testQuestions.Margin = new Padding(3, 2, 3, 2);
            button_testQuestions.Name = "button_testQuestions";
            button_testQuestions.Size = new Size(111, 38);
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
            button_AddQuestion.Location = new Point(1021, 37);
            button_AddQuestion.Margin = new Padding(2);
            button_AddQuestion.Name = "button_AddQuestion";
            button_AddQuestion.Size = new Size(161, 42);
            button_AddQuestion.TabIndex = 4;
            button_AddQuestion.Text = "Add Question";
            button_AddQuestion.UseVisualStyleBackColor = false;
            button_AddQuestion.Click += button_AddQuestion_Click;
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
            panel_questions.Location = new Point(6, 5);
            panel_questions.Margin = new Padding(3, 2, 3, 2);
            panel_questions.Name = "panel_questions";
            panel_questions.Size = new Size(1004, 635);
            panel_questions.TabIndex = 1;
            // 
            // button_SaveQuestion
            // 
            button_SaveQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_SaveQuestion.FlatStyle = FlatStyle.Flat;
            button_SaveQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SaveQuestion.ForeColor = Color.White;
            button_SaveQuestion.Location = new Point(845, 584);
            button_SaveQuestion.Margin = new Padding(2);
            button_SaveQuestion.Name = "button_SaveQuestion";
            button_SaveQuestion.Size = new Size(146, 42);
            button_SaveQuestion.TabIndex = 3;
            button_SaveQuestion.Text = "Save Question";
            button_SaveQuestion.UseVisualStyleBackColor = false;
            button_SaveQuestion.Click += button_SaveQuestion_Click;
            // 
            // textBox_QuetionContent
            // 
            textBox_QuetionContent.BorderStyle = BorderStyle.FixedSingle;
            textBox_QuetionContent.Location = new Point(206, 30);
            textBox_QuetionContent.Margin = new Padding(3, 2, 3, 2);
            textBox_QuetionContent.Multiline = true;
            textBox_QuetionContent.Name = "textBox_QuetionContent";
            textBox_QuetionContent.Size = new Size(480, 80);
            textBox_QuetionContent.TabIndex = 1;
            textBox_QuetionContent.TextChanged += textBox_QuetionContent_TextChanged;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_question.ForeColor = Color.FromArgb(0, 135, 209);
            label_question.Location = new Point(20, 32);
            label_question.Name = "label_question";
            label_question.Size = new Size(179, 25);
            label_question.TabIndex = 0;
            label_question.Text = "Question Content :";
            // 
            // panel_questionList
            // 
            panel_questionList.BackColor = SystemColors.InactiveBorder;
            panel_questionList.Controls.Add(button_removeQuestion);
            panel_questionList.Controls.Add(button_updateQuestion);
            panel_questionList.Controls.Add(label12);
            panel_questionList.Controls.Add(label10);
            panel_questionList.Controls.Add(listBox_opstionAns);
            panel_questionList.Controls.Add(listBox_Questions);
            panel_questionList.Location = new Point(5, 5);
            panel_questionList.Margin = new Padding(2);
            panel_questionList.Name = "panel_questionList";
            panel_questionList.Size = new Size(1004, 635);
            panel_questionList.TabIndex = 6;
            // 
            // button_removeQuestion
            // 
            button_removeQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_removeQuestion.FlatStyle = FlatStyle.Flat;
            button_removeQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_removeQuestion.ForeColor = Color.White;
            button_removeQuestion.Location = new Point(251, 413);
            button_removeQuestion.Margin = new Padding(2);
            button_removeQuestion.Name = "button_removeQuestion";
            button_removeQuestion.Size = new Size(161, 42);
            button_removeQuestion.TabIndex = 15;
            button_removeQuestion.Text = "Remove";
            button_removeQuestion.UseVisualStyleBackColor = false;
            button_removeQuestion.Click += button_removeQuestion_Click;
            // 
            // button_updateQuestion
            // 
            button_updateQuestion.BackColor = Color.FromArgb(0, 135, 209);
            button_updateQuestion.FlatStyle = FlatStyle.Flat;
            button_updateQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_updateQuestion.ForeColor = Color.White;
            button_updateQuestion.Location = new Point(73, 413);
            button_updateQuestion.Margin = new Padding(2);
            button_updateQuestion.Name = "button_updateQuestion";
            button_updateQuestion.Size = new Size(161, 42);
            button_updateQuestion.TabIndex = 14;
            button_updateQuestion.Text = "Update";
            button_updateQuestion.UseVisualStyleBackColor = false;
            button_updateQuestion.Click += button_updateQuestion_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 135, 209);
            label12.Location = new Point(509, 29);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 13;
            label12.Text = "Options : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 135, 209);
            label10.Location = new Point(22, 29);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(115, 25);
            label10.TabIndex = 12;
            label10.Text = "Questions : ";
            // 
            // listBox_opstionAns
            // 
            listBox_opstionAns.FormattingEnabled = true;
            listBox_opstionAns.ItemHeight = 20;
            listBox_opstionAns.Location = new Point(509, 62);
            listBox_opstionAns.Name = "listBox_opstionAns";
            listBox_opstionAns.Size = new Size(457, 324);
            listBox_opstionAns.TabIndex = 1;
            // 
            // listBox_Questions
            // 
            listBox_Questions.FormattingEnabled = true;
            listBox_Questions.ItemHeight = 20;
            listBox_Questions.Location = new Point(22, 62);
            listBox_Questions.Name = "listBox_Questions";
            listBox_Questions.Size = new Size(436, 324);
            listBox_Questions.TabIndex = 0;
            listBox_Questions.SelectedIndexChanged += listBox_Questions_SelectedIndexChanged;
            // 
            // tabPage_step3
            // 
            tabPage_step3.Location = new Point(4, 40);
            tabPage_step3.Margin = new Padding(3, 4, 3, 4);
            tabPage_step3.Name = "tabPage_step3";
            tabPage_step3.Padding = new Padding(3, 4, 3, 4);
            tabPage_step3.Size = new Size(1190, 642);
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
            button_SaveExamBuilder.Location = new Point(1039, 14);
            button_SaveExamBuilder.Margin = new Padding(2);
            button_SaveExamBuilder.Name = "button_SaveExamBuilder";
            button_SaveExamBuilder.Size = new Size(145, 42);
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
            button_next.Location = new Point(1055, 14);
            button_next.Margin = new Padding(2);
            button_next.Name = "button_next";
            button_next.Size = new Size(107, 42);
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
            panel3.Size = new Size(1219, 844);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_next);
            panel5.Controls.Add(button_Previous);
            panel5.Controls.Add(button_SaveExamBuilder);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 770);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1219, 74);
            panel5.TabIndex = 2;
            // 
            // button_Previous
            // 
            button_Previous.BackColor = Color.FromArgb(0, 135, 209);
            button_Previous.FlatStyle = FlatStyle.Flat;
            button_Previous.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Previous.ForeColor = Color.White;
            button_Previous.Location = new Point(45, 14);
            button_Previous.Margin = new Padding(2);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(118, 42);
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
            panel4.Size = new Size(1219, 70);
            panel4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(488, 6);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(185, 50);
            label11.TabIndex = 7;
            label11.Text = "run Exam";
            // 
            // label_TeacherName_S
            // 
            label_TeacherName_S.AutoSize = true;
            label_TeacherName_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_TeacherName_S.ForeColor = Color.Black;
            label_TeacherName_S.Location = new Point(186, 94);
            label_TeacherName_S.Margin = new Padding(2, 0, 2, 0);
            label_TeacherName_S.Name = "label_TeacherName_S";
            label_TeacherName_S.Size = new Size(132, 25);
            label_TeacherName_S.TabIndex = 31;
            label_TeacherName_S.Text = "Teacher Name";
            // 
            // label_course_S
            // 
            label_course_S.AutoSize = true;
            label_course_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_course_S.ForeColor = Color.Black;
            label_course_S.Location = new Point(125, 228);
            label_course_S.Margin = new Padding(2, 0, 2, 0);
            label_course_S.Name = "label_course_S";
            label_course_S.Size = new Size(71, 25);
            label_course_S.TabIndex = 33;
            label_course_S.Text = "Course";
            // 
            // label_totalExamTime_S
            // 
            label_totalExamTime_S.AutoSize = true;
            label_totalExamTime_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_totalExamTime_S.ForeColor = Color.Black;
            label_totalExamTime_S.Location = new Point(220, 162);
            label_totalExamTime_S.Margin = new Padding(2, 0, 2, 0);
            label_totalExamTime_S.Name = "label_totalExamTime_S";
            label_totalExamTime_S.Size = new Size(148, 25);
            label_totalExamTime_S.TabIndex = 34;
            label_totalExamTime_S.Text = "Total Exam Time";
            // 
            // label_examTitle_S
            // 
            label_examTitle_S.AutoSize = true;
            label_examTitle_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_examTitle_S.ForeColor = Color.Black;
            label_examTitle_S.Location = new Point(154, 38);
            label_examTitle_S.Margin = new Padding(2, 0, 2, 0);
            label_examTitle_S.Name = "label_examTitle_S";
            label_examTitle_S.Size = new Size(98, 25);
            label_examTitle_S.TabIndex = 30;
            label_examTitle_S.Text = "Exam Title";
            // 
            // label_pointQuestion_S
            // 
            label_pointQuestion_S.AutoSize = true;
            label_pointQuestion_S.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_pointQuestion_S.ForeColor = Color.Black;
            label_pointQuestion_S.Location = new Point(244, 290);
            label_pointQuestion_S.Margin = new Padding(2, 0, 2, 0);
            label_pointQuestion_S.Name = "label_pointQuestion_S";
            label_pointQuestion_S.Size = new Size(174, 25);
            label_pointQuestion_S.TabIndex = 39;
            label_pointQuestion_S.Text = "Points per question";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(0, 135, 209);
            label19.Location = new Point(45, 94);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(146, 25);
            label19.TabIndex = 42;
            label19.Text = "Teacher Name :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(0, 135, 209);
            label18.Location = new Point(45, 228);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(84, 25);
            label18.TabIndex = 44;
            label18.Text = "Course :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 135, 209);
            label17.Location = new Point(45, 162);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(171, 25);
            label17.TabIndex = 45;
            label17.Text = "Total Exam Time : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 135, 209);
            label15.Location = new Point(45, 38);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(113, 25);
            label15.TabIndex = 41;
            label15.Text = "Exam Title :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 135, 209);
            label14.Location = new Point(45, 290);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(195, 25);
            label14.TabIndex = 47;
            label14.Text = "Points per question :";
            // 
            // button_addOption
            // 
            button_addOption.BackColor = Color.FromArgb(0, 135, 209);
            button_addOption.FlatStyle = FlatStyle.Flat;
            button_addOption.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_addOption.ForeColor = Color.White;
            button_addOption.Location = new Point(700, 30);
            button_addOption.Margin = new Padding(2);
            button_addOption.Name = "button_addOption";
            button_addOption.Size = new Size(125, 42);
            button_addOption.TabIndex = 5;
            button_addOption.Text = "Add Option";
            button_addOption.UseVisualStyleBackColor = false;
            button_addOption.Click += button_addOption_Click;
            // 
            // checkBox_OptionOrder
            // 
            checkBox_OptionOrder.AutoSize = true;
            checkBox_OptionOrder.CheckAlign = ContentAlignment.MiddleRight;
            checkBox_OptionOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_OptionOrder.ForeColor = Color.FromArgb(0, 135, 209);
            checkBox_OptionOrder.Location = new Point(700, 80);
            checkBox_OptionOrder.Margin = new Padding(3, 2, 3, 2);
            checkBox_OptionOrder.Name = "checkBox_OptionOrder";
            checkBox_OptionOrder.Size = new Size(161, 29);
            checkBox_OptionOrder.TabIndex = 2;
            checkBox_OptionOrder.Text = "Options Order";
            checkBox_OptionOrder.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            button_start.BackColor = Color.FromArgb(0, 135, 209);
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_start.ForeColor = Color.White;
            button_start.Location = new Point(45, 358);
            button_start.Margin = new Padding(2);
            button_start.Name = "button_start";
            button_start.Size = new Size(113, 46);
            button_start.TabIndex = 48;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            // 
            // ExamRunForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1219, 844);
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
            panel_questionList.ResumeLayout(false);
            panel_questionList.PerformLayout();
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
        private Panel panel3;
        private Panel panel4;
        private Label label11;
        private Panel panel5;
        private Button button_Previous;
        private BindingSource questionBindingSource;
        private Button button_Test;
        private Button button_testQuestions;
        private Panel panel_questionList;
        private BindingSource questionBindingSource1;
        private Label label12;
        private Label label10;
        public Button button_SaveQuestion;
        public Button button_ShowQuestions;
        public Label label_question;
        public TextBox textBox_QuetionContent;
        public Panel panel_questions;
        public ListBox listBox_Questions;
        public ListBox listBox_opstionAns;
        public Button button_SaveExamBuilder;
        public Button button_next;
        public Button button_AddQuestion;
        public Button button_removeQuestion;
        public Button button_updateQuestion;
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
        public CheckBox checkBox_OptionOrder;
        public Button button_addOption;
    }
}