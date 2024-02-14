using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ExamSystem_Project.FormModels
{
    public class ExamFormModel
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
        public Exam dtExam;
        public BuildExamForm buildExam;
        public ExamFormModel(Exam examFromDT)
        {
            this.buildExam = BuildExamForm.buildExam;
            dtExam = examFromDT;
            CheckExamFromDT();
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            ControlsList = new List<Control>();
            labelList = new List<Label>();
            
        }

        public async Task<Exam> Update_Exam(Exam exam)
        {
             var resultExam = await General.mainRequestor.Request_Put<Exam>(1,exam, "api/exams/update");

            return resultExam;
        }

        public void CheckExamFromDT()
        {
            if (dtExam != null)
            {
                exam = dtExam;

            }
            else
            {
                exam = new Exam();
            }
        }

        public void Questions_SelectedIndex()
        {
            try
            {
                buildExam.listBox_opstionAns.DataSource = null;
                buildExam.listBox_opstionAns.Items.Clear();


                var index = buildExam.listBox_Questions.SelectedIndex;
                if (index != -1)
                {
                    question = exam.questions[index];
                    buildExam.listBox_opstionAns.DataSource = question.Options;
                }
            }
            catch (Exception ex)
            {


            }
        }

        public void CreateSummeryPage()
        {
            try
            {
                buildExam.label_examTitle_S.Text = buildExam.textBox_examTitle.Text;
                buildExam.label_TeacherName_S.Text = buildExam.textBox_teacherName.Text;
                buildExam.label_examDate_S.Text = buildExam.textBox_date.Text;
                buildExam.label_startTime_S.Text = string.Format($"{buildExam.comboBox_hours_StartTime.SelectedItem}:{buildExam.comboBox_minutes_StartTime.SelectedItem}");
                buildExam.label_totalExamTime_S.Text = $"{buildExam.comboBox_hours_totalTime.SelectedItem}:{buildExam.comboBox_minutes_totalTime.SelectedItem}";
                buildExam.label_course_S.Text = buildExam.comboBox_Course_Select.SelectedItem.ToString();
                buildExam.label_randomQuesOrder_S.Text = buildExam.checkBox_QuestionOrder.Checked.ToString();
                buildExam.label_pointQuestion_S.Text = (100 / buildExam.listBox_Questions.Items.Count).ToString("00");
                buildExam.listBox_questionList_S.DataSource = null;
                buildExam.listBox_questionList_S.Items.Clear();
                buildExam.listBox_questionList_S.DataSource = exam.questions;

                if (buildExam.checkBox_QuestionOrder.Checked)
                {
                    RandomQuestionOrder();
                }


            }
            catch (Exception ex)
            {

            }

            //exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
            //exam.RandomQuestionOrder = checkBox_QuestionOrder.Checked;
        }

        public void UpdateQuestion()
        {
            try
            {
                var index = buildExam.listBox_Questions.SelectedIndex;
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

                question.Text = buildExam.textBox_QuetionContent.Text;

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

                if (buildExam.checkBox_OptionOrder.Checked)
                {
                    RandomOptionsOrder();

                }
                if (!exam.questions.Contains(question))
                {
                    exam.questions.Add(question);
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
                buildExam.listBox_Questions.DataSource = null;
                buildExam.listBox_Questions.Items.Clear();
                if (exam.questions.Count > 0)
                {
                buildExam.listBox_Questions.DataSource = exam.questions;
                }

        }

        public void RemoveQuestion()
        {
            try
            {

                    var index = buildExam.listBox_Questions.SelectedIndex;
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
            bool res = exam.questions.Count > 0;

            buildExam.button_next.Enabled = res;
            buildExam.button_removeQuestion.Enabled = res;
            buildExam.button_updateQuestion.Enabled = res;
            if (res)
            {
                buildExam.listBox_Questions.SelectedIndex = 0;
            }
        }

        public void CreateDynamicFullFields()
        {
            buildExam.textBox_QuetionContent.Text = question.Text;
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
            buildExam.listBox_Questions.DataSource = null;
            buildExam.listBox_Questions.Items.Clear();
            buildExam.listBox_Questions.DataSource = exam.questions;
        }

        public void RandomOptionsOrder()
        {
            rand = new Random();
            question.Options = question.Options.OrderBy(o => rand.Next()).ToList();
            buildExam.listBox_opstionAns.DataSource = null;
            buildExam.listBox_opstionAns.Items.Clear();
            buildExam.listBox_opstionAns.DataSource = question.Options;
        }

        public void CreateDynamicOptions()
        {

            try
            {
                buildExam.button_addOption.Enabled = textBoxCounter == 4 ? true : false;

                // Create a unique identifier for the dynamic controls
                string controlId = Guid.NewGuid().ToString();

                // Create a new Label
                dynamicLabel = new Label
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Bold), // Set Font to bold
                    ForeColor = Color.FromArgb(0, 135, 209),
                    Text = "Option " + optionNameCounter + " :",
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Location = new Point(buildExam.label_question.Left, Convert.ToInt32(GetTopMargin())),
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
                    Location = new Point(buildExam.textBox_QuetionContent.Left - 80, dynamicLabel.Top),
                    Name = "textBox_option" + optionNameCounter, // Unique name based on the counter
                    Tag = controlId, // Set the same unique identifier as the Tag

                };
                dynamicTextBox.TextChanged += (dynamicTextBox, textBoxEventArgs) =>
                {
                    buildExam.OptionsButtonHandler(dynamicTextBox as TextBox, textBoxEventArgs);
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

                    buildExam.button_addOption.Enabled = textBoxCounter < 5;
                    textBoxCounter--;
                    optionNameCounter--;



                    // Retrieve the unique identifier associated with the controls
                    string tag = deleteButton.Tag as string;

                    textBoxesList.RemoveAll(x => x.Tag == tag);
                    radioButtonList.RemoveAll(x => x.Tag == tag);

                    // Find and remove controls with the same unique identifier
                    var controlsToRemove = buildExam.panel_questions.Controls
                        .Cast<Control>()
                        .Where(control => control.Tag as string == tag)
                        .ToList();

                    foreach (var control in controlsToRemove)
                    {
                        buildExam.panel_questions.Controls.Remove(control);
                    }
                    buildExam.button_addOption.Enabled = textBoxCounter < 5;
                    buildExam.OptionsButtonHandler(new TextBox(), EventArgs.Empty);
                };

                // Add Label, TextBox, and Delete button to the panel_questions
                buildExam.panel_questions.Controls.Add(dynamicLabel);
                buildExam.panel_questions.Controls.Add(dynamicTextBox);
                buildExam.panel_questions.Controls.Add(deleteButton);
                buildExam.panel_questions.Controls.Add(radioButton);

                // Increment the counter for the next TextBox

                textBoxCounter++;
                optionNameCounter++;
                buildExam.button_addOption.Enabled = textBoxCounter < 5;

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
                string time = string.Format($"{buildExam.comboBox_hours_StartTime.SelectedItem}:{buildExam.comboBox_minutes_StartTime.SelectedItem}");
                exam.ExamTitle = buildExam.textBox_examTitle.Text;
                exam.TeacherFullName = buildExam.textBox_teacherName.Text;
                exam.ExamDateTime = DateTime.Parse($"{buildExam.textBox_date.Text} {time}");
                exam.TotalHours = int.Parse(buildExam.comboBox_hours_totalTime.SelectedItem.ToString());
                exam.TotalMinutes = int.Parse(buildExam.comboBox_minutes_totalTime.SelectedItem.ToString());
                string coursetype = buildExam.comboBox_Course_Select.SelectedItem.ToString();
                exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
                exam.RandomQuestionOrder = buildExam.checkBox_QuestionOrder.Checked;
                res = await General.mainRequestor.Request_NewPost<Exam>(exam, "api/exams/create");
                if (res)
                {
                    MessageBox.Show(Constants.BuildSuccess);
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
            buildExam.textBox_QuetionContent.Invoke(() => buildExam.OptionsButtonHandler(buildExam.textBox_QuetionContent, EventArgs.Empty));
        }

        private double GetTopMargin()
        {
            double topMargin = 50;

            // Find the last TextBox in panel_questions and adjust the top margin
            if (buildExam.panel_questions.Controls.Count > 0)
            {
                foreach (Control control in buildExam.panel_questions.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        topMargin += textBox.Height + 40; // Increase the space between TextBoxes
                    }
                }
            }

            return topMargin;
        }

        public void ClearAllControls()
        {
            for (int i = 0; i < radioButtonList.Count; i++)
            {
                buildExam.panel_questions.Controls.Remove(labelList[i]);
                buildExam.panel_questions.Controls.Remove(textBoxesList[i]);
                buildExam.panel_questions.Controls.Remove(radioButtonList[i]);
                buildExam.panel_questions.Controls.Remove(deleteButtonList[i]);
            }
            textBoxCounter = 0;
            optionNameCounter = 1;

            buildExam.textBox_QuetionContent.Text = string.Empty;
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            labelList = new List<Label>();

            buildExam.button_addOption.Enabled = textBoxCounter == 0 ? true : false;
        }

    }
}
