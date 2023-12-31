using ExamSystem.ServerAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ExamSystem.ServerAPI.SQL
{
    public class Sql_Funcs
    {
        public SqlConnection con { get; set; }
        
        public Sql_Funcs(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            con = new SqlConnection(connectionString);
            con.Open();
            if(con.State == ConnectionState.Open)
            {

            }
          
            
        }



        #region User
        public void Insert_User(User user)
        {
            try
            {
                SqlCommand com = new SqlCommand("InsertUserData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TypeOfUser", user.TypeOfUser);
                com.Parameters.AddWithValue("@FullName", user.FullName);
                com.Parameters.AddWithValue("@PassWord", user.PassWord);
                com.Parameters.AddWithValue("@UserId", user.UserId);
                com.Parameters.AddWithValue("@CourseType", user.CourseType);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public DataTable GetAll_Users() 
        {
            try
            {
                SqlCommand com = new SqlCommand("GetAllUsers", con);
                com.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }

        public DataTable GetUserById(int Id)
        {
            try
            {
                SqlCommand com = new SqlCommand("GetUserDataById", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", Id);
                com.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }

        public void Update_User(User user)
        {
            try
            {
                SqlCommand com = new SqlCommand("UpdateUserData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", user.Id);
                com.Parameters.AddWithValue("@TypeOfUser", user.TypeOfUser);
                com.Parameters.AddWithValue("@FullName", user.FullName);
                com.Parameters.AddWithValue("@PassWord", user.PassWord);
                com.Parameters.AddWithValue("@UserId", user.UserId);
                com.Parameters.AddWithValue("@CourseType", user.CourseType);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }

        public void Delete_User(int id)
        {
            try
            {

                SqlCommand com = new SqlCommand("DeleteUserData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", id);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

        }
        #endregion


        #region Exam
        public void Insert_Exam(Exam exam)
        {
            try
            {
                SqlCommand com = new SqlCommand("InsertExamData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamTitle", exam.ExamTitle);
                com.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                com.Parameters.AddWithValue("@TeacherFullName", exam.TeacherFullName);
                com.Parameters.AddWithValue("@StartTime", exam.StartTime);
                com.Parameters.AddWithValue("@TotalHours", exam.TotalHours);
                com.Parameters.AddWithValue("@TotalMinutes", exam.TotalMinutes);
                com.Parameters.AddWithValue("@RandomOrder", exam.RandomOrder);
                com.Parameters.AddWithValue("@CourseType", exam.CourseType.ToString());
                // Additional parameters for questions, e.g., @QuestionId, @QuestionText, etc.
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable GetAll_Exams()
        {
            try
            {
                SqlCommand com = new SqlCommand("GetAllExams", con);
                com.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                return new DataTable();
            }
        }

        public DataTable GetExamById(int ExamId)
        {
            try
            {
                SqlCommand com = new SqlCommand("GetExamDataById", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamId", ExamId);
                com.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                return new DataTable();
            }
        }

        public void Update_Exam(Exam exam)
        {
            try
            {
                SqlCommand com = new SqlCommand("UpdateExamData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamId", exam.ExamId);
                com.Parameters.AddWithValue("@ExamTitle", exam.ExamTitle);
                com.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                com.Parameters.AddWithValue("@TeacherFullName", exam.TeacherFullName);
                com.Parameters.AddWithValue("@StartTime", exam.StartTime);
                com.Parameters.AddWithValue("@TotalHours", exam.TotalHours);
                com.Parameters.AddWithValue("@TotalMinutes", exam.TotalMinutes);
                com.Parameters.AddWithValue("@RandomOrder", exam.RandomOrder);
                com.Parameters.AddWithValue("@CourseType", exam.CourseType.ToString());
                // Additional parameters for questions, e.g., @QuestionId, @QuestionText, etc.
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }

        public void Delete_Exam(int examId)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteExamData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamId", examId);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #region OptionAns
        public void Insert_OptionAns(OptionAns optionAns)
        {
            try
            {
                SqlCommand com = new SqlCommand("InsertOptionAnsData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Question_Id", optionAns.Question_Id);
                com.Parameters.AddWithValue("@OptionText", optionAns.OptionText);
                com.Parameters.AddWithValue("@IsCorrect", optionAns.IsCorrect);
                // Additional parameters for OptionAns

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }

        public DataTable GetAll_OptionAns()
        {
            try
            {
                SqlCommand com = new SqlCommand("GetAllOptionAns", con);
                com.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                return new DataTable();
            }
        }

        public DataTable GetOptionAnsById(int optionAnsId)
        {
            try
            {
                SqlCommand com = new SqlCommand("GetOptionAnsDataById", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@OptionAnsId", optionAnsId);
                com.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);
                return dataTable;


            }
            catch (Exception ex)
            {

                return new DataTable();
            }

        }

        public void Delete_OptionAns(int optionAnsId)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteOptionAnsData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@OptionAnsId", optionAnsId);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }
        #endregion


        #region Question
        public void Insert_Question(Question question)
        {
            try
            {
                SqlCommand com = new SqlCommand("InsertQuestionData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Text", question.Text);
                com.Parameters.AddWithValue("@Exam_Id", question.Exam_Id);
                com.Parameters.AddWithValue("@RandomAnsOrder", question.RandomAnsOrder);

                // Additional parameters for Question

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }

        public void Update_Question(Question question)
        {
            try
            {
                SqlCommand com = new SqlCommand("UpdateQuestionData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@QuestionId", question.QuestionId);
                com.Parameters.AddWithValue("@Text", question.Text);
                com.Parameters.AddWithValue("@Exam_Id", question.Exam_Id);
                com.Parameters.AddWithValue("@RandomAnsOrder", question.RandomAnsOrder);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }

        public void Delete_Question(int questionId)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteQuestionData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@QuestionId", questionId);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }

        public DataTable GetQuestionById(int questionId)
        {
            try
            {
                SqlCommand com = new SqlCommand("GetQuestionDataById", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@QuestionId", questionId);
                com.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dataTable);


                return dataTable;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        #endregion
    }
}
    

