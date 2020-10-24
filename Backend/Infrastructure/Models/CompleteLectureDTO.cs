using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class CompleteLectureDTO 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public IEnumerable<VerbDTO> Verbs { get; set; }
        public IEnumerable<NounDTO> Nouns { get; set; }

    }
}
