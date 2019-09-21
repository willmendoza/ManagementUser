using ManagementUser.Api.Domains.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementUser.Api.Application.Contracts.Services
{
    public interface IUserServices {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetUser(int userId);
        Task<User> AddUser(User user);
        Task DeleteUser(int id);
        Task<User> UpdateUser(User user);

    }
}
