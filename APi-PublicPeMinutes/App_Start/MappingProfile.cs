using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APi_PublicPeMinutes.EF;
using APi_PublicPeMinutes.Dtos;

namespace APi_PublicPeMinutes.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<SchoolName, MinutesDto>();
            Mapper.CreateMap<SchoolTeachersWithADLogin, Teachers>();
            Mapper.CreateMap<EnteredPeMinute, Minute>();
        }
    }
}