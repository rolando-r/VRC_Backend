namespace Dominio;
public class Especialidad : BaseEntity
{
    public string ? NombreEspecialidad { get; set; }
    public ICollection<PersonaEspecialidad> ? PersonaEspecialidades { get; set; }
}