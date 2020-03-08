using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface IUserService
    {
        UserDTO Get(string email);
        void Create(string login, string email, string password);
    }
}
