using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using FemdAPI.Infrastructure.Commands.Users;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FemdAPI.Api.Controllers
{
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public ActionResult<UserDTO> Get(string email)
        {
            var user = _userService.Get(email);
            return Ok(user);
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetAll()
        {
            var user = _userService.GetAll();
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateUser command)
        {
            _userService.Create(command.Login, command.Password, command.Email);
            return Created("/users/" + command.Email, null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _userService.Delete(id);
            return NoContent();

        }

    }
}