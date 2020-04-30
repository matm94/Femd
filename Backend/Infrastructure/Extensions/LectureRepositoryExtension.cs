using FemdAPI.Core.Entities;
using FemdAPI.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Extensions
{
    public static class LectureRepositoryExtension
    {
        public static Lecture GetLectureOrNull(this ILectureRepository _lectureRepository, string name)
        {
            var lecture = _lectureRepository.Get(name);
            if (lecture == null)
            {
                throw new Exception($"Wyklad o podanej nazwie: {name} nie istnieje");
            }

            return lecture;
        }

        public static Lecture GetLectureOrNull(this ILectureRepository _lectureRepository, Guid id)
        {
            var lecture = _lectureRepository.Get(id);
            if (lecture == null)
            {
                throw new Exception($"Wyklad o podanym id: {id} nie istnieje");
            }

            return lecture;
        }

        public static Lecture GetLectureOrFail(this ILectureRepository _lectureRepository, string name)
        {
            var lecture = _lectureRepository.Get(name);

            if (lecture != null)
            {
                throw new Exception($"Wyklad o podanej nazwie: {name} istnieje");
            }

            return lecture;
        }
    }
}
