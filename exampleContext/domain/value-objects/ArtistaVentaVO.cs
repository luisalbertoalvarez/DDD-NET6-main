using domain.entities;

namespace domain.value_objects;

public record ArtistaVentaVO(string Id, string NombreArtista, string NombreDisco, int Publicacion, string Auditoria, decimal Ventas);
