using AutoMapper;
using TeamHost.Application.Features.Account.DTOs;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Common.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, AccountDto>()
                .ForMember(dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Birthday,
                    opt => opt.MapFrom(src => src.Birthday));
        }
    }
}
