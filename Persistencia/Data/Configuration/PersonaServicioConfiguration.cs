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
        
        builder.HasOne(p => p.Servicio)
        .WithMany(e => e.PersonaServicios)
        .HasForeignKey(i => i.IdServicio);

        builder.HasOne(p => p.Persona)
        .WithMany(e => e.PersonaServicios)
        .HasForeignKey(i => i.IdPersona);
    }
}