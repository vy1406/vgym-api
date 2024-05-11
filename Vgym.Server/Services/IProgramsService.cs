using Vgym.Models.Entities;

namespace Vgym.Server.Services
{
    public interface IProgramsService
    {
        Task<TrainingProgram> GetProgramByIdAsync(int programId);
        Task<IEnumerable<TrainingProgram>> GetAllProgramsAsync();
    }
}
