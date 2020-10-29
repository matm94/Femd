using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class Adjective
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string PhotoPath { get; set; }
        public Guid WordsDictonaryId { get; protected set; }
        public WordsDictionary WordsDictionary { get; protected set; }
    }
}
