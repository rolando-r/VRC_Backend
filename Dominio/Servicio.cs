namespace Dominio;
public class Servicio : BaseEntity
{
    public string NombreServicio { get; set; }
    public string IdTipoServicio { get; set; }
    public TipoServicio TipoServicio { get; set; }
    public ICollection<OrdenServicio> OrdenServicios { get; set; }
    public ICollection<PersonaServicio> PersonaServicios { get; set; }
}