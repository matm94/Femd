using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class UserDTO
    {
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public bool IsActive { get; protected set; }
        public string Name { get; protected set; }
        public string Level { get; set; }
    }
}
