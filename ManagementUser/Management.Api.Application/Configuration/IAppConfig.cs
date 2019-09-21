using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.Application.Configuration
{
    public class IAppConfig
    {
       public  int MaxTrys { get; } 
       public int SecondToWait { get; }
       public string ServiceUrl { get; }
    }
}
