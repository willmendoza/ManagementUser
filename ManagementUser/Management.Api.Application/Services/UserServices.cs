using ManagementUser.Api.DataAccess.Contract.Repositories;
using ManagementUser.Api.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ManagementUser.Api.Application.Contracts.Services;
using ManagementUser.Api.DataAccess.Mappers;
using ManagementUser.Api.Domains.Models;
using System.Linq;

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

        public async Task<User> AddUser(User user)
        {
           var addedEntity = await _userRepository.Add(UserMapper.Map(user));
            return UserMapper.Map(addedEntity);
        }

        public async Task<User> GetUser(int userId)
        {
            var entity = await _userRepository.Get(userId);
            return UserMapper.Map(entity);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> UpdateUser(User user)
        {
            var update = await _userRepository.Update(UserMapper.Map(user));
            return UserMapper.Map(update);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var entity = await _userRepository.GetAll();
            return entity.Select(UserMapper.Map);
        }
    }
}
