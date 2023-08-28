namespace Dominio;
public class DetalleFactura : BaseEntity
{
    public string IdRecomendacion { get; set; }
    public Recomendacion Recomendacion { get; set; }
    public string IdFactura { get; set; }
    public Factura Factura { get; set; }
    public ICollection<OrdenServicio> OrdenServicios { get; set; }
}