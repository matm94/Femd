using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; protected set; }
        public string Level { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
        public Student()
        {

        }
        public Student(string name, string level)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetLevel(level);
        }
        
        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Imie nie moze byc puste");
            }
            Name = name;
        }
        public void SetLevel(string level)
        {
            if(string.IsNullOrWhiteSpace(level))
            {
                throw new Exception("Poziom nie moze byc pusty");
            }
            Level = level;
        }

        
    }
}
