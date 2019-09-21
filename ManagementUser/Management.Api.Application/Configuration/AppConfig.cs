using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.Application.Configuration
{
    public class AppConfig : IAppConfig
    {
        private readonly IConfiguration _configuration;

        public AppConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int MaxTrys => int.Parse(_configuration.GetSection("Get:MaxTrys").Value);

        public int SecondsToWait => int.Parse(_configuration.GetSection("Polly:TimeDelay").Value);

        public string ServiceUrl => _configuration.GetSection("ServiceUrl:Url").Value;
    }
}
