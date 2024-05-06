using Vgym.Models.Entities;
using Vgym.Server.Data.Repositories;
using Vgym.Server.Utilities;
using Vgym.Server.Utilities.Responses;

namespace Vgym.Server.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<User> _userRepository;

        public LoginService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        //TODO: need to change params later to request when working with JWT tokens
        public async Task<Response> AuthenticateUserAsync(User userToAuthenticate)
        {
            var exisitingUser = await GetUserAsync(userToAuthenticate);
            if (exisitingUser == null)
            {
                return GenarateErrorResponse("Username is incorrect");
            }
            if (!IsPasswordValid(exisitingUser, userToAuthenticate.Password))
            {
                return GenarateErrorResponse("Password is incorrect");
            }

            return GenarateOkResponse();
        }

        private bool IsPasswordValid(User user, string passowrd)
        {
            if (user.Password == passowrd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private async Task<User> GetUserAsync(User userToAuthenticate) => await _userRepository.GetByName(userToAuthenticate.Username);
        private Response GenarateOkResponse() => new Response();
        private Response GenarateErrorResponse(string message) => new Response { ErrorCode = ErrorCodes.INTERNAL_ERROR, ErrorTitle = "Error", ErrorMessage = message };
    }
}
