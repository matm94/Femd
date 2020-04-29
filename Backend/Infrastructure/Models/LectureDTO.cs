using FemdAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Models
{
    public class LectureDTO
    {
        public string Name { get;  set; }
        public int Number { get;  set; }
        public Level Level { get; set; }   
    }
}
