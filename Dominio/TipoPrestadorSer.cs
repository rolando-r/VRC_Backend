namespace Dominio;
public class TipoPrestadorSer : BaseEntity
{
    public string NombreTipoPrestadorSer { get; set; }
    public ICollection<PrestadorServicio> PrestadorServicios { get; set; }
}