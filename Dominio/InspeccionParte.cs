namespace Dominio;
public class InspeccionParte : BaseEntity
{
    public string ? NombreInspeccionParte { get; set; }
    public string ? IdParteVehiculo { get; set; }
    public ParteVehiculo ? ParteVehiculo { get; set; }
    public ICollection<Vehiculo> ? Vehiculos { get; set; }
}