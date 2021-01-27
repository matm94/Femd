using FemdAPI.Core.Domains;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface ILectureService
    {
        LectureDTO Get(string name);
        CompleteLectureDTO GetFullLecture(Guid id);
        WordsDictionaryDTO GetOnlyDictionary(Guid id);
        AdjectiveDTO GetAdjectie(Guid id);
        AdverbDTO GetAdverb(Guid id);
        NounDTO GetNoun(Guid id);
        PersonalPronounDTO GetPersonalPronoun(Guid id);
        SentenceDTO GetSentence(Guid id);
        VerbDTO GetVerb(Guid id);
        IEnumerable<LectureDTO> GetAll();
        void Create(string name, int number, string description);
        void Delete(Guid id);
    }
}
