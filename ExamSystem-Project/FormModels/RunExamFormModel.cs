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
using System.Windows.Forms.VisualStyles;

namespace ExamSystem_Project.FormModels
{
    public class RunExamFormModel
    {

        public int textBoxCounter = 0;
        public int optionNameCounter = 1;
        public TextBox dynamicTextBox;
        public string[] strArr;
        public Exam exam;
        public Question question;
        public OptionAns optionAns;
        public Label dynamicLabel;
        public RadioButton radioButton;
        public List<TextBox> textBoxesList;
        public List<RadioButton> radioButtonList;
        public List<Button> deleteButtonList;
        public List<Label> labelList;
        public List<Control> ControlsList;
        Random rand;

        public ExamRunForm2 runExam;
        public bool isExist = false;


        public RunExamFormModel(Exam examFromSt)
        {

            this.runExam = ExamRunForm2.runExam;
            this.exam = examFromSt;
            FillAllExamFields();
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            ControlsList = new List<Control>();
            labelList = new List<Label>();

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
                CreateDynamicFullFields();
            }
            catch (Exception ex)
            {



            }
        }

        public void SaveQuestion()
        {

            try
            {

                question.Text = runExam.textBox_QuetionContent.Text;

                for (int i = 0; i < textBoxesList.Count; i++)
                {
                    var box = textBoxesList[i];
                    var radioButton = radioButtonList[i];

                    if (!string.IsNullOrEmpty(box.Text))
                    {
                        if (exam.questions.Contains(question))
                        {
                            optionAns = question.Options[i];
                            optionAns.QuestionStrId = question.QuestionStrId;
                            optionAns.OptionText = box.Text;
                            optionAns.IsCorrect = radioButton.Checked;
                        }
                        else
                        {
                            optionAns = new OptionAns();
                            optionAns.QuestionStrId = question.QuestionStrId;
                            optionAns.OptionText = box.Text;
                            optionAns.IsCorrect = radioButton.Checked;
                            question.Options.Add(optionAns);
                        }



                    }
                }

                if (runExam.checkBox_OptionOrder.Checked)
                {
                    RandomOptionsOrder();

                }
                if (!exam.questions.Contains(question))
                {
                    exam.questions.Add(question);
                }
                else
                {
                    int index = exam.questions.FindIndex(q => q.QuestionStrId == question.QuestionStrId);
                    exam.questions[index] = question;
                }

                RefreshQuestionsListBox();


                CheckQuestionListSize();

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

        public void CreateDynamicFullFields()
        {
            runExam.textBox_QuetionContent.Text = question.Text;
            for (int i = 0; i < question.Options.Count; i++)
            {
                CreateDynamicOptions();
                textBoxesList[i].Text = question.Options[i].ToString();
                radioButtonList[i].Checked = question.Options[i].IsCorrect;
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
                dynamicTextBox = new TextBox
                {
                    Width = 600,
                    Height = 26,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(runExam.textBox_QuetionContent.Left - 80, dynamicLabel.Top),
                    Name = "textBox_option" + optionNameCounter, // Unique name based on the counter
                    Tag = controlId, // Set the same unique identifier as the Tag

                };
                dynamicTextBox.TextChanged += (dynamicTextBox, textBoxEventArgs) =>
                {
                    runExam.OptionsButtonHandler(dynamicTextBox as TextBox, textBoxEventArgs);
                };

                textBoxesList.Add(dynamicTextBox);


                // Create a Delete button (trash icon)
                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Width = 107,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Name = "button_" + optionNameCounter,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(0, 135, 209),
                    Height = 40,
                    AutoSize = true,
                    Location = new Point(dynamicTextBox.Right + 15, dynamicTextBox.Top - 7),// Use Location instead of Margin
                    Tag = controlId // Set the same unique identifier as the Tag
                };

                deleteButtonList.Add(deleteButton);

                radioButton = new RadioButton
                {
                    Text = "Is Correct :",
                    Name = "radioButton_IsCorrect" + optionNameCounter,
                    AutoSize = true,
                    CheckAlign = System.Drawing.ContentAlignment.MiddleRight,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 135, 209),
                    Location = new Point(deleteButton.Right, dynamicTextBox.Top - 4),
                    Tag = controlId
                };

                radioButtonList.Add(radioButton);

                // Attach a click event handler to the delete button
                deleteButton.Click += (deleteSender, deleteEventArgs) =>
                {
                    if (deleteSender is Button btn)
                    {
                        var arr = btn.Name.Split("_");
                        if (int.Parse(arr[1]) < textBoxCounter)
                        {
                            MessageBox.Show($"Delete Option {textBoxCounter} first");
                            return;
                        }
                    }

                    runExam.button_addOption.Enabled = textBoxCounter < 5;
                    textBoxCounter--;
                    optionNameCounter--;



                    // Retrieve the unique identifier associated with the controls
                    string tag = deleteButton.Tag as string;

                    textBoxesList.RemoveAll(x => x.Tag == tag);
                    radioButtonList.RemoveAll(x => x.Tag == tag);

                    // Find and remove controls with the same unique identifier
                    var controlsToRemove = runExam.panel_questions.Controls
                        .Cast<Control>()
                        .Where(control => control.Tag as string == tag)
                        .ToList();

                    foreach (var control in controlsToRemove)
                    {
                        runExam.panel_questions.Controls.Remove(control);
                    }
                    runExam.button_addOption.Enabled = textBoxCounter < 5;
                    runExam.OptionsButtonHandler(new TextBox(), EventArgs.Empty);
                };

                // Add Label, TextBox, and Delete button to the panel_questions
                runExam.panel_questions.Controls.Add(dynamicLabel);
                runExam.panel_questions.Controls.Add(dynamicTextBox);
                runExam.panel_questions.Controls.Add(deleteButton);
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

        public async void SaveExam()
        {
            try
            {
                bool res = false;
                string time = string.Format($"{""}:{""}");
                // exam.ExamTitle = runExam.textBox_examTitle.Text;
                //  exam.TeacherFullName = runExam.textBox_teacherName.Text;
                // exam.ExamDateTime = DateTime.Parse($"{runExam.textBox_date.Text} {time}");
                //   exam.TotalHours = int.Parse(runExam.comboBox_hours_totalTime.SelectedItem.ToString());
                // exam.TotalMinutes = int.Parse(runExam.comboBox_minutes_totalTime.SelectedItem.ToString());
                // string coursetype = runExam.comboBox_Course_Select.SelectedItem.ToString();
                // exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
                //  exam.RandomQuestionOrder = runExam.checkBox_QuestionOrder.Checked;
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

        public void AddQuestion()
        {

            ClearAllControls();
            question = new Question();
            question.ExamStrId = exam.ExamStrId;
            runExam.textBox_QuetionContent.Invoke(() => runExam.OptionsButtonHandler(runExam.textBox_QuetionContent, EventArgs.Empty));
        }

        private double GetTopMargin()
        {
            double topMargin = 50;

            // Find the last TextBox in panel_questions and adjust the top margin
            if (runExam.panel_questions.Controls.Count > 0)
            {
                foreach (Control control in runExam.panel_questions.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        topMargin += textBox.Height + 40; // Increase the space between TextBoxes
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
            runExam.label_pointQuestion_S.Text = (100 / exam.questions.Count).ToString("00");

            //   RefreshQuestionsListBox();



        }

        public void ClearAllControls()
        {
            for (int i = 0; i < radioButtonList.Count; i++)
            {
                runExam.panel_questions.Controls.Remove(labelList[i]);
                runExam.panel_questions.Controls.Remove(textBoxesList[i]);
                runExam.panel_questions.Controls.Remove(radioButtonList[i]);
                runExam.panel_questions.Controls.Remove(deleteButtonList[i]);
            }
            textBoxCounter = 0;
            optionNameCounter = 1;

            runExam.textBox_QuetionContent.Text = string.Empty;
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            labelList = new List<Label>();

            runExam.button_addOption.Enabled = textBoxCounter == 0 ? true : false;
        }

    }
}
