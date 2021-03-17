using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using midTerm4187.Data.Entities;
using midTerm4187.Models.Models.Question;

namespace midTerm4187.Models.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionModelBase>().ReverseMap();
            CreateMap<Question, QuestionModelExtended>();
            CreateMap<QuestionCreateModel, Question>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<QuestionUpdateModel, Question>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text)).ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description)).ReverseMap();


        }
    }
}
