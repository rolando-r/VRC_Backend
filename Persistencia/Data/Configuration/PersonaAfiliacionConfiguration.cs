using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaAfiliacionConfiguration : IEntityTypeConfiguration<PersonaAfiliacion>
{
    public void Configure(EntityTypeBuilder<PersonaAfiliacion> builder)
    {
        builder.ToTable("PersonaAfiliaciones");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.HasOne(p => p.Persona)
        .WithMany(e => e.PersonaAfiliaciones)
        .HasForeignKey(i => i.IdPersona);

        builder.HasOne(p => p.Afiliacion)
        .WithMany(e => e.PersonaAfiliaciones)
        .HasForeignKey(i => i.IdAfiliacion);
    }
}