using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.ServerAPI.Models
{
    public class Participation
    {
        [Key]
        public int ParticipationId { get; set; }
        public string Student_Id { get; set; }
        public string Student_Name { get; set; }
        public int Exam_Id { get; set; }
        public int Grade { get; set; }

    }
}
