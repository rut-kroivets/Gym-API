using AutoMapper;
using gym_rutiKroivets.Entities;
using gym_rutiKroivets.Models;

namespace gym_rutiKroivets.Mapping
{
    public class ApiMappingProfile :Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<GuidePostModel, Guide>();
            CreateMap<StudentPostModel, Student>();
            CreateMap<TrainingPostModel, Training>();
        }
    }
}
