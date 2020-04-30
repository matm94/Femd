using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public class Verb
    {
        [Key]
        public int Id { get; protected set; }
        [Required]
        public string Infinitive { get; protected set; }
        [Required]
        public string PastPrateritum { get; protected set; }
        [Required]
        public string PastPartizip { get; protected set; }
        public Guid LectureId { get; protected set; }
        public Lecture Lecture { get; protected set; }

        public Verb(string infinitive, string pastPrateritum, string pastPartizip)
        {
            Infinitive = infinitive;
            PastPrateritum = pastPrateritum;
            PastPartizip = pastPartizip;
        }
    }
}
