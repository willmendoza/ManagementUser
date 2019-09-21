using ManagementUser.Api.Domains.Models;
using ManagementUser.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementUser.Api.Mappers
{
    public static class UserMappers
    {
        public static User Map(UserModel model)
        {
            return new User()
            {
                UserId = model.UserId,
                Name = model.Name,
                LastName = model.LastName,
                Address = model.Address,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };
        }
    }
}
