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
        public Error error;
        public float average = 0;
        public List<float> gradesList;


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
            int desiredFormWidth = 1500; // Set your desired form width
            int w = Math.Min(desiredFormWidth, maxWidth);
            int h = Math.Min(Height, maxHeight);

            int dataGridViewWidth = 1500; // Set your desired width


            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            participationsList = new List<Participation>();
            errorsList = new List<Error>();
            participation = new Participation();
            gradesList = new List<float>();
            error = new Error();
            GetAllParticipations();
            GetErrors();
            GetError();


            label_examName.Text = exam.ExamTitle;



        }

        public async void GetAllParticipations()
        {
            try
            {
                participationsList = await General.mainRequestor.Request_GetAllById(exam.ExamId);
                if (participationsList != null)
                {
                    foreach (var item in participationsList)
                    {
                        errorsList.AddRange(item.errors);

                        listBox_studentsList.Items.Add(item.Student_Name);
                        gradesList.Add(item.Grade);

                    }
                    listBox_studentsList.SelectedIndex = 0;
                    GetAverage();
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
                UpdateStudentLabels();
            }
            catch (Exception ex)
            {


            }

        }

        public void GetErrors()
        {
            try
            {
                listBox_errorsList.DataSource = null;
                listBox_errorsList.Items.Clear();
                GetParticipation();
                if (participation != null)
                {
                    if (participation.errors.Count > 0)
                    {
                        foreach (var item in participation.errors)
                        {
                            listBox_errorsList.Items.Add(item.QuestionContent);
                        }
                        listBox_errorsList.SelectedIndex = 0;
                        label_selectedAnswer.Visible = true;
                        label_currectAnswer.Visible = true;
                    }
                    else
                    {
                        listBox_errorsList.Items.Add("No Errors congratulations :)");
                        label_selectedAnswer.Visible = false;
                        label_currectAnswer.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }

        public void GetError()
        {
            try
            {
                var index = listBox_errorsList.SelectedIndex;
                if (index != -1)
                {
                    error = errorsList[index];
                }

            }
            catch (Exception ex)
            {


            }

        }

        public void GetAverage()
        {
            try
            {
                average = gradesList.Sum() / gradesList.Count;
                label_studentsAver.Text = average.ToString();
            }
            catch (Exception ex)
            {


            }
        }


        public void UpdateStudentLabels()
        {
            label_studentName.Text = participation.Student_Name;
            label_idStudent.Text = participation.Student_Id;
            label_gradeStudent.Text = participation.Grade.ToString();

        }


        public void UpdateAnswersLabels()
        {
            label_currectAnswer.Text = error.CorrectAnswer;
            label_selectedAnswer.Text = error.StudentAnswer;

        }







        private void listBox_studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateStudentLabels();
                GetErrors();
            }
            catch (Exception ex)
            {


            }

        }

        private void listBox_errorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetError();
            UpdateAnswersLabels();
        }
    }
}
