using ManagementUser.Api.Application.Contracts.Services;
using ManagementUser.Api.Mappers;
using ManagementUser.Api.ViewModel;
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
            var name = await _userServices.GetUser(id);
            return Ok(name);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var name = await _userServices.GetAll();
            return Ok(name);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]UserModel userModel)
        {
            var name = await _userServices.AddUser(UserMappers.Map(userModel));
            return Ok(name);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userServices.DeleteUser(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UserModel userModel)
        {
            var name = await _userServices.UpdateUser(UserMappers.Map(userModel));
            return Ok(name);
        }
    }
}
