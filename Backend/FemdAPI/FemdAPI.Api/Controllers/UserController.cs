using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FemdAPI.Api.Controllers
{

    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //[HttpGet]
        //public ActionResult<List<UserDTO>> Get()
        //{
        //    var user = _userService.GetAll().ToList();
        //    return Ok(user);
        //}

        [HttpGet("{email}")]
        public ActionResult<UserDTO> Get(string email)
        {
            var user = _userService.Get(email);
            return Ok(user);
        }

    }
}