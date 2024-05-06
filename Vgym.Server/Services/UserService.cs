using Vgym.Models.Entities;

namespace Vgym.Server.Services
{
    //Example boilerplate for a service , user service, workoutservice etc.
    //needs to change to work with async, await and tasks
    //needs to change to work with DTO's 
    public class UserService : IUserService
    {
        public Task<User> CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
