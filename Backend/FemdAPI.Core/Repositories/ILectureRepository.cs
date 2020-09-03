using FemdAPI.Core.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Repositories
{
    public interface ILectureRepository
    {
        Lecture Get(string name);
        Lecture Get(Guid id);
        IEnumerable<Lecture> GetAll();
        void AddLecture(Lecture lecture);
        void UpdateLecture(Lecture lecture);
        void DeleteLecture(Guid id);

    }
}
