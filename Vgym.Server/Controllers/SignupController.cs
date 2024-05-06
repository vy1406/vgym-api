using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vgym.Models.Entities;
using Vgym.Server.Services;

namespace Vgym.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly ISignupService _signupService;

        public SignupController(ISignupService signupService)
        {
            _signupService = signupService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var response = await _signupService.SignupUserAsync(user);
            return Ok(response);
        }
    }
}
