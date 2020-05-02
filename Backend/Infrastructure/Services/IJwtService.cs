using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface IJwtService
    {
        JwtDTO CreateToken(Guid id, string role);
    }
}
