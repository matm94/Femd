using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{

    public class Lecture
    {
        [Key]
        public Guid Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }
        [Required]
        public int Number { get; protected set; }
        [Required]
        public string Description { get; protected set; }
        public string PhotoPath { get; set; }

        public WordsDictionary WordsDictionary { get; set; }

        public Lecture(string name, int number, string description)
        {
            Name = name;
            Number = number;
            Description = description;
            Id = Guid.NewGuid();
        }
    }
}
