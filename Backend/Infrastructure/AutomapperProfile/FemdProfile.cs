using AutoMapper;
using FemdAPI.Core.Domains;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FemdAPI.Infrastructure.AutomapperProfile
{
    public class FemdProfile : Profile
    {
        public FemdProfile()
        {
            CreateMap<Adjective, AdjectiveDTO>();
            CreateMap<Adverb, AdverbDTO>();
            CreateMap<Lecture, LectureDTO>();
            CreateMap<Lecture, CompleteLectureDTO>()
                .ForMember(d => d.Adjectives, src => src.MapFrom(x => x.WordsDictionary.Adjectives))
                .ForMember(d => d.Adverbs, src => src.MapFrom(x => x.WordsDictionary.Adverbs))
                .ForMember(d => d.PersonalPronuns, src => src.MapFrom(x => x.WordsDictionary.PersonalPronouns))
                .ForMember(d => d.Nouns, src => src.MapFrom(x => x.WordsDictionary.Nouns))
                .ForMember(d => d.Sentences, src => src.MapFrom(x => x.WordsDictionary.Sentences))
                .ForMember(d => d.Verbs, src => src.MapFrom(x => x.WordsDictionary.Verbs));
            CreateMap<Noun, NounDTO>();
            CreateMap<PersonalPronoun, PersonalPronunDTO>();
            CreateMap<Sentence, SentenceDTO>();
            CreateMap<User, AccountDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<Verb, VerbDTO>();
            CreateMap<WordsDictionary, WordsDictionaryDTO>();
        }

    }
}
