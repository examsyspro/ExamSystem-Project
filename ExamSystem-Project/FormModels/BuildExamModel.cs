using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem_Project.FormModels
{
    public class BuildExamModel
    {

        public async Task<bool> Build_Exam(Exam exam)
        {
            bool resultExam = await General.mainRequestor.Request_NewPost<Exam>(exam, "api/exams/create");

            return resultExam;
        }

        public async Task<Exam> Update_Exam(Exam exam)
        {
             var resultExam = await General.mainRequestor.Request_Put<Exam>(1,exam, "api/exams/update");

            return resultExam;
        }
    }
}
