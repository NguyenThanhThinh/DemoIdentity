using System;
using System.Collections.Generic;
using System.Text;

namespace DemoIdentity.Services.Implementations
{
    using System.Linq;
    using System.Threading.Tasks;
    using DemoIdentity.Data;
    using DemoIdentity.Services.Interfaces;
    using DemoIdentity.Services.Models;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    public class UserService : IUserService
    {
        private readonly DemoIdentityDbContext db;

        public UserService(DemoIdentityDbContext db)
        {
            this.db = db;
        }

        public async Task<UserProfileServiceModel> ProfileAsync(string id)
        {
            var getInfo = await db.Users.Where(n => n.UserName == id)
                .ProjectTo<UserProfileServiceModel>(new { studentId = id })
                .FirstOrDefaultAsync();
            return getInfo;
        }
    }
}
