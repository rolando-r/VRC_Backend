using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EstadoParteConfiguration : IEntityTypeConfiguration<EstadoParte>
{
    public void Configure(EntityTypeBuilder<EstadoParte> builder)
    {
        builder.ToTable("EstadoPartes");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreEstadoParte)
        .IsRequired()
        .HasMaxLength(50);
    }
}