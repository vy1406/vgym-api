using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vgym.Server.Services;
using Vgym.Server.Utilities.Enums;

namespace Vgym.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramsService _programsService;

        public ProgramsController(IProgramsService programsService)
        {
            _programsService = programsService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var program = await _programsService.GetProgramByIdAsync(id);
            return Ok(program); 
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allPrograms = await _programsService.GetAllProgramsAsync();
            return Ok(allPrograms);
        }


    }
}
