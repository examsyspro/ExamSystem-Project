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
                return await _context.Participations.Where(id => id.Exam_Id == examId).Include(e => e.errors).ToListAsync();

            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public async Task<Participation> GetParticipationById(int id)
        {
            try
            {
                var participation = await _context.Participations.Include(e => e.errors)
               .FirstOrDefaultAsync(p => p.Exam_Id == id);
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
                return await _context.Participations
          .FirstOrDefaultAsync(p => p.Student_Id == studentId && p.Exam_Id == examId);
            }
            catch (Exception ex)
            {
                return null;

            }

        }
    }
}

