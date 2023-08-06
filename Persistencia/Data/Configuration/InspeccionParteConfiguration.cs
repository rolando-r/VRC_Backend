using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InspeccionParteConfiguration : IEntityTypeConfiguration<InspeccionParte>
{
    public void Configure(EntityTypeBuilder<InspeccionParte> builder)
    {
        builder.ToTable("InspeccionPartes");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}