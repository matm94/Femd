using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Extensions
{
    public static class UserRepositoryExtension
    {
        public static User GetUserOrNull(this IUserRepository _userRepository, string email)
        {
            var user = _userRepository.GetUser(email);
            if (user == null)
            {
                throw new Exception($"Użytkownik o podanym emailu: {email} nie istnieje");
            }

            return user;
        }

        public static User GetUserOrFail(this IUserRepository _userRepository, string email)
        {
            var user = _userRepository.GetUser(email);
            if (user != null)
            {
                throw new Exception($"Użytkownik o podanym emailu: {email} istnieje");
            }

            return user;
        }

        public static User GetUserOrNull(this IUserRepository _userRepository, Guid id)
        {
            var user = _userRepository.GetUser(id);
            if (user == null)
            {
                throw new Exception($"Użytkownik o podanym id: {id} nie istnieje");
            }

            return user;
        }

    }
}
