namespace Dominio;
public class Factura : BaseEntity
{
    public int NumeroFactura { get; set; }
    public int Total { get; set; }
    public string EstadoFactura { get; set; }
    public ICollection<DetalleFactura> DetalleFacturas { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}