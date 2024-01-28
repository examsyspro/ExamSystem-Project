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



namespace ExamSystem_Project.Forms
{
    public partial class BuildExamForm : Form
    {
        private int textBoxCounter = 0;
        private int optionNameCounter = 1;
        public TextBox dynamicTextBox;
        string[] strArr;
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


        }


        public void InitializeAll()
        {


            comboBox_Course_Select.Text = "Select Course";
            comboBox_Course_Select.Items.Insert(0, Course_Enum.C_Sharp);
            comboBox_Course_Select.Items.Insert(1, Course_Enum.JavaSctipt);
            tabControl1.TabPages.Remove(tabPage_step2);
            tabControl1.TabPages.Remove(tabPage_step3);
            dateTimePicker_examDate.MinDate = DateTime.Now;
            dateTimePicker_examDate.MaxDate = DateTime.Now.AddDays(60);

            panel_questions.SendToBack();
        }

        private void button_next_Click(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_step1":
                    if (!tabControl1.TabPages.Contains(tabPage_step2))
                    {
                        tabControl1.TabPages.Add(tabPage_step2);
                        tabControl1.TabPages.Remove(tabPage_step1);
                    }
                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":
                    if (!tabControl1.TabPages.Contains(tabPage_step3))
                    {
                        tabControl1.TabPages.Add(tabPage_step3);
                        tabControl1.TabPages.Remove(tabPage_step2);
                    }
                    tabControl1.SelectedTab = tabPage_step3;
                    break;
                default:
                    break;
            }


        }

        private void dateTimePicker_examDate_ValueChanged(object sender, EventArgs e)
        {
            textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
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
                    Location = new Point(label_question.Left , Convert.ToInt32(GetTopMargin())),
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
                    Location = new Point(textBox_QuetionContent.Left-80, dynamicLabel.Top),
                    Name = "textBox_option" + optionNameCounter, // Unique name based on the counter
                    Tag = controlId, // Set the same unique identifier as the Tag

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

        private void button_SaveExamBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                string time = string.Format($"{textBox_hours_StartTime.Text}:{textBox_minutes_StartTime.Text}");
                exam.ExamTitle = textBox_examTitle.Text;
                exam.TeacherFullName = textBox_teacherName.Text;
                exam.ExamDateTime = DateTime.Parse($"{textBox_date.Text} {time}");
                exam.TotalHours = int.Parse(textBox_hours_totalTime.Text);
                string coursetype = comboBox_Course_Select.SelectedItem.ToString();
                exam.CourseType = (Course_Enum)Enum.Parse(typeof(Course_Enum), coursetype);
                exam.RandomQuestionOrder = checkBox_QuestionOrder.Checked;
            }
            catch (Exception ex)
            {

            }
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

                panel_questionList.BringToFront();

            }
            catch (Exception ex)
            {


            }




        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            textBox_examTitle.Text = "test exam";
            textBox_teacherName.Text = "test teacher";
            textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
            textBox_hours_StartTime.Text = "10";
            textBox_minutes_StartTime.Text = "00";
            textBox_hours_totalTime.Text = "2";
            textBox_minutes_totalTime.Text = "00";
            comboBox_Course_Select.SelectedIndex = 0;
            checkBox_QuestionOrder.Checked = true;


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




        }
    }
}
