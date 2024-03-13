using ExamSystem_Project.ApiRequestors;
using ExamSystem_Project.Helpers;
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
    public partial class StatisticsForm : Form
    {
        public Exam exam;
        public User user;
        public List<Participation> participationsList;
        public List<Error> errorsList;
        public Participation participation;

        public StatisticsForm(Exam recivedexam, User reciveduser)
        {

            InitializeComponent();
            this.user = reciveduser;
            this.exam = recivedexam;

            InitializeAll();






        }


        public void InitializeAll()
        {
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


            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            participationsList = new List<Participation>();
            errorsList = new List<Error>();
            GetAllParticipations();
            participation = new Participation();
            if (participationsList.Count > 0)
            {
                listBox_studentsList.SelectedIndex = 0;
            }
            GetErrors();

        }

        public async void GetAllParticipations()
        {
            try
            {
                participationsList = await General.mainRequestor.Request_GetAllById(exam.ExamId);
                foreach (var item in participationsList)
                {
                    errorsList.AddRange(item.errors);

                    listBox_studentsList.Items.Add(item.Student_Name);

                }




            }
            catch (Exception ex)
            {


            }
        }

        private void listBox_studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetErrors();
        }

        public void GetErrors()
        {
            try
            {
                listBox_errorsList.DataSource = null;
                listBox_errorsList.Items.Clear();
                GetParticipation();
                foreach (var item in participation.errors)
                {
                    listBox_errorsList.Items.Add(item.StudentAnswer);
                }
            }
            catch (Exception ex)
            {


            }
        }

        public void GetParticipation()
        {
            try
            {
                var index = listBox_studentsList.SelectedIndex;
                if (index != -1)
                {
                    participation = participationsList[index];
                }

            }
            catch (Exception ex)
            {


            }

        }
    }
}
