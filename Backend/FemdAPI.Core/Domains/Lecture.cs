using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{

    public class Lecture
    {
        [Key]
        public Guid Id { get;  set; }
        [Required]
        public string Name { get;  set; }
        [Required]
        public int Number { get;  set; }
        [Required]
        public string Description { get;  set; }

        public WordsDictionary WordsDictionary { get; set; }

        public Lecture(string name, int number, string description)
        {
            Name = name;
            Number = number;
            Description = description;
        }
    }
}
