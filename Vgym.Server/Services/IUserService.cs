using Vgym.Models.Entities;

namespace Vgym.Server.Services
{
    //Example of a service interface that implaments CRUD operations
    //needs to change later to work with async await and tasks
    //needs to change later to work with returning DTO's
    public interface IUserService
    {
        User GetDummy(int id);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

    }
}
