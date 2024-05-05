using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vgym.Models.Entities;
using Vgym.Server.Utilities;

namespace Vgym.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(User user)
        {
            var response = new
            {
                ErrorCode = ErrorCodes.NO_ERROR,
                ErrorMessage = "message from post in api",
                
            };
            Console.WriteLine($"{user}");
            return Ok(response);
        }
    }
}
