﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Commands.Users
{
    public class LoginUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
  
    }
}
