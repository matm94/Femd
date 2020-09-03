using FemdAPI.Core.Domains;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public interface ILectureService
    {
        LectureDetailsDTO Get(string name);
        LectureDetailsDTO Get(Guid id);
        IEnumerable<LectureDetailsDTO> GetAll();
        void Create(string name, int number, Level level);
        void Delete(Guid id);
    }
}
