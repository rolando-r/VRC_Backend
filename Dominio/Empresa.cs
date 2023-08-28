namespace Dominio;
public class Empresa : BaseEntity
{
    public string NombreEmpresa { get; set; }
    public ICollection<Sucursal> Sucursales { get; set; }
}