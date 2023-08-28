namespace Dominio;
public class Modelo : BaseEntity
{
    public string ? NombreModelo { get; set; }
    public string ? IdMarca { get; set; }
    public Marca ? Marca { get; set; }
    public ICollection<Vehiculo> ? Vehiculos { get; set; }
}