namespace api.entities;

public record ArtistaEntity
{
    public string Id { get; set; }
    public string NombreArtista { get; set; }
    public string NombreDisco { get; set; }
    public int Publicacion { get; set; }
}