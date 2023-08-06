namespace Dominio;
public class Afiliacion : BaseEntity
{
    public string ? NombreAfiliacion { get; set; }
    public string ? IdPrestadorServicio { get; set; }
    public PrestadorServicio ? PrestadorServicio { get; set; }
    public ICollection<PersonaAfiliacion> ? PersonaAfiliaciones { get; set; }
}