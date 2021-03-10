using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public abstract class PartsOfSpeechBase
    {
        [Key]
        public Guid Id { get; protected set; }
        [Required]
        public string Translation { get; protected set; }
        [Required]
        public string Content { get; protected set; }
        [Required]
        public string PhotoPath { get; set; }
        public Guid WordsDictonaryId { get; set; }
        public WordsDictionary WordsDictionary { get; set; }
        public PartsOfSpeechBase(string translation, string content, string photoPath)
        {
            Translation = translation;
            Content = content;
            PhotoPath = photoPath;
            Id = Guid.NewGuid();
        }
    }
}
