using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagementUser.Api.DataAccess.Contract.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Delete(int id);
        Task<T> Update(T element);
        Task<T> Add(T element);
    }
}
