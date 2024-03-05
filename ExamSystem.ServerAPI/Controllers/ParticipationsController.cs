﻿using ExamSystem.ServerAPI.Models;
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
        public async Task<List<Participation>> GetAllParticipations()
        {
            return await _participationRepo.GetAllParticipations();
        }

        [HttpGet("{id}")]
        public async Task<Participation> GetParticipation(int id)
        {
            return await _participationRepo.GetParticipationById(id);
        }

        [HttpPost("create")]
        public async Task<bool> CreateParticipation([FromBody] Participation participation)
        {
            return await _participationRepo.CreateParticipation(participation);
        }

        [HttpPut("update")]
        public async Task<bool> UpdateParticipation([FromBody] Participation updatedParticipation)
        {
            return await _participationRepo.UpdateParticipation(updatedParticipation);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteParticipation(int id)
        {
            return await _participationRepo.DeleteParticipation(id);
        }
    }
}