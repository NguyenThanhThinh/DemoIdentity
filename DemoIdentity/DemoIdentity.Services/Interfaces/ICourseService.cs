using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoIdentity.Services.Interfaces
{
    using DemoIdentity.Services.Models;
    public interface ICourseService
    {
        Task<IEnumerable<CourseListingServiceModel>> GetAllAsync();

        Task<TModel> GetByIdAsync<TModel>(int id) where TModel : class;

        Task<bool> IsUserSignedInCourseAsync(int courseId, string userId);

        Task<bool> SignUpStudentAsync(int courseId, string userId);

        Task<bool> SignOutStudentAsync(int courseId, string userId);
    }
}
