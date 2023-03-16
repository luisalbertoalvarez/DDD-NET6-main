using domain.contracts;
using domain.entities;

namespace infraestructure.repository;

public class ArtistaRepository : IArtistaRepository
{
    public bool create(ArtistaCompletoEntity artistaCompleto)
    {
        Console.WriteLine(artistaCompleto.ToString());
        return true;
    }
}
