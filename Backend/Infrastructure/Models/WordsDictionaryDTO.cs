using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class WordsDictionaryDTO : LectureDTO
    {
        public IEnumerable<Verb> Verbs { get; set; }
        public IEnumerable<Noun> Nouns { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
