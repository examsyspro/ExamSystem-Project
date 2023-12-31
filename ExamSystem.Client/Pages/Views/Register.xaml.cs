using ExamSystem.Client.Models;
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
using ExamSystem.Client.ApiRequestors;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExamSystem.Client.Helpers;
using System.Text.RegularExpressions;

namespace ExamSystem.Client.Pages.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl
    {
        private UserRequestor userRequestor;
        public bool success;
        public string selectedItem;
        public UserType_Enum userType;
        public Course_Enum? courseType;
        public string fullname;
        public string userid;
        public User user;
        public string password;
        public Register()
        {
            InitializeComponent();
            userRequestor = new UserRequestor();
            success = false;
            selectedItem = string.Empty;
            userType = new UserType_Enum();
            courseType = new Course_Enum();
            fullname = string.Empty;
            userid = string.Empty;
            password = string.Empty;
            user = new User();
            firlas.Visibility = Visibility.Hidden;
            pass.Visibility = Visibility.Hidden;
            cour.Visibility = Visibility.Hidden;
            teaStu.Visibility = Visibility.Hidden;
            id.Visibility = Visibility.Hidden;
        }

        private async void Register_Click(object sender, RoutedEventArgs e)
        {


            if ((textName.Text == "") || textid.Text == "")
            {
                MessageBox.Show(Helpers.Constants.requiredfields);
            }
            else if (ComboBoxType.SelectedIndex == 0)
            {
                MessageBox.Show(Helpers.Constants.typeSelect);
            }
            else
            {
                selectedItem = ComboBoxType.SelectedItem.ToString();
                //Convert String from ComboBox (string) to Enum UserType
                userType = (UserType_Enum)Enum.Parse(typeof(UserType_Enum), selectedItem);
                if (userType == UserType_Enum.Student && Course_Select.SelectedIndex==0)
                {
                    MessageBox.Show(Helpers.Constants.curseSelect);
                }
                else
                {
                    password = text_Password.Text;
                    fullname = textName.Text;
                    userid = textid.Text;
                    if (!Regex.IsMatch(fullname, "^[a-zA-Z]+\\s[a-zA-Z]+$"))
                    {
                        MessageBox.Show(Helpers.Constants.fullNameRegex);

                        return;
                    }
                    if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        MessageBox.Show(Helpers.Constants.passwordRegex);
                        return;
                    }
                    if (!Regex.IsMatch(userid, "^[0-9]{9}$"))
                    {
                        MessageBox.Show(Helpers.Constants.userIdRegex);
                        return;
                    }
                    if (userType == UserType_Enum.Teacher)
                    {
                        courseType = null;
                    }
                 
                    user = new User() { TypeOfUser = userType.ToString(), FullName = fullname, UserId = userid, CourseType = courseType ,PassWord = password};

                  
                    if (!await userRequestor.Request_ExistingUser(userid))
                    {

                        success = await userRequestor.Request_RegisterAsync(user);
                        if (success)
                        {
                            MessageBox.Show(Helpers.Constants.successReg);
                            this.Content = null;
                        }
                        else
                        {
                            MessageBox.Show(Helpers.Constants.notSuccessReg);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Helpers.Constants.alreadyExists);
                    }
                }
 

            }


        }

        /// <summary>
        /// insert the data to all combobox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBoxType.Items.Insert(0, "Click to select");
            ComboBoxType.SelectedIndex = 0;
            ComboBoxType.Items.Insert(1, UserType_Enum.Teacher);
            ComboBoxType.Items.Insert(2, UserType_Enum.Student);

            Course_Select.Items.Insert(0, "Click to select");
            Course_Select.SelectedIndex = 0;
            Course_Select.Items.Insert(1, Course_Enum.C_Sharp);
            Course_Select.Items.Insert(2, Course_Enum.JavaSctipt);

        }


        /// <summary>
        /// Course_Select is only for student 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (ComboBoxType.SelectedIndex)
            {
                case 1:
                    Course_Select.IsEnabled = false;
                    break; 
                case 2:
                    Course_Select.IsEnabled = true;
                    cour.Visibility = Visibility.Visible;

                    break;
                default:
                    Course_Select.IsEnabled = false;
                    break;
            }
        }


        private void textName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            firlas.Visibility = Visibility.Visible;
        }

        private void textid_SelectionChanged(object sender, RoutedEventArgs e)
        {
          id.Visibility = Visibility.Visible;
        }


        private void text_Password_SelectionChanged(object sender, RoutedEventArgs e)
        {
            pass.Visibility = Visibility.Visible;
        }

        private void ComboBoxType_GotFocus(object sender, RoutedEventArgs e)
        {
            teaStu.Visibility = Visibility.Visible;
        }
    }
}
