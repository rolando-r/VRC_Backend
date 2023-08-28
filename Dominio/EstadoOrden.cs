namespace Dominio;
public class EstadoOrden : BaseEntity
{
    public string NombreEstadoOrden { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}