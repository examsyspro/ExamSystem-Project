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
    public class ExamFormModel
    {

        private int textBoxCounter = 0;
        public int optionNameCounter = 1;
        public TextBox dynamicTextBox;
        public string[] strArr;
        public Exam exam;
        public Question question;
        public OptionAns optionAns;
        public Label dynamicLabel;
        public RadioButton radioButton;
        public List<TextBox> textBoxesList;
        public List<RadioButton> radioButtonList;
        public List<Button> deleteButtonList;
        public List<Label> labelList;
        public List<Control> ControlsList;
        Random rand;
        public ExamFormModel()
        {
            exam = new Exam();
            textBoxesList = new List<TextBox>();
            radioButtonList = new List<RadioButton>();
            deleteButtonList = new List<Button>();
            ControlsList = new List<Control>();
            labelList = new List<Label>();
        }

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
