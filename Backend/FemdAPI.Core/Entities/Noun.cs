using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public class Noun
    {
        [Key]
        public int Id { get; protected set; }
        public string Feminine { get; protected set; }
        public string Masculine { get; protected set; }
        public string GenderNeutral { get; protected set; }
        public Guid LectureId { get; set; }
        public Lecture Lecture { get; set; }
    }
}
