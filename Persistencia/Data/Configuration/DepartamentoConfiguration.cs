using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamentos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreDepartamento)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(p => p.Pais)
        .WithMany(e => e.Departamentos)
        .HasForeignKey(i => i.IdPais);
    }
}