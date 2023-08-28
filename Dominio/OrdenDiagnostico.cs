namespace Dominio;
public class OrdenDiagnostico : BaseEntity
{
    public string DescripcionDiagnostico { get; set; }
    public string IdPersona { get; set; }
    public Persona Persona { get; set; }
    public string IdOrden { get; set; }
    public Orden Orden { get; set; }
}