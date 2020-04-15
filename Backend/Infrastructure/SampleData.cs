﻿using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FemdAPI.Infrastructure
{
    public class SampleData
    {
        private readonly FemdApiContext _femdAPIContext;
        public SampleData(FemdApiContext femdAPIContext)
        {
            _femdAPIContext = femdAPIContext;
        }

        public void GetSampleData()
        {
            if(_femdAPIContext.Database.CanConnect())
            {
                if(!_femdAPIContext.UserDbSet.Any())
                {
                    InsertData();
                }
                
            }
        }

        private void InsertData()
        {
            var _femdSampleData = new List<User>
            {
                new User("WhiteWolf","Ciri","Butcher@gmail.com")
                {
                    Student = new Student("Geralt", "Expert")  
                },

                new User("Yennefer","Geralt","Unicorn@gmail.com")
                {
                    Student = new Student("Yen","Master")
                },

                new User("Ciranell","Ciria","Princess@gmail.com")
                {
                    Student = new Student("Ciri","Noob")
                }

            };

            _femdAPIContext.AddRange(_femdSampleData);
            _femdAPIContext.SaveChanges();
        }
    }
}