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
        AccountDTO GetAccount(Guid id);
        IEnumerable<UserDTO> GetAll();
        void Create(string login, string password, string email, string role = "user");
        TokenDTO Login(string email, string password);
        void Delete(Guid id);
    }
}
