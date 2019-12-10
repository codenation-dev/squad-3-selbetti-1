using AppLog.Domain.Models;
using AppLog.Dto;
using AutoMapper;
using System.Collections.Generic;

namespace AppLog.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Log, LogDto>();
            CreateMap<LogDto, Log>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Application, ApplicationDto>();
            CreateMap<ApplicationDto, Application>();
            CreateMap<EnvironmentDto, Domain.Models.Environment> ();
            CreateMap<Domain.Models.Environment, EnvironmentDto>();
        }
    }
}
