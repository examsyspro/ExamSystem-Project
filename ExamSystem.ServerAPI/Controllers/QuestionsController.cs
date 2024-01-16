using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ExamSystem.ServerAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepository _questionsRepo;

        public QuestionsController(IQuestionsRepository repo)
        {
            _questionsRepo = repo;
        }

        [HttpGet("getallquestions")]
        public async Task<List<Question>> GetAllQuestions()
        {
            return await _questionsRepo.GetAllQuestions();
        }

        [HttpGet("{id}")]
        public async Task<Question> GetQuestion(int id)
        {
            return await _questionsRepo.GetQuestionById(id);
        }

        [HttpPost("create")]
        public async Task<bool> CreateQuestion([FromBody] Question question)
        {
            return await _questionsRepo.CreateQuestion(question);
        }

        [HttpPut("{id}")]
        public async Task<Question> UpdateQuestion(int id, [FromBody] Question updatedQuestion)
        {
            return await _questionsRepo.UpdateQuestion(id, updatedQuestion);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteQuestion(int id)
        {
            return await _questionsRepo.DeleteQuestion(id);
        }
    }
}