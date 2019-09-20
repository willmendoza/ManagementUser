using ManagementUser.Api.DataAccess.Contract;
using ManagementUser.Api.DataAccess.Contract.Entities;
using ManagementUser.Api.DataAccess.Contract.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementUser.Api.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        // CRUD --> CREATE, READ, UPDATE, DELETE
        private readonly IManagementUserDBContext _managementUserDBContext;

        public UserRepository(IManagementUserDBContext managementUserDBContext)
        {
            _managementUserDBContext = managementUserDBContext;
        }

        public async Task<UserEntity> Add(UserEntity entity)
        {
            await _managementUserDBContext.Users.AddAsync(entity);
            await _managementUserDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var result = await _managementUserDBContext.Users.SingleAsync(x => x.UserId == id);
            _managementUserDBContext.Users.Remove(result);
            await _managementUserDBContext.SaveChangesAsync();
        }

        public async Task<bool> Exist(int id)
        {
            var result = await _managementUserDBContext.Users.SingleAsync(x => x.UserId == id);
            return result != null ? true : false;
        }

        public async Task<UserEntity> Get(int id)
        {
            var result = await _managementUserDBContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
            return result;
        }

        public Task<IEnumerable<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Update(UserEntity element)
        {
            var updateEntity = _managementUserDBContext.Users.Update(element);
            await _managementUserDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
