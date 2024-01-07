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
            tabControl1 = new TabControl();
            tabPage_step1 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
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
            tabPage_step3 = new TabPage();
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
            tabControl1.Location = new Point(24, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1405, 876);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_step1
            // 
            tabPage_step1.BackColor = SystemColors.Window;
            tabPage_step1.Controls.Add(panel1);
            tabPage_step1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_step1.Location = new Point(4, 47);
            tabPage_step1.Name = "tabPage_step1";
            tabPage_step1.Padding = new Padding(3);
            tabPage_step1.Size = new Size(1397, 825);
            tabPage_step1.TabIndex = 0;
            tabPage_step1.Text = "Exam details";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
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
            panel1.Location = new Point(26, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 763);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 56);
            panel2.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 135, 209);
            label5.Location = new Point(54, 121);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 11;
            label5.Text = "Exam Title :";
            // 
            // dateTimePicker_examDate
            // 
            dateTimePicker_examDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_examDate.Location = new Point(219, 312);
            dateTimePicker_examDate.Name = "dateTimePicker_examDate";
            dateTimePicker_examDate.Size = new Size(331, 37);
            dateTimePicker_examDate.TabIndex = 19;
            dateTimePicker_examDate.ValueChanged += dateTimePicker_examDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(398, 548);
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
            label7.Location = new Point(57, 312);
            label7.Name = "label7";
            label7.Size = new Size(136, 30);
            label7.TabIndex = 20;
            label7.Text = "Exam Date :";
            // 
            // textBox_examTitle
            // 
            textBox_examTitle.BorderStyle = BorderStyle.FixedSingle;
            textBox_examTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_examTitle.Location = new Point(203, 119);
            textBox_examTitle.Name = "textBox_examTitle";
            textBox_examTitle.Size = new Size(292, 37);
            textBox_examTitle.TabIndex = 0;
            // 
            // textBox_minutes_StartTime
            // 
            textBox_minutes_StartTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_minutes_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_minutes_StartTime.Location = new Point(395, 401);
            textBox_minutes_StartTime.Name = "textBox_minutes_StartTime";
            textBox_minutes_StartTime.Size = new Size(100, 37);
            textBox_minutes_StartTime.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(267, 548);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 27;
            label9.Text = "Hours";
            // 
            // textBox_date
            // 
            textBox_date.BorderStyle = BorderStyle.FixedSingle;
            textBox_date.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_date.Location = new Point(586, 312);
            textBox_date.Name = "textBox_date";
            textBox_date.ReadOnly = true;
            textBox_date.Size = new Size(188, 37);
            textBox_date.TabIndex = 21;
            // 
            // textBox_hours_StartTime
            // 
            textBox_hours_StartTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_hours_StartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_hours_StartTime.Location = new Point(267, 401);
            textBox_hours_StartTime.Name = "textBox_hours_StartTime";
            textBox_hours_StartTime.Size = new Size(100, 37);
            textBox_hours_StartTime.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 135, 209);
            label6.Location = new Point(54, 511);
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
            label2.Location = new Point(398, 442);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 26;
            label2.Text = "Minutes";
            // 
            // textBox_hours_totalTime
            // 
            textBox_hours_totalTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_hours_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_hours_totalTime.Location = new Point(267, 509);
            textBox_hours_totalTime.Name = "textBox_hours_totalTime";
            textBox_hours_totalTime.Size = new Size(100, 37);
            textBox_hours_totalTime.TabIndex = 22;
            // 
            // textBox_teacherName
            // 
            textBox_teacherName.BorderStyle = BorderStyle.FixedSingle;
            textBox_teacherName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_teacherName.Location = new Point(242, 214);
            textBox_teacherName.Name = "textBox_teacherName";
            textBox_teacherName.Size = new Size(253, 37);
            textBox_teacherName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 135, 209);
            label4.Location = new Point(54, 622);
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
            label_teaStu.Location = new Point(267, 442);
            label_teaStu.Name = "label_teaStu";
            label_teaStu.Size = new Size(63, 25);
            label_teaStu.TabIndex = 25;
            label_teaStu.Text = "Hours";
            // 
            // textBox_minutes_totalTime
            // 
            textBox_minutes_totalTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_minutes_totalTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_minutes_totalTime.Location = new Point(395, 508);
            textBox_minutes_totalTime.Name = "textBox_minutes_totalTime";
            textBox_minutes_totalTime.Size = new Size(100, 37);
            textBox_minutes_totalTime.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 135, 209);
            label1.Location = new Point(57, 216);
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
            label3.Location = new Point(57, 403);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 14;
            label3.Text = "Start Time :";
            // 
            // comboBox_Course_Select
            // 
            comboBox_Course_Select.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Course_Select.FormattingEnabled = true;
            comboBox_Course_Select.Location = new Point(169, 623);
            comboBox_Course_Select.Name = "comboBox_Course_Select";
            comboBox_Course_Select.Size = new Size(247, 38);
            comboBox_Course_Select.TabIndex = 24;
            // 
            // tabPage_step2
            // 
            tabPage_step2.Location = new Point(4, 47);
            tabPage_step2.Name = "tabPage_step2";
            tabPage_step2.Padding = new Padding(3);
            tabPage_step2.Size = new Size(1397, 825);
            tabPage_step2.TabIndex = 1;
            tabPage_step2.Text = "Add questions";
            tabPage_step2.UseVisualStyleBackColor = true;
            // 
            // tabPage_step3
            // 
            tabPage_step3.Location = new Point(4, 47);
            tabPage_step3.Margin = new Padding(4, 5, 4, 5);
            tabPage_step3.Name = "tabPage_step3";
            tabPage_step3.Padding = new Padding(4, 5, 4, 5);
            tabPage_step3.Size = new Size(1397, 825);
            tabPage_step3.TabIndex = 2;
            tabPage_step3.Text = "Question list";
            tabPage_step3.UseVisualStyleBackColor = true;
            // 
            // button_SaveExamBuilder
            // 
            button_SaveExamBuilder.BackColor = Color.FromArgb(0, 135, 209);
            button_SaveExamBuilder.FlatStyle = FlatStyle.Flat;
            button_SaveExamBuilder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_SaveExamBuilder.ForeColor = Color.White;
            button_SaveExamBuilder.Location = new Point(629, 16);
            button_SaveExamBuilder.Name = "button_SaveExamBuilder";
            button_SaveExamBuilder.Size = new Size(181, 54);
            button_SaveExamBuilder.TabIndex = 2;
            button_SaveExamBuilder.Text = "Save Exam";
            button_SaveExamBuilder.UseVisualStyleBackColor = false;
            // 
            // button_next
            // 
            button_next.BackColor = Color.FromArgb(0, 135, 209);
            button_next.FlatStyle = FlatStyle.Flat;
            button_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_next.ForeColor = Color.White;
            button_next.Location = new Point(1313, 16);
            button_next.Name = "button_next";
            button_next.Size = new Size(134, 54);
            button_next.TabIndex = 3;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += button_next_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1459, 1104);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_next);
            panel5.Controls.Add(button_Previous);
            panel5.Controls.Add(button_SaveExamBuilder);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 1013);
            panel5.Name = "panel5";
            panel5.Size = new Size(1459, 91);
            panel5.TabIndex = 2;
            // 
            // button_Previous
            // 
            button_Previous.BackColor = Color.FromArgb(0, 135, 209);
            button_Previous.FlatStyle = FlatStyle.Flat;
            button_Previous.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Previous.ForeColor = Color.White;
            button_Previous.Location = new Point(12, 16);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(147, 54);
            button_Previous.TabIndex = 4;
            button_Previous.Text = "Previous";
            button_Previous.UseVisualStyleBackColor = false;
            button_Previous.Click += button_Previous_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1459, 89);
            panel4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 135, 209);
            label11.Location = new Point(610, 9);
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
            ClientSize = new Size(1459, 1104);
            Controls.Add(panel3);
            Name = "BuildExamForm";
            Text = "BuildExamForm";
            tabControl1.ResumeLayout(false);
            tabPage_step1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label11;
        private Button button_SaveExamBuilder;
        private Button button_next;
        private Panel panel5;
        private Button button_Previous;
    }
}