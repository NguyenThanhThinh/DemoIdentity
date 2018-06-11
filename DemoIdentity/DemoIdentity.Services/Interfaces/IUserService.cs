using System.Threading.Tasks;

namespace DemoIdentity.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserProfileServiceModel> ProfileAsync(string username);
    }
}
