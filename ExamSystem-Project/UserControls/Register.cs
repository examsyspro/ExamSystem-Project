﻿using System;
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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label_LoginNow_Click(object sender, EventArgs e)
        {
            MainForm.main.UISwitch("Login");
        }
    }
}
