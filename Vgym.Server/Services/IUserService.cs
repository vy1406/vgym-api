using Vgym.Models.Entities;

namespace Vgym.Server.Services
{
    //Example of a service interface that implaments CRUD operations
    //needs to change later to work with async await and tasks
    //needs to change later to work with returning DTO's
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
    }
}
