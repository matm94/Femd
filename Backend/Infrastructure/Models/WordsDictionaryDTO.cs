using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class WordsDictionaryDTO
    {
        public IEnumerable<AdjectiveDTO> Adjectives { get; set; }
        public IEnumerable<AdverbDTO> Adverbs { get; set; }
        public IEnumerable<NounDTO> Nouns { get; set; }
        public IEnumerable<PersonalPronunDTO> PersonalPronouns { get; set; }
        public IEnumerable<SentenceDTO> Sentences { get; set; }
        public IEnumerable<VerbDTO> Verbs { get; set; }
    }
}
