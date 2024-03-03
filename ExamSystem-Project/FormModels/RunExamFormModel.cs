using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExamSystem_Project.FormModels
{
    public class RunExamFormModel
    {

        public int textBoxCounter = 0;
        public int optionNameCounter = 1;
        public Label dynamicText;
        public string[] strArr;
        public Exam exam;
        public Label dynamicLabelOption;
        public Question question;
        public OptionAns optionAns;
        public Label dynamicLabel;
        public RadioButton radioButton;
        public List<RadioButton> radioButtonList;
        public List<Label> labelList;
        public List<Label> labelListOptions;
        public List<Control> ControlsList;
        Random rand;
        public int questionIndex = 0;
        List<int> checekdList;
        public ExamRunForm2 runExam;
        public bool isExist = false;


        public RunExamFormModel(Exam examFromSt)
        {
            this.runExam = ExamRunForm2.runExam;
            this.exam = examFromSt;
            FillAllExamFields();

            radioButtonList = new List<RadioButton>();
            labelListOptions = new List<Label>();
            ControlsList = new List<Control>();
            labelList = new List<Label>();
            checekdList = new List<int>();
        }




        public void Questions_SelectedIndex()
        {
            try
            {
                runExam.listBox_opstionAns.DataSource = null;
                runExam.listBox_opstionAns.Items.Clear();


                var index = runExam.listBox_Questions.SelectedIndex;
                if (index != -1)
                {
                    question = exam.questions[index];
                    runExam.listBox_opstionAns.DataSource = question.Options;
                }
            }
            catch (Exception ex)
            {


            }
        }

        public void UpdateQuestion()
        {
            try
            {
                var index = runExam.listBox_Questions.SelectedIndex;
                question = exam.questions[index];
                ClearAllControls();
                // CreateDynamicFullFields();
            }
            catch (Exception ex)
            {



            }
        }

        public void CreateDynamicOptions()
        {

            try
            {
                runExam.button_addOption.Enabled = textBoxCounter == 4 ? true : false;

                // Create a unique identifier for the dynamic controls
                string controlId = Guid.NewGuid().ToString();

                // Create a new Label
                dynamicLabel = new Label
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Bold), // Set Font to bold
                    ForeColor = Color.FromArgb(0, 135, 209),
                    Text = "Option " + optionNameCounter + " :",
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Location = new Point(runExam.label_question.Left, Convert.ToInt32(GetTopMargin())),
                    AutoSize = true,
                    Tag = controlId // Set a unique identifier as the Tag
                };

                labelList.Add(dynamicLabel);
                // Create a new TextBox
                dynamicLabelOption = new Label
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Regular), // Set Font to bold
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Location = new Point(runExam.textBox_QuetionContent.Left - 80, dynamicLabel.Top),
                    Name = "label_labeloption" + optionNameCounter, // Unique name based on the counter
                    AutoSize = true,
                    Tag = controlId, // Set the same unique identifier as the Tag

                };

                //dynamicTextBox = new TextBox
                //{
                //    Width = 600,
                //    Height = 26,
                //    BorderStyle = BorderStyle.FixedSingle,
                //    Location = new Point(runExam.textBox_QuetionContent.Left - 80, dynamicLabel.Top),
                //    Name = "textBox_option" + optionNameCounter, // Unique name based on the counter
                //    Tag = controlId, // Set the same unique identifier as the Tag

                //};


                labelListOptions.Add(dynamicLabelOption);






                radioButton = new RadioButton
                {
                    Text = " ",
                    Name = "radioButton_IsCorrect" + optionNameCounter,
                    AutoSize = true,
                    CheckAlign = System.Drawing.ContentAlignment.MiddleRight,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 135, 209),
                    Location = new Point(dynamicLabelOption.Right + 10, dynamicLabelOption.Top),
                    Tag = controlId
                };

                radioButtonList.Add(radioButton);



                // Add Label, TextBox, and Delete button to the panel_questions
                runExam.panel_questions.Controls.Add(dynamicLabel);
                runExam.panel_questions.Controls.Add(dynamicLabelOption);
                runExam.panel_questions.Controls.Add(radioButton);

                // Increment the counter for the next TextBox

                textBoxCounter++;
                optionNameCounter++;
                runExam.button_addOption.Enabled = textBoxCounter < 5;

            }
            catch (Exception ex)
            {


            }
        }



        public void RefreshQuestionsListBox()
        {
            runExam.listBox_Questions.DataSource = null;
            runExam.listBox_Questions.Items.Clear();
            if (exam.questions.Count > 0)
            {
                runExam.listBox_Questions.DataSource = exam.questions;
            }

        }

        public void RemoveQuestion()
        {
            try
            {

                var index = runExam.listBox_Questions.SelectedIndex;
                question = exam.questions[index];
                exam.questions.Remove(question);
                RefreshQuestionsListBox();
                CheckQuestionListSize();



            }
            catch (Exception ex)
            {

            }
        }

        public void CheckQuestionListSize()
        {
            try
            {
                bool res = exam.questions.Count > 0;

                runExam.button_next.Enabled = res;
                runExam.button_removeQuestion.Enabled = res;
                runExam.button_updateQuestion.Enabled = res;
                if (res)
                {
                    runExam.listBox_Questions.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {


            }

        }

        public void CreateDynamicFullFields(int val)
        {
            try
            {
                switch (val)
                {
                    case 1:
                        if (questionIndex <= exam.questions.Count - 1)
                        {
                            // SaveMarkedIndex();
                            questionIndex++;
                        }
                        break;
                    case 2:
                        if (questionIndex >= 0)
                        {
                            questionIndex--;
                        }
                        break;
                    default:
                        break;
                }

                runExam.textBox_QuetionContent.Text = exam.questions[questionIndex].Text;
                question = exam.questions[questionIndex];
                for (int i = 0; i < question.Options.Count; i++)
                {
                    CreateDynamicOptions();
                    labelListOptions[i].Text = question.Options[i].ToString();

                    //radioButtonList[i].Checked = question.Options[i].IsCorrect;
                }




            }
            catch (Exception ex)
            {


            }

        }

        public void SaveMarkedIndex()
        {
            foreach (var item in radioButtonList)
            {
                int index = radioButtonList.FindIndex(x => x.Checked == true);
                if (index >= 0)
                {
                    checekdList.Add(index);
                }

            }
        }


        public void RandomQuestionOrder()
        {

            rand = new Random();
            exam.questions = exam.questions.OrderBy(q => rand.Next()).ToList();
            runExam.listBox_Questions.DataSource = null;
            runExam.listBox_Questions.Items.Clear();
            runExam.listBox_Questions.DataSource = exam.questions;
        }

        public void RandomOptionsOrder()
        {
            rand = new Random();
            question.Options = question.Options.OrderBy(o => rand.Next()).ToList();
            runExam.listBox_opstionAns.DataSource = null;
            runExam.listBox_opstionAns.Items.Clear();
            runExam.listBox_opstionAns.DataSource = question.Options;
        }



        public async void SaveExam()
        {
            try
            {
                bool res = false;
                string time = string.Format($"{""}:{""}");

                if (isExist)
                {
                    res = await General.mainRequestor.Request_Put<Exam>(exam, "api/exams/update");
                }
                else
                {
                    res = await General.mainRequestor.Request_NewPost<Exam>(exam, "api/exams/create");

                }

                if (res)
                {
                    MessageBox.Show(Constants.BuildSuccess);
                    runExam.Close();
                    TeacherFormModel.teacherFormModel.GetAllExams();
                }
            }
            catch (Exception ex)
            {

            }
        }



        private double GetTopMargin()
        {
            double topMargin = 50;

            // Find the last TextBox in panel_questions and adjust the top margin
            if (runExam.panel_questions.Controls.Count > 0)
            {
                foreach (Control control in runExam.panel_questions.Controls)
                {
                    if (control is TextBox text)
                    {
                        topMargin += text.Height + 20; // Increase the space between TextBoxes
                    }
                    if (control is Label label)
                    {
                        topMargin += label.Height + 10; // Increase the space between TextBoxes
                    }
                }
            }

            return topMargin;
        }

        public void FillAllExamFields()
        {

            runExam.label_examTitle_S.Text = exam.ExamTitle;
            runExam.label_TeacherName_S.Text = exam.TeacherFullName;
            runExam.label_totalExamTime_S.Text = $"{exam.TotalHours:00}:{exam.TotalMinutes:00}";
            runExam.label_course_S.Text = exam.CourseType.ToString();
            runExam.label_pointQuestion_S.Text = (100.0 / exam.questions.Count).ToString("F2");

            //   RefreshQuestionsListBox();



        }

        public void ClearAllControls()
        {
            for (int i = 0; i < radioButtonList.Count; i++)
            {
                runExam.panel_questions.Controls.Remove(labelList[i]);
                runExam.panel_questions.Controls.Remove(labelListOptions[i]);
                runExam.panel_questions.Controls.Remove(radioButtonList[i]);

            }
            textBoxCounter = 0;
            optionNameCounter = 1;

            runExam.textBox_QuetionContent.Text = string.Empty;
            labelListOptions = new List<Label>();
            radioButtonList = new List<RadioButton>();
            labelList = new List<Label>();

            runExam.button_addOption.Enabled = textBoxCounter == 0 ? true : false;
        }


        public void CreateQuestions()
        {
            try
            {
                runExam.panel_questions.BringToFront();
                runExam.tabControl1.TabPages.Add(runExam.tabPage_step2);
                runExam.tabControl1.TabPages.Remove(runExam.tabPage_step1);
                ClearAllControls();
                CreateDynamicFullFields(0);
            }
            catch (Exception ex)
            {



            }
        }

    }
}
