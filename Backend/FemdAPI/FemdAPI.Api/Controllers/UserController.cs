using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using FemdAPI.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FemdAPI.Api.Controllers
{
   
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly FemdApiContext _femdApiContext;
        private readonly IMapper _mapper;
        public UserController(FemdApiContext femdApiContext, IMapper imapper)
        {
            _femdApiContext = femdApiContext;
            _mapper = imapper;
        }

        [HttpGet]
        public ActionResult<List<UserDTO>> Get()
        {
            var users = _femdApiContext.UserDbSet.Include(n => n.Student).ToList();

            var userDTOs = _mapper.Map<List<UserDTO>>(users);
            return Ok(userDTOs);    
        }
    
    }
}