using AutoMapper;
using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _imapper;
        public UserService(IUserRepository userRepository, IMapper imapper)
        {
            _userRepository = userRepository;
            _imapper = imapper;
        }

        public UserDTO Get(string email)
        {
            var user = _userRepository.GetUser(email);
            if (user == null)
            {
                throw new Exception("Użytkownik o podanym emailu nie istnieje");
            }

            return _imapper.Map<UserDTO>(user);
        }

        public void Create(string login, string email, string password)
        {
            var user = _userRepository.GetUser(email);
            if (user != null)
            {
                throw new Exception("Użytkownik o podanym emailu istnieje");
            }

            user = new User(login, password, email);
            _userRepository.AddUser(user);
        }
    }
}
