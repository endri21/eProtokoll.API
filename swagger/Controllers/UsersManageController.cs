using eProtokollCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.Controllers
{
    public class UsersManageController : ApiController
    {

        private readonly IUserService _userService;
        public UsersManageController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route(nameof(GetUsers))]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }
        [HttpGet]
        [Route(nameof(GetUsersByRole))]
        public async Task<IActionResult> GetUsersByRole(string role)
        {
            return Ok(await _userService.GetUsersByRoleAsync(role));
        }
        [HttpGet]
        [Route(nameof(GetUserById))]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }
        [HttpPost]
        [Route(nameof(ActivateUser))]
        public async Task<IActionResult> ActivateUser(int id)
        {
            return Ok(await _userService.ActivateUser(id));
        }

        [HttpGet]
        [Route(nameof(GetRoles))]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _userService.GetRolesAsync());
        }
    }
}
