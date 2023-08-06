namespace Dominio;
public class Departamento : BaseEntity
{
    public string ? NombreDepartamento { get; set; }
    public string ? IdPais { get; set; }
    public Pais ? Pais { get; set; }
    public ICollection<Ciudad> ? Ciudades { get; set; }
}