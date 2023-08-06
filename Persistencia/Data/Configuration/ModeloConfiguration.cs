using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
{
    public void Configure(EntityTypeBuilder<Modelo> builder)
    {
        builder.ToTable("Modelos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}