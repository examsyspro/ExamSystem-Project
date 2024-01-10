using ExamSystem_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem_Project.Forms
{
    public partial class BuildExamForm : Form
    {
        public BuildExamForm()
        {
            InitializeComponent();
            InitializeAll();
        }


        public void InitializeAll()
        {
            comboBox_Course_Select.Items.Insert(0, "Click to select");
            comboBox_Course_Select.SelectedIndex = 0;
            comboBox_Course_Select.Items.Insert(1, Course_Enum.C_Sharp);
            comboBox_Course_Select.Items.Insert(2, Course_Enum.JavaSctipt);
            tabControl1.TabPages.Remove(tabPage_step2);
            tabControl1.TabPages.Remove(tabPage_step3);
            dateTimePicker_examDate.MinDate = DateTime.Now;
            
        }

        private void button_next_Click(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_step1":
                    if (!tabControl1.TabPages.Contains(tabPage_step2))
                    {
                        tabControl1.TabPages.Add(tabPage_step2);
                    }
                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":
                    if (!tabControl1.TabPages.Contains(tabPage_step3))
                    {
                        tabControl1.TabPages.Add(tabPage_step3);
                    }
                    tabControl1.SelectedTab = tabPage_step3;
                    break;
                default:
                    break;
            }


        }

        private void dateTimePicker_examDate_ValueChanged(object sender, EventArgs e)
        {
            textBox_date.Text = dateTimePicker_examDate.Value.ToString("dd/MM/yy");
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_step3":
                    tabControl1.SelectedTab = tabPage_step2;
                    break;
                case "tabPage_step2":
                    tabControl1.SelectedTab = tabPage_step1;
                    break;
                default:
                    break;
            }
        }
    }
}
