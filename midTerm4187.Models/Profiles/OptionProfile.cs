using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using AutoMapper;
using midTerm4187.Data.Entities;
using midTerm4187.Models.Models.Option;

namespace midTerm4187.Models.Profiles
{
    class OptionProfile : Profile
    {
        public OptionProfile()
        {
            CreateMap<Option, OptionModel>().ReverseMap();
            CreateMap<OptionCreateModel, Option>();
            CreateMap<OptionUpdateModel, Option>();
        }
       
    }
}
