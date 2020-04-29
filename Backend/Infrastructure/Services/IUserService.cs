using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface IUserService
    {
        UserDTO Get(string email);
        UserDTO Get(Guid id);
        IEnumerable<UserDTO> GetAll();
        void Create(string login, string password, string email);
        void Delete(Guid id);
    }
}
