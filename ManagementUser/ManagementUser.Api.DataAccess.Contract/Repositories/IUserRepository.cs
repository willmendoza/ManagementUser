using ManagementUser.Api.DataAccess.Contract.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagementUser.Api.DataAccess.Contract.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> Update(UserEntity entity);
    }
}
