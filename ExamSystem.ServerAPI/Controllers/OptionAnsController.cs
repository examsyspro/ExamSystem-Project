using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ExamSystem.ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionAnsController : ControllerBase
    {
        private readonly IOptionAnsRepository _optionAnsRepo;

        public OptionAnsController(IOptionAnsRepository repo)
        {
            _optionAnsRepo = repo;
        }

        [HttpGet("getalloptionans")]
        public async Task<List<OptionAns>> GetAllOptionAns()
        {
            return await _optionAnsRepo.GetAllOptionAns();
        }

        [HttpGet("{id}")]
        public async Task<OptionAns> GetOptionAns(int id)
        {
            return await _optionAnsRepo.GetOptionAnsById(id);
        }

        [HttpPost("create")]
        public async Task<bool> CreateOptionAns([FromBody] OptionAns optionAns)
        {
            return await _optionAnsRepo.CreateOptionAns(optionAns);
        }

        [HttpPut("{id}")]
        public async Task<OptionAns> UpdateOptionAns(int id, [FromBody] OptionAns updatedOptionAns)
        {
            return await _optionAnsRepo.UpdateOptionAns(id, updatedOptionAns);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteOptionAns(int id)
        {
            return await _optionAnsRepo.DeleteOptionAns(id);
        }
    }
}