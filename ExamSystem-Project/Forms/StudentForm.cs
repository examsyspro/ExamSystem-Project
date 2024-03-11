using ExamSystem_Project.FormModels;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using Microsoft.VisualBasic.Devices;
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
    public partial class StudentForm : Form
    {
        public User user { get; set; }
        public StudentFormModel StudentModel;

        LocalClock clock;
        public StudentForm(User user1)
        {
            InitializeComponent();
            InitializeAll();
            this.user = user1;
            StudentModel = new StudentFormModel(this);

            clock = LocalClock.Get_Instance();
            clock.Clock_event += Clock_Update;


        }

        public void Clock_Update(object sender, EventArgs e)
        {

            label_clock.Invoke((MethodInvoker)delegate
            {
                label_clock.Text = sender.ToString();
            });

        }
        public void InitializeAll()
        {
            //datagridview configuration 
            dataGridView_StudentExam.ReadOnly = true;
            dataGridView_StudentExam.AllowUserToAddRows = false;
            dataGridView_StudentExam.MultiSelect = false;
            dataGridView_StudentExam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_StudentExam.ClearSelection();

            dataGridView_StudentExam.AllowUserToResizeColumns = false;
            dataGridView_StudentExam.RowTemplate.Height = 40;

            // Set StartPosition to Manual
            StartPosition = FormStartPosition.CenterScreen;

            // Calculate and set the position and size of the form
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;

            // Set maximum width and height for the form
            int maxWidth = screen.Width - 100; // Adjust this value as needed
            int maxHeight = screen.Height - 100; // Adjust this value as needed
            int desiredFormWidth = 1650; // Set your desired form width
            int w = Math.Min(desiredFormWidth, maxWidth);
            int h = Math.Min(Height, maxHeight);

            int dataGridViewWidth = 1500; // Set your desired width
            dataGridView_StudentExam.Width = dataGridViewWidth;

            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            // Set DataGridView properties
            dataGridView_StudentExam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_StudentExam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_StudentExam.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);

        }

        private void dataGridView_StudentExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9)
                {

                    var x = (int)dataGridView_StudentExam.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                    if (x != 1)
                    {
                        StudentModel.OpenExam(user);
                    }

                }
            }
            catch (Exception ex)
            {


            }

        }

        private void StudentForm_Shown(object sender, EventArgs e)
        {
            clock.Clock_Run();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StudentModel.FilterRows(textBox_filter.Text);
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // clock.Stop();
            Environment.Exit(0);
        }


    }
}
