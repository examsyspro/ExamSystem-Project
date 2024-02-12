using ExamSystem_Project.Helpers;
using ExamSystem_Project.UserControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;


namespace ExamSystem_Project
{
    public partial class MainForm : Form
    {
        General gen;
        public MainForm()
        {

            InitializeComponent();
            panel1_main.Controls.Add(new Register(this));
            panel1_main.Controls.Add(new Login(this));
            gen = new General();
            UISwitch("Login");

        }


        public void UISwitch(string ui)
        {
            switch (ui)
            {
                case "Register":
                    panel1_main.Controls.Find("Register", false)[0].BringToFront();
                    break;
                case "Login":
                    panel1_main.Controls.Find("Login", false)[0].BringToFront();

                    break;
            }
        }

    }
}