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
        public string Translation { get; set; }
        [Required]
        public string Infinitive { get; protected set; }
        public string ConjugationTense { get; protected set; }
        [Required]
        public string ConjugationIch { get; protected set; }
        [Required]
        public string ConjugationDu { get; protected set; }
        [Required]
        public string ConjugationEr { get; protected set; }
        [Required]
        public string ConjugationWir { get; protected set; }
        [Required]
        public string ConjugationIhr { get; protected set; }
        [Required]
        public string Conjugation_sie { get; protected set; }
        [Required]
        public string ConjugationSie { get; protected set; }
        [Required]
        public string PhotoPath { get; set; }
        public string Description { get; set; }

        public Guid WordsDictonaryId { get; protected set; }
        public WordsDictionary WordsDictionary { get; protected set; }

        public Verb(string translation, string infinitive,string conjugationTense, string conjugationIch, string conjugationDu,
            string conjugationEr, string conjugationWir, string conjugationIhr, string conjugation_sie, string conjugationSie)
        {
            Translation = translation;
            Infinitive = infinitive;
            ConjugationTense = conjugationTense;
            ConjugationIch = conjugationIch;
            ConjugationDu = conjugationDu;
            ConjugationEr = conjugationEr;
            ConjugationWir = conjugationWir;
            ConjugationIhr = conjugationIhr;
            Conjugation_sie = conjugation_sie;
            ConjugationSie = conjugationSie;
        }
    }
}
