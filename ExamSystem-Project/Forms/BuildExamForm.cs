using ExamSystem_Project.Helpers;
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
        private int textBoxCounter = 1;
        public BuildExamForm()
        {
            InitializeComponent();
            InitializeAll();
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

        private double GetTopMargin()
        {
            double topMargin = -350;

            // Find the last TextBox in mainGrid and adjust the top margin
            if (panel_questions.Children.Count > 0)
            {
                foreach (UIElement element in panel_questions.Children)
                {
                    if (element is TextBox textBox)
                    {
                        topMargin += textBox.ActualHeight + 50; // Increase the space between TextBoxes
                    }
                }
            }

            return topMargin;
        }

        private void button_addOption_Click(object sender, EventArgs e)
        {

            button_AddQuestion.Enabled = textBoxCounter == 5 ? false : true;

            // Create a unique identifier for the dynamic controls
            string controlId = Guid.NewGuid().ToString();

            // Create a new Label
            Label dynamicLabel = new Label
            {
                Font = new Font("Arial", 14, FontStyle.Bold), // Set Font to bold
                ForeColor = Color.DarkSlateGray,
                Text = "Option " + textBoxCounter + " :",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Location = new Point(250, GetTopMargin()),
                AutoSize = true,
                Tag = controlId // Set a unique identifier as the Tag
            };

            // Create a new TextBox
            TextBox dynamicTextBox = new TextBox
            {
                Width = 362,
                Height = 26,
                Margin = new Thickness(70, GetTopMargin(), 10, 10),
                Name = "TextBox" + textBoxCounter, // Unique name based on the counter

                Tag = controlId // Set the same unique identifier as the Tag
            };

            // Create a Delete button (trash icon)
            Button deleteButton = new Button
            {
                Content = "Delete",
                Width = 40,
                Name = "Button_" + textBoxCounter,
                Height = 20,
                Margin = new Thickness(480, GetTopMargin(), 10, 10),
                Tag = controlId // Set the same unique identifier as the Tag
            };

            // Attach a click event handler to the delete button
            deleteButton.Click += (sender, e) =>
            {
                if (sender is Button btn)
                {

                    var arr = btn.Name.Split("_");
                    if (int.Parse(arr[1]) < textBoxCounter - 1)
                    {
                        MessageBox.Show($"Delete Option {textBoxCounter - 1} first");
                        return;
                    }

                }
                Button_add_Option.IsEnabled = textBoxCounter == 5 ? false : true;
                textBoxCounter--;
                // Retrieve the unique identifier associated with the controls
                string tag = deleteButton.Tag as string;

                // Find and remove controls with the same unique identifier
                var controlsToRemove = mainGrid.Children
                    .Cast<FrameworkElement>()
                    .Where(control => control.Tag as string == tag)
                    .ToList();

                foreach (var control in controlsToRemove)
                {
                    mainGrid.Children.Remove(control);
                }
            };

            // Add Label, TextBox, and Delete button to the mainGrid
            mainGrid.Children.Add(dynamicLabel);
            mainGrid.Children.Add(dynamicTextBox);
            mainGrid.Children.Add(deleteButton);

            // Increment the counter for the next TextBox
            textBoxCounter++;
        }
    }
}
