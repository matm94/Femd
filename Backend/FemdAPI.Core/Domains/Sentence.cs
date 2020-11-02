﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class Sentence : PartsOfSpeechBase
    {
        public Sentence(string translation, string content, string photoPath) : base(translation, content, photoPath)
        {
        }
    }
}
