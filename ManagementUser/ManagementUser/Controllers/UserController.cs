using ManagementUser.Api.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementUser.Api.Controllers
{
    [Produces("application/json")]
    [Route("User")]
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var name = await _userServices.GetUserName(id);
            return Ok(name);
        }
    }
}
