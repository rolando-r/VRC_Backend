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
        
    }
}