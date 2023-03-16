using domain.entities;

namespace domain.contracts;

public interface IArtistaRepository
{
    bool create(ArtistaCompletoEntity artistaCompleto);
}
