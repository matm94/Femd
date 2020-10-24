using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class WordsDictionaryDTO
    {
        public IEnumerable<VerbDTO> Verbs { get; set; }
        public IEnumerable<NounDTO> Nouns { get; set; }
    }
}
