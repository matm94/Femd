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
        IEnumerable<LectureDTO> GetAll();
        void Create(string name, int number, string description);
        void Delete(Guid id);
    }
}
