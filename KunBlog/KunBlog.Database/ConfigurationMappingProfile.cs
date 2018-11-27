using AutoMapper;
using KunBlog.Contracts.Dto;
using KunBlog.Database.Context;

namespace KunBlog.Database
{
    class ConfigurationMappingProfile : Profile
    {
        public ConfigurationMappingProfile()
        {
            CreateMap<UserProfileEntity, UserProfileDto>().ReverseMap();
        }
    }
}
