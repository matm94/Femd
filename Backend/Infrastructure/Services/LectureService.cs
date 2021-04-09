using AutoMapper;
using FemdAPI.Core.Domains;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Extensions;
using FemdAPI.Infrastructure.Models;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public class LectureService : ILectureService
    {
        private readonly IMapper _mapper;
        private readonly ILectureRepository _lectureRepository;

        public LectureService(ILectureRepository lectureRepository, IMapper mapper)
        {
            _lectureRepository = lectureRepository;
            _mapper = mapper;
        }
        public LectureDTO Get(string name)
        {
            var lecture = _lectureRepository.GetLectureOrNull(name);
            return _mapper.Map<LectureDTO>(lecture);
        }
        public LectureDTO Get(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            return _mapper.Map<LectureDTO>(lecture);
        }
        public CompleteLectureDTO GetFullLecture(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            return _mapper.Map<CompleteLectureDTO>(lecture);
        }
        public WordsDictionaryDTO GetOnlyDictionary(Guid id)
        {
            var lecture = _lectureRepository.GetWordsDictionaryOrNull(id);
            return _mapper.Map<WordsDictionaryDTO>(lecture);
        }
        public AdjectiveDTO GetAdjective(Guid id)
        {
            var adjective = _lectureRepository.GetAdjectiveOrNull(id);
            return _mapper.Map<AdjectiveDTO>(adjective);
        }
        public AdverbDTO GetAdverb(Guid id)
        {
            var adverb = _lectureRepository.GetAdverbOrNull(id);
            return _mapper.Map<AdverbDTO>(adverb);
        }
        public NounDTO GetNoun(Guid id)
        {
            var noun = _lectureRepository.GetNounOrNull(id);
            return _mapper.Map<NounDTO>(noun);
        }
        public PersonalPronounDTO GetPersonalPronoun(Guid id)
        {
            var personalPronoun = _lectureRepository.GetPersonalPronounOrNull(id);
            return _mapper.Map<PersonalPronounDTO>(personalPronoun);
        }
        public SentenceDTO GetSentence(Guid id)
        {
            var sentence = _lectureRepository.GetSentenceOrNull(id);
            return _mapper.Map<SentenceDTO>(sentence);
        }
        public VerbDTO GetVerb(Guid id)
        {
            var verb = _lectureRepository.GetVerbeOrNull(id);
            return _mapper.Map<VerbDTO>(verb);
        }
        public IEnumerable<LectureDTO> GetAll()
        {
            var letureAll = _lectureRepository.GetAll();
            var lectureAllDtos = _mapper.Map<IEnumerable<LectureDTO>>(letureAll);
            return lectureAllDtos;
        }
        public void Create(string name, int number, string description)
        { 
            var lecture = _lectureRepository.GetLectureOrFail(name);
            lecture = new Lecture(name,number,description);
            _lectureRepository.AddLecture(lecture);
        }
        public void Delete(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            _lectureRepository.DeleteLecture(lecture.Id);
        }

    }
}
