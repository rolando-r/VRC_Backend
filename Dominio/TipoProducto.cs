namespace Dominio;
public class TipoProducto : BaseEntity
{
    public string NombreTipoProducto { get; set; }
    public ICollection<Producto> Productos { get; set; }
}