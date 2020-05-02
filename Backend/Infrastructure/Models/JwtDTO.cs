using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class JwtDTO
    {
        public string Token { get; set; }
        public long LifeTime { get; set; }
    }
}
