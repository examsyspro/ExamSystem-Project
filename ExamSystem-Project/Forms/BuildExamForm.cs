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
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExamSystem_Project.Forms
{
    public partial class BuildExamForm : Form
    {
        private int textBoxCounter = 0;
        private int optionNameCounter = 1;
        public Exam exam;
        public BuildExamForm()
        {
            InitializeComponent();
            InitializeAll();
            exam = new Exam();
        }


        public void InitializeAll()
        {
            comboBox_Course_Select.Items.Insert(0, "Click to select");
            comboBox_Course_Select.SelectedIndex = 0;
            comboBox_Course_Select.Items.Insert(1, Course_Enum.C_Sharp);
            comboBox_Course_Select.Items.Insert(2, Course_Enum.JavaSctipt);
            tabControl1.TabPages.Remove(tabPage_step2);
            tabControl1.TabPages.Remove(tabPage_step3);
            dateTimePicker_examDate.MinDate = DateTime.Now;
            dateTimePicker_examDate.MaxDate = DateTime.Now.AddDays(60);
        }

        private void button_next_Click(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_step1":
                    if (!tabControl1.TabPages.Contains(tabPage_step2))
                    {
                        tabControl1.TabPages.Add(tabPage_step2);
                    }
                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":
                    if (!tabControl1.TabPages.Contains(tabPage_step3))
                    {
                        tabControl1.TabPages.Add(tabPage_step3);
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
                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":
                    tabControl1.SelectedTab = tabPage_step1;
                    break;
                default:
                    break;
            }
        }




        private void button_AddQuestion_Click(object sender, EventArgs e)
        {

        }



        private void button_addOption_Click(object sender, EventArgs e)
        {
            button_addOption.Enabled = textBoxCounter == 4 ? true : false;

            // Create a unique identifier for the dynamic controls
            string controlId = Guid.NewGuid().ToString();

            // Create a new Label
            Label dynamicLabel = new Label
            {
                Font = new Font("Segoe UI", 11, FontStyle.Bold), // Set Font to bold
                ForeColor = Color.FromArgb(0, 135, 209),
                Text = "Option " + optionNameCounter + " :",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Location = new Point(label_question.Left, Convert.ToInt32(GetTopMargin())),
                AutoSize = true,
                Tag = controlId // Set a unique identifier as the Tag
            };

            // Create a new TextBox
            TextBox dynamicTextBox = new TextBox
            {
                Width = 500,
                Height = 26,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(dynamicLabel.Right + 50, dynamicLabel.Top),
                Name = "TextBox" + optionNameCounter, // Unique name based on the counter
                Tag = controlId, // Set the same unique identifier as the Tag

            };

            // Create a Delete button (trash icon)
            Button deleteButton = new Button
            {
                Text = "Delete",
                Width = 130,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Name = "Button_" + optionNameCounter,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 135, 209),
                Height = 54,
                AutoSize = true,
                Location = new Point(dynamicTextBox.Right + 20, dynamicTextBox.Top - 4),// Use Location instead of Margin
                Tag = controlId // Set the same unique identifier as the Tag
            };


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

            // Increment the counter for the next TextBox

            textBoxCounter++;
            optionNameCounter++;
            button_addOption.Enabled = textBoxCounter < 5;
        }


        private double GetTopMargin()
        {
            double topMargin = 10;

            // Find the last TextBox in panel_questions and adjust the top margin
            if (panel_questions.Controls.Count > 0)
            {
                foreach (Control control in panel_questions.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        topMargin += textBox.Height + 50; // Increase the space between TextBoxes
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
    }
}
