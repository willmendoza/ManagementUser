using ManagementUser.Api.Application.Contracts.Services;
using ManagementUser.Api.Application.Services;
using ManagementUser.Api.DataAccess.Contract.Repositories;
using ManagementUser.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepositories(services);
            return services;
        }

        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IUserServices, UserServices>();
            return services;
        }

        public static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
