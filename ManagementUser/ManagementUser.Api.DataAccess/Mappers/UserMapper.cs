
using ManagementUser.Api.DataAccess.Contract.Entities;
using ManagementUser.Api.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.DataAccess.Mappers
{
    public static class UserMapper
    {
        public static UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                UserId = dto.UserId,
                Name = dto.Name,
                LastName = dto.LastName,
                Address = dto.Address,
                CreateDate = dto.CreateDate,
                UpdateDate = dto.UpdateDate
            };
        }

        public static User Map(UserEntity entity)
        {
            return new User()
            {
                UserId = entity.UserId,
                Name = entity.Name,
                LastName = entity.LastName,
                Address = entity.Address,
                CreateDate = entity.CreateDate,
                UpdateDate = entity.UpdateDate
            };
        }
    }
}
