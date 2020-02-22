using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FemdAPI.Api.Controllers
{
   
    [Route("(api/user)")]
    public class UserController : ControllerBase
    {
        private readonly FemdApiContext _femdApiContext;
        public UserController(FemdApiContext femdApiContext)
        {
            _femdApiContext = femdApiContext;
        }
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var users = _femdApiContext.UserDbSet.ToList();
            return Ok(users);
            
        }
    
    }
}