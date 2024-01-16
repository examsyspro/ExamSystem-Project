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
        public async Task<List<Question>> GetAllQuestions()
        {
            List<Question> questions = new List<Question>();
            await using (AppDbContext Db = new AppDbContext())
            {
                questions = await Db.Questions.ToListAsync();
            }
            return questions;
        }

        public async Task<Question> GetQuestionById(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                return await Db.Questions.FindAsync(id);
            }
        }

        public async Task<bool> CreateQuestion(Question question)
        {
            await using (AppDbContext Db = new AppDbContext())
            {
                Db.Questions.Add(question);
                return await Db.SaveChangesAsync() > 0;
            }
        }

        public async Task<Question> UpdateQuestion(int id, Question updatedQuestion)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var existingQuestion = await Db.Questions.FindAsync(id);
                if (existingQuestion != null)
                {
                    // Update properties of existingQuestion with values from updatedQuestion
                    // ...

                    await Db.SaveChangesAsync();
                }
                return existingQuestion;
            }
        }

        public async Task<bool> DeleteQuestion(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var questionToDelete = await Db.Questions.FindAsync(id);
                if (questionToDelete != null)
                {
                    Db.Questions.Remove(questionToDelete);
                    return await Db.SaveChangesAsync() > 0;
                }
                return false;
            }
        }
    }
}
