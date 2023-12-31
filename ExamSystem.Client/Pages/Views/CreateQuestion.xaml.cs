using ExamSystem.Client.Pages.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamSystem.Client.Pages.Views
{
    /// <summary>
    /// Interaction logic for CreateQuestion.xaml
    /// </summary>
    public partial class CreateQuestion : UserControl
    {
        private int textBoxCounter = 1;

        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void add_Option_Click(object sender, RoutedEventArgs e)
        {
            Button_add_Option.IsEnabled = textBoxCounter == 5 ? false : true;

            // Create a unique identifier for the dynamic controls
            string controlId = Guid.NewGuid().ToString();

            // Create a new Label
            Label dynamicLabel = new Label
            {
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                Foreground = Brushes.DarkSlateGray,
                Content = "Option " + textBoxCounter + " :",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(250, GetTopMargin(), 10, 10),
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



        private double GetTopMargin()
        {
            double topMargin = -350;

            // Find the last TextBox in mainGrid and adjust the top margin
            if (mainGrid.Children.Count > 0)
            {
                foreach (UIElement element in mainGrid.Children)
                {
                    if (element is TextBox textBox)
                    {
                        topMargin += textBox.ActualHeight + 50; // Increase the space between TextBoxes
                    }
                }
            }

            return topMargin;
        }

        private void button_Save_Question_Click(object sender, RoutedEventArgs e)
        {
            Window buildExamWindow = Window.GetWindow(this);
            BuildExamWindow b = buildExamWindow as BuildExamWindow;
            b.button_add_Qution.IsEnabled = true;



        }

        private void button_Previous_Page_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new CreateExamStarter();
        }
    }
}
