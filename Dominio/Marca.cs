namespace Dominio;
public class Marca : BaseEntity
{
    public string ? NombreMarca { get; set; }
    public ICollection<Modelo> ? Modelos { get; set; }
}