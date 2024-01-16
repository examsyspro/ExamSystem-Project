using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.ServerAPI.Models
{
    public class OptionAns
    {
        [Key]
        public int OptionAnsId { get; set; }
        public Guid OptionAnsStrId { get; set; }
        public int Question_Id { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }

    }
}


