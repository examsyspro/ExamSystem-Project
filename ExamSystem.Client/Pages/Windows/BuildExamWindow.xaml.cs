using ExamSystem.Client.Helpers;
using ExamSystem.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ExamSystem.Client.Pages.Views;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamSystem.Client.Pages.Windows
{
    /// <summary>
    /// Interaction logic for BuildExamWindow.xaml
    /// </summary>
    public partial class BuildExamWindow : Window
    {
        public BuildExamWindow()
        {
            InitializeComponent();
            button_Save_exam.IsEnabled = false;
            PlaceHolder.Content = new CreateExamStarter();

        }

        //private void build_exam_Click(object sender, RoutedEventArgs e)
        //{

        //    Exam exam = new Exam
        //    {
        //        ExamId = 100,
        //        CourseType = Helpers.Course_Enum.C_Sharp,
        //        ExamDate = DateTime.Now,               
        //        TeacherFullName = "Roei Atar",
        //        StartTime = DateTime.Now,
        //        TotalHours = 1,
        //        TotalMinutes = 30,
        //        RandomOrder = true,
        //        ExamTitle = "c# OOP",
        //    };

        //    OptionAns option1 = new OptionAns { OptionText = "2fsdfsdfsd", IsCorrect = true, Question_Id = 1, OptionAnsId = 2 };
        //    OptionAns option2 = new OptionAns { OptionText = "2sdfsdfsd", IsCorrect = false, Question_Id = 1, OptionAnsId = 2 };
        //    OptionAns option3 = new OptionAns { OptionText = "fsdfsds", IsCorrect = false, Question_Id = 1, OptionAnsId = 2 };
        //    OptionAns option4 = new OptionAns { OptionText = "e324234/?" };
        //    List<OptionAns> options = new List<OptionAns>() { option1, option2, option3, option4 };
        //    Question q1 = new Question()
        //    {
        //        QuestionId = 1,
        //        Text = "what a fuck?",
        //        Options = options

        //    };



        //    OptionAns option10 = new OptionAns { OptionText = "xxxx", IsCorrect = true, Question_Id = 2, OptionAnsId = 2 };
        //    OptionAns option11 = new OptionAns { OptionText = "ddddd", IsCorrect = false, Question_Id = 2, OptionAnsId = 2 };
        //    OptionAns option12 = new OptionAns { OptionText = "ddddff", IsCorrect = false, Question_Id = 2, OptionAnsId = 2 };
        //    OptionAns option13 = new OptionAns { OptionText = "ffff/?" };
        //    List<OptionAns> options1 = new List<OptionAns>() { option10, option11, option12, option13 };
        //    Question q2 = new Question()
        //    {
        //        QuestionId = 2,
        //        Text = "what a?",
        //        Options = options1

        //    };


        //    exam.QuestionsList.Add(q1);
        //    exam.QuestionsList.Add(q2);

        //    MessageBox.Show(exam.ToString());

        //    DatePicker d = new DatePicker();
        //    d = picker_Date;







        //}






        private void question_List_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_exam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_add_Qution_Click(object sender, RoutedEventArgs e)
        {
            PlaceHolder.Content = new CreateQuestion();
            button_add_Qution.IsEnabled = false;
        }

        private void button_Question_List_Click(object sender, RoutedEventArgs e)
        {
            PlaceHolder.Content = new QuestionList();
        }
    }
}
