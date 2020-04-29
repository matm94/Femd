using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Commands.Users
{
    public class CreateUser : ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
    }
}
