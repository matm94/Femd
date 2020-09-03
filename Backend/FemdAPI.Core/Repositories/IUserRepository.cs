using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string email);
        User GetUser(Guid id);
        IEnumerable<User> GetAll();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);

    }
}
