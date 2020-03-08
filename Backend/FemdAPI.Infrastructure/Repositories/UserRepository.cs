using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FemdAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FemdApiContext _femdApiContext;
        public UserRepository(FemdApiContext femdApiContext)
        {
            _femdApiContext = femdApiContext;
        }

        public User GetUser(string email)
            => _femdApiContext.UserDbSet.FirstOrDefault(m => m.Email.ToLower() == email.ToLower());

        public User GetUser(Guid id)
            => _femdApiContext.UserDbSet.FirstOrDefault(m => m.Id == id);

        public IEnumerable<User> GetAll()
            => _femdApiContext.UserDbSet.ToList();

        public void AddUser(User user)
        {
            _femdApiContext.UserDbSet.Add(user);
            _femdApiContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var user = _femdApiContext.UserDbSet.FirstOrDefault(m => m.Id == id);
            _femdApiContext.UserDbSet.Remove(user);
            _femdApiContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
             _femdApiContext.UserDbSet.Update(user);
            _femdApiContext.SaveChanges();

        }
    }
}
