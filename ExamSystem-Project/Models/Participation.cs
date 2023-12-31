using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.Models
{
    public class Participation
    {
        public int ParticipationId { get; set; }
        public string Student_Id { get; set; }
        public string Student_Name { get; set; }
        public int Exam_Id { get; set; }
        public int Grade { get; set; }
        public bool IsExpired { get; set; }


    }
}
