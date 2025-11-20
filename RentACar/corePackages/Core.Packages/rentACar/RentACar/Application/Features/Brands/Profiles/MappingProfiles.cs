using Application.Features.Brands.Commands.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateBrandCommand, Brand>().ReverseMap();
        CreateMap<CreatedBrandResponse,Brand >().ReverseMap();
    }
}
