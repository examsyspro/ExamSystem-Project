
using ExamSystem.Client.Models;
using ExamSystem.Client.Pages;
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
using ExamSystem.Client.Pages.Views;
using ExamSystem.Client.Helpers;
using ExamSystem.ServerAPI.SQL;

namespace ExamSystem.Client.Pages.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            
            //PlaceHolder.Content = new TeacherMain(new User());
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            PlaceHolder.Content = new Login();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            PlaceHolder.Content = new Register();

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Helpers.Constants.About, "Exam System Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
