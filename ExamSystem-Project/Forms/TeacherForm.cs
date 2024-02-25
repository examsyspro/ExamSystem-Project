using ExamSystem_Project.FormModels;
using ExamSystem_Project.Models;
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
    public partial class TeacherForm : Form
    {
        BuildExamForm buildExamForm;
        TeacherFormModel teacherModel;
        public User user;


        public TeacherForm(User user1)
        {
            InitializeComponent();
            teacherModel = new TeacherFormModel(this);
            this.user = user1;
            InitializeAll();

        }

        public void InitializeAll()
        {
            //datagridview configuration 
            dataGridView_teacherExams.ReadOnly = true;
            dataGridView_teacherExams.AllowUserToAddRows = false;
            dataGridView_teacherExams.MultiSelect = false;
            dataGridView_teacherExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_teacherExams.ClearSelection();
            dataGridView_teacherExams.AllowUserToResizeColumns = false;
            dataGridView_teacherExams.RowTemplate.Height = 40;
            // Set DPI Awareness
            this.AutoScaleMode = AutoScaleMode.Dpi;

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
            dataGridView_teacherExams.Width = dataGridViewWidth;

            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            // Set DataGridView properties
            dataGridView_teacherExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_teacherExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_teacherExams.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);

            
        }



        private void button_createExam_Click(object sender, EventArgs e)
        {
            teacherModel.CreateNewExam(user);
        }

        private void button_getAllExams_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView_teacherExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                teacherModel.OpenExistExam(user);

            }
        }

        private void TeacherForm_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {

            teacherModel.FilterRows(textBox_filter.Text);


        }

    }
}

