using FemdAPI.Core.Domains;
using FemdAPI.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Extensions
{
    public static class PartsOfSpeechExtension
    {
        public static Adjective GetAdjectiveOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var adjective = _lectureRepository.GetAdjectie(id);
            IsExist(adjective, id);
            return adjective;
        }
        public static Adverb GetAdverbOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var adverb = _lectureRepository.GetAdverb(id);
            IsExist(adverb, id);
            return adverb;
        }
        public static Noun GetNounOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var noun = _lectureRepository.GetNoun(id);
            IsExist(noun, id);
            return noun;
        }
        public static PersonalPronoun GetPersonalPronounOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var personalPronoun= _lectureRepository.GetPersonalPronoun(id);
            IsExist(personalPronoun, id);
            return personalPronoun;
        }
        public static Sentence GetSentenceOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var sentence = _lectureRepository.GetSentence(id);
            IsExist(sentence, id);
            return sentence;
        }
        public static Verb GetVerbeOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var verb = _lectureRepository.GetVerb(id);
            IsExist(verb, id);
            return verb;
        }

        public static void IsExist(object obj, Guid id)
        {
            if (obj == null)
            {
                throw new Exception($"Część mowy o podanym id: {id} nie istnieje");
            }
        }
    }
}
