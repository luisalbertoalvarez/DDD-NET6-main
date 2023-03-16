using domain.entities;
using domain.value_objects;

namespace domain.services;

public interface IArtistaService
{
    ArtistaVentaVO create(ArtistaCompletoEntity artistaCompleto);
}
