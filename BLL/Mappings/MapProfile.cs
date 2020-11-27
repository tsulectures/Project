using AutoMapper;
using BLL.DTOs.Person;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Person, PersonListDTO>()
                .ForMember(dest =>
                 dest.Gender,
                 opt => opt.MapFrom(src => src.Gender.Title));

            CreateMap<PersonCUDTO, Person>();
        }
    }
}
