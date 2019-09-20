using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagementUser.Api.Application.Contracts.Services
{
    public interface IUserServices { 
        Task<string> GetUserName(int userId);
    }
}
