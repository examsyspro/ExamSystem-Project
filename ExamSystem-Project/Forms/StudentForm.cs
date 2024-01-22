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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            InitializeAll();
        }


        public void InitializeAll()
        {
            //datagridview configuration 
            dataGridView_StudentExam.ReadOnly = true;
            dataGridView_StudentExam.AllowUserToAddRows = false;
            dataGridView_StudentExam.MultiSelect = false;
            dataGridView_StudentExam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_StudentExam.ClearSelection();

            StudentExam s1 = new StudentExam();
            s1.StartTime = DateTime.Now;

            StudentExam s2 = new StudentExam();
            s2.StartTime = DateTime.Now;

            List<StudentExam> hgfghf = new List<StudentExam>();
            hgfghf.Add(s1);
            hgfghf.Add(s2);

            dataGridView_StudentExam.DataSource = hgfghf;


        }

        private void dataGridView_StudentExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                MessageBox.Show(e.ColumnIndex.ToString());
            }
        }
    }
}
