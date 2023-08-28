namespace Dominio;
public class ContactoPersona : BaseEntity
{
    public string Direccion { get; set; }
    public string Email { get; set; }
    public int NroFijo { get; set; } 
    public int NroMovil { get; set; }
    public string IdPersona { get; set; }
    public Persona Persona { get; set; }
    public string IdTipoContacto { get; set; }
    public TipoContacto TipoContacto { get; set; }
    public ICollection<Sucursal> Sucursales { get; set; }
}