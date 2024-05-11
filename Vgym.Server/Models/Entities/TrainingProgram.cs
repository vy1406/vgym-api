using Vgym.Server.Utilities.Enums;

namespace Vgym.Models.Entities
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BackgroundImage { get; set; }
        public ProgramType Type { get; set; }
        public int Duration { get; set; }
    }
}
