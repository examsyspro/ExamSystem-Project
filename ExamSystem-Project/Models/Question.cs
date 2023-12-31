﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.Models
{
    public class Question
    {


        public int QuestionId { get; set; }
        public string Text { get; set; }
        public List<OptionAns> Options { get; set; }
        public int Exam_Id { get; set; }
        public bool RandomAnsOrder { get; set; }
        public int IndexCorrect
        {
            get
            {
                int foundIndex = -1;
                var option = Options.SingleOrDefault(o => o.IsCorrect == true);
                if (option != null)
                {
                    foundIndex = Options.IndexOf(option);
                }
                return foundIndex;
            }
        }
        public Question(int questionId, string text, List<OptionAns> options, int exam_Id, bool randomAnsOrder)
        {
            QuestionId = questionId;
            Text = text;
            Options = options;
            Exam_Id = exam_Id;
            RandomAnsOrder = randomAnsOrder;
        }
        public Question()
        {
                
        }


    }
}

