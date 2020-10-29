using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class PersonalPronoun
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FirstPerson { get; set; }
        [Required]
        public string SecondPerson { get; set; }
        [Required]
        public string ThirdPerson { get; set; }
        [Required]
        public string FirstPersonPlural { get; set; }
        [Required]
        public string SecondPersonPlural { get; set; }
        [Required]
        public string ThirdPersonPlural { get; set; }
        [Required]
        public string Formal { get; set; }
        [Required]
        public string PhotoPath { get; set; }
        public Guid WordsDictonaryId { get; protected set; }
        public WordsDictionary WordsDictionary { get; protected set; }

        public PersonalPronoun(string firstPerson, string secondPerson, string thirdPerson,
            string firstPersonPlural, string secondPersonPlural, string thirdPersonPlural, string formal, string photoPath)
        {
            FirstPerson = firstPerson;
            SecondPerson = secondPerson;
            ThirdPerson = thirdPerson;
            FirstPersonPlural = firstPersonPlural;
            SecondPersonPlural = secondPersonPlural;
            ThirdPersonPlural = thirdPersonPlural;
            Formal = formal;
            PhotoPath = photoPath;
        }

    }
}
