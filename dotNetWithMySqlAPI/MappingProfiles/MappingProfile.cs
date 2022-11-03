using AutoMapper;
using dotNetWithMySqlAPI.DTO;
using dotNetWithMySqlAPI.Entities;

namespace dotNetWithMySqlAPI.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
