using FemdAPI.Core.Data;
using FemdAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FemdAPI.Infrastructure
{
    public class SampleData
    {
        private readonly FemdApiContext _femdAPIContext;
        public SampleData(FemdApiContext femdAPIContext)
        {
            _femdAPIContext = femdAPIContext;
        }

        public void GetSampleData()
        {
            if(_femdAPIContext.Database.CanConnect())
            {
                if(!_femdAPIContext.UserDbSet.Any())
                {
                    InsertData();
                    InsertDataLecture();
                }
                
            }
        }

        private void InsertData()
        {
            var femdSampleData = new List<User>
            {
                new User("WhiteWolf","Ciri","Butcher@gmail.com","Legend"),

                new User("Yennefer","Geralt","Unicorn@gmail.com","Master"),

                new User("Ciranell","Ciria","Princess@gmail.com","Noobie")

            };                
            _femdAPIContext.AddRange(femdSampleData);
            _femdAPIContext.SaveChanges();
        }

        private void InsertDataLecture()
        {
            var LectureSampleData = new List<Lecture>
            {
                new Lecture("Hello",1,Level.Beginner)
                {
                    Verbs = new List<Verb>()
                    {
                        new Verb("kommen","gekommen","kommten"),
                        new Verb("bekommen","bekommen","bekommten"),
                        new Verb("machen","gemacht","machten"),

                    }
                }
            };
            _femdAPIContext.AddRange(LectureSampleData);
            _femdAPIContext.SaveChanges();
        }
    }
}
