using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Repositories
{
    public interface ILectureRepository
    {
        Lecture Get(string name);
        Lecture GetFullLecture(Guid id);
        WordsDictionary GetOnlyDictionary(Guid id);
        Adjective GetAdjectie(Guid id);
        Adverb GetAdverb(Guid id);
        Noun GetNoun(Guid id);
        PersonalPronoun GetPersonalPronoun(Guid id);
        Sentence GetSentence(Guid id);
        Verb GetVerb(Guid id);
        IEnumerable<Lecture> GetAll();
        void AddLecture(Lecture lecture);
        void UpdateLecture(Lecture lecture);
        void DeleteLecture(Guid id);

    }
}
