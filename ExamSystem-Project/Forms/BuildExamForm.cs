using ExamSystem_Project.Helpers;
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
    public partial class BuildExamForm : Form
    {


        private int textBoxCounter = 0;
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
        public General gen;
        

        private readonly int[] numbersArr = { 1, 2, 3, 4, 5, 6, 7 };
        public BuildExamForm()
        {
            InitializeComponent();
            InitializeAll();
            exam = new Exam();
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            ControlsList = new List<Control>();
            labelList = new List<Label>();
            gen = new General();
            

        }

        public void InitializeAll()
        {

            try
            {
                comboBox_Course_Select.Text = "Select Course";
                comboBox_Course_Select.Items.Insert(0, Course_Enum.C_Sharp);
                comboBox_Course_Select.Items.Insert(1, Course_Enum.JavaSctipt);
                tabControl1.TabPages.Remove(tabPage_step2);
                tabControl1.TabPages.Remove(tabPage_step3);
                dateTimePicker_examDate.MinDate = DateTime.Now;
                dateTimePicker_examDate.MaxDate = DateTime.Now.AddDays(60);
                panel_questions.SendToBack();
                textBox_date.Text = string.Empty;
                button_SaveExamBuilder.Enabled = false;



                for (int i = 0; i < 60; i++)
                {
                    if (i <= 20)
                    {
                        if (!numbersArr.Contains(i))
                        {
                            comboBox_hours_StartTime.Items.Add(i.ToString("00"));
                        }
                        if (i <= 4)
                        {
                            comboBox_hours_totalTime.Items.Add(i.ToString("00"));
                        }
                        comboBox_minutes_StartTime.Items.Add(i.ToString("00"));
                        comboBox_minutes_totalTime.Items.Add(i.ToString("00"));


                    }
                    else
                    {
                        comboBox_minutes_totalTime.Items.Add(i.ToString("00"));
                        comboBox_minutes_StartTime.Items.Add(i.ToString("00"));
                    }

                }


                foreach (Control control in panel1.Controls)
                {

                    if (control is TextBox)
                    {
                        ExamButtonHandler(control as TextBox);

                    }

                }

                button_SaveExamBuilder.Visible = false;
                button_next.Visible = true;
            }
            catch (Exception ex)
            {


            }





        }

        private void button_next_Click(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_step1":
                    if (!tabControl1.TabPages.Contains(tabPage_step2))
                    {

                        CheckQuestionListSize();
                        tabControl1.TabPages.Add(tabPage_step2);
                        tabControl1.TabPages.Remove(tabPage_step1);
                    }

                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":

                    if (!tabControl1.TabPages.Contains(tabPage_step3))
                    {
                        button_next.Visible = false;
                        CreateSummeryPage();
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

        private void button_Previous_Click(object sender, EventArgs e)
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
                        ExamButtonHandler(new TextBox());
                        tabControl1.TabPages.Add(tabPage_step1);
                        tabControl1.TabPages.Remove(tabPage_step2);
                    }

                    tabControl1.SelectedTab = tabPage_step1;
                    break;
                default:
                    break;
            }
        }





        private void dateTimePicker_examDate_ValueChanged(object sender, EventArgs e)
        {
            textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
        }


        public void ClearAllControls()
        {
            for (int i = 0; i < radioButtonList.Count; i++)
            {
                panel_questions.Controls.Remove(labelList[i]);
                panel_questions.Controls.Remove(textBoxesList[i]);
                panel_questions.Controls.Remove(radioButtonList[i]);
                panel_questions.Controls.Remove(deleteButtonList[i]);
            }
            textBoxCounter = 0;
            optionNameCounter = 1;

            textBox_QuetionContent.Text = string.Empty;
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            labelList = new List<Label>();

            button_addOption.Enabled = textBoxCounter == 0 ? true : false;
        }

        private void button_addOption_Click(object sender, EventArgs e)
        {

            try
            {
                button_addOption.Enabled = textBoxCounter == 4 ? true : false;

                // Create a unique identifier for the dynamic controls
                string controlId = Guid.NewGuid().ToString();

                // Create a new Label
                dynamicLabel = new Label
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Bold), // Set Font to bold
                    ForeColor = Color.FromArgb(0, 135, 209),
                    Text = "Option " + optionNameCounter + " :",
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Location = new Point(label_question.Left, Convert.ToInt32(GetTopMargin())),
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
                    Location = new Point(textBox_QuetionContent.Left - 80, dynamicLabel.Top),
                    Name = "textBox_option" + optionNameCounter, // Unique name based on the counter
                    Tag = controlId, // Set the same unique identifier as the Tag

                };
                dynamicTextBox.TextChanged += (dynamicTextBox, textBoxEventArgs) =>
                {
                    OptionsButtonHandler(dynamicTextBox as TextBox, textBoxEventArgs);
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

                    button_addOption.Enabled = textBoxCounter < 5;
                    textBoxCounter--;
                    optionNameCounter--;



                    // Retrieve the unique identifier associated with the controls
                    string tag = deleteButton.Tag as string;

                    textBoxesList.RemoveAll(x => x.Tag == tag);
                    radioButtonList.RemoveAll(x => x.Tag == tag);

                    // Find and remove controls with the same unique identifier
                    var controlsToRemove = panel_questions.Controls
                        .Cast<Control>()
                        .Where(control => control.Tag as string == tag)
                        .ToList();

                    foreach (var control in controlsToRemove)
                    {
                        panel_questions.Controls.Remove(control);
                    }
                    button_addOption.Enabled = textBoxCounter < 5;
                };

                // Add Label, TextBox, and Delete button to the panel_questions
                panel_questions.Controls.Add(dynamicLabel);
                panel_questions.Controls.Add(dynamicTextBox);
                panel_questions.Controls.Add(deleteButton);
                panel_questions.Controls.Add(radioButton);

                // Increment the counter for the next TextBox

                textBoxCounter++;
                optionNameCounter++;
                button_addOption.Enabled = textBoxCounter < 5;
            }
            catch (Exception ex)
            {


            }
        }

        private double GetTopMargin()
        {
            double topMargin = 50;

            // Find the last TextBox in panel_questions and adjust the top margin
            if (panel_questions.Controls.Count > 0)
            {
                foreach (Control control in panel_questions.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        topMargin += textBox.Height + 40; // Increase the space between TextBoxes
                    }
                }
            }

            return topMargin;
        }

        private void button_SaveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                //question = new Question();
                question.Text = textBox_QuetionContent.Text;

                for (int i = 0; i < textBoxesList.Count; i++)
                {
                    var box = textBoxesList[i];
                    var radioButton = radioButtonList[i];

                    if (!string.IsNullOrEmpty(box.Text))
                    {
                        optionAns = new OptionAns();
                        optionAns.QuestionStrId = question.QuestionStrId;
                        optionAns.OptionText = box.Text;
                        optionAns.IsCorrect = radioButton.Checked;
                        question.Options.Add(optionAns);
                    }
                }
                exam.questions.Add(question);
                listBox_Questions.DataSource = null;
                listBox_Questions.Items.Clear();
                listBox_Questions.DataSource = exam.questions;
                panel_questionList.BringToFront();

                CheckQuestionListSize();
            }
            catch (Exception ex)
            {


            }




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

        public void ExamButtonHandler(TextBox text)
        {
            ChangeTextBoxColor(text);
            bool res = CheckEmptyPanelControls(panel1);
            button_next.Enabled = res;
            label_filedsReq.Visible = !res;
        }


        public void CheckQuestionListSize()
        {

            if (exam.questions.Count >= 0)
            {
                button_next.Enabled = true;
            }
            else
            {
                button_next.Enabled = false;
            }
        }


        public void ChangeTextBoxColor(TextBox text)
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

        public void OptionsButtonHandler(TextBox text, EventArgs e)
        {
            ChangeTextBoxColor(text);
            bool res = CheckEmptyPanelControls(panel_questions);

            if (!res || textBoxesList.Count < 2)
            {
                res = false;
            }
            else
            {
                res = true;
            }


            button_SaveQuestion.Enabled = res;

        }



        private void button_Test_Click(object sender, EventArgs e)
        {
            textBox_examTitle.Text = "test exam";
            textBox_teacherName.Text = "test teacher";
            textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
            comboBox_Course_Select.SelectedIndex = 0;
            checkBox_QuestionOrder.Checked = true;
            comboBox_hours_StartTime.SelectedIndex = 1;
            comboBox_minutes_StartTime.SelectedIndex = 0;
            comboBox_hours_totalTime.SelectedIndex = 1;
            comboBox_minutes_totalTime.SelectedIndex = 0;
        }

        private void button_testQuestions_Click(object sender, EventArgs e)
        {
            if (textBoxCounter < 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    button_addOption_Click(sender, EventArgs.Empty);
                }
            }
            textBox_QuetionContent.Text = "what is the best text option?";

            for (int i = 0; i < textBoxesList.Count; i++)
            {
                textBoxesList[i].Text = "test option" + (i + 1);
                radioButtonList[i].Checked = true;
            }
        }

        private void button_ShowQuestions_Click(object sender, EventArgs e)
        {
            panel_questions.SendToBack();
        }

        private void button_AddQuestion_Click(object sender, EventArgs e)
        {

            panel_questions.BringToFront();
            ClearAllControls();
            question = new Question();
            question.ExamStrId = exam.ExamStrId;
            textBox_QuetionContent.Invoke(() => OptionsButtonHandler(textBox_QuetionContent, EventArgs.Empty));
        }

        private void listBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_opstionAns.DataSource = null;
                listBox_opstionAns.Items.Clear();


                var index = listBox_Questions.SelectedIndex;
                if (index != -1)
                {
                    Question q = exam.questions[index];
                    listBox_opstionAns.DataSource = q.Options;
                }
            }
            catch (Exception ex)
            {


            }
        }


        private async void button_SaveExamBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = false;
                string time = string.Format($"{comboBox_hours_StartTime.SelectedItem}:{comboBox_minutes_StartTime.SelectedItem}");
                exam.ExamTitle = textBox_examTitle.Text;
                exam.TeacherFullName = textBox_teacherName.Text;
                exam.ExamDateTime = DateTime.Parse($"{textBox_date.Text} {time}");
                exam.TotalHours = int.Parse(comboBox_hours_totalTime.SelectedItem.ToString());
                exam.TotalMinutes = int.Parse(comboBox_minutes_totalTime.SelectedItem.ToString());
                string coursetype = comboBox_Course_Select.SelectedItem.ToString();
                exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
                exam.RandomQuestionOrder = checkBox_QuestionOrder.Checked;
                res = await General.buildExam.Build_Exam(exam);
                if (res) 
                {
                    MessageBox.Show(Constants.BuildSuccess);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox_examTitle_TextChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(textBox_examTitle);
        }

        private void textBox_teacherName_TextChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(textBox_teacherName);
        }

        private void textBox_date_TextChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(textBox_date);
        }

        private void comboBox_hours_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(new TextBox());
        }

        private void comboBox_minutes_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(new TextBox());
        }

        private void comboBox_Course_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(new TextBox());
        }

        private void comboBox_hours_totalTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(new TextBox());
        }

        private void comboBox_minutes_totalTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamButtonHandler(new TextBox());
        }

        private void textBox_QuetionContent_TextChanged(object sender, EventArgs e)
        {
            OptionsButtonHandler(textBox_QuetionContent, e);
        }

        public void CreateSummeryPage()
        {
            try
            {
                label_examTitle_S.Text = textBox_examTitle.Text;
                label_TeacherName_S.Text = textBox_teacherName.Text;
                label_examDate_S.Text = textBox_date.Text;
                label_startTime_S.Text = string.Format($"{comboBox_hours_StartTime.SelectedItem}:{comboBox_minutes_StartTime.SelectedItem}");
                label_totalExamTime_S.Text = $"{comboBox_hours_totalTime.SelectedItem}:{comboBox_minutes_totalTime.SelectedItem}";
                label_course_S.Text = comboBox_Course_Select.SelectedItem.ToString();
                label_randomQuesOrder_S.Text = checkBox_QuestionOrder.Checked.ToString();
                label_pointQuestion_S.Text = (100 / listBox_Questions.Items.Count).ToString("00");
                listBox_questionList_S.DataSource = null;
                listBox_questionList_S.Items.Clear();
                listBox_questionList_S.DataSource = exam.questions;
            }
            catch (Exception ex)
            {

            }

            //exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
            //exam.RandomQuestionOrder = checkBox_QuestionOrder.Checked;
        }


    }
}
