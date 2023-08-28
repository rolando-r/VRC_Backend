namespace Dominio;
public class TipoContacto : BaseEntity
{
    public string ? NombreTipoContacto { get; set; }
    public ICollection<ContactoPersona> ? ContactoPersonas { get; set; }
}