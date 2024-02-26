using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.FormModels
{
    public class StudentFormModel
    {
        public Exam exam;
        public StudentForm student;
        public List<Exam> exams;
        public static StudentFormModel studentFormModel;

        public ExamRunForm2 examRun;
        public StudentFormModel(StudentForm studentFrom)
        {
            this.student = studentFrom;
            exam = new Exam();
            exams = new List<Exam>();
            studentFormModel = this;
            GetAllExams();

        }
        public async void GetAllExams()
        {
            try
            {
                exams = await General.mainRequestor.Request_GetAll<Exam>("api/exams/getallexams");
                if (exams.Count > 0)
                {
                    student.dataGridView_StudentExam.DataSource = exams.Where(c => c.CourseType == student.user.CourseType).ToList();

                }
            }
            catch (Exception ex)
            {


            }
        }

        public void OpenExam(User user)
        {
            try
            {
                int index = student.dataGridView_StudentExam.SelectedRows[0].Index;
                exam = exams[index];
                examRun = new ExamRunForm2(exam, user);
                examRun.ShowDialog();

            }
            catch (Exception ex)
            {


            }


        }

    }
}
