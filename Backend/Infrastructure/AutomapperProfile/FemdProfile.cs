﻿using AutoMapper;
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
            CreateMap<User, UserDTO>();
            CreateMap<User, AccountDTO>();
            CreateMap<Lecture, LectureDTO>();
            CreateMap<Lecture, CompleteLectureDTO>();
            CreateMap<WordsDictionary, WordsDictionaryDTO>();
        }

    }
}
