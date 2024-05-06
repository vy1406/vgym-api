using Vgym.Models.Entities;

namespace Vgym.Server.Utilities.Requests
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginRequest(User user)
        {
            Username = user.UserName;
            Password = user.Password;
        }
    }
}
