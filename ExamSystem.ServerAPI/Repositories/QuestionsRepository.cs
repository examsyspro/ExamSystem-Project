using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly AppDbContext _context;

        public QuestionsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAllQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        public async Task<Question> GetQuestionById(int id)
        {

            return await _context.Questions.FindAsync(id); ;

        }

        public async Task<bool> CreateQuestion(Question question)
        {
            _context.Questions.Add(question);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Question> UpdateQuestion(int id, Question updatedQuestion)
        {
            var existingQuestion = await _context.Questions.FindAsync(id);
            if (existingQuestion != null)
            {
                // Update properties of existingQuestion with values from updatedQuestion
                // ...

                await _context.SaveChangesAsync();
            }
            return existingQuestion;
        }

        public async Task<bool> DeleteQuestion(int id)
        {
            var questionToDelete = await _context.Questions.FindAsync(id);
            if (questionToDelete != null)
            {
                _context.Questions.Remove(questionToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
