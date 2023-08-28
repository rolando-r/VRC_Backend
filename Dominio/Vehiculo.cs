namespace Dominio;
public class Vehiculo : BaseEntity
{
    public string ? Placa { get; set; }
    public string ? IdPersona { get; set; }
    public Persona ? Persona { get; set; }
    public string ? IdInspeccionParte { get; set; }
    public InspeccionParte ? InspeccionParte { get; set; }
    public string ? IdTipoVehiculo { get; set; }
    public TipoVehiculo ? TipoVehiculo { get; set; }
    public string ? IdModelo { get; set; }
    public Modelo ? Modelo { get; set; }
    public string ? IdOrden { get; set; }
    public Orden ? Orden { get; set; }
}