using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Domains
{
    public class Photo
    {
        [Key]
        public Guid Id { get; protected set; }
        public string Path { get; protected set; }
        public Guid VerbId { get; set; }
        public Verb Verb { get; set; }
        public Guid NounId { get; set; }
        public Noun Noun { get; set; }

        public Photo(string path)
        {
            Path = path;
        }
    }
}
