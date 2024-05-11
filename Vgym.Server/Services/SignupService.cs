using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Vgym.Models.Entities;
using Vgym.Server.Data.Repositories;
using Vgym.Server.Utilities;
using Vgym.Server.Utilities.Responses;

namespace Vgym.Server.Services
{
    public class SignupService : ISignupService
    {
        private readonly IRepository<User> _userRepository;

        //TODO: add validations to make sure username is valid, password is valid
        public SignupService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Response> SignupUserAsync(User user)
        {
            if (await IsUsernameTaken(user.Username))
            {
                return GenarateErrorResponse("Error registering user");
            }
            else
            {
                await _userRepository.Add(user);
                return GenarateSuccessResponse("User was added successfully");
            }
            
        }

        private async Task<bool> IsUsernameTaken(string username)
        {
            var users = await GetUsersAsync();
            return users.Any(u => u.Username == username);
        }
        private Response GenarateErrorResponse(string message) => new Response { ErrorCode = ErrorCodes.INTERNAL_ERROR, ErrorMessage = message };
        private Response GenarateSuccessResponse(string message) => new Response { ErrorMessage = message };
        private async Task<IEnumerable<User>> GetUsersAsync() => await _userRepository.GetAll();
    }
}
