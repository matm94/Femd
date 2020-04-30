using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class LectureDetailsDTO : LectureDTO
    {
        public IEnumerable<VerbDTO> verbsDTO { get; set; }
        public IEnumerable<NounDTO> nounsDTO { get; set; }
    }
}
