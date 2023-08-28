namespace Dominio;
public class TipoMovimiento : BaseEntity
{
    public string NombreTipoMovimiento { get; set; }
    public ICollection<Movimiento> Movimientos { get; set; }
}