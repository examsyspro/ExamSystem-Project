using ExamSystem_Project.FormModels;
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

        public TeacherForm()
        {
            InitializeComponent();
            teacherModel = new TeacherFormModel(this);
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
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            // Set DataGridView properties
            dataGridView_teacherExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_teacherExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_teacherExams.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
        }



        private void button_createExam_Click(object sender, EventArgs e)
        {
            teacherModel.CreateNewExam();
        }

        private void button_getAllExams_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView_teacherExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                teacherModel.OpenExistExam();

            }
        }


    }
}
