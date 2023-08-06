namespace Dominio;
public class Producto : BaseEntity
{
    public string ? NombreProducto { get; set; }
    public int PrecioProducto { get; set; }
    public string ? Descripcion { get; set; }
    public int Stock { get; set; }
    public string ? IdMovimiento { get; set; }
    public Movimiento ? Movimiento { get; set; }
    public string ? IdTipoProducto { get; set; }
    public TipoProducto ? TipoProducto { get; set; }
    public string ? IdPersona { get; set; }
    public Persona ? Persona { get; set; }
    public ICollection<ProductoOrdenSer> ? ProductoOrdenSers { get; set; }
}