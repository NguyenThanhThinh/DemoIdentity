using System.Threading.Tasks;

namespace DemoIdentity.Services.Interfaces
{
    using DemoIdentity.Services.Models;
    public interface IUserService
    {
        Task<UserProfileServiceModel> ProfileAsync(string username);
    }
}
