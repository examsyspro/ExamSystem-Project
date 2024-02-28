﻿using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using ExamSystem_Project.FormModels;

namespace ExamSystem_Project.Forms
{
    public partial class ExamRunForm2 : Form
    {

        private readonly int[] numbersArr = { 1, 2, 3, 4, 5, 6, 7 };
        public RunExamFormModel examModel;
        public static ExamRunForm2 runExam;
        public User user;
        public ExamRunForm2(Exam exam, User user1)
        {
            InitializeComponent();
            this.user = user1;
            InitializeAll();
            runExam = this;
            examModel = new RunExamFormModel(exam);

        }

        public void InitializeAll()
        {

            try
            {
                tabControl1.TabPages.Remove(tabPage_step2);
                tabControl1.TabPages.Remove(tabPage_step3);
                panel_questions.SendToBack();
                button_SaveExamBuilder.Enabled = false;

                // Set DPI Awareness
                this.AutoScaleMode = AutoScaleMode.Dpi;

                // Set StartPosition to Manual
                StartPosition = FormStartPosition.CenterScreen;

                // Calculate and set the position and size of the form
                Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;

                // Set maximum width and height for the form
                int maxWidth = screen.Width - 100; // Adjust this value as needed
                int maxHeight = screen.Height - 100; // Adjust this value as needed
                int desiredFormWidth = 1237; // Set your desired form width
                int w = Math.Min(desiredFormWidth, maxWidth);
                int h = Math.Min(Height, maxHeight);

                Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
                Size = new Size(w, h);








                button_SaveExamBuilder.Visible = false;
                button_next.Visible = true;
                //  textBox_teacherName.Text = user.FullName;
            }
            catch (Exception ex)
            {


            }





        }

        private void button_next_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedTab.Name)
                {
                    case "tabPage_step1":
                        if (!tabControl1.TabPages.Contains(tabPage_step2))
                        {

                            examModel.CheckQuestionListSize();
                            tabControl1.TabPages.Add(tabPage_step2);
                            tabControl1.TabPages.Remove(tabPage_step1);
                            examModel.RefreshQuestionsListBox();
                        }

                        tabControl1.SelectedTab = tabPage_step2;
                        break;
                    case "tabPage_step2":

                        if (!tabControl1.TabPages.Contains(tabPage_step3))
                        {
                            button_next.Visible = false;
                            tabControl1.TabPages.Add(tabPage_step3);
                            tabControl1.TabPages.Remove(tabPage_step2);
                        }
                        // ExamButtonHandler(new TextBox());
                        tabControl1.SelectedTab = tabPage_step3;
                        button_SaveExamBuilder.Visible = true;
                        button_SaveExamBuilder.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {


            }



        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedTab.Name)
                {
                    case "tabPage_step3":
                        if (!tabControl1.TabPages.Contains(tabPage_step2))
                        {
                            tabControl1.TabPages.Add(tabPage_step2);
                            tabControl1.TabPages.Remove(tabPage_step3);
                            button_SaveExamBuilder.Visible = false;
                            button_SaveExamBuilder.Enabled = false;
                            button_next.Visible = true;
                        }
                        tabControl1.SelectedTab = tabPage_step2;
                        break;
                    case "tabPage_step2":
                        if (!tabControl1.TabPages.Contains(tabPage_step1))
                        {
                            tabControl1.TabPages.Add(tabPage_step1);
                            tabControl1.TabPages.Remove(tabPage_step2);
                        }

                        tabControl1.SelectedTab = tabPage_step1;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {


            }

        }

        public void ExamButtonHandler(Label text)
        {
            ChangeTextBoxColor(text);
            bool res = CheckEmptyPanelControls(panel1);
            button_next.Enabled = res;

        }

        public bool CheckEmptyPanelControls(Panel panel)
        {
            bool res = true;
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox t)
                {
                    if (string.IsNullOrEmpty(t.Text))
                    {

                        res = false;
                        break;
                    }
                }
                if (item is ComboBox c)
                {
                    if (c.SelectedItem == null || c.SelectedIndex == -1)
                    {
                        res = false;
                        break;
                    }
                }
            }

            return res;
        }

        public void ChangeTextBoxColor(Label text)
        {
            if (text.Text == string.Empty)
            {
                text.BackColor = Color.MistyRose;
            }
            else
            {
                text.BackColor = Color.White;
            }
        }





        private void button_addOption_Click(object sender, EventArgs e)
        {
            examModel.CreateDynamicOptions();
        }

        private void button_SaveQuestion_Click(object sender, EventArgs e)
        {

            panel_questionList.BringToFront();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            //textBox_examTitle.Text = "test exam";
            //textBox_teacherName.Text = "test teacher";
            //textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
            //comboBox_Course_Select.SelectedIndex = 0;
            //checkBox_QuestionOrder.Checked = true;
            //comboBox_hours_StartTime.SelectedIndex = 1;
            //comboBox_minutes_StartTime.SelectedIndex = 0;
            //comboBox_hours_totalTime.SelectedIndex = 1;
            //comboBox_minutes_totalTime.SelectedIndex = 0;
        }



        private void button_ShowQuestions_Click(object sender, EventArgs e)
        {
            panel_questions.SendToBack();
        }

        private void button_AddQuestion_Click(object sender, EventArgs e)
        {
            panel_questions.BringToFront();

        }

        private void listBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            examModel.Questions_SelectedIndex();
        }

        private void button_SaveExamBuilder_Click(object sender, EventArgs e)
        {
            examModel.SaveExam();
        }









        private void button_removeQuestion_Click(object sender, EventArgs e)
        {
            examModel.RemoveQuestion();
        }

        private void button_updateQuestion_Click(object sender, EventArgs e)
        {

            examModel.UpdateQuestion();
            panel_questionList.SendToBack();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            examModel.CreateQuestions();
        }
    }
}
