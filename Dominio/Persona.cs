namespace Dominio;
public class Persona : BaseEntity
{
    public string ? NombrePersona { get; set; }
    public string ? Contraseña { get; set;}
    public string ? IdTipoPersona { get; set; }
    public TipoPersona ? TipoPersona { get; set; }
    public string ? IdSucursal { get; set; }
    public Sucursal ? Sucursal { get; set; }
    public ICollection<PersonaEspecialidad> ? PersonaEspecialidades { get; set; }
    public ICollection<PersonaAfiliacion> ? PersonaAfiliaciones { get; set; }
    public ICollection<Vehiculo> ? Vehiculos { get; set; }
    public ICollection<ContactoPersona> ? ContactoPersonas { get; set; }
    public ICollection<PersonaServicio> ? PersonaServicios { get; set; }
    public ICollection<Producto> ? Productos { get; set; }
    public ICollection<OrdenDiagnostico> ? OrdenDiagnosticos { get; set; }
    public ICollection<Orden> ? Ordenes { get; set; }
}