namespace Dominio;
public class Ciudad : BaseEntity
{
    public string NombreCiudad { get; set; }
    public string IdDepartamento { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Sucursal> Sucursales { get; set; }
}