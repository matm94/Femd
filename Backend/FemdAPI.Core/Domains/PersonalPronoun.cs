using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class PersonalPronoun
    {
        [Key]
        public Guid Id { get; protected set; }
        [Required]
        public string Translation { get; protected set; }
        [Required]
        public string FirstPerson { get; protected set; }
        [Required]
        public string SecondPerson { get; protected set; }
        [Required]
        public string ThirdPerson { get; protected set; }
        [Required]
        public string FirstPersonPlural { get; protected set; }
        [Required]
        public string SecondPersonPlural { get; protected set; }
        [Required]
        public string ThirdPersonPlural { get; protected set; }
        [Required]
        public string Formal { get; protected set; }
        [Required]
        public string PhotoPath { get; set; }
        public Guid WordsDictonaryId { get;  set; }
        public WordsDictionary WordsDictionary { get;  set; }

        public PersonalPronoun(string translation, string firstPerson, string secondPerson, string thirdPerson,
            string firstPersonPlural, string secondPersonPlural, string thirdPersonPlural, string formal)
        {
            Translation = translation;
            FirstPerson = firstPerson;
            SecondPerson = secondPerson;
            ThirdPerson = thirdPerson;
            FirstPersonPlural = firstPersonPlural;
            SecondPersonPlural = secondPersonPlural;
            ThirdPersonPlural = thirdPersonPlural;
            Formal = formal;
            Id = Guid.NewGuid();
        }

    }
}
