using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FemdAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected Guid userId => User?.Identity?.IsAuthenticated == true ?
            Guid.Parse(User.Identity.Name) :
            Guid.Empty;

    }
}