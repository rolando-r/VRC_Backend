namespace Dominio;
public class PrestadorServicio : BaseEntity
{
    public string NombrePrestadorServicio { get; set; }
    public string IdTipoPrestadorSer { get; set; }
    public TipoPrestadorSer TipoPrestadorSer { get; set; }
    public ICollection<Afiliacion> Afiliaciones { get; set; }
}