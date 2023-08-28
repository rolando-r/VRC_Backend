namespace Dominio;
public class TipoPersona : BaseEntity
{
    public string NombreTipoPersona { get; set; }
    public ICollection<Persona> Personas { get; set; }
}