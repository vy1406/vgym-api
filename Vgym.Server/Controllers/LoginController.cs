using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vgym.Models.Entities;
using Vgym.Server.Services;
using Vgym.Server.Utilities;

namespace Vgym.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var response = await _loginService.AuthenticateUserAsync(user);
            return Ok(response);
        }
    }
}
