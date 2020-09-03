using AutoMapper;
using FemdAPI.Core.Domains;
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
        private readonly IJwtService _jwtService;

        public UserService(IUserRepository userRepository, IMapper imapper, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _imapper = imapper;
            _jwtService = jwtService;
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

        public AccountDTO GetAccount(Guid id)
        {
            var userAccount = _userRepository.GetUserOrNull(id);
            var userAccountDtos = _imapper.Map<AccountDTO>(userAccount);
            return userAccountDtos;
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var userAll = _userRepository.GetAll();
            var userAllDtos = _imapper.Map<IEnumerable<UserDTO>>(userAll);
            return userAllDtos;
        }

        public void Create(string login,string password, string email, string role)
        {
            var user = _userRepository.GetUserOrFail(email);
            user = new User(login, password, email, role);
           _userRepository.AddUser(user);

        }
        public TokenDTO Login(string email, string password)
        {
            var user = _userRepository.GetUserOrNull(email);
            if(user.Password != password)
            {
                throw new Exception("Invaild password");
            }
            var jwt = _jwtService.CreateToken(user.Id, user.Role);

            return new TokenDTO
            {
                Token = jwt.Token,
                LifeTime = jwt.LifeTime,
                Role = user.Role
            };
        }
        public void Delete(Guid id)
        {
            var user  = _userRepository.GetUserOrNull(id);
            _userRepository.DeleteUser(user.Id);
        }

    }
}
