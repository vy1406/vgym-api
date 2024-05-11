using Microsoft.AspNetCore.DataProtection.Repositories;
using Vgym.Models.Entities;
using Vgym.Server.Data.Repositories;
using Vgym.Server.Utilities.Exeptions;

namespace Vgym.Server.Services
{
    public class ProgramsService : IProgramsService
    {
        private readonly IRepository<TrainingProgram> _programsRepository;

        public ProgramsService(IRepository<TrainingProgram> programRepository)
        {
            _programsRepository = programRepository;
        }

        public async Task<IEnumerable<TrainingProgram>> GetAllProgramsAsync()
        {
            return await _programsRepository.GetAll();
        }

        public async Task<TrainingProgram> GetProgramByIdAsync(int programId)
        {
            //basic attempt to use costume data exeption and basic handaling of them, needs work
            try
            {
                return await _programsRepository.GetById(programId);
            }
            catch(EntityNotFoundException innerException)
            {
                Console.WriteLine("Inner exception: " + innerException.Message);
                return null;
            }
        }
    }
}
