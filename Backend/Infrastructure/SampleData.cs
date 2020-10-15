using FemdAPI.Core.Data;
using FemdAPI.Core.Domains;
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

                new User("Ciranell","Ciria","Princess@gmail.com","Noobie"),

                new User("Test","Test","Test@test.pl","Admin"),

            };                
            _femdAPIContext.AddRange(femdSampleData);
            _femdAPIContext.SaveChanges();
        }

        private void InsertDataLecture()
        {
            var LectureSampleData = new List<Lecture>
            {
                new Lecture("Hello",1,"Na pierwszej lekcji zajmiemy się zagadnieniami dotyczących powitań w jezyku niemieckim")
                {

                    WordsDictionary =  new WordsDictionary
                    {
                         Verbs = new List<Verb>()
                            {
                                new Verb("machen","machte","hat gemacht")
                                {
                                    Photo = new Photo("c/d/e/sciezkadoPlotki")
                                },

                                
                            },
                         Nouns = new List<Noun>()
                            {
                               new Noun
                               {
                                   Masculine = "der Mann",
                                   Feminine = "die Frau",
                                   GenderNeutral = "das Auto",
                                   Photo = new Photo("c/d/e/sciezkadoVesemira")
                               }
                            }
                    }
                },
                 
                new Lecture("Tschoss",2,"Na drugiej lekcji zajmiemy się zagadnieniami dotyczących pożegnań w jezyku niemieckim")
                {

                    WordsDictionary =  new WordsDictionary
                    {
                         Verbs = new List<Verb>()
                         {
                            new Verb("Kommen","Kann","ist gekommen")
                            {
                               Photo = new Photo("c/d/e/sciezkadoCiri")
                            },
                         },
                        Nouns = new List<Noun>()
                         {
                           new Noun
                           {
                               Masculine = "der Tag",
                               Feminine = "die Monat",
                               GenderNeutral = "das Jahr",
                               Photo = new Photo("c/d/e/sciezkadoJenfer")
                           }
                         }
                    }
                     
                }
            };
            _femdAPIContext.AddRange(LectureSampleData);
            _femdAPIContext.SaveChanges();
        }
    }
}
