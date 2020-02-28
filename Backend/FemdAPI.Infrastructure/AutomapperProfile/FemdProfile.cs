using AutoMapper;
using FemdAPI.Core.Entities;
using FemdAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.AutomapperProfile
{
    public class FemdProfile : Profile
    {
        public FemdProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(n => n.Name, map => map.MapFrom(n => n.Student.Name))
                .ForMember(n => n.Level, map => map.MapFrom(n => n.Student.Level));

        }

    }
}
