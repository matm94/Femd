using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class VerbDTO
    {
        public string Translation { get; set; }
        public string Infinitive { get; protected set; }
        public string ConjugationTense { get; protected set; }
        public string ConjugationIch { get; protected set; }
        public string ConjugationDu { get; protected set; }
        public string ConjugationEr { get; protected set; }
        public string ConjugationWir { get; protected set; }
        public string ConjugationIhr { get; protected set; }
        public string Conjugation_sie { get; protected set; }
        public string ConjugationSie { get; protected set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
    }
}
