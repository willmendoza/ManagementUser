using ManagementUser.Api.Application.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ManagementUser.Api.Application.ApiCaller
{
    public class ApiCaller
    {
        private readonly HttpClient _httpClient;
        //private readonly IAppConfig _appConfig;
        public ApiCaller(IAppConfig appConfig)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(appConfig.ServiceUrl)
            };

            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
