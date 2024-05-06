using Vgym.Models.Entities;
using Vgym.Server.Utilities.Requests;
using Vgym.Server.Utilities.Responses;

namespace Vgym.Server.Services
{
    public interface ILoginService
    {
        Task<LoginResponse> AuthenticateUserAsync(User user);
    }
}
