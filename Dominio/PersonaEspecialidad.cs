namespace Dominio;
public class PersonaEspecialidad : BaseEntity
{
    public string ? IdEspecialidad { get; set; }
    public Especialidad ? Especialidad { get; set; }
    public string ? IdPersona { get; set; }
    public Persona ? Persona { get; set; }
}