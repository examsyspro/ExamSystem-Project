using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.Models
{
    public class OptionAns
    {
        public int OptionAnsId { get; set; }
        public Guid OptionAnsStrId { get; set; }
        public int Question_Id { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }

        public OptionAns()
        {
                
        }
        public OptionAns(int optionAnsId, int question_Id, string optionText, bool isCorrect)
        {
            OptionAnsId = optionAnsId;
            Question_Id = question_Id;
            OptionText = optionText;
            IsCorrect = isCorrect;
        }
    }
}


