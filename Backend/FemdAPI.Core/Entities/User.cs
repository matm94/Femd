﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public DateTime UpdatedAt{ get; protected set; }
        public bool IsActive { get; protected set; }

        public IEnumerable<Student> Students { get; set; }

        public User()
        {
            
        }
        public User(string login, string password, string email)
        {
            Id = Guid.NewGuid();
            SetLogin(login);
            SetPassword(password);
            SetEmail(email);
            UpdatedAt = DateTime.UtcNow;

        }

        public void SetLogin(string login)
        {
            if(string.IsNullOrWhiteSpace(login))
            {
                throw new Exception("Login nie moze byc pusty");
            }
            if(Login == login)
            {
                return;
            }
            Login = login;
            Update();
        }
        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Haslo nie moze byc puste");
            }
            if(Password == password)
            {
                return;
            }

            Password = password;
            Update();
        }
        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("email nie moze byc pusty");
            }
            if(Email == email)
            {
                return;
            }
            Email = email;
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
