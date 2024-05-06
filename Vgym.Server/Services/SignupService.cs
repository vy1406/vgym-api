using Vgym.Models.Entities;
using Vgym.Server.Data.Repositories;
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

        public Task<Response> SignupUserAsync(User user)
        {
            _userRepository.Add(user);
        }

        private async Task<bool> IsUsernameAvailable(string username)
        {
            var users = await GetUsersAsync();
            users.Any(u => u.Username == username);
        }

        private async Task<IEnumerable<User>> GetUsersAsync() => await _userRepository.GetAll();
    }
}
