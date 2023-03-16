using domain.contracts;
using domain.entities;
using domain.value_objects;

namespace domain.services;

public class ArtistaService : IArtistaService
{
    private readonly IArtistaRepository artistaRepository;

    public ArtistaService(IArtistaRepository artistaRepository)
    {
        this.artistaRepository = artistaRepository;
    }

    public ArtistaVentaVO create(ArtistaCompletoEntity artistaCompleto)
    {
        artistaCompleto = artistaCompleto with { Auditoria = "Admin" };
        if (!this.artistaRepository.create(artistaCompleto))
        {
            throw new Exception("No guardo en la fuente datos");
        }
        return new ArtistaVentaVO(artistaCompleto.Id
       , artistaCompleto.NombreArtista
       , artistaCompleto.NombreDisco
       , artistaCompleto.Publicacion
       , artistaCompleto.Auditoria
       , artistaCompleto.Publicacion * 2
       );
    }
}
