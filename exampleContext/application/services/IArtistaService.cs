using api.entities;
using domain.value_objects;

namespace application.services;

public interface IArtistaService
{
    ArtistaVentaVO create(ArtistaEntity artista);
}
