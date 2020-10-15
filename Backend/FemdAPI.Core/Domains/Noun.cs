using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class Noun
    {
        [Key]
        public Guid Id { get; protected set; }
        public string Feminine { get;  set; }
        public string Masculine { get;  set; }
        public string GenderNeutral { get;  set; }
        public Guid WordsDictonaryId { get; protected set; }
        public WordsDictionary WordsDictionary { get; protected set; }
        public Photo Photo { get; set; }

    }
}
