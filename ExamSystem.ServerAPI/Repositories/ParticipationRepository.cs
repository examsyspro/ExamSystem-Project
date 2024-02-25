using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class ParticipationRepository : IParticipationRepository
    {
        private readonly AppDbContext _context;

        public ParticipationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Participation>> GetAllParticipations()
        {
            List<Participation> participations = await _context.Participations.ToListAsync();
            return participations;
        }

        public async Task<Participation> GetParticipationById(int id)
        {
            var participation = await _context.Participations
                .FirstOrDefaultAsync(p => p.ParticipationId == id);

            return participation;
        }

        public async Task<bool> CreateParticipation(Participation participation)
        {
            try
            {
                _context.Participations.Add(participation);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<bool> UpdateParticipation(Participation updatedParticipation)
        {
            try
            {
                _context.Participations.Update(updatedParticipation);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<bool> DeleteParticipation(int id)
        {
            var participationToDelete = await _context.Participations.FindAsync(id);
            if (participationToDelete != null)
            {
                _context.Participations.Remove(participationToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}

