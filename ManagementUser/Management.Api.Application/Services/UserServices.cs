using ManagementUser.Api.DataAccess.Contract.Repositories;
using ManagementUser.Api.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ManagementUser.Api.Application.Contracts.Services;

namespace ManagementUser.Api.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> GetUserName(int userId)
        {
            var entity = await _userRepository.Get(userId);
            return entity.Name;
        }
    }
}
