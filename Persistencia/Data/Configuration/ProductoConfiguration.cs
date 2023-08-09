using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreProducto)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.PrecioVenta)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(250);

        builder.Property(p => p.Stock)
        .IsRequired()
        .HasColumnType("int");

        builder.HasOne(p => p.Movimiento)
        .WithMany(e => e.Productos)
        .HasForeignKey(i => i.IdMovimiento);

        builder.HasOne(p => p.TipoProducto)
        .WithMany(e => e.Productos)
        .HasForeignKey(i => i.IdTipoProducto);

        builder.HasOne(p => p.Persona)
        .WithMany(e => e.Productos)
        .HasForeignKey(i => i.IdPersona);
    }
}