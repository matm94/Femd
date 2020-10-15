using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
  
    public class User
    {
        public Guid Id { get; protected set; }

        [Required]
        [MinLength(3,ErrorMessage ="Minimalna ilosc znakow 3")]
        [MaxLength(30, ErrorMessage = "Maksymalna ilosc znakow 3")]
        public string Login { get; protected set; }

        [Required]
        [MinLength(3, ErrorMessage = "Minimalna ilosc znakow 3")]
        [MaxLength(15, ErrorMessage = "Maksymalna ilosc znakow 15")]
        public string Password { get; protected set; }
        public string Role { get; protected set; }

        [EmailAddress(ErrorMessage ="Nieprawidłowy format")]
        public string Email { get; protected set; }
        public DateTime UpdatedAt{ get; protected set; }
        public bool IsActive { get; protected set; }


        public User(string login, string password, string email, string role)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
            Email = email;
            Role = role;
            Update();
        }

        public void Active()
        {
            if(IsActive)
            {
                return;
            }

            IsActive = true;
            Update();
        }
        public void Deactive()
        {
            if(!IsActive)
            {
                return;
            }
            IsActive = false;
            Update();
        }
        private void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
