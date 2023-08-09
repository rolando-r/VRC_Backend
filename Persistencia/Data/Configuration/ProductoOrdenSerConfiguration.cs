using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoOrdenSerConfiguration : IEntityTypeConfiguration<ProductoOrdenSer>
{
    public void Configure(EntityTypeBuilder<ProductoOrdenSer> builder)
    {
        builder.ToTable("ProductoOrdenSers");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.Cantidad)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.EstadoProdOrdenSer)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.PrecioUnitario)
        .IsRequired()
        .HasColumnType("int");

        builder.HasOne(p => p.OrdenServicio)
        .WithMany(e => e.ProductoOrdenSers)
        .HasForeignKey(i => i.IdOrdenServicio);

        builder.HasOne(p => p.Producto)
        .WithMany(e => e.ProductoOrdenSers)
        .HasForeignKey(i => i.IdProducto);
    }
}