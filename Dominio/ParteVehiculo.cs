namespace Dominio;
public class ParteVehiculo : BaseEntity
{
    public string NombreParteVehiculo { get; set; }
    public string IdEstadoParte { get; set; }
    public EstadoParte EstadoParte { get; set; }
    public ICollection<InspeccionParte> InspeccionPartes { get; set; } 
}