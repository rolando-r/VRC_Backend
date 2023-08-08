using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("Ordenes");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.FechaOrden)
        .IsRequired()
        .HasColumnType("date");

        builder.Property(p => p.FechaCierre)
        .IsRequired()
        .HasColumnType("date");

        builder.HasOne(p => p.EstadoOrden)
        .WithMany(e => e.Ordenes)
        .HasForeignKey(i => i.IdEstadoOrden);

        builder.HasOne(p => p.Persona)
        .WithMany(e => e.Ordenes)
        .HasForeignKey(i => i.IdPersona);

        builder.HasOne(p => p.Factura)
        .WithMany(e => e.Ordenes)
        .HasForeignKey(i => i.IdFactura);
    }
}