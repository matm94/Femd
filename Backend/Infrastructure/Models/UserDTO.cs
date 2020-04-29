using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class UserDTO
    {
        public Guid Id { get;  set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
