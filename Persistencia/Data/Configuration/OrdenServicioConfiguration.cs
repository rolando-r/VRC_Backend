using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class OrdenServicioConfiguration : IEntityTypeConfiguration<OrdenServicio>
{
    public void Configure(EntityTypeBuilder<OrdenServicio> builder)
    {
        builder.ToTable("OrdenServicios");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.HasOne(p => p.Servicio)
        .WithMany(e => e.OrdenServicios)
        .HasForeignKey(i => i.IdServicio);

        builder.HasOne(p => p.Orden)
        .WithMany(e => e.OrdenServicios)
        .HasForeignKey(i => i.IdOrden);

        builder.HasOne(p => p.DetalleFactura)
        .WithMany(e => e.OrdenServicios)
        .HasForeignKey(i => i.IdDetalleFact);
    }
}