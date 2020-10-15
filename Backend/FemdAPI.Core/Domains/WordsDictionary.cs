using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class WordsDictionary
    {
        [Key]
        public Guid Id { get; set; }
        public IEnumerable<Verb> Verbs { get; set; }
        public IEnumerable<Noun> Nouns { get; set; }

        public Guid LectureId { get; set; }
        public Lecture Lecture { get; set; }


    }
}
