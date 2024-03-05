using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamSystem.ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationsController : ControllerBase
    {
        private readonly IParticipationRepository _participationRepo;

        public ParticipationsController(IParticipationRepository repo)
        {
            _participationRepo = repo;
        }

        [HttpGet("getallparticipations")]
        public async Task<ActionResult<List<Participation>>> GetAllParticipations()
        {
            var participations = await _participationRepo.GetAllParticipations();
            return Ok(participations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Participation>> GetParticipation(int id)
        {
            var participation = await _participationRepo.GetParticipationById(id);
            if (participation == null)
            {
                return NotFound();
            }
            return Ok(participation);
        }

        [HttpPost("create")]
        public async Task<ActionResult<bool>> CreateParticipation([FromBody] Participation participation)
        {
            var result = await _participationRepo.CreateParticipation(participation);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500); // Internal Server Error
        }

        [HttpPut("update")]
        public async Task<ActionResult<bool>> UpdateParticipation([FromBody] Participation updatedParticipation)
        {
            var result = await _participationRepo.UpdateParticipation(updatedParticipation);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500); // Internal Server Error
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteParticipation(int id)
        {
            var result = await _participationRepo.DeleteParticipation(id);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500); // Internal Server Error
        }
    }
}
