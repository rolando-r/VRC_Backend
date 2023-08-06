using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PrestadorServicioConfiguration : IEntityTypeConfiguration<PrestadorServicio>
{
    public void Configure(EntityTypeBuilder<PrestadorServicio> builder)
    {
        builder.ToTable("PrestadorServicios");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}