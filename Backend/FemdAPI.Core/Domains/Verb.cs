using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class Verb
    {
        [Key]
        public Guid Id { get; protected set; }
        [Required]
        public string Infinitive { get; protected set; }
        [Required]
        public string PastPrateritum { get; protected set; }
        [Required]
        public string PastPartizip { get; protected set; }
        [Required]
        public string PhotoPath { get; set; }

        public Guid WordsDictonaryId { get; protected set; }
        public WordsDictionary WordsDictionary { get; protected set; }

        public Verb(string infinitive, string pastPrateritum, string pastPartizip)
        {
            Infinitive = infinitive;
            PastPrateritum = pastPrateritum;
            PastPartizip = pastPartizip;
        }
    }
}
