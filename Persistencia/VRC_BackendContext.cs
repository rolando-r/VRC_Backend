using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class VRC_BackendContext : DbContext
    {
        public VRC_BackendContext(DbContextOptions<VRC_BackendContext> options) : base(options)
        {
        }

        public DbSet<Afiliacion> ? Afiliaciones { get; set; }
        public DbSet<Ciudad> ? Ciudades { get; set; }
        public DbSet<ContactoPersona> ? ContactoPersonas { get; set; }
        public DbSet<Departamento> ? Departamentos { get; set; }
        public DbSet<DetalleFactura> ? DetalleFacturas { get; set; }
        public DbSet<Empresa> ? Empresas { get; set; }
        public DbSet<Especialidad> ? Especialidades { get; set; }
        public DbSet<EstadoOrden> ? EstadoOrdenes { get; set; }
        public DbSet<EstadoParte> ? EstadoPartes { get; set; }
        public DbSet<Factura> ? Facturas { get; set; }
        public DbSet<InspeccionParte> ? InspeccionPartes { get; set; }
        public DbSet<Marca> ? Marcas { get; set; }
        public DbSet<Modelo> ? Modelos { get; set; }
        public DbSet<Movimiento> ? Movimientos { get; set; }
        public DbSet<Orden> ? Ordenes { get; set; }
        public DbSet<OrdenDiagnostico> ? OrdenDiagnosticos { get; set; }
        public DbSet<Pais> ? Paises { get; set; }
        public DbSet<ParteVehiculo> ? ParteVehiculos { get; set; }
        public DbSet<Persona> ? Personas { get; set; }
        public DbSet<PersonaAfiliacion> ? PersonaAfiliaciones { get; set; }
        public DbSet<PersonaEspecialidad> ? PersonaEspecialidades { get; set; }
        public DbSet<PersonaServicio> ? PersonaServicios { get; set; }
        public DbSet<PrestadorServicio> ? PrestadorServicios { get; set; }
        public DbSet<Producto> ? Productos { get; set; }
        public DbSet<ProductoOrdenSer> ? ProductoOrdenSers { get; set; }
        public DbSet<Recomendacion> ? Recomendaciones { get; set; }
        public DbSet<Servicio> ? Servicios { get; set; }
        public DbSet<Sucursal> ? Sucursales { get; set; }
        public DbSet<TipoContacto> ? TipoContactos { get; set; }
        public DbSet<TipoMovimiento> ? TipoMovimientos { get; set; }
        public DbSet<TipoPersona> ? TipoPersonas { get; set; }
        public DbSet<TipoPrestadorSer> ? TipoPrestadorSers { get; set; }
        public DbSet<TipoProducto> ? TipoProductos { get; set; }
        public DbSet<TipoServicio> ? TipoServicios { get; set; }
        public DbSet<TipoVehiculo> ? TipoVehiculos { get; set; }
        public DbSet<Vehiculo> ? Vehiculos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Afiliacion());
        modelBuilder.ApplyConfiguration(new Ciudad());
        modelBuilder.ApplyConfiguration(new ContactoPersona());
        modelBuilder.ApplyConfiguration(new Departamento());
        modelBuilder.ApplyConfiguration(new DetalleFactura());
        modelBuilder.ApplyConfiguration(new Empresa());
        modelBuilder.ApplyConfiguration(new Especialidad());
        modelBuilder.ApplyConfiguration(new EstadoOrden());
        modelBuilder.ApplyConfiguration(new Factura());
        modelBuilder.ApplyConfiguration(new InspeccionParte());
        modelBuilder.ApplyConfiguration(new Marca());
        modelBuilder.ApplyConfiguration(new Modelo());
        modelBuilder.ApplyConfiguration(new Movimiento());
        modelBuilder.ApplyConfiguration(new Orden());
        modelBuilder.ApplyConfiguration(new OrdenDiagnostico());
        modelBuilder.ApplyConfiguration(new OrdenServicio());
        modelBuilder.ApplyConfiguration(new Pais());
        modelBuilder.ApplyConfiguration(new ParteVehiculo());
        modelBuilder.ApplyConfiguration(new Persona());
        modelBuilder.ApplyConfiguration(new PersonaAfiliacion());
        modelBuilder.ApplyConfiguration(new PersonaEspecialidad());
        modelBuilder.ApplyConfiguration(new PersonaServicio());
        modelBuilder.ApplyConfiguration(new PrestadorServicio());
        modelBuilder.ApplyConfiguration(new Producto());
        modelBuilder.ApplyConfiguration(new ProductoOrdenSer());
        modelBuilder.ApplyConfiguration(new Recomendacion());
        modelBuilder.ApplyConfiguration(new Servicio());
        modelBuilder.ApplyConfiguration(new Sucursal());
        modelBuilder.ApplyConfiguration(new TipoContacto());
        modelBuilder.ApplyConfiguration(new TipoMovimiento());
        modelBuilder.ApplyConfiguration(new TipoPersona());
        modelBuilder.ApplyConfiguration(new TipoPrestadorSer());
        modelBuilder.ApplyConfiguration(new TipoProducto());
        modelBuilder.ApplyConfiguration(new TipoServicio());
        modelBuilder.ApplyConfiguration(new TipoVehiculo());
        modelBuilder.ApplyConfiguration(new Vehiculo());

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    }
}