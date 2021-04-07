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
                         Adjectives = new List<Adjective>()
                         {
                             new Adjective("dobry","gut","C/gut")
                         },
                         Adverbs = new List<Adverb>()
                         {
                             new Adverb("późno","spater","c/spater")
                         },
                         Nouns = new List<Noun>()
                         {
                             new Noun("Rano","der Morgen", "C/morgen"),
                             new Noun("Dzien","der Tag", "C/tag"),
                             new Noun("Wieczór","der Abend" , "c/Tag"),
                             new Noun("Noc","die Nacht", "c/Nacht")
                         },
                         PersonalPronouns = new List<PersonalPronoun>()
                         {
                             new PersonalPronoun("Nominativ - mianownik","ich","du","er","Wir","Ihr","sie","Sie")
                             {
                                 PhotoPath = "C/sciezka",
                             },
                             new PersonalPronoun("Genitive - dopełniacz","meiner","deiner","seiner","unserer","eurer","ihrer","Ihrer")
                             {
                                 PhotoPath = "C/sciezka",
                             }
                         },
                         Sentences = new List<Sentence>()
                         {
                             new Sentence("Cześć","Hallo","c/hallo"),
                             new Sentence("Dzień dobry-rano","Guten Morgen","c/Guten Morgen"),
                             new Sentence("Dzień dobry-po południu","Guten Tag","c/guten tag"),
                             new Sentence("Dobry wieczór","Guten Abend","c/guten abend"),
                             new Sentence("Cześć","Servus","c/servus"),
                             new Sentence("Witam","Willkommen","c/willkommen"),
                             new Sentence("Do widzenia","Auf Wiedersehen","C/auf wiedersehen"),
                             new Sentence("Dobranoc","Gute Nacht","c/Gute nacht"),
                             new Sentence("Cześć","Tschüs","c/Tschüs"),
                             new Sentence("Na razie","Bis später","c/Bis später"),
                             new Sentence("Do zobaczenia","Wir sehen uns","c/Wirsehenuns"),
                             new Sentence("Do następnego razu","Bis zum nächsten Mal","c/biszumnachste"),
                             new Sentence("Co tam","Wie geht's?","C/wiegehts"),
                             new Sentence("Co tam u Ciebie","Wie gehts es dir","c/wiegehtsesdir"),
                             new Sentence("Jak się ma Pan/Pani/Państwo","Wie geht es Ihnen?","C/wiegehtsesIhnen")
                         },
                         Verbs = new List<Verb>()
                         {
                             new Verb("iść","gehen","gehen","gehe","gehst","geht","gehen","geht","gehen","gehen")
                             {
                                 PhotoPath = "C/sciezka",
                                 Description = "Gehen wyraza nie tylko ruch 'isc ,chodzic' ale rowniez 'powiesc sie, udac'"
                             },
                             new Verb("Widzieć","sehen","sehen","sehe","siehst","sieht","sehen","seht","sehen","sehen")
                             {
                                 PhotoPath = "c/sehen"
                             }
                         },
                    }
                },
                new Lecture("Tschus",2,"Na Drugiej lekcji ")
                {
                    WordsDictionary =  new WordsDictionary
                    {
                         Adjectives = new List<Adjective>()
                         {
                             new Adjective("dobry","gut","C/gut")
                         },
                         Adverbs = new List<Adverb>()
                         {
                             new Adverb("późno","spater","c/spater")
                         },
                         Nouns = new List<Noun>()
                         {
                             new Noun("Rano","der Morgen", "C/morgen"),
                             new Noun("Dzien","der Tag", "C/tag"),
                             new Noun("Wieczór","der Abend" , "c/Tag"),
                             new Noun("Noc","die Nacht", "c/Nacht")
                         },
                         PersonalPronouns = new List<PersonalPronoun>()
                         {
                             new PersonalPronoun("Nominativ - mianownik","ich","du","er","Wir","Ihr","sie","Sie")
                             {
                                 PhotoPath = "C/sciezka",
                             },
                             new PersonalPronoun("Genitive - dopełniacz","meiner","deiner","seiner","unserer","eurer","ihrer","Ihrer")
                             {
                                 PhotoPath = "C/sciezka",
                             }
                         },
                         Sentences = new List<Sentence>()
                         {
                             new Sentence("Cześć","Hallo","c/hallo"),
                             new Sentence("Dzień dobry-rano","Guten Morgen","c/Guten Morgen"),
                             new Sentence("Dzień dobry-po południu","Guten Tag","c/guten tag"),
                             new Sentence("Dobry wieczór","Guten Abend","c/guten abend"),
                             new Sentence("Cześć","Servus","c/servus"),
                             new Sentence("Witam","Willkommen","c/willkommen"),
                             new Sentence("Do widzenia","Auf Wiedersehen","C/auf wiedersehen"),
                             new Sentence("Dobranoc","Gute Nacht","c/Gute nacht"),
                             new Sentence("Cześć","Tschüs","c/Tschüs"),
                             new Sentence("Na razie","Bis später","c/Bis später"),
                             new Sentence("Do zobaczenia","Wir sehen uns","c/Wirsehenuns"),
                             new Sentence("Do następnego razu","Bis zum nächsten Mal","c/biszumnachste"),
                             new Sentence("Co tam","Wie geht's?","C/wiegehts"),
                             new Sentence("Co tam u Ciebie","Wie gehts es dir","c/wiegehtsesdir"),
                             new Sentence("Jak się ma Pan/Pani/Państwo","Wie geht es Ihnen?","C/wiegehtsesIhnen")
                         },
                         Verbs = new List<Verb>()
                         {
                             new Verb("iść","gehen","gehen","gehe","gehst","geht","gehen","geht","gehen","gehen")
                             {
                                 PhotoPath = "C/sciezka",
                                 Description = "Gehen wyraza nie tylko ruch 'isc ,chodzic' ale rowniez 'powiesc sie, udac'"
                             },
                             new Verb("Widzieć","sehen","sehen","sehe","siehst","sieht","sehen","seht","sehen","sehen")
                             {
                                 PhotoPath = "c/sehen"
                             }
                         },
                    }
                },
                new Lecture("Ich",3,"Na trzeciej lekcji ")
                {
                    WordsDictionary =  new WordsDictionary
                    {
                         Adjectives = new List<Adjective>()
                         {
                             new Adjective("dobry","gut","C/gut")
                         },
                         Adverbs = new List<Adverb>()
                         {
                             new Adverb("późno","spater","c/spater")
                         },
                         Nouns = new List<Noun>()
                         {
                             new Noun("Rano","der Morgen", "C/morgen"),
                             new Noun("Dzien","der Tag", "C/tag"),
                             new Noun("Wieczór","der Abend" , "c/Tag"),
                             new Noun("Noc","die Nacht", "c/Nacht")
                         },
                         PersonalPronouns = new List<PersonalPronoun>()
                         {
                             new PersonalPronoun("Nominativ - mianownik","ich","du","er","Wir","Ihr","sie","Sie")
                             {
                                 PhotoPath = "C/sciezka",
                             },
                             new PersonalPronoun("Genitive - dopełniacz","meiner","deiner","seiner","unserer","eurer","ihrer","Ihrer")
                             {
                                 PhotoPath = "C/sciezka",
                             }
                         },
                         Sentences = new List<Sentence>()
                         {
                             new Sentence("Cześć","Hallo","c/hallo"),
                             new Sentence("Dzień dobry-rano","Guten Morgen","c/Guten Morgen"),
                             new Sentence("Dzień dobry-po południu","Guten Tag","c/guten tag"),
                             new Sentence("Dobry wieczór","Guten Abend","c/guten abend"),
                             new Sentence("Cześć","Servus","c/servus"),
                             new Sentence("Witam","Willkommen","c/willkommen"),
                             new Sentence("Do widzenia","Auf Wiedersehen","C/auf wiedersehen"),
                             new Sentence("Dobranoc","Gute Nacht","c/Gute nacht"),
                             new Sentence("Cześć","Tschüs","c/Tschüs"),
                             new Sentence("Na razie","Bis später","c/Bis später"),
                             new Sentence("Do zobaczenia","Wir sehen uns","c/Wirsehenuns"),
                             new Sentence("Do następnego razu","Bis zum nächsten Mal","c/biszumnachste"),
                             new Sentence("Co tam","Wie geht's?","C/wiegehts"),
                             new Sentence("Co tam u Ciebie","Wie gehts es dir","c/wiegehtsesdir"),
                             new Sentence("Jak się ma Pan/Pani/Państwo","Wie geht es Ihnen?","C/wiegehtsesIhnen")
                         },
                         Verbs = new List<Verb>()
                         {
                             new Verb("iść","gehen","gehen","gehe","gehst","geht","gehen","geht","gehen","gehen")
                             {
                                 PhotoPath = "C/sciezka",
                                 Description = "Gehen wyraza nie tylko ruch 'isc ,chodzic' ale rowniez 'powiesc sie, udac'"
                             },
                             new Verb("Widzieć","sehen","sehen","sehe","siehst","sieht","sehen","seht","sehen","sehen")
                             {
                                 PhotoPath = "c/sehen"
                             }
                         },
                    }
                },
                new Lecture("DasHaus",4,"Na czwartej")
                {
                    WordsDictionary =  new WordsDictionary
                    {
                         Adjectives = new List<Adjective>()
                         {
                             new Adjective("dobry","gut","C/gut")
                         },
                         Adverbs = new List<Adverb>()
                         {
                             new Adverb("późno","spater","c/spater")
                         },
                         Nouns = new List<Noun>()
                         {
                             new Noun("Rano","der Morgen", "C/morgen"),
                             new Noun("Dzien","der Tag", "C/tag"),
                             new Noun("Wieczór","der Abend" , "c/Tag"),
                             new Noun("Noc","die Nacht", "c/Nacht")
                         },
                         PersonalPronouns = new List<PersonalPronoun>()
                         {
                             new PersonalPronoun("Nominativ - mianownik","ich","du","er","Wir","Ihr","sie","Sie")
                             {
                                 PhotoPath = "C/sciezka",
                             },
                             new PersonalPronoun("Genitive - dopełniacz","meiner","deiner","seiner","unserer","eurer","ihrer","Ihrer")
                             {
                                 PhotoPath = "C/sciezka",
                             }
                         },
                         Sentences = new List<Sentence>()
                         {
                             new Sentence("Cześć","Hallo","c/hallo"),
                             new Sentence("Dzień dobry-rano","Guten Morgen","c/Guten Morgen"),
                             new Sentence("Dzień dobry-po południu","Guten Tag","c/guten tag"),
                             new Sentence("Dobry wieczór","Guten Abend","c/guten abend"),
                             new Sentence("Cześć","Servus","c/servus"),
                             new Sentence("Witam","Willkommen","c/willkommen"),
                             new Sentence("Do widzenia","Auf Wiedersehen","C/auf wiedersehen"),
                             new Sentence("Dobranoc","Gute Nacht","c/Gute nacht"),
                             new Sentence("Cześć","Tschüs","c/Tschüs"),
                             new Sentence("Na razie","Bis später","c/Bis später"),
                             new Sentence("Do zobaczenia","Wir sehen uns","c/Wirsehenuns"),
                             new Sentence("Do następnego razu","Bis zum nächsten Mal","c/biszumnachste"),
                             new Sentence("Co tam","Wie geht's?","C/wiegehts"),
                             new Sentence("Co tam u Ciebie","Wie gehts es dir","c/wiegehtsesdir"),
                             new Sentence("Jak się ma Pan/Pani/Państwo","Wie geht es Ihnen?","C/wiegehtsesIhnen")
                         },
                         Verbs = new List<Verb>()
                         {
                             new Verb("iść","gehen","gehen","gehe","gehst","geht","gehen","geht","gehen","gehen")
                             {
                                 PhotoPath = "C/sciezka",
                                 Description = "Gehen wyraza nie tylko ruch 'isc ,chodzic' ale rowniez 'powiesc sie, udac'"
                             },
                             new Verb("Widzieć","sehen","sehen","sehe","siehst","sieht","sehen","seht","sehen","sehen")
                             {
                                 PhotoPath = "c/sehen"
                             }
                         },
                    }
                },
            };
            _femdAPIContext.AddRange(LectureSampleData);
            _femdAPIContext.SaveChanges();
        }
    }
}
