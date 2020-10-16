﻿using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class WordsDictionaryDTO
    {
        public IEnumerable<Verb> Verbs { get; set; }
        public IEnumerable<Noun> Nouns { get; set; }
    }
}
