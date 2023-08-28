namespace Dominio;
public class PersonaServicio : BaseEntity
{
    public string IdPersona { get; set; }
    public Persona Persona { get; set; }
    public string IdServicio { get; set; }
    public Servicio Servicio { get; set; }
}