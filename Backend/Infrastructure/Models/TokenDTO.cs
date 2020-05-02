using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class TokenDTO
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public long LifeTime { get; set; }
    }
}
