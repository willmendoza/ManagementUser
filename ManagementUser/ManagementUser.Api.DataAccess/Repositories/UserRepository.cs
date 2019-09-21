using ManagementUser.Api.DataAccess.Contract;
using ManagementUser.Api.DataAccess.Contract.Entities;
using ManagementUser.Api.DataAccess.Contract.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task DeleteAsync(int id)
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

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return  _managementUserDBContext.Users.Select(x=> x);
        }

        public async Task<UserEntity> Update(UserEntity element)
        {
            var updateEntity = _managementUserDBContext.Users.Update(element);
            await _managementUserDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }

        public async Task<UserEntity> Update(int id, UserEntity element)
        {

            var entity = await Get(id);

            entity.Name = element.Name;
            entity.LastName = element.LastName;
            entity.Address = element.Address;
            entity.UpdateDate = DateTime.Now;
            _managementUserDBContext.Users.Update(entity);
            await _managementUserDBContext.SaveChangesAsync();

            return entity;
        }
    }
}
