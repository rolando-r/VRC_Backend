using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaServicioConfiguration : IEntityTypeConfiguration<PersonaServicio>
{
    public void Configure(EntityTypeBuilder<PersonaServicio> builder)
    {
        builder.ToTable("PersonaServicios");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}