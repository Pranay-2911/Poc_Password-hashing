using AutoMapper;
using Poc_Password_hashing.Dtos;
using Poc_Password_hashing.Models;

namespace Poc_Password_hashing.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Encrpt the password
            CreateMap<UserDto, User>().ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => BCrypt.Net.BCrypt.HashPassword(src.Password)));

        }
    }
}
