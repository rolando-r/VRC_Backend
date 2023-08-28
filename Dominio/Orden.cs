namespace Dominio;
public class Orden : BaseEntity
{
    public DateTime FechaOrden { get; set; }
    public DateTime FechaCierre { get; set; }
    public string IdEstadoOrden { get; set; }
    public EstadoOrden EstadoOrden { get; set; }
    public string IdPersona { get; set; }
    public Persona Persona { get; set; }
    public string IdFactura { get; set; }
    public Factura Factura { get; set; }
    public ICollection<OrdenDiagnostico> OrdenDiagnosticos { get; set; }
    public ICollection<OrdenServicio> OrdenServicios { get; set; }
}