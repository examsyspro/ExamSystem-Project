using ExamSystem.Client.Helpers;
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
    /// Interaction logic for CreateExamStarter.xaml
    /// </summary>
    public partial class CreateExamStarter : UserControl
    {
        public CreateExamStarter()
        {
            InitializeComponent();
            text_TeacherFullName.Text = "Roei Atar";
            text_TeacherFullName.IsEnabled = false;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Course_Select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Next_Page_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new CreateQuestion();
        }
    }
}
