namespace Dominio;
public class Movimiento : BaseEntity
{
    public DateTime FechaMovimiento { get; set; }
    public string ? IdTipoMovimiento { get; set; }
    public TipoMovimiento ? TipoMovimiento { get; set; }
    public IEnumerable<Producto> ? Productos { get; set; }
}