using AutoMapper;
using Gym.Core.DTOs;
using gym_rutiKroivets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Guide,GuideDto>().ReverseMap();
            CreateMap<Student,StudentDto>().ReverseMap();
            CreateMap<Training,TrainingDto>().ReverseMap();

        }
    }
}
