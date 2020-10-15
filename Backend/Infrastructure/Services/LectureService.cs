using AutoMapper;
using FemdAPI.Core.Domains;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure.Extensions;
using FemdAPI.Infrastructure.Models;
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
        public WordsDictionaryDTO Get(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            return _mapper.Map<WordsDictionaryDTO>(lecture);
        }
        public LectureDTO Get(string name)
        {
            var lecture = _lectureRepository.GetLectureOrNull(name);
            return _mapper.Map<LectureDTO>(lecture);
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
