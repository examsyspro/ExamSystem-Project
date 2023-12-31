

using ExamSystem.Client.ApiRequestors;
using ExamSystem.Client.Models;
using ExamSystem.Client.Pages.Windows;
using ExamSystem.ServerAPI.Repositories;
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
using System.Windows.Shapes;

namespace ExamSystem.Client.Pages.Views
{

    /// <summary>
    /// Interaction logic for StudentMain.xaml
    /// </summary>
    public partial class StudentMain : UserControl
    {
        private UserRequestor userRequestor;
        public User _User { get; set; } = null;
        public List<User> users;
        public string searchText;
        List<string> filteredItems;
        public StudentMain(User user)
        {

            InitializeComponent();
            _User = user;
            userRequestor = new UserRequestor();
            users = new List<User>();
            searchText = string.Empty;
            filteredItems = new List<string>();

        }
        public async void Window_Open(object sender, RoutedEventArgs e)
        {

            users = await userRequestor.Request_GetAllUsers();
            if (users.Count != 0)
            {
                examListBox.ItemsSource = null;
                examListBox.Items.Clear();
                foreach (var user in users)
                {
                    examListBox.Items.Add($"{user.FullName}");
                }
            }
            else
            {
                examListBox.ItemsSource = "No Eaxams Yet";
            }


        }

        private async void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Filter the ListBox based on the search text

            users = await userRequestor.Request_GetAllUsers();
            searchText = searchTextBox.Text.ToLower();
            filteredItems.Clear();
            foreach (var user in users)
            {
                if (user.FullName.ToLower().Contains(searchText))
                {
                    filteredItems.Add(user.FullName);
                }
            }
            if (filteredItems.Count == 0)
            {
                filteredItems.Add("Exam dosen't exist");
            }
            // Update the ListBox
            examListBox.ItemsSource = null;
            examListBox.Items.Clear();
            examListBox.ItemsSource = filteredItems;
        }




        private void startExamButton_Click(object sender, RoutedEventArgs e)
        {
            ExamRunWindow x  = new ExamRunWindow();
            x.ShowDialog();

        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("successfully logged out");
            //this.Content = new Progress();

            
        }
    }
}
