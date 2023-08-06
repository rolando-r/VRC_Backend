using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaEspecialidadConfiguration : IEntityTypeConfiguration<PersonaEspecialidad>
{
    public void Configure(EntityTypeBuilder<PersonaEspecialidad> builder)
    {
        builder.ToTable("PersonaEspecialidades");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}