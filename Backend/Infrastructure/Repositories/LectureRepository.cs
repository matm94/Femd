using FemdAPI.Core.Data;
using FemdAPI.Core.Domains;
using FemdAPI.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FemdAPI.Infrastructure.Repositories
{
    public class LectureRepository : ILectureRepository
    {
        private readonly FemdApiContext _femdApiContext;

        public LectureRepository(FemdApiContext femdApiContext)
        {
            _femdApiContext = femdApiContext;
        }

        public Lecture Get(string name)
            => _femdApiContext.LectureDbSet.SingleOrDefault(n => n.Name == name);

        public Lecture Get(Guid id)
            => _femdApiContext.LectureDbSet.SingleOrDefault(n => n.Id == id);

        public Lecture GetFullLecture(Guid id)
            => _femdApiContext.LectureDbSet
                .Include(x => x.WordsDictionary)
                .Include(x => x.WordsDictionary.Adjectives)
                .Include(x => x.WordsDictionary.Adverbs)
                .Include(n => n.WordsDictionary.Nouns)
                .Include(x => x.WordsDictionary.PersonalPronouns)
                .Include(x => x.WordsDictionary.Sentences)
                .Include(v => v.WordsDictionary.Verbs)
                .SingleOrDefault(n => n.Id == id);

        public WordsDictionary GetOnlyDictionary(Guid id)
             => _femdApiContext.WordsDictionaryDbSet
                .Include(x => x.Adjectives)
                .Include(x => x.Adverbs)
                .Include(x => x.Nouns)
                .Include(x => x.PersonalPronouns)
                .Include(x => x.Sentences)
                .Include(x => x.Verbs)
                .SingleOrDefault(x => x.LectureId == id);

        public Adjective GetAdjectie(Guid id)
            => _femdApiContext.AdjectiveDbSet.FirstOrDefault(x => x.Id == id);

        public Adverb GetAdverb(Guid id)
            => _femdApiContext.AdverbDbSet.FirstOrDefault(x => x.Id == id);

        public Noun GetNoun(Guid id)
            => _femdApiContext.NounDbSet.FirstOrDefault(x => x.Id == id);


        public PersonalPronoun GetPersonalPronoun(Guid id)
            => _femdApiContext.PersonalPronounDbSet.FirstOrDefault(x => x.Id == id);

        public Sentence GetSentence(Guid id)
            => _femdApiContext.SentenceDbSet.FirstOrDefault(x => x.Id == id);

        public Verb GetVerb(Guid id)
            => _femdApiContext.VerbDbSet.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Lecture> GetAll()
            => _femdApiContext.LectureDbSet.ToList();

        public void AddLecture(Lecture lecture)
        {
            _femdApiContext.LectureDbSet.Add(lecture);
            _femdApiContext.SaveChanges();
        }
        public void DeleteLecture(Guid id)
        {
            var lecture =_femdApiContext.LectureDbSet.SingleOrDefault(n => n.Id == id);
            _femdApiContext.LectureDbSet.Remove(lecture);
            _femdApiContext.SaveChanges();
        }
        public void UpdateLecture(Lecture lecture)
        {
            _femdApiContext.LectureDbSet.Update(lecture);
            _femdApiContext.SaveChanges();
        }

    }
}
