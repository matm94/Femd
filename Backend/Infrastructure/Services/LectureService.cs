using AutoMapper;
using FemdAPI.Core.Entities;
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
        public LectureDetailsDTO Get(string name)
        {
            var lecture = _lectureRepository.GetLectureOrNull(name);
            var lectureDtos = _mapper.Map<LectureDetailsDTO>(lecture);
            return lectureDtos;
        }

        public LectureDetailsDTO Get(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            var lectureDtos = _mapper.Map<LectureDetailsDTO>(lecture);
            return lectureDtos;
        }

        public IEnumerable<LectureDetailsDTO> GetAll()
        {
            var letureAll = _lectureRepository.GetAll();
            var lectureAllDtos = _mapper.Map<IEnumerable<LectureDetailsDTO>>(letureAll);
            return lectureAllDtos;
        }

        public void Create(string name, int number, Level level)
        { 
            var lecture = _lectureRepository.GetLectureOrFail(name);
            lecture = new Lecture(name,number,level);
            _lectureRepository.AddLecture(lecture);
        }


        public void Delete(Guid id)
        {
            var lecture = _lectureRepository.GetLectureOrNull(id);
            _lectureRepository.DeleteLecture(lecture.Id);
        }

    }
}
