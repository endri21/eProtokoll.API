using eProtokollCore.Dtos;
using eProtokollCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.Controllers
{
    public class AuthController : ApiController
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public AuthController(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
        }

        [HttpPost]
        [Route(nameof(login))]
        public async Task<IActionResult> login(LoginRequestDto login)
        {
            var result = await _authenticationService.Login(login);
            if (!result.success)
            {
                return Unauthorized(result);
            }
            return Ok(result);
        }

        [HttpPost]
        [Route(nameof(register))]
        public async Task<IActionResult> register(AddUserRequestDto dto)
        {
            var result = await _authenticationService.Register(dto);
            if (!result.success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet]
        [Route(nameof(GetAuthUserByToken))]
        public async Task<IActionResult> GetAuthUserByToken(string token)
        {
            return Ok(await _userService.GetUserByTokenAsync(token));
        }
    }
}
