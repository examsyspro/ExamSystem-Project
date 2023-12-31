using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem_Project.UserControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            //button_loginStart.Enabled = false;
        }

        private void label_registerNow_Click(object sender, EventArgs e)
        {
            MainForm.main.UISwitch("Register");
        }

        private void textBox_userId_TextChanged(object sender, EventArgs e)
        {
            ButtonHandler();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            ButtonHandler();
        }

        public void ButtonHandler()
        {
            if (textBox_userId.Text == "UserId" || string.IsNullOrEmpty(textBox_userId.Text.Trim()) || textBox_password.Text == "Password" || string.IsNullOrEmpty(textBox_password.Text.Trim()))
            {
                button_loginStart.Enabled = false;
            }
            else
            {
                button_loginStart.Enabled = true;
            }
        }

        private void button_loginStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("complete");
        }
    }
}