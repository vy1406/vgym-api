using Vgym.Models.Entities;
using Vgym.Server.Utilities.Responses;

namespace Vgym.Server.Services
{
    public interface ISignupService
    {
        Task<Response> SignupUserAsync(User user);
    }
}
