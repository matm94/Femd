using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Entities
{
    public enum Level
    {
        Beginner,
        Intrmediate,
        Advenced
    }

    public class Lecture
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Number { get; protected set; }
        public Level Level { get; set; }
        public List<Verb> Verbs { get; set; }
        public List<Noun> Nouns { get; set; }

        public Lecture(string name, int number, Level level)
        {
            Name = name;
            Number = number;
            Level = new Level();
        }


    }
}
