using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.ToTable("Facturas");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NumeroFactura)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.Total)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.EstadoFactura)
        .IsRequired()
        .HasMaxLength(50);
    }
}