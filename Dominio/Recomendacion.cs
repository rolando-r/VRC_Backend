namespace Dominio;
public class Recomendacion : BaseEntity
{
    public string DescripcionRec { get; set; }
    public ICollection<DetalleFactura> DetalleFacturas { get; set; }
}