using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleFacturaConfiguration : IEntityTypeConfiguration<DetalleFactura>
{
    public void Configure(EntityTypeBuilder<DetalleFactura> builder)
    {
        builder.ToTable("DetalleFacturas");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.HasOne(p => p.Recomendacion)
        .WithMany(e => e.DetalleFacturas)
        .HasForeignKey(i => i.IdRecomendacion);

        builder.HasOne(p => p.Factura)
        .WithMany(e => e.DetalleFacturas)
        .HasForeignKey(i => i.IdFactura);
    }
}