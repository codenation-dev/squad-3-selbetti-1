using AppLog.Domain.Models;
using AppLog.Dto;
using AutoMapper;

namespace AppLog.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
