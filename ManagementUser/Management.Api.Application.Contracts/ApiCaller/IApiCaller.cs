using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.Application.Contracts.ApiCaller
{
    public interface IApiCaller
    {
        int MaxTry { get; }
        int SecondsToWait { get; }
        string ServiceUrl { get; }
    }
}
