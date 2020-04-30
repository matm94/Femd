using AutoMapper;
using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Extensions;
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
            var user = _userRepository.GetUserOrNull(email);
            var userDTOs = _imapper.Map<UserDTO>(user);
            return userDTOs;
        }
        public UserDTO Get(Guid id)
        {
            var user = _userRepository.GetUserOrNull(id);
            var userDTOs = _imapper.Map<UserDTO>(user);
            return userDTOs;
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var userAll = _userRepository.GetAll();
            var userAllDtos = _imapper.Map<IEnumerable<UserDTO>>(userAll);
            return userAllDtos;
        }

        public void Create(string login,string password, string email)
        {
            var user = _userRepository.GetUserOrFail(email);
            user = new User(login, password, email);
           _userRepository.AddUser(user);

        }

        public void Delete(Guid id)
        {
            var user  = _userRepository.GetUserOrNull(id);
            _userRepository.DeleteUser(user.Id);
        }


    }
}
