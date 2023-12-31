using ExamSystem.Client;
using ExamSystem.Client.ApiRequestors;
using ExamSystem.Client.Helpers;
using ExamSystem.Client.Models;
using ExamSystem.Client.Pages.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private UserRequestor userRequestor;
        public string userid;
        public string password;
        public User? userResponse;
        public User user;

        public Login()
        {
            InitializeComponent();
            userRequestor = new UserRequestor();
            userid = string.Empty;
            password = string.Empty;
            user = new User();
            userResponse = new User();

        }


        private async void Login_Click(object sender, RoutedEventArgs e)
        {

            if ((text_Password.Text == "") || textid.Text == "")
            {
                MessageBox.Show(Constants.requiredfields);
            }
            else
            {

                
                password = text_Password.Text;
                userid = textid.Text;

                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                {
                    MessageBox.Show(Helpers.Constants.passwordRegex);
                    return;
                }
                if (!Regex.IsMatch(userid, "^[0-9]{9}$"))
                {
                    MessageBox.Show(Constants.userIdRegex);
                    return;
                }
                this.Content = new Progress();
                user = new User() { PassWord = password, UserId = userid };
                userResponse = await userRequestor.Request_LoginAsync(user);

                if (userResponse != null)
                {
                    if (userResponse.TypeOfUser == "Student")
                    {

                        Window mainWindow = Window.GetWindow(this);
                        StudentWindow student = new StudentWindow(userResponse);
                        student.Show();
                        mainWindow.Close();


                    }
                    else if (userResponse.TypeOfUser == "Teacher")
                    {

                        this.Content = new TeacherMain(userResponse);
                    }
                }
                else
                {
                    MessageBox.Show(Constants.invalidMsg);
                    this.Content = new Login();
                }
            }
        }





    }
}
