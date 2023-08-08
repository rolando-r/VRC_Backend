using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombrePersona)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Contraseña)
        .IsRequired()
        .HasMaxLength(250);

        builder.HasOne(p => p.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdTipoPersona);

        builder.HasOne(p => p.Sucursal)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdSucursal);
    }
}