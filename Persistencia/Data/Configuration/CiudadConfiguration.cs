using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("Ciudades");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();

        builder.Property(p => p.NombreCiudad)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Departamento)
        .WithMany(e => e.Ciudades)
        .HasForeignKey(i => i.IdDepartamento);
    }
}