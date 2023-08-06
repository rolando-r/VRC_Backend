namespace Dominio;
public class EstadoParte : BaseEntity
{
    public string ? NombreEstadoParte { get; set; }
    public ICollection<ParteVehiculo> ? ParteVehiculos { get; set; }
}