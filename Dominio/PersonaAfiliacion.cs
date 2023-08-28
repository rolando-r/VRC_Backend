namespace Dominio;
public class PersonaAfiliacion : BaseEntity
{
    public string IdPersona { get; set; }
    public Persona  Persona { get; set; }
    public string IdAfiliacion { get; set; }
    public Afiliacion Afiliacion { get; set; }
}