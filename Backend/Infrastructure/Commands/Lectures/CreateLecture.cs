using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Commands.Lectures
{
    public class CreateLecture : ICommand
    {
        public string Name { get;  set; }
        public int Number { get;  set; }
        public Level Level { get; set; }
    }
}
