


using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.Models;


namespace ExamSystem.ServerAPI.Repositories
{
    public interface IQuestionsRepository
    {
        Task<List<Question>> GetAllQuestions();
        Task<Question> GetQuestionById(int id);
        Task<bool> CreateQuestion(Question question);
        Task<Question> UpdateQuestion(int id, Question updatedQuestion);
        Task<bool> DeleteQuestion(int id);
    }
}
