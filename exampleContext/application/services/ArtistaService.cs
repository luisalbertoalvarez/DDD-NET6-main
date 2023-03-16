using api.entities;
using DomainService = domain.services;
using AutoMapper;
using domain.entities;
using domain.value_objects;

namespace application.services;

public class ArtistaService : IArtistaService
{
    private readonly IMapper _mapper;
    private readonly DomainService.IArtistaService artistaDomainService;

    public ArtistaService(DomainService.IArtistaService artistaDomainService, IMapper mapper = null)
    {
        this.artistaDomainService = artistaDomainService;
        _mapper = mapper;
    }

    public ArtistaVentaVO create(ArtistaEntity artista)
    {
        artista = artista with { Id = Guid.NewGuid().ToString() };
        ArtistaCompletoEntity artistaCompleto = _mapper.Map<ArtistaCompletoEntity>(artista);
        ArtistaVentaVO artistaVenta = this.artistaDomainService.create(artistaCompleto);
        return artistaVenta;
    }
}
