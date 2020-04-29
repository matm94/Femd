using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public class Noun
    {
        public string Feminine { get; protected set; }
        public string Masculine { get; protected set; }
        public string GenderNeutral { get; protected set; }
        public Guid LectureId { get; set; }
        public Lecture Lecture { get; set; }
    }
}
