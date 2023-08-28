namespace Dominio;
public class TipoVehiculo : BaseEntity
{
    public string ? NombreTipoVehiculo { get; set; }
    public ICollection<Vehiculo> ? Vehiculos { get; set; }
}