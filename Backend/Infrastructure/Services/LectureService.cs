using AutoMapper;
using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
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
        public LectureDTO Get(string name)
        {
            var lecture = _lectureRepository.Get(name);
            if (lecture == null)
            {
                throw new Exception("Wyklad o podanej nazwie nie istnieje");
            }

            var lectureDtos = _mapper.Map<LectureDTO>(lecture);
            return lectureDtos;
        }

        public LectureDTO Get(Guid id)
        {
            var lecture = _lectureRepository.Get(id);
            if (lecture == null)
            {
                throw new Exception("Wyklad o podanym id nieistnieje");
            }

            var lectureDtos = _mapper.Map<LectureDTO>(lecture);
            return lectureDtos;
        }

        public IEnumerable<LectureDTO> GetAll()
        {
            var letureAll = _lectureRepository.GetAll();
            var lectureAllDtos = _mapper.Map<IEnumerable<LectureDTO>>(letureAll);
            return lectureAllDtos;
        }

        public void Create(LectureDTO model)
        {
            var lecture = _mapper.Map<Lecture>(model);
            lecture = _lectureRepository.Get(model.Name);
            if (lecture != null)
            {
                throw new Exception("Wyklad o podanej nazwie istnieje");
            }
            lecture = new Lecture(model.Name, model.Number, model.Level);
            _lectureRepository.AddLecture(lecture);
        }


        public void Delete(Guid id)
        {
            var lecture = _lectureRepository.Get(id);
            if (lecture == null)
            {
                throw new Exception("Wyklad o podanym id nie istnieje");
            }
            _lectureRepository.DeleteLecture(lecture.Id);
        }

    }
}
