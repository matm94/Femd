using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class PersonalPronounDTO
    {
        public string Translation { get; set; }
        public string FirstPerson { get; set; }
        public string SecondPerson { get; set; }
        public string ThirdPerson { get; set; }
        public string FirstPersonPlural { get; set; }
        public string SecondPersonPlural { get; set; }
        public string ThirdPersonPlural { get; set; }
        public string Formal { get; set; }
        public string PhotoPath { get; set; }
    }
}
