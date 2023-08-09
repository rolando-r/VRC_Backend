namespace Dominio;
public class ProductoOrdenSer : BaseEntity
{
    public int Cantidad { get; set; }
    public string ? EstadoProdOrdenSer { get; set; }
    public int PrecioUnitario { get; set; }
    public string ? IdOrdenServicio { get; set; }
    public OrdenServicio ? OrdenServicio { get; set; }
    public string ? IdProducto { get; set; }
    public Producto ? Producto { get; set; }
}