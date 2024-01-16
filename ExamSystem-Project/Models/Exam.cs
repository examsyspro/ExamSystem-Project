using ExamSystem.Client.Helpers;
using ExamSystem_Project.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExamSystem_Project.Models
{
    public class Exam
    {

        #region Properties

        public int ExamId { get; set; }  //AutoIncrement
        public Guid ExamStrId { get; set; }  //AutoIncrement
        public string ExamTitle { get; set; } //Title
        public DateTime ExamDate { get; set; }
        public string TeacherFullName { get; set; } // when the thecher was logged on the name show automaticly
        public DateTime StartTime { get; set; } //available for execution
        public int TotalHours { get; set; } //Total exam Hours duration 
        public int TotalMinutes { get; set; } //Total exam Minutes duration 
        public bool RandomQuestionOrder { get; set; } //Random order of the questions
        public Course_Enum CourseType { get; set; }




        #endregion
        public Exam() { }
        #region Methods 

        public bool AddNewExam(Exam e)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }




        #endregion







        public override string ToString()
        {
            return "";
        }






    }


}
