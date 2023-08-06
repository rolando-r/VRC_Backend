namespace Dominio;
public class DetalleFactura : BaseEntity
{
    public string ? IdOrdenServicio { get; set; }
    public OrdenServicio ? OrdenServicio { get; set; }
    public string ? IdRecomendacion { get; set; }
    public Recomendacion ? Recomendacion { get; set; }
    public string ? IdFactura { get; set; }
    public Factura ? Factura { get; set; }
}