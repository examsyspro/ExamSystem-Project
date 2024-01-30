using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class ExamsRepository : IExamsRepository
    {
        private readonly AppDbContext _context;

        public ExamsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Exam>> GetAllExams()
        {
            List<Exam> exams = await _context.Exams.ToListAsync();

            foreach (var exam in exams)
            {
                await _context.Entry(exam)
                    .Collection(e => e.questions) // Include the related Questions
                    .Query()
                    .Include(q => q.Options) // Include the related OptionAns entities for each Question
                    .LoadAsync();
            }

            return exams;
        }

        public async Task<Exam> GetExamById(int id)
        {
            return await _context.Exams
       .Include(e => e.questions) // Include the related Questions
           .ThenInclude(q => q.Options) // Include the related OptionAns entities for each Question
       .FirstOrDefaultAsync(e => e.ExamId == id);
        }

        public async Task<bool> CreateExam(Exam exam)
        {
            try
            {
                _context.Exams.Add(exam);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<Exam> UpdateExam(int id, Exam updatedExam)
        {
            var existingExam = await _context.Exams.FindAsync(id);

            if (existingExam != null)
            {
                // Update the entire Exam object
                _context.Entry(existingExam).CurrentValues.SetValues(updatedExam);

                // Update or add new questions and their options
                foreach (var updatedQuestion in updatedExam.questions)
                {
                    var existingQuestion = existingExam.questions.FirstOrDefault(q => q.QuestionId == updatedQuestion.QuestionId);

                    if (existingQuestion != null)
                    {
                        // Update properties of existingQuestion with values from updatedQuestion
                        _context.Entry(existingQuestion).CurrentValues.SetValues(updatedQuestion);
                    }
                    else
                    {
                        // Add new Question to the existingExam
                        existingExam.questions.Add(updatedQuestion);
                    }
                }

                // Remove questions that are not present in the updatedExam
                var questionsToRemove = existingExam.questions.Where(q => !updatedExam.questions.Any(uq => uq.QuestionId == q.QuestionId)).ToList();
                foreach (var questionToRemove in questionsToRemove)
                {
                    existingExam.questions.Remove(questionToRemove);
                }

                await _context.SaveChangesAsync();
            }

            return existingExam;
        }

        public async Task<bool> DeleteExam(int id)
        {
            var examToDelete = await _context.Exams.FindAsync(id);
            if (examToDelete != null)
            {
                _context.Exams.Remove(examToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
