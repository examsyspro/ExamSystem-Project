using ExamSystem.Client.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExamSystem.Client.Models
{
    public class Exam
    {

        #region Properties

        public int ExamId { get; set; }  //AutoIncrement
        public string ExamTitle { get; set; } //Title
        public DateTime ExamDate { get; set; }
        public string TeacherFullName { get; set; } // when the thecher was loggedon the name show automaticly
        public DateTime StartTime { get; set; } //available for execution
        public int TotalHours { get; set; } //Total exam Hours duration 
        public int TotalMinutes { get; set; } //Total exam Minutes duration 
        public bool RandomOrder { get; set; } //Random order of the questions
        public List<Question> QuestionsList { get; set; } //List of questions
        public Course_Enum CourseType { get; set; }




        #endregion



        

        public Exam()
        {
          
            QuestionsList = new List<Question>();
        }
        public override string ToString()
        {
            return "";
        }






    }

    
}
