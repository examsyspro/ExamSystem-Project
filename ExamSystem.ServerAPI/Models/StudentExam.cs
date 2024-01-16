

namespace ExamSystem.ServerAPI.Models
{
    public class StudentExam
    {

        public int StudentExamId { get; set; }
        public int ExamId { get; set; }  //AutoIncrement
        public string UserId { get; set; } //Student id
        public string ExamTitle { get; set; } //Title
        public DateTime ExamDate { get; set; }//available for execution (Date)
        public DateTime StartTime { get; set; } //available for execution (Time)
        public int TotalTime { get; set; } //Total exam Time  
        public Course_Enum CourseType { get; set; }
        public int Grade { get; set; }
        public bool isFinished { get; set; }//if true == Finish

    }
}
