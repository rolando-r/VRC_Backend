namespace Dominio;
public class Sucursal : BaseEntity
{
    public string NombreSucursal { get; set; }
    public string Direccion { get; set; }
    public string IdContactoPersona { get; set;}
    public ContactoPersona ContactoPersona { get; set; }
    public string IdCiudad { get; set; }
    public Ciudad Ciudad { get; set; }
    public string IdEmpresa { get; set; }
    public Empresa Empresa { get; set; }
    public IEnumerable<Persona> Personas { get; set; }
}