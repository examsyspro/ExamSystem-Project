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
            try
            {
                List<Participation> participations = await _context.Participations.ToListAsync();
                return participations;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<List<Participation>> GetAllParticipationsById(int examId)
        {
            try
            {
                // Retrieve participations filtered by examId
                List<Participation> participations = await _context.Participations
                    .Where(p => p.Exam_Id == examId)
                    .ToListAsync();

                // Loop through each participation to retrieve errors
                foreach (var participation in participations)
                {
                    participation.errors = await _context.Errors
                        .Where(e => e.ParticipationId == participation.ParticipationId)
                        .ToListAsync();
                }

            
                return participations;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // Returning null might not be the best practice; consider throwing the exception instead
                return null;
            }
        }
        public async Task<Participation> GetParticipationById(int id)
        {
            try
            {

                var participation = await _context.Participations.FirstOrDefaultAsync(p => p.Exam_Id == id);
                
                if (participation != null)
                {
                    participation.errors = await _context.Errors.Where(e=>e.ParticipationId == participation.ParticipationId).ToListAsync();
                }
              
                if (participation == null)
                {
                    return new Participation();
                }

                return participation;
            }
            catch (Exception ex)
            {

                return new Participation();
            }

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
            try
            {
                var participationToDelete = await _context.Participations.FindAsync(id);
                if (participationToDelete != null)
                {
                    _context.Participations.Remove(participationToDelete);
                    return await _context.SaveChangesAsync() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public async Task<bool> GetByStudentAndExamId(string studentId, int examId)
        {
            try
            {
                return await _context.Participations
          .AnyAsync(p => p.Student_Id == studentId && p.Exam_Id == examId);
            }
            catch (Exception ex)
            {
                return false;

            }

        }


        public async Task<Participation> GetParticipationBySE(string studentId, int examId)
        {
            try
            {
                Participation participation = await _context.Participations.FirstOrDefaultAsync(p => p.Student_Id == studentId && p.Exam_Id == examId);

                // Assuming you intended to retrieve errors associated with the participation, you should include that logic
                if (participation != null)
                {
                    participation.errors = await _context.Errors.Where(e=>e.ParticipationId == participation.ParticipationId).ToListAsync();
                }

                return participation;
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                return null;
            }
        }

    }
}

