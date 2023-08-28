namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IAfiliacionRepository Afiliaciones { get;}
    IContactoPersonaRepository ContactoPersonas { get;}
    IDetalleFacturaRepository DetalleFacturas { get;}
    IEmpresaRepository Empresas { get;}
    IEspecialidadRepository Especialidades { get;}
    IEstadoOrdenRepository EstadoOrdenes { get;}
    IEstadoParteRepository EstadoPartes { get;}
    IFacturaRepository Facturas { get;}
    IInspeccionParteRepository InspeccionPartes { get;}
    IMarcaRepository Marcas { get;}
    IModeloRepository Modelos { get;}
    IMovimientoRepository Movimientos { get;}
    IOrdenDiagnosticoRepository OrdenDiagnosticos { get;}
    IOrdenRepository Ordenes { get;}
    IOrdenServicioRepository OrdenServicios { get;}
    IParteVehiculoRepository ParteVehiculos { get;}
    IPersonaAfiliacionRepository PersonaAfiliaciones { get;}
    IPersonaEspecialidadRepository PersonaEspecialidades { get;}
    IPersonaServicioRepository PersonaServicios { get;}
    IPrestadorServicioRepository PrestadorServicios { get;}
    IProductoOrdenSerRepository ProductoOrdenSers { get;}
    IProductoRepository Productos { get;}
    IRecomendacionRepository Recomendaciones { get;}
    IServicioRepository Servicios { get;}
    ISucursalRepository Sucursales { get;}
    ITipoContactoRepository TipoContactos { get;}
    ITipoMovimientoRepository TipoMovimientos { get;}
    ITipoPrestadorSerRepository TipoPrestadorSers { get;}
    ITipoProductoRepository TipoProductos { get;}
    ITipoServicioRepository TipoServicios { get;}
    ITipoVehiculoRepository TipoVehiculos { get;}
    IVehiculoRepository Vehiculos { get;}
    ICiudadRepository Ciudades { get; }
    IDepartamentoRepository Departamentos { get; }
    IPaisRepository Paises { get; }
    IPersonaRepository Personas { get; }
    ITipoPersonaRepository TipoPersonas { get; }
    Task<int> SaveAsync();
}