using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface ILectureService
    {
        LectureDTO Get(string name);
        LectureDTO Get(Guid id);
        IEnumerable<LectureDTO> GetAll();
        void Create(LectureDTO lectureDTO);
        void Delete(Guid id);
    }
}
