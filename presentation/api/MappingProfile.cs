using AutoMapper;
using api.Dtos;
using api.entities;
using domain.entities;

namespace api;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ArtistaDto, ArtistaEntity>();
        CreateMap<ArtistaEntity, ArtistaDto>();

        CreateMap<ArtistaEntity, ArtistaCompletoEntity>();
        CreateMap<ArtistaCompletoEntity, ArtistaEntity>();
    }
}
