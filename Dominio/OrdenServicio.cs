namespace Dominio;
public class OrdenServicio : BaseEntity
{
    public string ? IdServicio { get; set; }
    public Servicio ? Servicio { get; set; }
    public string ? IdOrden { get; set; }
    public Orden ? Orden { get; set; }
    public string ? IdDetalleFact { get; set; }
    public DetalleFactura ? DetalleFactura { get; set; }
    public ICollection<ProductoOrdenSer> ? ProductoOrdenSers { get; set; }
}