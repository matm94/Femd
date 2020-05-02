using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FemdAPI.Infrastructure.Commands.Users;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FemdAPI.Api.Controllers
{

    [ApiController]
    public class AccountController : ApiBaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("{email}")]
        [Authorize]
        public ActionResult<AccountDTO> Get()
        {
            var user = _userService.GetAccount(userId);
            return Ok(user);
        }
            
        [HttpPost("Register")]
        public ActionResult Post([FromBody]RegisterUser command)
        {
            _userService.Create(command.Login, command.Password, command.Email,command.Role);
            return Created("api/account/" + command.Email, null);
        }

        [HttpPost("Login")]
        public ActionResult Post([FromBody]LoginUser command)
        {
            return Ok(_userService.Login(command.Email, command.Password));
        }
    }
}