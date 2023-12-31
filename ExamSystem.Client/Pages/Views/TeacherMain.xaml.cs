using ExamSystem.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for TeacherMain.xaml
    /// </summary>
    public partial class TeacherMain : UserControl
    {
        public User _User { get; set; }
        public TeacherMain(User user)
        {
            InitializeComponent();
            _User = user;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            // this.Content = new Progress();

            MessageBox.Show("successfully logged out");
           
        }

        private void Build_Exam_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
