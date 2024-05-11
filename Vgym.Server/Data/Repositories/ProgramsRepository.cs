using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Vgym.Data.Contexts;
using Vgym.Models.Entities;
using Vgym.Server.Utilities.Exeptions;

namespace Vgym.Server.Data.Repositories
{
    public class ProgramsRepository : IRepository<TrainingProgram>
    {
        private readonly VgymDbContext _context;

        public ProgramsRepository(VgymDbContext context)
        {
                _context = context;
        }

        public Task Add(TrainingProgram entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TrainingProgram>> GetAll()
        {
            return await _context.TrainingPrograms.ToListAsync();
        }

        public Task<TrainingProgram> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<TrainingProgram> GetById(int id)
        {
            var program = await _context.TrainingPrograms.SingleOrDefaultAsync(program => program.Id == id);

            if(program != null)
            {
                return program;
            }
            else
            {
                throw new DataException("Entity not found");
            }
        }

        public Task Update(TrainingProgram entity)
        {
            throw new NotImplementedException();
        }
    }
}
