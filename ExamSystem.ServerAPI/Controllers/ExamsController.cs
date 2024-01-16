using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ExamSystem.ServerAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamsRepository _examsRepo;

        public ExamsController(IExamsRepository repo)
        {
            _examsRepo = repo;
        }

        [HttpGet("getallexams")]
        public async Task<List<Exam>> GetAllExams()
        {
            return await _examsRepo.GetAllExams();
        }

        [HttpGet("{id}")]
        public async Task<Exam> GetExam(int id)
        {
            return await _examsRepo.GetExamById(id);
        }

        [HttpPost("create")]
        public async Task<bool> CreateExam([FromBody] Exam exam)
        {
            return await _examsRepo.CreateExam(exam);
        }

        [HttpPut("{id}")]
        public async Task<Exam> UpdateExam(int id, [FromBody] Exam updatedExam)
        {
            return await _examsRepo.UpdateExam(id, updatedExam);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteExam(int id)
        {
            return await _examsRepo.DeleteExam(id);
        }
    }
}