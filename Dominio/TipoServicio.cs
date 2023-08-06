namespace Dominio;
public class TipoServicio : BaseEntity
{
    public string ? NombreTipoServicio { get; set; }
    public ICollection<Servicio> ? Servicios { get; set; }
}