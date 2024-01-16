using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.ServerAPI.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public Guid QuestionStrId { get; set; }
        public string Text { get; set; }
        public int Exam_Id { get; set; }
        public bool RandomAnsOrder { get; set; }
        public int IndexCorrect { get; set; }

    }
}

