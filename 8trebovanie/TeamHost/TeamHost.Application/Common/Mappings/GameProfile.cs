using AutoMapper;
using TeamHost.Application.Features.Games.DTOs;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Common.Mappings
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GetAllGamesResponse>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Categories,
                    opt => opt.MapFrom(src => src.Category.Select(x => x.Code)))
                .ForMember(dest => dest.Platforms,
                    opt => opt.MapFrom(src => src.Platforms))
                .ForMember(dest => dest.MainImagePath,
                    opt => opt.MapFrom(src => src.MainImage.Path))
                .ForMember(dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ReleaseDate,
                    opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(dest => dest.Companies,
                    opt => opt.MapFrom(src => new CompanyDto() { Name = src.CompanyDeveloper.Name, Description = src.CompanyDeveloper.Description}));
        }
    }
}
