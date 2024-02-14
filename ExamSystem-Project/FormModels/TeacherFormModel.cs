using ExamSystem_Project.ApiRequestors;
using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.FormModels
{
    
    public class TeacherFormModel
    {
        public Exam exam;
       public List<Exam> exams;
       public TeacherForm teacher;
       public  General gen = new General();

        BuildExamForm buildExam;
        public TeacherFormModel(TeacherForm teacherForm)
        {
            exam = new Exam();
                 exams = new List<Exam>();
                 this.teacher = teacherForm;
                GetAllExams();
                
        }
        public async void GetAllExams()
        {
            try
            {
                    exams = await General.mainRequestor.Request_GetAll<Exam>("api/exams/getallexams");
                    if (exams.Count > 0)
                    {
                    teacher.dataGridView_teacherExams.DataSource = exams;
                    }
            }
            catch (Exception ex)
            {

               
            }
        }

        

        public void OpenExistExam()
        {
            try
            {
                int index = teacher.dataGridView_teacherExams.SelectedRows[0].Index;
                exam = exams[index];
                buildExam = new BuildExamForm(exam);
                buildExam.ShowDialog();

            }
            catch (Exception ex)
            {

             
            }
         

        }

        public void CreateNewExam()
        {
            buildExam = new BuildExamForm(null);
            buildExam.ShowDialog();
        }
        
    }
}
