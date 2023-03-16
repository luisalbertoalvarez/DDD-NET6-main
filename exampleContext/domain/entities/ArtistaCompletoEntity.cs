namespace domain.entities;

public record ArtistaCompletoEntity
{
    public string Id { get; set; }
    public string NombreArtista { get; set; }
    public string NombreDisco { get; set; }
    public int Publicacion { get; set; }
    public string Auditoria { get; set; }
}
